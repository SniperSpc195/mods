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
        public const string PluginVersion = "2.0.4";

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
            if (_expRoot == null || _expPanelRect == null || _expText == null) return;

            var now = _sw.ElapsedTicks;
            if (now - _lastRefreshTicks < Stopwatch.Frequency / 2) return;
            _lastRefreshTicks = now;
            try
            {
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

                _expRoot = CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_ExpCounterRoot");
                var canvas = AddComponent(_expRoot, canvasType);
                ConfigureOverlayCanvas(canvas);

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
                ConfigureOverlayText(_expText, CreateColor(colorType, 1f, 1f, 1f, 1f), 16f);
                SetProp(_expText, "text", "EXP Counter");
                var textRect = GetComponent(textGO, rectTransformType);
                SetProp(textRect, "anchorMin", CreateVector2(vector2Type, 0f, 0f));
                SetProp(textRect, "anchorMax", CreateVector2(vector2Type, 1f, 1f));
                SetProp(textRect, "offsetMin", CreateVector2(vector2Type, 8f, 8f));
                SetProp(textRect, "offsetMax", CreateVector2(vector2Type, -8f, -8f));
                Log.LogInfo("[Descriptive Elements] EXP counter UI created on topmost screen overlay.");
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
            if (!_hasLoggedExpRefresh)
            {
                Log.LogInfo($"[Descriptive Elements] EXP counter refresh found {players.Length} player(s).");
                _hasLoggedExpRefresh = true;
            }

            var fallbackText = new StringBuilder();
            fallbackText.AppendLine("EXP Counter");

            foreach (var p in players)
            {
                var playerIndex = (int)GetProp(p, "mIndex");

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
                    fallbackText.AppendFormat("P{0} {1}: EXP {2} / {3}\n", playerIndex, name, exp, needStr);
                }
                catch (Exception ex)
                {
                    fallbackText.AppendFormat("P{0}: (error: {1})\n", playerIndex, ex.Message);
                }
            }

            if (_expText != null)
                SetProp(_expText, "text", fallbackText.ToString());
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
