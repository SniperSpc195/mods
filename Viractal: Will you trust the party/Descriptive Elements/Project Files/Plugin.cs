using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace DescriptiveElements
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.kdubaz.descriptiveelements";
        public const string PluginName = "Descriptive Elements";
        public const string PluginVersion = "1.0.0";

        internal static Plugin Instance { get; private set; }
        internal new static ManualLogSource Log { get; private set; }

        internal ConfigEntry<bool> EnableEventOutcomes { get; private set; }
        internal ConfigEntry<bool> EnableExpCounter { get; private set; }
        internal ConfigEntry<float> ExpCounterX { get; private set; }
        internal ConfigEntry<float> ExpCounterY { get; private set; }
        internal ConfigEntry<float> GrantToastDuration { get; private set; }

        private Harmony _harmony;
        private object _expRoot;
        private object _expText;
        private readonly Dictionary<int, object> _expDisplays = new();
        private readonly Stopwatch _sw = Stopwatch.StartNew();
        private long _lastRefreshTicks;

        private void Awake()
        {
            Instance = this;
            Log = Logger;
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

            if (EnableExpCounter.Value) SetupExpCounter();
            Log.LogInfo($"[{PluginName}] v{PluginVersion} initialization complete.");
        }

        private void OnDestroy()
        {
            _harmony?.UnpatchSelf();
            Instance = null;
        }

        private void Update()
        {
            if (!EnableExpCounter.Value) return;
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
            var prop = target.GetType().GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            prop?.SetValue(target, value);
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

        private object CreateVector2(Type vector2Type, float x, float y)
        {
            try { return vector2Type.GetConstructor(new[] { typeof(float), typeof(float) }).Invoke(new object[] { x, y }); } catch { return null; }
        }

        private object CreateColor(Type colorType, float r, float g, float b, float a)
        {
            try { return colorType.GetConstructor(new[] { typeof(float), typeof(float), typeof(float), typeof(float) }).Invoke(new object[] { r, g, b, a }); } catch { return null; }
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

                if (goType == null || canvasType == null || textMeshProType == null)
                { Log.LogError("[DE] Required Unity types not found; EXP counter disabled."); return; }

                _expRoot = goType.GetConstructor(Type.EmptyTypes).Invoke(null);
                SetProp(_expRoot, "name", "DescriptiveElements_ExpCounterRoot");

                var addComponent = goType.GetMethod("AddComponent", new[] { typeof(Type) });
                addComponent.Invoke(_expRoot, new object[] { canvasType });

                objectType.GetMethod("DontDestroyOnLoad")?.Invoke(null, new object[] { _expRoot });

                var panel = goType.GetConstructor(Type.EmptyTypes).Invoke(null);
                panel.GetType().GetMethod("SetParent")?.Invoke(panel, new object[] { _expRoot, false });
                var panelRect = panel.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(panel, new object[] { rectTransformType });
                SetProp(panelRect, "anchorMin", CreateVector2(vector2Type, 0f, 1f));
                SetProp(panelRect, "anchorMax", CreateVector2(vector2Type, 0f, 1f));
                SetProp(panelRect, "pivot", CreateVector2(vector2Type, 0f, 1f));
                SetProp(panelRect, "sizeDelta", CreateVector2(vector2Type, 340f, 240f));

                var panelImage = panel.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(panel, new object[] { imageType });
                SetProp(panelImage, "color", CreateColor(colorType, 0f, 0f, 0f, 0.72f));

                var textGO = goType.GetConstructor(Type.EmptyTypes).Invoke(null);
                textGO.GetType().GetMethod("SetParent")?.Invoke(textGO, new object[] { panel, false });
                textGO.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(textGO, new object[] { rectTransformType });
                _expText = textGO.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(textGO, new object[] { textMeshProType });
                SetProp(_expText, "fontSize", 16);
                SetProp(_expText, "color", CreateColor(colorType, 1f, 1f, 1f, 1f));
                SetProp(_expText, "text", "EXP Counter");
            }
            catch (Exception ex) { Log.LogError($"[DE] SetupExpCounter failed: {ex}"); }
        }

        private void ApplyFallbackPosition()
        {
            if (_expRoot == null) return;
            var rectTransformType = GetType("UnityEngine.RectTransform");
            var screenType = GetType("UnityEngine.Screen");
            if (rectTransformType == null || screenType == null) return;

            var rootRect = _expRoot.GetType().GetMethod("GetComponent", new[] { typeof(Type) }).Invoke(_expRoot, new object[] { rectTransformType });
            if (rootRect == null) return;

            var width = (int)GetStaticProp(screenType, "width");
            var height = (int)GetStaticProp(screenType, "height");
            float fx = ExpCounterX.Value / 1000f;
            float fy = ExpCounterY.Value / 1000f;

            var anchoredPositionProp = rectTransformType.GetProperty("anchoredPosition",
                BindingFlags.Public | BindingFlags.Instance);
            var vector2Type = GetType("UnityEngine.Vector2");
            anchoredPositionProp?.SetValue(rootRect, CreateVector2(vector2Type, width * fx, -height * fy));
        }

        private void RefreshExpCounter()
        {
            ApplyFallbackPosition();

            var players = FindObjectsOfType("CFieldPlayer");
            Array.Sort(players, (a, b) => ((int)GetProp(a, "mIndex")).CompareTo((int)GetProp(b, "mIndex")));

            var statusPanels = FindObjectsOfType("CUICharacterStatus");

            var sb = new StringBuilder();
            sb.AppendLine("EXP Counter");
            int panelIdx = 0;
            var active = new HashSet<int>();

            foreach (var p in players)
            {
                active.Add((int)GetProp(p, "mIndex"));
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

                    sb.AppendFormat("P{0} {1}: EXP {2} / {3}\n", GetProp(p, "mIndex"), name, exp, needStr);
                    UpdateExpDisplay((int)GetProp(p, "mIndex"), anchor, exp, needStr, haveData);
                }
                catch (Exception ex)
                {
                    sb.AppendFormat("P{0}: (error: {1})\n", GetProp(p, "mIndex"), ex.Message);
                    if (_expDisplays.ContainsKey((int)GetProp(p, "mIndex"))) RemoveExpDisplay((int)GetProp(p, "mIndex"));
                }
            }

            PruneExpDisplays(active);

            if (_expText != null)
            {
                bool anyAnchored = _expDisplays.Count > 0;
                SetProp(_expText, "text", anyAnchored ? "" : sb.ToString());
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
                disp.GetType().GetMethod("SetParent", new[] { transformType, typeof(bool) })?.Invoke(disp, new object[] { anchor, false });

                var rectTransformType = GetType("UnityEngine.RectTransform");
                var rect = disp.GetType().GetMethod("GetComponent", new[] { typeof(Type) }).Invoke(disp, new object[] { rectTransformType });
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

                var go = goType.GetConstructor(Type.EmptyTypes).Invoke(null);
                go.GetType().GetMethod("SetParent")?.Invoke(go, new object[] { parent, false });

                var rect = go.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(go, new object[] { rectTransformType });
                SetProp(rect, "sizeDelta", CreateVector2(vector2Type, 180f, 20f));

                var text = go.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(go, new object[] { textMeshProType });
                var textRect = text.GetType().GetMethod("GetComponent", new[] { typeof(Type) }).Invoke(text, new object[] { rectTransformType });
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
                var goType = GetType("UnityEngine.GameObject");
                goType.GetMethod("Destroy", new[] { goType })?.Invoke(null, new object[] { disp });
                _expDisplays.Remove(playerIndex);
            }
        }

        private object[] FindObjectsOfType(string typeName)
        {
            var type = GetType(typeName);
            if (type == null) return Array.Empty<object>();
            var findMethod = GetType("UnityEngine.Object").GetMethod("FindObjectsOfType", new[] { typeof(Type) });
            return (object[])findMethod.Invoke(null, new object[] { type });
        }
    }
}
