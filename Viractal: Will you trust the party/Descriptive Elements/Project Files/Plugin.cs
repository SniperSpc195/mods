using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace DescriptiveElements
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class Plugin : BasePlugin
    {
        public const string PluginGUID = "com.kdubaz.descriptiveelements";
        public const string PluginName = "Descriptive Elements";
        public const string PluginVersion = "2.0.1";

        internal static Plugin Instance { get; private set; }
        internal new static ManualLogSource Log { get; private set; }

        internal ConfigEntry<bool> EnableEventOutcomes { get; private set; }
        internal ConfigEntry<bool> EnableExpCounter { get; private set; }
        internal ConfigEntry<float> ExpCounterX { get; private set; }
        internal ConfigEntry<float> ExpCounterY { get; private set; }
        internal ConfigEntry<float> GrantToastDuration { get; private set; }

        private Harmony _harmony;
        private EventInfo _frameEvent;
        private Delegate _frameHandler;
        private MethodInfo _playerUpdateMethod;
        private object _expRoot;
        private object _expPanelRect;
        private object _expText;
        private readonly Dictionary<int, object> _expDisplays = new();
        private readonly Stopwatch _sw = Stopwatch.StartNew();
        private long _lastRefreshTicks;
        private bool _expCounterSetupAttempted;

        public override void Load()
        {
            Instance = this;
            Log = base.Log;
            BindConfig();

            _harmony = new Harmony(PluginGUID);
            try
            {
                EventOutcomePatches.Apply(_harmony);
                Log.LogInfo($"[{PluginName}] v{PluginVersion} loaded. Harmony patches applied.");
            }
            catch (Exception ex)
            {
                Log.LogError($"[{PluginName}] Failed to apply Harmony patches: {ex}");
            }

            if (EnableExpCounter.Value)
                RegisterExpUpdateCallback();
            Log.LogInfo($"[{PluginName}] v{PluginVersion} initialization complete.");
        }

        public override bool Unload()
        {
            if (_frameEvent != null && _frameHandler != null)
                _frameEvent.RemoveEventHandler(null, _frameHandler);
            _harmony?.UnpatchSelf();
            foreach (var playerIndex in _expDisplays.Keys.ToArray()) RemoveExpDisplay(playerIndex);
            if (_expRoot != null) DestroyUnityObject(_expRoot);
            Instance = null;
            return true;
        }

        internal void Tick()
        {
            if (!EnableExpCounter.Value) return;
            if (!_expCounterSetupAttempted)
            {
                _expCounterSetupAttempted = true;
                SetupExpCounter();
            }
            if (_expRoot == null || _expPanelRect == null || _expText == null) return;

            var now = _sw.ElapsedTicks;
            if (now - _lastRefreshTicks < Stopwatch.Frequency / 2) return;
            _lastRefreshTicks = now;
            RefreshExpCounter();
        }

        private void BindConfig()
        {
            EnableEventOutcomes = Config.Bind("General", "EnableEventOutcomes", true, "Show a grant/outcome toast when an event choice is resolved.");
            EnableExpCounter = Config.Bind("General", "EnableExpCounter", true, "Show the per-character EXP counter overlay.");
            ExpCounterX = Config.Bind("UI", "ExpCounterX", 10f, "Horizontal offset of the fallback EXP list (screen fraction * 1000); only used when portrait anchoring fails.");
            ExpCounterY = Config.Bind("UI", "ExpCounterY", 10f, "Vertical offset of the fallback EXP list (screen fraction * 1000); only used when portrait anchoring fails.");
            GrantToastDuration = Config.Bind("UI", "GrantToastDuration", 5f, "Seconds the grant-outcome toast stays on screen.");
        }

        private void RegisterExpUpdateCallback()
        {
            try
            {
                var applicationType = GetType("UnityEngine.Application");
                _frameEvent = applicationType?.GetEvent("onBeforeRender",
                    BindingFlags.Public | BindingFlags.Static);
                var tickMethod = typeof(Plugin).GetMethod(nameof(Tick),
                    BindingFlags.Instance | BindingFlags.NonPublic);
                if (_frameEvent?.EventHandlerType == null || tickMethod == null)
                    throw new MissingMemberException("UnityEngine.Application.onBeforeRender");

                _frameHandler = Delegate.CreateDelegate(_frameEvent.EventHandlerType, this, tickMethod);
                _frameEvent.AddEventHandler(null, _frameHandler);
                Log.LogInfo("EXP counter frame callback registered.");
                return;
            }
            catch (Exception ex)
            {
                Log.LogWarning($"[{PluginName}] onBeforeRender callback unavailable; trying Unity update fallback: {ex.Message}");
                _frameEvent = null;
                _frameHandler = null;
            }

            var playerType = GetType("CFieldPlayer");
            _playerUpdateMethod = playerType?.GetMethod("Update",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                null, Type.EmptyTypes, null);
            var updateCallback = typeof(Plugin).GetMethod(nameof(OnUnityUpdate),
                BindingFlags.NonPublic | BindingFlags.Static);
            if (_playerUpdateMethod != null && updateCallback != null)
            {
                try
                {
                    _harmony.Patch(_playerUpdateMethod, postfix: new HarmonyMethod(updateCallback));
                    Log.LogInfo("EXP counter CFieldPlayer.Update callback registered.");
                    return;
                }
                catch (Exception ex)
                {
                    Log.LogError($"[{PluginName}] Could not patch CFieldPlayer.Update: {ex}");
                }
            }

            Log.LogError($"[{PluginName}] Could not register the EXP counter update callback. " +
                         "Neither UnityEngine.Application.onBeforeRender nor CFieldPlayer.Update was available.");
        }

        private static void OnUnityUpdate() => Instance?.Tick();

        private static Type GetType(string name)
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) { var t = asm.GetType(name); if (t != null) return t; }
            return null;
        }

        private object Call(object target, string methodName, params object[] args)
        {
            var method = target.GetType().GetMethod(methodName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            if (method == null) { Log.LogWarning($"[DE] Method not found: {target.GetType().Name}.{methodName}"); return null; }
            return method.Invoke(target, args);
        }

        private object GetProp(object target, string propertyName)
        {
            var prop = target.GetType().GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            if (prop == null) { Log.LogWarning($"[DE] Property not found: {target.GetType().Name}.{propertyName}"); return null; }
            return prop.GetValue(target);
        }

        private void SetProp(object target, string propertyName, object value)
        {
            if (target == null) throw new ArgumentNullException(nameof(target), $"Cannot set '{propertyName}' on a null object.");
            var prop = target.GetType().GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            if (prop == null || !prop.CanWrite)
                throw new MissingMemberException(target.GetType().FullName, propertyName);
            prop.SetValue(target, value);
        }

        private object CallStatic(Type type, string methodName, params object[] args)
        {
            var method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (method == null) { Log.LogWarning($"[DE] Static method not found: {type.Name}.{methodName}"); return null; }
            return method.Invoke(null, args);
        }

        private object GetStaticProp(Type type, string propertyName)
        {
            var prop = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (prop == null) { Log.LogWarning($"[DE] Static property not found: {type.Name}.{propertyName}"); return null; }
            return prop.GetValue(null);
        }

        internal static object CreateVector2(Type vector2Type, float x, float y)
        {
            if (vector2Type == null) throw new TypeLoadException("UnityEngine.Vector2 was not found.");
            var constructor = vector2Type.GetConstructor(new[] { typeof(float), typeof(float) });
            if (constructor == null) throw new MissingMethodException(vector2Type.FullName, ".ctor(float, float)");
            return constructor.Invoke(new object[] { x, y });
        }

        internal static object CreateColor(Type colorType, float r, float g, float b, float a)
        {
            if (colorType == null) throw new TypeLoadException("UnityEngine.Color was not found.");
            var constructor = colorType.GetConstructor(new[] { typeof(float), typeof(float), typeof(float), typeof(float) });
            if (constructor == null) throw new MissingMethodException(colorType.FullName, ".ctor(float, float, float, float)");
            return constructor.Invoke(new object[] { r, g, b, a });
        }

        private void SetupExpCounter()
        {
            try
            {
                var goType = GetType("UnityEngine.GameObject");
                var canvasType = GetType("UnityEngine.Canvas");
                var graphicRaycasterType = GetType("UnityEngine.UI.GraphicRaycaster");
                var rectTransformType = GetType("UnityEngine.RectTransform");
                var imageType = GetType("UnityEngine.UI.Image");
                var textMeshProType = GetType("TMPro.TextMeshProUGUI");
                var colorType = GetType("UnityEngine.Color");
                var vector2Type = GetType("UnityEngine.Vector2");
                var objectType = GetType("UnityEngine.Object");

                if (goType == null || canvasType == null || rectTransformType == null ||
                    imageType == null || textMeshProType == null || colorType == null ||
                    vector2Type == null || objectType == null)
                    throw new TypeLoadException("A required Unity UI type was not found.");

                _expRoot = CreateGameObject(goType, "DescriptiveElements_ExpCounterRoot");

                AddComponent(_expRoot, canvasType);

                var dontDestroy = objectType?.GetMethod("DontDestroyOnLoad",
                    BindingFlags.Public | BindingFlags.Static, null, new[] { objectType }, null);
                dontDestroy?.Invoke(null, new[] { _expRoot });

                var panel = CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_ExpCounterPanel");
                SetParent(panel, _expRoot);
                var panelRect = GetComponent(panel, rectTransformType);
                _expPanelRect = panelRect;
                SetProp(panelRect, "anchorMin", CreateVector2(vector2Type, 0f, 1f));
                SetProp(panelRect, "anchorMax", CreateVector2(vector2Type, 0f, 1f));
                SetProp(panelRect, "pivot", CreateVector2(vector2Type, 0f, 1f));
                SetProp(panelRect, "sizeDelta", CreateVector2(vector2Type, 340f, 240f));

                var panelImage = AddComponent(panel, imageType);
                SetProp(panelImage, "color", CreateColor(colorType, 0f, 0f, 0f, 0.72f));

                var textGO = CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_ExpCounterText");
                SetParent(textGO, panel);
                _expText = AddComponent(textGO, textMeshProType);
                SetProp(_expText, "fontSize", 16);
                SetProp(_expText, "color", CreateColor(colorType, 1f, 1f, 1f, 1f));
                SetProp(_expText, "text", "EXP Counter");
            }
            catch (Exception ex)
            {
                if (_expRoot != null)
                {
                    try { DestroyUnityObject(_expRoot); }
                    catch (Exception cleanupException)
                    {
                        Log.LogWarning($"[DE] Could not clean up the partial EXP counter: {cleanupException}");
                    }
                }
                _expRoot = null;
                _expPanelRect = null;
                _expText = null;
                Log.LogError($"[DE] SetupExpCounter failed: {ex}");
            }
        }

        private void ApplyFallbackPosition()
        {
            if (_expPanelRect == null) return;
            var screenType = GetType("UnityEngine.Screen");
            if (screenType == null) return;

            var width = (int)GetStaticProp(screenType, "width");
            var height = (int)GetStaticProp(screenType, "height");
            float fx = ExpCounterX.Value / 1000f;
            float fy = ExpCounterY.Value / 1000f;

            var anchoredPositionProp = _expPanelRect.GetType().GetProperty("anchoredPosition",
                BindingFlags.Public | BindingFlags.Instance);
            var vector2Type = GetType("UnityEngine.Vector2");
            anchoredPositionProp?.SetValue(_expPanelRect, CreateVector2(vector2Type, width * fx, -height * fy));
        }

        private void RefreshExpCounter()
        {
            ApplyFallbackPosition();

            var players = FindObjectsOfType("CFieldPlayer");
            Array.Sort(players, (a, b) => ((int)GetProp(a, "mIndex")).CompareTo((int)GetProp(b, "mIndex")));

            var statusPanels = FindObjectsOfType("CUICharacterStatus");

            var fallbackText = new StringBuilder();
            fallbackText.AppendLine("EXP Counter");
            var hasFallbackRows = false;
            var anyAnchored = false;
            int panelIdx = 0;
            var active = new HashSet<int>();

            foreach (var p in players)
            {
                var playerIndex = (int)GetProp(p, "mIndex");
                active.Add(playerIndex);
                object anchor = null;
                if (panelIdx < statusPanels.Length) anchor = statusPanels[panelIdx];
                panelIdx++;

                try
                {
                    var mParam = GetProp(p, "mParam");
                    var mLv = GetProp(mParam, "mLv");
                    var mExp = GetProp(mParam, "mExp");
                    int lv = (int)mLv.GetType().GetMethod("Get").Invoke(mLv, null);
                    int exp = (int)mExp.GetType().GetMethod("Get").Invoke(mExp, null);

                    var levelData = CallStatic(GetType("CMaster_CharLevel"), "GetData", lv + 1);
                    int need = levelData != null ? (int)GetProp(levelData, "exp") : 0;
                    bool haveData = need > 0;
                    string needStr = haveData ? need.ToString() : "?";
                    string name = p.GetType().GetMethod("Name", Type.EmptyTypes)?.Invoke(p, null)?.ToString() ?? "?";

                    if (anchor == null)
                    {
                        if (_expDisplays.ContainsKey(playerIndex)) RemoveExpDisplay(playerIndex);
                        fallbackText.AppendFormat("P{0} {1}: EXP {2} / {3}\n", playerIndex, name, exp, needStr);
                        hasFallbackRows = true;
                    }
                    else
                    {
                        UpdateExpDisplay(playerIndex, anchor, exp, needStr, haveData);
                        if (_expDisplays.TryGetValue(playerIndex, out var display) && display != null)
                        {
                            anyAnchored = true;
                        }
                        else
                        {
                            fallbackText.AppendFormat("P{0} {1}: EXP {2} / {3}\n", playerIndex, name, exp, needStr);
                            hasFallbackRows = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    fallbackText.AppendFormat("P{0}: (error: {1})\n", playerIndex, ex.Message);
                    hasFallbackRows = true;
                    if (_expDisplays.ContainsKey(playerIndex)) RemoveExpDisplay(playerIndex);
                }
            }

            PruneExpDisplays(active);

            if (_expText != null)
            {
                SetProp(_expText, "text", hasFallbackRows || !anyAnchored ? fallbackText.ToString() : "");
            }
        }

        private void UpdateExpDisplay(int playerIndex, object anchor, int exp, string needStr, bool haveData)
        {
            if (!_expDisplays.TryGetValue(playerIndex, out var disp))
            {
                disp = CreateExpDisplay(anchor);
                _expDisplays[playerIndex] = disp;
            }
            if (disp == null) return;

            if (anchor != null)
            {
                var transformType = GetType("UnityEngine.Transform");
                SetParent(disp, anchor);

                var rectTransformType = GetType("UnityEngine.RectTransform");
                var rect = GetComponent(disp, rectTransformType);
                if (rect != null)
                {
                    var vector2Type = GetType("UnityEngine.Vector2");
                    SetProp(rect, "anchorMin", CreateVector2(vector2Type, 0f, 1f));
                    SetProp(rect, "anchorMax", CreateVector2(vector2Type, 0f, 1f));
                    SetProp(rect, "pivot", CreateVector2(vector2Type, 0f, 1f));
                    SetProp(rect, "anchoredPosition", CreateVector2(vector2Type, 24f, -104f));
                    SetProp(rect, "sizeDelta", CreateVector2(vector2Type, 180f, 20f));
                }
            }

            var textProp = disp.GetType().GetProperty("text", BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            textProp?.SetValue(disp, haveData ? $"EXP {exp} / {needStr}" : $"EXP {exp} / ?");
        }

        private object CreateExpDisplay(object parent)
        {
            try
            {
                var goType = GetType("UnityEngine.GameObject");
                var rectTransformType = GetType("UnityEngine.RectTransform");
                var textMeshProType = GetType("TMPro.TextMeshProUGUI");
                var vector2Type = GetType("UnityEngine.Vector2");
                var colorType = GetType("UnityEngine.Color");

                var go = CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_ExpDisplay");
                SetParent(go, parent);

                var rect = GetComponent(go, rectTransformType);
                SetProp(rect, "sizeDelta", CreateVector2(vector2Type, 180f, 20f));

                var text = AddComponent(go, textMeshProType);
                var textRect = GetComponent(text, rectTransformType);
                SetProp(textRect, "anchorMin", CreateVector2(vector2Type, 0f, 0f));
                SetProp(textRect, "anchorMax", CreateVector2(vector2Type, 1f, 1f));
                SetProp(textRect, "offsetMin", CreateVector2(vector2Type, 0f, 0f));
                SetProp(textRect, "offsetMax", CreateVector2(vector2Type, 0f, 0f));
                SetProp(text, "fontSize", 14);
                SetProp(text, "color", CreateColor(colorType, 1f, 1f, 1f, 1f));
                SetProp(text, "text", "");

                return go;
            }
            catch (Exception ex) { Log.LogWarning($"[DE] CreateExpDisplay failed: {ex}"); return null; }
        }

        private void PruneExpDisplays(HashSet<int> active)
        {
            var toRemove = new List<int>();
            foreach (var kv in _expDisplays) if (!active.Contains(kv.Key)) toRemove.Add(kv.Key);
            foreach (var key in toRemove) RemoveExpDisplay(key);
        }

        private void RemoveExpDisplay(int playerIndex)
        {
            if (_expDisplays.TryGetValue(playerIndex, out var disp) && disp != null)
            {
                DestroyUnityObject(disp);
                _expDisplays.Remove(playerIndex);
            }
        }

        private object[] FindObjectsOfType(string typeName)
        {
            var type = GetType(typeName);
            if (type == null) return Array.Empty<object>();
            var findMethod = GetType("UnityEngine.Object").GetMethod("FindObjectsOfType", new[] { typeof(Type) });
            var found = findMethod.Invoke(null, new object[] { type });
            if (found is object[] objects) return objects;

            var results = new List<object>();
            if (found is System.Collections.IEnumerable enumerable)
            {
                foreach (var item in enumerable) results.Add(item);
                return results.ToArray();
            }

            if (found == null) return Array.Empty<object>();
            var length = GetProp(found, "Length");
            if (length is int count)
            {
                var indexer = found.GetType().GetProperty("Item");
                for (var i = 0; i < count; i++) results.Add(indexer.GetValue(found, new object[] { i }));
            }
            return results.ToArray();
        }

        internal static object CreateRectTransformGameObject(Type gameObjectType, Type rectTransformType, string name)
        {
            if (gameObjectType == null) throw new TypeLoadException("UnityEngine.GameObject was not found.");
            if (rectTransformType == null) throw new TypeLoadException("UnityEngine.RectTransform was not found.");
            var constructor = gameObjectType.GetConstructor(new[] { typeof(string), typeof(Type[]) });
            if (constructor == null)
                throw new MissingMethodException(gameObjectType.FullName, ".ctor(string, Type[])");
            return constructor.Invoke(new object[] { name, new[] { rectTransformType } });
        }

        internal static object CreateGameObject(Type gameObjectType, string name)
        {
            if (gameObjectType == null) throw new TypeLoadException("UnityEngine.GameObject was not found.");
            var namedConstructor = gameObjectType.GetConstructor(new[] { typeof(string) });
            if (namedConstructor != null) return namedConstructor.Invoke(new object[] { name });

            var constructor = gameObjectType.GetConstructor(Type.EmptyTypes);
            if (constructor == null)
                throw new MissingMethodException(gameObjectType.FullName, ".ctor(string) or .ctor()");

            var gameObject = constructor.Invoke(null);
            var nameProperty = gameObjectType.GetProperty("name", BindingFlags.Public | BindingFlags.Instance);
            nameProperty?.SetValue(gameObject, name);
            return gameObject;
        }

        internal static object AddComponent(object gameObject, Type componentType)
        {
            if (gameObject == null) throw new ArgumentNullException(nameof(gameObject));
            if (componentType == null) throw new ArgumentNullException(nameof(componentType));

            var methods = gameObject.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var genericMethod = methods.FirstOrDefault(method =>
                method.Name == "AddComponent" && method.IsGenericMethodDefinition &&
                method.GetGenericArguments().Length == 1 && method.GetParameters().Length == 0);
            if (genericMethod != null)
                return genericMethod.MakeGenericMethod(componentType).Invoke(gameObject, null);

            var typeMethod = methods.FirstOrDefault(method =>
                method.Name == "AddComponent" && !method.IsGenericMethod &&
                method.GetParameters().Length == 1 && method.GetParameters()[0].ParameterType == typeof(Type));
            if (typeMethod != null)
                return typeMethod.Invoke(gameObject, new object[] { componentType });

            throw new MissingMethodException(gameObject.GetType().FullName, "AddComponent<T>()");
        }

        internal static object GetComponent(object component, Type componentType)
        {
            if (component == null) throw new ArgumentNullException(nameof(component));
            if (componentType == null) throw new ArgumentNullException(nameof(componentType));

            var methods = component.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var genericMethod = methods.FirstOrDefault(method =>
                method.Name == "GetComponent" && method.IsGenericMethodDefinition &&
                method.GetGenericArguments().Length == 1 && method.GetParameters().Length == 0);
            if (genericMethod != null)
                return genericMethod.MakeGenericMethod(componentType).Invoke(component, null);

            var typeMethod = methods.FirstOrDefault(method =>
                method.Name == "GetComponent" && !method.IsGenericMethod &&
                method.GetParameters().Length == 1 && method.GetParameters()[0].ParameterType == typeof(Type));
            if (typeMethod != null)
                return typeMethod.Invoke(component, new object[] { componentType });

            throw new MissingMethodException(component.GetType().FullName, "GetComponent<T>()");
        }

        internal void SetParent(object child, object parent)
        {
            var childTransform = GetProp(child, "transform") ?? child;
            var parentTransform = GetProp(parent, "transform") ?? parent;
            var transformType = childTransform.GetType();
            var method = transformType.GetMethod("SetParent", new[] { parentTransform.GetType(), typeof(bool) })
                ?? transformType.GetMethods().FirstOrDefault(candidate =>
                    candidate.Name == "SetParent" &&
                    candidate.GetParameters().Length == 2 &&
                    candidate.GetParameters()[1].ParameterType == typeof(bool));
            if (method == null) throw new MissingMethodException(transformType.FullName, "SetParent");
            method.Invoke(childTransform, new[] { parentTransform, (object)false });
        }

        internal void DestroyUnityObject(object unityObject, float delay = 0f)
        {
            var objectType = GetType("UnityEngine.Object");
            var method = objectType?.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .FirstOrDefault(candidate =>
                {
                    if (candidate.Name != "Destroy") return false;
                    var parameters = candidate.GetParameters();
                    return parameters.Length == 2 && parameters[1].ParameterType == typeof(float);
                });
            if (method == null) throw new MissingMethodException(objectType?.FullName, "Destroy");
            method.Invoke(null, new[] { unityObject, (object)delay });
        }
    }
}
