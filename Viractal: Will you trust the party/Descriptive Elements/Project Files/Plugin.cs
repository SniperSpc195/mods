using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
        public const string PluginVersion = "2.0.11";

        internal static Plugin Instance { get; private set; }
        internal new static ManualLogSource Log { get; private set; }

        internal ConfigEntry<bool> EnableEventOutcomes { get; private set; }
        internal ConfigEntry<bool> EnableEventDiagnostics { get; private set; }
        internal ConfigEntry<bool> EnableExpCounter { get; private set; }
        internal ConfigEntry<float> ExpCounterX { get; private set; }
        internal ConfigEntry<float> ExpCounterY { get; private set; }
        internal ConfigEntry<float> GrantToastDuration { get; private set; }

        private Harmony _harmony;
        private EventInfo _frameEvent;
        private Delegate _frameHandler;
        private object _expRoot;
        private bool _expRootActive = true;
        private string _lastExpVisibilityState;
        private readonly Dictionary<int, object> _expPanels = new Dictionary<int, object>();
        private readonly Dictionary<int, object> _expTexts = new Dictionary<int, object>();
        private readonly HashSet<int> _expCounterErrors = new HashSet<int>();
        private readonly HashSet<int> _loggedExpCounterRows = new HashSet<int>();
        private readonly Stopwatch _sw = Stopwatch.StartNew();
        private long _lastRefreshTicks;
        private bool _expCounterSetupAttempted;
        private bool _hasLoggedExpRefreshError;
        private bool _hasLoggedExpRefresh;

        public override void Load()
        {
            Instance = this;
            Log = base.Log;
            BindConfig();

            _harmony = new Harmony(PluginGUID);
            try
            {
                EventOutcomePatches.Apply(_harmony);
                if (EnableEventDiagnostics.Value)
                    EventDiagnostics.Apply(_harmony);
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
            if (_expRoot == null) return;

            var now = _sw.ElapsedTicks;
            if (now - _lastRefreshTicks < Stopwatch.Frequency / 2) return;
            _lastRefreshTicks = now;
            try
            {
                UpdateExpCounterVisibility();
                if (!_expRootActive) return;
                RefreshExpCounter();
                _hasLoggedExpRefreshError = false;
            }
            catch (Exception ex)
            {
                if (!_hasLoggedExpRefreshError)
                    Log.LogError($"[{PluginName}] EXP counter refresh failed: {ex}");
                _hasLoggedExpRefreshError = true;
            }
        }

        private void BindConfig()
        {
            EnableEventOutcomes = Config.Bind("General", "EnableEventOutcomes", true, "Show a grant/outcome toast when an event choice is resolved.");
            EnableEventDiagnostics = Config.Bind("General", "EnableEventDiagnostics", false, "Log event choice and a limited number of distinct script positions for preview research.");
            EnableExpCounter = Config.Bind("General", "EnableExpCounter", true, "Show the per-character EXP counter overlay.");
            ExpCounterX = Config.Bind("UI", "ExpCounterX", 10f, "Horizontal EXP counter offset from each player profile (screen fraction * 1000).");
            ExpCounterY = Config.Bind("UI", "ExpCounterY", 10f, "Vertical EXP counter offset from each player profile (screen fraction * 1000).");
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

            var updateCallback = typeof(Plugin).GetMethod(nameof(OnUnityUpdate),
                BindingFlags.NonPublic | BindingFlags.Static);
            if (updateCallback == null)
                throw new MissingMethodException(typeof(Plugin).FullName, nameof(OnUnityUpdate));

            var registered = false;
            foreach (var typeName in new[] { "CFieldMain", "CBattleMain", "CBattleResultMain", "CFieldPlayer" })
                registered |= PatchUpdateCallback(typeName, updateCallback);

            if (!registered)
                Log.LogError($"[{PluginName}] Could not register an update callback for the EXP counter.");
        }

        private bool PatchUpdateCallback(string typeName, MethodInfo callback)
        {
            var type = GetType(typeName);
            var update = type?.GetMethod("Update",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                null, Type.EmptyTypes, null);
            if (update == null)
            {
                Log.LogWarning($"[{PluginName}] {typeName}.Update was not found; no EXP update hook was added there.");
                return false;
            }

            try
            {
                _harmony.Patch(update, postfix: new HarmonyMethod(callback));
                Log.LogInfo($"EXP counter {typeName}.Update callback registered.");
                return true;
            }
            catch (Exception ex)
            {
                Log.LogError($"[{PluginName}] Could not patch {typeName}.Update: {ex}");
                return false;
            }
        }

        private static void OnUnityUpdate() => Instance?.Tick();

        private void UpdateExpCounterVisibility()
        {
            var battleMainType = GetType("CBattleMain");
            if (battleMainType == null)
                throw new TypeLoadException("CBattleMain is unavailable; cannot determine battle visibility.");

            var battleObjects = FindObjectsOfType(battleMainType);
            var resultObjects = FindObjectsOfType("CBattleResultMain");
            var battleCanvasVisible = battleObjects.Any(result => IsGameObjectCanvasVisible(result, "m_Canvas"));
            var resultCanvasVisible = resultObjects.Any(IsBattleResultCanvasVisible);
            var shouldShow = !battleCanvasVisible && !resultCanvasVisible;
            var state = $"battleObjects={battleObjects.Length}, battleCanvasVisible={battleCanvasVisible}, resultObjects={resultObjects.Length}, resultCanvasVisible={resultCanvasVisible}, shouldShow={shouldShow}";
            if (state != _lastExpVisibilityState)
            {
                Log.LogInfo($"[Descriptive Elements] EXP visibility state: {state}");
                _lastExpVisibilityState = state;
            }
            if (shouldShow == _expRootActive) return;

            var setActive = _expRoot.GetType().GetMethod("SetActive",
                BindingFlags.Public | BindingFlags.Instance, null, new[] { typeof(bool) }, null);
            if (setActive == null)
                throw new MissingMethodException(_expRoot.GetType().FullName, "SetActive(Boolean)");
            setActive.Invoke(_expRoot, new object[] { shouldShow });
            _expRootActive = shouldShow;
            Log.LogInfo($"[Descriptive Elements] EXP counters {(shouldShow ? "shown" : "hidden")} for the current game phase.");
        }

        private static bool IsBattleResultCanvasVisible(object result)
            => IsGameObjectCanvasVisible(result, "m_Canvas");

        private static bool IsGameObjectCanvasVisible(object owner, string canvasMember)
        {
            var canvas = ReadRequiredProperty(owner, canvasMember);
            if (canvas == null) return false;

            var enabled = Convert.ToBoolean(ReadRequiredProperty(canvas, "enabled"));
            var gameObject = ReadRequiredProperty(canvas, "gameObject");
            var activeInHierarchy = gameObject != null &&
                                    Convert.ToBoolean(ReadRequiredProperty(gameObject, "activeInHierarchy"));
            return enabled && activeInHierarchy;
        }

        private static object ReadRequiredProperty(object target, string name)
        {
            if (target == null) throw new ArgumentNullException(nameof(target), $"Cannot read '{name}' from a null object.");
            var property = target.GetType().GetProperty(name,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.FlattenHierarchy);
            if (property?.GetMethod == null)
                throw new MissingMemberException(target.GetType().FullName, name);
            return property.GetValue(property.GetMethod.IsStatic ? null : target);
        }

        private static Type GetType(string name)
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) { var t = asm.GetType(name); if (t != null) return t; }
            return null;
        }

        private object Call(object target, string methodName, params object[] args)
        {
            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy;
            var method = FindMethod(target.GetType(), methodName, flags, args);
            if (method == null) { Log.LogWarning($"[DE] Method not found: {target.GetType().Name}.{methodName}({string.Join(", ", args.Select(arg => arg?.GetType().Name ?? "null"))})"); return null; }
            return method.Invoke(target, args);
        }

        private object GetProp(object target, string propertyName)
        {
            var prop = target.GetType().GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            if (prop == null) { Log.LogWarning($"[DE] Property not found: {target.GetType().Name}.{propertyName}"); return null; }
            return prop.GetValue(target);
        }

        internal static void SetProp(object target, string propertyName, object value)
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
            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
            var method = FindMethod(type, methodName, flags, args);
            if (method == null) { Log.LogWarning($"[DE] Static method not found: {type.Name}.{methodName}({string.Join(", ", args.Select(arg => arg?.GetType().Name ?? "null"))})"); return null; }
            return method.Invoke(null, args);
        }

        private static MethodInfo FindMethod(Type type, string methodName, BindingFlags flags, object[] args)
        {
            return type.GetMethods(flags)
                .Where(method => method.Name == methodName && !method.IsGenericMethodDefinition)
                .FirstOrDefault(method =>
                {
                    var parameters = method.GetParameters();
                    if (parameters.Length != args.Length) return false;
                    for (var index = 0; index < parameters.Length; index++)
                    {
                        if (args[index] == null)
                        {
                            if (parameters[index].ParameterType.IsValueType &&
                                Nullable.GetUnderlyingType(parameters[index].ParameterType) == null)
                                return false;
                        }
                        else if (!parameters[index].ParameterType.IsInstanceOfType(args[index]))
                        {
                            return false;
                        }
                    }
                    return true;
                });
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
                var rectTransformType = GetType("UnityEngine.RectTransform");
                var objectType = GetType("UnityEngine.Object");

                if (goType == null || canvasType == null || rectTransformType == null ||
                    objectType == null)
                    throw new TypeLoadException("A required Unity UI canvas type was not found.");

                _expRoot = CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_ExpCounterRoot");
                var canvas = AddComponent(_expRoot, canvasType);
                ConfigureOverlayCanvas(canvas);

                var dontDestroy = objectType?.GetMethod("DontDestroyOnLoad",
                    BindingFlags.Public | BindingFlags.Static, null, new[] { objectType }, null);
                dontDestroy?.Invoke(null, new[] { _expRoot });

                Log.LogInfo("[Descriptive Elements] EXP counter overlay canvas created.");
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
                Log.LogError($"[DE] SetupExpCounter failed: {ex}");
            }
        }

        private object CreateExpCounterPanel(int playerIndex)
        {
            var goType = GetType("UnityEngine.GameObject");
            var rectTransformType = GetType("UnityEngine.RectTransform");
            var imageType = GetType("UnityEngine.UI.Image");
            var textMeshProType = GetType("TMPro.TextMeshProUGUI");
            var colorType = GetType("UnityEngine.Color");
            var vector2Type = GetType("UnityEngine.Vector2");
            if (goType == null || rectTransformType == null || imageType == null ||
                textMeshProType == null || colorType == null || vector2Type == null)
                throw new TypeLoadException("A required EXP label UI type was not found.");

            var panel = CreateRectTransformGameObject(goType, rectTransformType, $"DescriptiveElements_ExpCounter_P{playerIndex}");
            SetParent(panel, _expRoot);
            var panelRect = GetComponent(panel, rectTransformType);
            SetProp(panelRect, "anchorMin", CreateVector2(vector2Type, 0f, 0f));
            SetProp(panelRect, "anchorMax", CreateVector2(vector2Type, 0f, 0f));
            SetProp(panelRect, "pivot", CreateVector2(vector2Type, 0.5f, 0.5f));
            SetProp(panelRect, "sizeDelta", CreateVector2(vector2Type, 190f, 30f));
            SetPanelScreenAnchor(panelRect, playerIndex, vector2Type);

            var panelImage = AddComponent(panel, imageType);
            var panelColor = playerIndex switch
            {
                0 => CreateColor(colorType, 0.75f, 0.12f, 0.12f, 0.58f),
                1 => CreateColor(colorType, 0.12f, 0.35f, 0.78f, 0.58f),
                2 => CreateColor(colorType, 0.12f, 0.58f, 0.2f, 0.58f),
                _ => CreateColor(colorType, 0.12f, 0.12f, 0.12f, 0.58f)
            };
            SetProp(panelImage, "color", panelColor);

            var textGO = CreateRectTransformGameObject(goType, rectTransformType, $"DescriptiveElements_ExpCounterText_P{playerIndex}");
            SetParent(textGO, panel);
            var text = AddComponent(textGO, textMeshProType);
            var textRect = GetComponent(textGO, rectTransformType);
            SetProp(textRect, "anchorMin", CreateVector2(vector2Type, 0f, 0f));
            SetProp(textRect, "anchorMax", CreateVector2(vector2Type, 1f, 1f));
            SetProp(textRect, "offsetMin", CreateVector2(vector2Type, 5f, 2f));
            SetProp(textRect, "offsetMax", CreateVector2(vector2Type, -5f, -2f));
            ConfigureOverlayText(text, CreateColor(colorType, 1f, 1f, 1f, 1f), 14f);

            _expPanels[playerIndex] = panel;
            _expTexts[playerIndex] = text;
            Log.LogInfo($"[Descriptive Elements] Created EXP counter label for player slot {playerIndex + 1}.");
            return panelRect;
        }

        private void SetPanelScreenAnchor(object panelRect, int playerIndex, Type vector2Type)
        {
            var screenType = GetType("UnityEngine.Screen");
            if (screenType == null || vector2Type == null)
                throw new TypeLoadException("UnityEngine.Screen or Vector2 was not found.");

            var width = Convert.ToSingle(GetStaticProp(screenType, "width"));
            var height = Convert.ToSingle(GetStaticProp(screenType, "height"));
            var xAnchor = playerIndex switch { 0 => 0.07f, 1 => 0.308f, 2 => 0.545f, _ => 0.07f };
            const float yAnchor = 0.245f;
            SetProp(panelRect, "anchorMin", CreateVector2(vector2Type, xAnchor, yAnchor));
            SetProp(panelRect, "anchorMax", CreateVector2(vector2Type, xAnchor, yAnchor));
            SetProp(panelRect, "pivot", CreateVector2(vector2Type, 0.5f, 0.5f));
            SetProp(panelRect, "anchoredPosition", CreateVector2(vector2Type, width * ExpCounterX.Value / 1000f,
                height * ExpCounterY.Value / 1000f));
            Log.LogInfo($"[Descriptive Elements] Player slot {playerIndex + 1} EXP counter anchored at ({xAnchor:P1}, {yAnchor:P1}) screen position.");
        }

        private void UpdateExpCounterPosition(int playerIndex)
        {
            if (!_expPanels.TryGetValue(playerIndex, out var panel) || panel == null) return;
            var vector2Type = GetType("UnityEngine.Vector2");
            var rectTransformType = GetType("UnityEngine.RectTransform");
            var panelRect = GetComponent(panel, rectTransformType);
            if (panelRect == null) throw new InvalidOperationException($"EXP panel for player slot {playerIndex + 1} has no RectTransform.");
            var screenType = GetType("UnityEngine.Screen");
            if (screenType == null) throw new TypeLoadException("UnityEngine.Screen was not found.");
            var width = Convert.ToSingle(GetStaticProp(screenType, "width"));
            var height = Convert.ToSingle(GetStaticProp(screenType, "height"));
            SetProp(panelRect, "anchoredPosition", CreateVector2(vector2Type,
                width * ExpCounterX.Value / 1000f, height * ExpCounterY.Value / 1000f));
        }

        private void RefreshExpCounter()
        {
            var players = FindObjectsOfType("CFieldPlayer");
            Array.Sort(players, (a, b) => ((int)GetProp(a, "mIndex")).CompareTo((int)GetProp(b, "mIndex")));
            if (!_hasLoggedExpRefresh)
            {
                Log.LogInfo($"[Descriptive Elements] EXP counter refresh found {players.Length} player(s).");
                _hasLoggedExpRefresh = true;
            }

            foreach (var p in players)
            {
                var playerIndex = (int)GetProp(p, "mIndex");

                try
                {
                    if (!_expPanels.ContainsKey(playerIndex))
                        CreateExpCounterPanel(playerIndex);
                    UpdateExpCounterPosition(playerIndex);

                    var mParam = GetProp(p, "mParam");
                    var mLv = GetProp(mParam, "mLv");
                    var mExp = GetProp(mParam, "mExp");
                    var getFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
                    var getLevel = mLv.GetType().GetMethod("Get", getFlags, null, Type.EmptyTypes, null)
                        ?? throw new MissingMethodException(mLv.GetType().FullName, "Get()");
                    var getExp = mExp.GetType().GetMethod("Get", getFlags, null, Type.EmptyTypes, null)
                        ?? throw new MissingMethodException(mExp.GetType().FullName, "Get()");
                    int lv = Convert.ToInt32(getLevel.Invoke(mLv, null));
                    int exp = Convert.ToInt32(getExp.Invoke(mExp, null));

                    var levelData = CallStatic(GetType("CMaster_CharLevel"), "GetData", lv + 1);
                    int need = levelData != null ? (int)GetProp(levelData, "exp") : 0;
                    bool haveData = need > 0;
                    string needStr = haveData ? need.ToString() : "?";
                    SetProp(_expTexts[playerIndex], "text", $"P{playerIndex + 1} EXP {exp} / {needStr}");
                    if (_loggedExpCounterRows.Add(playerIndex))
                        Log.LogInfo($"[Descriptive Elements] Player slot {playerIndex + 1} EXP counter updated: {exp} / {needStr}.");
                    _expCounterErrors.Remove(playerIndex);
                }
                catch (Exception ex)
                {
                    if (_expPanels.ContainsKey(playerIndex))
                        SetProp(_expTexts[playerIndex], "text", "EXP unavailable");
                    if (_expCounterErrors.Add(playerIndex))
                        Log.LogWarning($"[{PluginName}] Could not update player {playerIndex} EXP counter: {ex}");
                }
            }
        }

        private object[] FindObjectsOfType(string typeName)
        {
            var type = GetType(typeName);
            if (type == null) return Array.Empty<object>();

            return FindObjectsOfType(type);
        }

        internal static object[] FindObjectsOfType(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            var objectType = GetType("UnityEngine.Object");
            if (objectType == null)
                throw new TypeLoadException("UnityEngine.Object was not found in loaded assemblies.");

            var findMethods = objectType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(method => method.Name == "FindObjectsOfType")
                .ToArray();
            var genericFind = findMethods.FirstOrDefault(method =>
                method.IsGenericMethodDefinition && method.GetGenericArguments().Length == 1 &&
                method.GetParameters().Length == 0);

            object found;
            if (genericFind != null)
            {
                found = genericFind.MakeGenericMethod(type).Invoke(null, null);
            }
            else
            {
                var typeFind = findMethods.FirstOrDefault(method =>
                    !method.IsGenericMethod && method.GetParameters().Length == 1 &&
                    method.GetParameters()[0].ParameterType == typeof(Type));
                if (typeFind == null)
                    throw new MissingMethodException(objectType.FullName, "FindObjectsOfType<T>()");
                found = typeFind.Invoke(null, new object[] { type });
            }

            if (found is object[] objects) return objects;
            if (found == null) return Array.Empty<object>();

            var results = new List<object>();
            if (found is System.Collections.IEnumerable enumerable)
            {
                foreach (var item in enumerable) results.Add(item);
                return results.ToArray();
            }

            var foundType = found.GetType();
            var length = foundType.GetProperty("Length")?.GetValue(found)
                         ?? foundType.GetProperty("Count")?.GetValue(found);
            if (length == null)
                throw new InvalidOperationException($"FindObjectsOfType({type.FullName}) returned unsupported array type {foundType.FullName}.");

            var count = Convert.ToInt32(length);
            var indexer = foundType.GetProperty("Item");
            if (indexer == null)
                throw new MissingMemberException(foundType.FullName, "Item");
            for (var i = 0; i < count; i++)
                results.Add(indexer.GetValue(found, new object[] { i }));
            return results.ToArray();
        }

        internal static void ConfigureOverlayCanvas(object canvas)
        {
            if (canvas == null) throw new ArgumentNullException(nameof(canvas));
            var renderMode = canvas.GetType().GetProperty("renderMode",
                BindingFlags.Public | BindingFlags.Instance);
            if (renderMode == null || !renderMode.CanWrite)
                throw new MissingMemberException(canvas.GetType().FullName, "renderMode");
            renderMode.SetValue(canvas, Enum.Parse(renderMode.PropertyType, "ScreenSpaceOverlay"));
            SetProp(canvas, "overrideSorting", true);
            SetProp(canvas, "sortingOrder", 32767);
            SetProp(canvas, "enabled", true);

            var rectTransformType = GetType("UnityEngine.RectTransform");
            var vector2Type = GetType("UnityEngine.Vector2");
            var rect = GetComponent(canvas, rectTransformType);
            if (rect != null)
            {
                SetProp(rect, "anchorMin", CreateVector2(vector2Type, 0f, 0f));
                SetProp(rect, "anchorMax", CreateVector2(vector2Type, 1f, 1f));
                SetProp(rect, "offsetMin", CreateVector2(vector2Type, 0f, 0f));
                SetProp(rect, "offsetMax", CreateVector2(vector2Type, 0f, 0f));
            }
        }

        internal static void ConfigureOverlayText(object text, object color, float fontSize)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            var fontProperty = text.GetType().GetProperty("font",
                BindingFlags.Public | BindingFlags.Instance);
            if (fontProperty?.CanWrite == true)
            {
                var font = GetDefaultTextMeshProFont(fontProperty.PropertyType);
                if (font != null) fontProperty.SetValue(text, font);
                else Plugin.Log.LogWarning("No TextMeshPro font asset was found; overlay text may not render.");
            }

            SetProp(text, "fontSize", fontSize);
            SetProp(text, "color", color);
            var raycastTarget = text.GetType().GetProperty("raycastTarget",
                BindingFlags.Public | BindingFlags.Instance);
            if (raycastTarget?.CanWrite == true) raycastTarget.SetValue(text, false);
        }

        private static object GetDefaultTextMeshProFont(Type fontType)
        {
            var settingsType = GetType("TMPro.TMP_Settings");
            var defaultFont = settingsType?.GetProperty("defaultFontAsset",
                BindingFlags.Public | BindingFlags.Static)?.GetValue(null);
            if (defaultFont != null && fontType.IsInstanceOfType(defaultFont))
                return defaultFont;

            var textType = GetType("TMPro.TextMeshProUGUI");
            if (textType == null) return null;
            foreach (var text in FindObjectsOfType(textType))
            {
                var font = text?.GetType().GetProperty("font",
                    BindingFlags.Public | BindingFlags.Instance)?.GetValue(text);
                if (font != null && fontType.IsInstanceOfType(font))
                    return font;
            }
            return null;
        }

        internal static object CreateRectTransformGameObject(Type gameObjectType, Type rectTransformType, string name)
        {
            if (gameObjectType == null) throw new TypeLoadException("UnityEngine.GameObject was not found.");
            if (rectTransformType == null) throw new TypeLoadException("UnityEngine.RectTransform was not found.");

            var constructor = gameObjectType.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(candidate =>
                {
                    var parameters = candidate.GetParameters();
                    return parameters.Length == 2 && parameters[0].ParameterType == typeof(string);
                });
            if (constructor == null)
                throw new MissingMethodException(gameObjectType.FullName, ".ctor(string, component types)");

            var componentArrayType = constructor.GetParameters()[1].ParameterType;
            object componentTypes;
            if (componentArrayType == typeof(Type[]))
            {
                componentTypes = new[] { rectTransformType };
            }
            else if (componentArrayType.IsGenericType &&
                     componentArrayType.GetGenericTypeDefinition().FullName ==
                     "Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1")
            {
                var il2CppTypeFactory = GetType("Il2CppInterop.Runtime.Il2CppType");
                var fromMethod = il2CppTypeFactory?.GetMethod("From",
                    BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(Type) }, null);
                if (fromMethod == null)
                    throw new MissingMethodException("Il2CppInterop.Runtime.Il2CppType.From(System.Type)");

                var il2CppComponentType = fromMethod.Invoke(null, new object[] { rectTransformType });
                var elementType = componentArrayType.GetGenericArguments()[0];
                if (il2CppComponentType == null || !elementType.IsInstanceOfType(il2CppComponentType))
                    throw new InvalidCastException($"The IL2CPP type wrapper is not compatible with {elementType.FullName}.");

                var arrayConstructor = componentArrayType.GetConstructor(new[] { typeof(long) });
                if (arrayConstructor == null)
                    throw new MissingMethodException(componentArrayType.FullName, ".ctor(long)");
                componentTypes = arrayConstructor.Invoke(new object[] { 1L });

                var indexer = componentArrayType.GetProperty("Item");
                if (indexer?.CanWrite != true)
                    throw new MissingMemberException(componentArrayType.FullName, "Item");
                indexer.SetValue(componentTypes, il2CppComponentType, new object[] { 0 });
            }
            else
            {
                throw new MissingMethodException(gameObjectType.FullName,
                    $".ctor(string, {componentArrayType.FullName})");
            }

            return constructor.Invoke(new[] { (object)name, componentTypes });
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
