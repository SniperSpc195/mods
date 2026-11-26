using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using HarmonyLib;
using BepInEx;

namespace DescriptiveElements
{
    internal static class EventPreviewCache
    {
        private const int CacheSchemaVersion = 1;
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions { WriteIndented = true };
        private static readonly Dictionary<string, CachedEvent> Events = new Dictionary<string, CachedEvent>();
        private static string _cachePath;
        private static string _activeEventKey;
        private static int _activeOptionIndex = -1;
        private static object _previewRoot;
        private static object _previewText;
        private static object _previewPanel;
        private static bool _enabled;

        internal static void Apply(Harmony harmony)
        {
            _cachePath = Path.Combine(Paths.ConfigPath, "DescriptiveElements.EventCache.json");
            _enabled = true;
            Load();
            PatchNamedMethods(harmony, "CEventChoices", "Go", nameof(Postfix_ChoiceOpened),
                method => method.GetParameters().Length == 4 &&
                          (method.GetParameters()[0].ParameterType == typeof(string) ||
                           method.GetParameters()[0].ParameterType.Name == "Il2CppStringArray"));
            PatchNamedMethods(harmony, "CEventChoices", "CbDecision", nameof(Postfix_ChoiceSelected),
                method => method.GetParameters().Length == 1 &&
                          method.GetParameters()[0].ParameterType == typeof(int));
            PatchNamedMethods(harmony, "CEventChoices", "CbCancel", nameof(Postfix_ChoiceCancelled),
                method => method.GetParameters().Length == 0);
            PatchNamedMethods(harmony, "CEventScript", "ExecCommand", nameof(Postfix_ExecCommand),
                method => method.GetParameters().Length == 0);
        }

        internal static void Shutdown()
        {
            HidePreview();
            if (_previewRoot != null)
            {
                Plugin.Instance?.DestroyUnityObject(_previewRoot);
                _previewRoot = null;
                _previewPanel = null;
                _previewText = null;
            }
            _activeEventKey = null;
            _activeOptionIndex = -1;
            _enabled = false;
        }

        internal static void RecordOutcome(string text, string classification)
        {
            if (!_enabled || string.IsNullOrWhiteSpace(_activeEventKey) || _activeOptionIndex < 0 ||
                !Events.TryGetValue(_activeEventKey, out var cachedEvent) ||
                _activeOptionIndex >= cachedEvent.Options.Count)
                return;

            var option = cachedEvent.Options[_activeOptionIndex];
            if (option.Outcomes.Any(outcome => outcome.Classification == classification && outcome.Text == text))
                return;

            option.Outcomes.Add(new CachedOutcome { Text = text, Classification = classification });
            Save();
            Plugin.Log.LogInfo($"[Event preview] Cached {classification} outcome for option {_activeOptionIndex + 1} ({cachedEvent.Key}).");
        }

        private static void Postfix_ChoiceOpened(object __instance, object[] __args)
        {
            if (!_enabled) return;
            try
            {
                var labels = ReadLabels(__args.Length > 0 ? __args[0] : null);
                if (labels.Count == 0)
                {
                    HidePreview();
                    return;
                }

                var eventKey = BuildEventKey(labels);
                if (string.IsNullOrEmpty(eventKey))
                {
                    Plugin.Log.LogWarning("[Event preview] Could not identify the active event script; this choice will not be cached.");
                    HidePreview();
                    return;
                }

                if (!Events.TryGetValue(eventKey, out var cachedEvent))
                {
                    cachedEvent = new CachedEvent { Key = eventKey };
                    Events.Add(eventKey, cachedEvent);
                }

                while (cachedEvent.Options.Count < labels.Count)
                    cachedEvent.Options.Add(new CachedOption());
                for (var index = 0; index < labels.Count; index++)
                    cachedEvent.Options[index].Label = labels[index];
                if (cachedEvent.Options.Count > labels.Count)
                    cachedEvent.Options.RemoveRange(labels.Count, cachedEvent.Options.Count - labels.Count);

                _activeEventKey = eventKey;
                _activeOptionIndex = -1;
                ShowPreview(cachedEvent);
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"[Event preview] Could not prepare event preview: {ex}");
                HidePreview();
            }
        }

        private static void Postfix_ChoiceSelected(object[] __args)
        {
            if (!_enabled) return;
            _activeOptionIndex = __args.Length > 0 ? Convert.ToInt32(__args[0]) : -1;
            HidePreview();
        }

        private static void Postfix_ChoiceCancelled()
        {
            _activeOptionIndex = -1;
            _activeEventKey = null;
            HidePreview();
        }

        private static void Postfix_ExecCommand(object __instance)
        {
            if (!_enabled || string.IsNullOrEmpty(_activeEventKey) || _activeOptionIndex < 0 ||
                !Events.TryGetValue(_activeEventKey, out var cachedEvent) ||
                _activeOptionIndex >= cachedEvent.Options.Count)
                return;

            try
            {
                var command = ReadMember(__instance, "mCommand");
                var name = ReadCollectionItem(command, 0)?.ToString();
                var option = cachedEvent.Options[_activeOptionIndex];
                var changed = false;
                if (string.Equals(name, "DICE", StringComparison.OrdinalIgnoreCase) && !option.HasDiceChallenge)
                {
                    option.HasDiceChallenge = true;
                    changed = true;
                }
                if (string.Equals(name, "BATTLE", StringComparison.OrdinalIgnoreCase) && !option.HasBattle)
                {
                    option.HasBattle = true;
                    changed = true;
                }
                if (changed) Save();
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[Event preview] Could not inspect the current script command: {ex.Message}");
            }
        }

        private static void PatchNamedMethods(Harmony harmony, string typeName, string methodName,
            string handlerName, Func<MethodInfo, bool> predicate)
        {
            var type = ResolveType(typeName);
            if (type == null)
            {
                Plugin.Log.LogWarning($"[Event preview] Type not found: {typeName}; {methodName} preview hook skipped.");
                return;
            }

            var handler = typeof(EventPreviewCache).GetMethod(handlerName,
                BindingFlags.NonPublic | BindingFlags.Static);
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic |
                                          BindingFlags.Instance | BindingFlags.Static)
                .Where(method => method.Name == methodName && predicate(method)).ToArray();
            if (methods.Length == 0)
            {
                Plugin.Log.LogWarning($"[Event preview] Method not found: {type.Name}.{methodName}.");
                return;
            }

            foreach (var method in methods)
            {
                try
                {
                    harmony.Patch(method, postfix: new HarmonyMethod(handler));
                    Plugin.Log.LogInfo($"[Event preview] Patched {type.Name}.{method.Name}.");
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogError($"[Event preview] Could not patch {type.Name}.{method.Name}: {ex}");
                }
            }
        }

        private static List<string> ReadLabels(object value)
        {
            if (value is string text)
                return text.Split('\n').Select(label => label.Trim()).Where(label => label.Length > 0).ToList();

            var labels = new List<string>();
            var count = GetCount(value);
            for (var index = 0; index < count; index++)
            {
                var label = ReadCollectionItem(value, index)?.ToString();
                if (label != null) labels.Add(label.Trim());
            }
            return labels;
        }

        private static string BuildEventKey(IReadOnlyList<string> labels)
        {
            var scriptType = ResolveType("CEventScript");
            var scripts = scriptType == null ? Array.Empty<object>() : Plugin.FindObjectsOfType(scriptType);
            var script = scripts.FirstOrDefault(candidate => GetCount(ReadMember(candidate, "mSelfChoice")) > 0)
                         ?? scripts.FirstOrDefault();
            if (script == null) return null;

            var executionIndex = ReadInt(script, "mExecIndex");
            var data = ReadMember(script, "mExecData");
            var dataLength = GetCount(data);
            var addressablePath = ReadMember(script, "mAddressablePath")?.ToString() ?? "";
            var branches = ReadBranchSignature(ReadMember(script, "mSelfChoice"));
            var context = ReadScriptContext(data, executionIndex);
            var signature = string.Join("|", addressablePath, dataLength, executionIndex,
                string.Join(";", labels), branches, context);
            return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(signature)));
        }

        private static string ReadBranchSignature(object choices)
        {
            var parts = new List<string>();
            var count = GetCount(choices);
            for (var index = 0; index < count; index++)
            {
                var tuple = ReadCollectionItem(choices, index);
                var label = ReadMember(tuple, "Item1")?.ToString() ?? "";
                var offset = ReadMember(tuple, "Item2")?.ToString() ?? "";
                parts.Add($"{label}:{offset}");
            }
            return string.Join(";", parts);
        }

        private static string ReadScriptContext(object data, int center)
        {
            var count = GetCount(data);
            if (center < 0 || count <= 0) return "";
            var start = Math.Max(0, center - 96);
            var end = Math.Min(count, center + 48);
            var context = new StringBuilder(end - start);
            for (var index = start; index < end; index++)
            {
                var value = Convert.ToInt32(ReadCollectionItem(data, index));
                context.Append(value >= 32 && value <= 126 ? (char)value : '.');
            }
            return context.ToString();
        }

        private static void ShowPreview(CachedEvent cachedEvent)
        {
            CreatePreviewUi();
            var goodCount = cachedEvent.Options.Sum(option => option.Outcomes.Count(outcome => outcome.Classification == "good"));
            var badCount = cachedEvent.Options.Sum(option => option.Outcomes.Count(outcome => outcome.Classification == "bad"));
            var diceCount = cachedEvent.Options.Count(option => option.HasDiceChallenge);
            var battleCount = cachedEvent.Options.Count(option => option.HasBattle);
            var text = new StringBuilder();
            text.AppendLine($"Cached outcomes: {goodCount} good, {badCount} bad | {diceCount} dice challenges | {battleCount} battle options");
            text.AppendLine("Only observed outcomes are shown; unexplored results are unknown.");

            for (var index = 0; index < cachedEvent.Options.Count; index++)
            {
                var option = cachedEvent.Options[index];
                text.AppendLine();
                text.Append($"{index + 1}. {option.Label}");
                if (option.HasDiceChallenge) text.Append(" [DICE]");
                if (option.HasBattle) text.Append(" [BATTLE]");
                if (option.Outcomes.Count == 0)
                {
                    text.AppendLine().Append("   Unknown: not observed yet.");
                    continue;
                }

                foreach (var outcome in option.Outcomes)
                    text.AppendLine().Append($"   [{outcome.Classification.ToUpperInvariant()}] {outcome.Text}");
            }

            Plugin.SetProp(_previewText, "text", text.ToString());
            PositionPreviewPanel();
            SetActive(_previewRoot, true);
        }

        private static void CreatePreviewUi()
        {
            if (_previewRoot != null) return;
            var gameObjectType = ResolveType("UnityEngine.GameObject");
            var canvasType = ResolveType("UnityEngine.Canvas");
            var rectTransformType = ResolveType("UnityEngine.RectTransform");
            var imageType = ResolveType("UnityEngine.UI.Image");
            var textType = ResolveType("TMPro.TextMeshProUGUI");
            var colorType = ResolveType("UnityEngine.Color");
            var vector2Type = ResolveType("UnityEngine.Vector2");
            var objectType = ResolveType("UnityEngine.Object");
            if (gameObjectType == null || canvasType == null || rectTransformType == null ||
                imageType == null || textType == null || colorType == null || vector2Type == null ||
                objectType == null)
                throw new TypeLoadException("A required event preview UI type was not found.");

            _previewRoot = Plugin.CreateRectTransformGameObject(gameObjectType, rectTransformType,
                "DescriptiveElements_EventPreviewRoot");
            var canvas = Plugin.AddComponent(_previewRoot, canvasType);
            Plugin.ConfigureOverlayCanvas(canvas);
            var dontDestroy = objectType.GetMethod("DontDestroyOnLoad",
                BindingFlags.Public | BindingFlags.Static, null, new[] { objectType }, null);
            dontDestroy?.Invoke(null, new[] { _previewRoot });

            _previewPanel = Plugin.CreateRectTransformGameObject(gameObjectType, rectTransformType,
                "DescriptiveElements_EventPreviewPanel");
            Plugin.Instance.SetParent(_previewPanel, _previewRoot);
            var panelRect = Plugin.GetComponent(_previewPanel, rectTransformType);
            Plugin.SetProp(panelRect, "anchorMin", Plugin.CreateVector2(vector2Type, 0f, 0f));
            Plugin.SetProp(panelRect, "anchorMax", Plugin.CreateVector2(vector2Type, 0f, 0f));
            Plugin.SetProp(panelRect, "pivot", Plugin.CreateVector2(vector2Type, 0.5f, 0.5f));
            Plugin.SetProp(panelRect, "sizeDelta", Plugin.CreateVector2(vector2Type, 620f, 440f));
            var panelImage = Plugin.AddComponent(_previewPanel, imageType);
            Plugin.SetProp(panelImage, "color", Plugin.CreateColor(colorType, 0.02f, 0.02f, 0.02f, 0.9f));

            var textObject = Plugin.CreateRectTransformGameObject(gameObjectType, rectTransformType,
                "DescriptiveElements_EventPreviewText");
            Plugin.Instance.SetParent(textObject, _previewPanel);
            _previewText = Plugin.AddComponent(textObject, textType);
            var textRect = Plugin.GetComponent(textObject, rectTransformType);
            Plugin.SetProp(textRect, "anchorMin", Plugin.CreateVector2(vector2Type, 0f, 0f));
            Plugin.SetProp(textRect, "anchorMax", Plugin.CreateVector2(vector2Type, 1f, 1f));
            Plugin.SetProp(textRect, "offsetMin", Plugin.CreateVector2(vector2Type, 12f, 12f));
            Plugin.SetProp(textRect, "offsetMax", Plugin.CreateVector2(vector2Type, -12f, -12f));
            Plugin.ConfigureOverlayText(_previewText, Plugin.CreateColor(colorType, 1f, 1f, 1f, 1f), 16f);
        }

        private static void PositionPreviewPanel()
        {
            var screenType = ResolveType("UnityEngine.Screen");
            var vector2Type = ResolveType("UnityEngine.Vector2");
            var rectTransformType = ResolveType("UnityEngine.RectTransform");
            var width = Convert.ToSingle(ReadMember(screenType, "width"));
            var height = Convert.ToSingle(ReadMember(screenType, "height"));
            var panelWidth = Math.Min(620f, width * 0.4f);
            var panelHeight = Math.Min(440f, height * 0.72f);
            var rect = Plugin.GetComponent(_previewPanel, rectTransformType);
            Plugin.SetProp(rect, "sizeDelta", Plugin.CreateVector2(vector2Type, panelWidth, panelHeight));
            Plugin.SetProp(rect, "anchoredPosition",
                Plugin.CreateVector2(vector2Type, width * 0.52f, height * 0.5f));
        }

        private static void HidePreview()
        {
            if (_previewRoot != null) SetActive(_previewRoot, false);
        }

        private static void SetActive(object target, bool active)
        {
            var method = target?.GetType().GetMethod("SetActive",
                BindingFlags.Public | BindingFlags.Instance, null, new[] { typeof(bool) }, null);
            method?.Invoke(target, new object[] { active });
        }

        private static void Load()
        {
            try
            {
                if (!File.Exists(_cachePath)) return;
                var json = File.ReadAllText(_cachePath);
                var cache = JsonSerializer.Deserialize<EventCacheFile>(json, JsonOptions);
                if (cache == null || cache.SchemaVersion != CacheSchemaVersion || cache.Events == null)
                    throw new InvalidDataException("The event cache has an unsupported or invalid format.");
                foreach (var entry in cache.Events.Where(entry => !string.IsNullOrWhiteSpace(entry.Key)))
                    Events[entry.Key] = entry;
                Plugin.Log.LogInfo($"[Event preview] Loaded {Events.Count} cached event(s).");
            }
            catch (Exception ex)
            {
                _enabled = false;
                Plugin.Log.LogError($"[Event preview] Could not load cache at '{_cachePath}'; event previews are disabled to protect the cache: {ex}");
            }
        }

        private static void Save()
        {
            try
            {
                var cache = new EventCacheFile { Events = Events.Values.OrderBy(entry => entry.Key).ToList() };
                var json = JsonSerializer.Serialize(cache, JsonOptions);
                var temporaryPath = _cachePath + ".tmp";
                File.WriteAllText(temporaryPath, json);
                File.Move(temporaryPath, _cachePath, true);
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"[Event preview] Could not save cache at '{_cachePath}': {ex}");
            }
        }

        private static object ReadMember(object instance, string name)
        {
            if (instance == null) return null;
            const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic |
                                       BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy;
            var type = instance is Type reflectedType ? reflectedType : instance.GetType();
            var property = type.GetProperty(name, flags);
            if (property?.GetMethod != null)
                return property.GetValue(property.GetMethod.IsStatic || instance is Type ? null : instance);
            var field = type.GetField(name, flags);
            return field?.GetValue(field.IsStatic || instance is Type ? null : instance);
        }

        private static int ReadInt(object instance, string name)
        {
            var value = ReadMember(instance, name);
            return value == null ? -1 : Convert.ToInt32(value);
        }

        private static int GetCount(object value)
        {
            if (value == null || value is string) return -1;
            var count = ReadMember(value, "Length") ?? ReadMember(value, "Count");
            return count == null ? -1 : Convert.ToInt32(count);
        }

        private static object ReadCollectionItem(object collection, int index)
        {
            if (collection == null) return null;
            if (collection is IList list) return list[index];
            var indexer = collection.GetType().GetProperty("Item", BindingFlags.Public | BindingFlags.Instance);
            if (indexer != null) return indexer.GetValue(collection, new object[] { index });
            var getter = collection.GetType().GetMethod("get_Item", BindingFlags.Public | BindingFlags.Instance,
                null, new[] { typeof(int) }, null);
            if (getter != null) return getter.Invoke(collection, new object[] { index });
            if (collection is IEnumerable enumerable) return enumerable.Cast<object>().Skip(index).FirstOrDefault();
            return null;
        }

        private static Type ResolveType(string name)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var type = assembly.GetType(name);
                if (type != null) return type;
            }
            return null;
        }

        private sealed class EventCacheFile
        {
            public EventCacheFile() { }
            public int SchemaVersion { get; set; } = CacheSchemaVersion;
            public List<CachedEvent> Events { get; set; } = new List<CachedEvent>();
        }

        private sealed class CachedEvent
        {
            public CachedEvent() { }
            public string Key { get; set; }
            public List<CachedOption> Options { get; set; } = new List<CachedOption>();
        }

        private sealed class CachedOption
        {
            public CachedOption() { }
            public string Label { get; set; }
            public List<CachedOutcome> Outcomes { get; set; } = new List<CachedOutcome>();
            public bool HasDiceChallenge { get; set; }
            public bool HasBattle { get; set; }
        }

        private sealed class CachedOutcome
        {
            public CachedOutcome() { }
            public string Text { get; set; }
            public string Classification { get; set; }
        }
    }
}
