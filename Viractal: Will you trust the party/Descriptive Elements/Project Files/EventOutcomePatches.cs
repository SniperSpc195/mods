using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace DescriptiveElements
{
    internal static class EventOutcomePatches
    {
        private static int _lastChoiceIndex = -1;

        internal static void Apply(Harmony harmony)
        {
            var grantType = ResolveType("CEventGrant");
            if (grantType == null)
            {
                Plugin.Log.LogWarning("[Descriptive Elements] CEventGrant type not found; grant patches skipped.");
                return;
            }

            var typeParam = grantType.GetNestedType("TYPE");
            if (typeParam == null)
            {
                Plugin.Log.LogWarning("[Descriptive Elements] CEventGrant.TYPE not found; grant patches skipped.");
                return;
            }

            Patch(harmony, grantType, "Start", new[] { typeParam, typeof(int), typeof(int) },
                nameof(Prefix_Grant_Int), true);
            Patch(harmony, grantType, "Start", new[] { typeParam, typeof(List<string>) },
                nameof(Prefix_Grant_ListString), true);

            var pairStrInt = ResolvePairStrIntType(grantType);
            if (pairStrInt != null)
                Patch(harmony, grantType, "Start", new[] { typeParam, typeof(List<>).MakeGenericType(pairStrInt) },
                    nameof(Prefix_Grant_ListPair), true);

            Patch(harmony, grantType, "StartDroprank", new[] { typeof(List<string>), typeof(List<int>) },
                nameof(Prefix_StartDroprank), true);

            var choicesType = ResolveType("CEventChoices");
            if (choicesType != null)
                Patch(harmony, choicesType, "CbDecision", new[] { typeof(int) },
                    nameof(Postfix_CbDecision), false);
        }

        private static void Patch(Harmony harmony, Type type, string methodName, Type[] paramTypes,
            string handlerName, bool isPrefix)
        {
            var method = type.GetMethod(methodName, paramTypes);
            if (method == null)
            {
                Plugin.Log.LogWarning($"[Descriptive Elements] Patch target not found: {type.Name}.{methodName}");
                return;
            }
            var handler = typeof(EventOutcomePatches).GetMethod(handlerName,
                BindingFlags.NonPublic | BindingFlags.Static);
            if (handler == null)
            {
                Plugin.Log.LogError($"[Descriptive Elements] Patch handler not found: {handlerName}");
                return;
            }
            if (isPrefix)
                harmony.Patch(method, prefix: new HarmonyMethod(handler));
            else
                harmony.Patch(method, postfix: new HarmonyMethod(handler));
        }

        private static bool Prefix_Grant_Int(object __instance, object typeObj, int add, int bonus)
        {
            if (!Plugin.Instance.EnableEventOutcomes.Value) return true;
            try
            {
                var sb = new StringBuilder();
                sb.Append(typeObj).Append(" +").Append(add);
                if (bonus != 0) sb.Append(" (bonus +").Append(bonus).Append(")");
                sb.Append(" | ").Append(PlayerInfo(__instance)).Append(ChoiceSuffix());
                ShowGrantToast(sb.ToString(), Classify(typeObj));
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] Prefix_Grant_Int: {ex}"); }
            return true;
        }

        private static bool Prefix_Grant_ListString(object __instance, object typeObj, List<string> list)
        {
            if (!Plugin.Instance.EnableEventOutcomes.Value) return true;
            try
            {
                var sb = new StringBuilder();
                sb.Append(typeObj);
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i > 0) sb.Append(", ");
                        sb.Append(ResolveItemName(list[i]));
                    }
                }
                else sb.Append(" (none)");
                sb.Append(" | ").Append(PlayerInfo(__instance)).Append(ChoiceSuffix());
                ShowGrantToast(sb.ToString(), Classify(typeObj));
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] Prefix_Grant_ListString: {ex}"); }
            return true;
        }

        private static bool Prefix_Grant_ListPair(object __instance, object typeObj, object listObj)
        {
            if (!Plugin.Instance.EnableEventOutcomes.Value) return true;
            try
            {
                var list = listObj as IList<object>;
                var sb = new StringBuilder();
                sb.Append(typeObj);
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i > 0) sb.Append(", ");
                        var pair = ReadPairStrInt(list[i]);
                        sb.Append(ResolveItemName(pair.id));
                        if (pair.count != 0) sb.Append(" x").Append(pair.count);
                    }
                }
                else sb.Append(" (none)");
                sb.Append(" | ").Append(PlayerInfo(__instance)).Append(ChoiceSuffix());
                ShowGrantToast(sb.ToString(), Classify(typeObj));
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] Prefix_Grant_ListPair: {ex}"); }
            return true;
        }

        private static bool Prefix_StartDroprank(object __instance, List<string> names, List<int> nums)
        {
            if (!Plugin.Instance.EnableEventOutcomes.Value) return true;
            try
            {
                var sb = new StringBuilder();
                sb.Append("DropRank");
                if (names != null)
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (i > 0) sb.Append(", ");
                        sb.Append(names[i]);
                        if (nums != null && i < nums.Count) sb.Append(" x").Append(nums[i]);
                    }
                }
                else sb.Append(" (none)");
                sb.Append(" | ").Append(PlayerInfo(__instance)).Append(ChoiceSuffix());
                ShowGrantToast(sb.ToString(), "neutral");
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] Prefix_StartDroprank: {ex}"); }
            return true;
        }

        private static void Postfix_CbDecision(int cur) => _lastChoiceIndex = cur;
        private static string ChoiceSuffix() => _lastChoiceIndex >= 0 ? $" | Choice #{_lastChoiceIndex}" : "";

        private static string PlayerInfo(object inst)
        {
            try
            {
                var target = GetFieldValue<object>(inst, "mTargetPlayer");
                var exec = GetFieldValue<object>(inst, "mExecPlayer");
                var p = target ?? exec;
                if (p != null)
                {
                    var idx = GetFieldValue<int>(p, "mIndex");
                    var nameMethod = p.GetType().GetMethod("Name", Type.EmptyTypes);
                    var name = nameMethod?.Invoke(p, null)?.ToString() ?? "?";
                    return $"P{idx} ({name})";
                }
            }
            catch { }
            return "target=?";
        }

        private static string ResolveItemName(string id)
        {
            if (string.IsNullOrEmpty(id)) return "(empty)";
            try
            {
                var itemType = ResolveType("CMaster_Item");
                if (itemType == null) return id;
                var data = CallStatic(itemType, "GetData", id);
                if (data == null) return id;
                var nameMethod = data.GetType().GetMethod("GetName", Type.EmptyTypes);
                var name = nameMethod?.Invoke(data, null)?.ToString();
                if (!string.IsNullOrEmpty(name)) return name;
            }
            catch { }
            return id;
        }

        private static (string id, int count) ReadPairStrInt(object pair)
        {
            string id = null; int count = 0;
            if (pair == null) return (null, 0);
            foreach (var f in pair.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (f.FieldType == typeof(string) && id == null) id = (string)f.GetValue(pair);
                else if (f.FieldType == typeof(int) && count == 0) count = (int)f.GetValue(pair);
            }
            return (id, count);
        }

        private static string Classify(object typeObj)
        {
            var typeStr = typeObj?.ToString() ?? "";
            var good = new[] { "Grant_Item", "Grant_Card", "Grant_Ability", "Grant_Condition", "Money",
                "HP_Num", "HP_Per", "MaxHP", "Speed", "Dp", "NoText_Dp", "Exp", "DropRank_Money" };
            var bad = new[] { "Erase_Item", "Erase_Card", "Erase_Ability", "Erase_Condition",
                "Reset_MaxHP", "Reset_Speed" };
            if (Array.IndexOf(good, typeStr) >= 0) return "good";
            if (Array.IndexOf(bad, typeStr) >= 0) return "bad";
            return "neutral";
        }

        private static void ShowGrantToast(string text, string classify)
        {
            try
            {
                float duration = Plugin.Instance?.GrantToastDuration?.Value ?? 5f;
                var goType = ResolveType("UnityEngine.GameObject");
                var canvasType = ResolveType("UnityEngine.Canvas");
                var graphicRaycasterType = ResolveType("UnityEngine.UI.GraphicRaycaster");
                var rectTransformType = ResolveType("UnityEngine.RectTransform");
                var imageType = ResolveType("UnityEngine.UI.Image");
                var textMeshProType = ResolveType("TMPro.TextMeshProUGUI");
                var colorType = ResolveType("UnityEngine.Color");
                var vector2Type = ResolveType("UnityEngine.Vector2");
                var objectType = ResolveType("UnityEngine.Object");

                if (goType == null || canvasType == null || imageType == null || textMeshProType == null) return;

                var go = goType.GetConstructor(Type.EmptyTypes).Invoke(null);
                objectType.GetMethod("DontDestroyOnLoad")?.Invoke(null, new object[] { go });

                var canvas = goType.GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(go, new object[] { canvasType });
                SetProp(canvas, "sortingOrder", 32767);
                goType.GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(go, new object[] { graphicRaycasterType });

                var panel = goType.GetConstructor(Type.EmptyTypes).Invoke(null);
                panel.GetType().GetMethod("SetParent")?.Invoke(panel, new object[] { go, false });
                var rect = panel.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(panel, new object[] { rectTransformType });
                SetProp(rect, "anchorMin", CreateVector2(vector2Type, 0.5f, 0f));
                SetProp(rect, "anchorMax", CreateVector2(vector2Type, 0.5f, 0f));
                SetProp(rect, "pivot", CreateVector2(vector2Type, 0.5f, 0f));
                SetProp(rect, "anchoredPosition", CreateVector2(vector2Type, 0f, 70f));
                SetProp(rect, "sizeDelta", CreateVector2(vector2Type, 760f, 42f));

                var img = panel.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(panel, new object[] { imageType });
                SetProp(img, "color", CreateColor(colorType, 0f, 0f, 0f, 0.8f));

                var textGO = goType.GetConstructor(Type.EmptyTypes).Invoke(null);
                textGO.GetType().GetMethod("SetParent")?.Invoke(textGO, new object[] { panel, false });
                textGO.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(textGO, new object[] { rectTransformType });
                var txt = textGO.GetType().GetMethod("AddComponent", new[] { typeof(Type) }).Invoke(textGO, new object[] { textMeshProType });
                SetProp(txt, "text", $"[{classify}] {text}");
                SetProp(txt, "fontSize", 18);
                SetProp(txt, "color", ColorFor(classify, colorType));

                objectType.GetMethod("Destroy", new[] { goType })?.Invoke(null, new object[] { go });
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] ShowGrantToast: {ex}"); }
        }

        private static object CreateVector2(Type vector2Type, float x, float y)
        {
            try { return vector2Type.GetConstructor(new[] { typeof(float), typeof(float) }).Invoke(new object[] { x, y }); } catch { return null; }
        }

        private static object CreateColor(Type colorType, float r, float g, float b, float a)
        {
            try { return colorType.GetConstructor(new[] { typeof(float), typeof(float), typeof(float), typeof(float) }).Invoke(new object[] { r, g, b, a }); } catch { return null; }
        }

        private static void SetProp(object target, string propertyName, object value)
        {
            var prop = target.GetType().GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            prop?.SetValue(target, value);
        }

        private static object ColorFor(string classify, Type colorType)
        {
            switch (classify)
            {
                case "good": return CreateColor(colorType, 0.7f, 1f, 0.7f, 1f);
                case "bad": return CreateColor(colorType, 1f, 0.65f, 0.65f, 1f);
                default: return CreateColor(colorType, 0.9f, 0.9f, 0.9f, 1f);
            }
        }

        private static T GetFieldValue<T>(object obj, string fieldName)
        {
            var field = obj.GetType().GetField(fieldName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (field == null) return default;
            return (T)field.GetValue(obj);
        }

        private static Type ResolveType(string name)
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) { var t = asm.GetType(name); if (t != null) return t; }
            return null;
        }

        private static Type ResolvePairStrIntType(Type grant)
        {
            foreach (var name in new[] { "PairStrInt", "Fork.Game.PairStrInt" })
            { var t = grant.Assembly.GetType(name); if (t != null) return t; }
            return null;
        }

        private static object CallStatic(Type type, string methodName, params object[] args)
        {
            var method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            return method?.Invoke(null, args);
        }
    }
}
