using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

            var patchedCount = 0;
            foreach (var method in grantType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                         .Where(candidate => candidate.Name == "Start"))
            {
                var parameters = method.GetParameters();
                if (parameters.Length == 3 &&
                    parameters[0].ParameterType == typeParam &&
                    parameters[1].ParameterType == typeof(int) &&
                    parameters[2].ParameterType == typeof(int))
                {
                    if (Patch(harmony, method, nameof(Prefix_Grant_Int), true)) patchedCount++;
                }
                else if (parameters.Length == 2 &&
                         parameters[0].ParameterType == typeParam &&
                         IsCollectionType(parameters[1].ParameterType))
                {
                    if (Patch(harmony, method, nameof(Prefix_Grant_List), true)) patchedCount++;
                }
            }

            foreach (var method in grantType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                         .Where(candidate => candidate.Name == "StartDroprank"))
            {
                var parameters = method.GetParameters();
                if (parameters.Length == 2 &&
                    IsCollectionType(parameters[0].ParameterType) &&
                    IsCollectionType(parameters[1].ParameterType))
                    if (Patch(harmony, method, nameof(Prefix_StartDroprank), true)) patchedCount++;
            }
            if (patchedCount == 0)
                Plugin.Log.LogWarning("[Descriptive Elements] No CEventGrant.Start or StartDroprank overloads matched.");

            var choicesType = ResolveType("CEventChoices");
            if (choicesType != null)
            {
                var decision = choicesType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                    .FirstOrDefault(candidate => candidate.Name == "CbDecision" &&
                                                 candidate.GetParameters().Length == 1 &&
                                                 candidate.GetParameters()[0].ParameterType == typeof(int));
                if (decision != null) Patch(harmony, decision, nameof(Postfix_CbDecision), false);
                else Plugin.Log.LogWarning("[Descriptive Elements] Patch target not found: CEventChoices.CbDecision");
            }
            else
            {
                Plugin.Log.LogWarning("[Descriptive Elements] CEventChoices type not found; choice tracking skipped.");
            }

            Plugin.Log.LogInfo($"[Descriptive Elements] Patched {patchedCount} event-grant method(s).");
        }

        private static bool IsCollectionType(Type type)
        {
            return typeof(IEnumerable).IsAssignableFrom(type) ||
                   type.Name.IndexOf("List", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private static bool Patch(Harmony harmony, MethodInfo method, string handlerName, bool isPrefix)
        {
            var handler = typeof(EventOutcomePatches).GetMethod(handlerName,
                BindingFlags.NonPublic | BindingFlags.Static);
            if (handler == null)
            {
                Plugin.Log.LogError($"[Descriptive Elements] Patch handler not found: {handlerName}");
                return false;
            }
            if (isPrefix)
                harmony.Patch(method, prefix: new HarmonyMethod(handler));
            else
                harmony.Patch(method, postfix: new HarmonyMethod(handler));
            Plugin.Log.LogInfo($"[Descriptive Elements] Patched {method.DeclaringType?.Name}.{method.Name}({string.Join(", ", method.GetParameters().Select(parameter => parameter.ParameterType.Name))}).");
            return true;
        }

        private static bool Prefix_Grant_Int(object __instance, object[] __args)
        {
            try
            {
                var typeObj = __args[0];
                var add = Convert.ToInt32(__args[1]);
                var bonus = Convert.ToInt32(__args[2]);
                var sb = new StringBuilder();
                var outcomeText = new StringBuilder();
                outcomeText.Append(typeObj).Append(' ').Append(FormatSigned(add));
                if (bonus != 0) outcomeText.Append(" (bonus ").Append(FormatSigned(bonus)).Append(')');
                sb.Append(outcomeText);
                sb.Append(" | ").Append(PlayerInfo(__instance)).Append(ChoiceSuffix());
                var classification = Classify(typeObj, (long)add + bonus);
                EventPreviewCache.RecordOutcome(outcomeText.ToString(), classification);
                if (Plugin.Instance.EnableEventOutcomes.Value)
                    ShowGrantToast(sb.ToString(), classification);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] Prefix_Grant_Int: {ex}"); }
            return true;
        }

        private static bool Prefix_Grant_List(object __instance, object[] __args)
        {
            try
            {
                var typeObj = __args[0];
                var list = EnumerateCollection(__args[1]).ToArray();
                var sb = new StringBuilder();
                var outcomeText = new StringBuilder();
                outcomeText.Append(typeObj);
                if (list.Length > 0)
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (i > 0) outcomeText.Append(", ");
                        if (list[i] is string id)
                        {
                            outcomeText.Append(ResolveItemName(id));
                        }
                        else
                        {
                            var pair = ReadPairStrInt(list[i]);
                            outcomeText.Append(ResolveItemName(pair.id));
                            if (pair.count != 0) outcomeText.Append(" x").Append(pair.count);
                        }
                    }
                }
                else outcomeText.Append(" (none)");
                sb.Append(outcomeText);
                sb.Append(" | ").Append(PlayerInfo(__instance)).Append(ChoiceSuffix());
                var classification = Classify(typeObj);
                EventPreviewCache.RecordOutcome(outcomeText.ToString(), classification);
                if (Plugin.Instance.EnableEventOutcomes.Value)
                    ShowGrantToast(sb.ToString(), classification);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] Prefix_Grant_List: {ex}"); }
            return true;
        }

        private static bool Prefix_StartDroprank(object __instance, object[] __args)
        {
            if (!Plugin.Instance.EnableEventOutcomes.Value) return true;
            try
            {
                var names = EnumerateCollection(__args[0]).ToArray();
                var nums = EnumerateCollection(__args[1]).Select(value => Convert.ToInt32(value)).ToArray();
                var sb = new StringBuilder();
                sb.Append("DropRank");
                if (names.Length > 0)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (i > 0) sb.Append(", ");
                        sb.Append(names[i]);
                        if (i < nums.Length) sb.Append(" x").Append(nums[i]);
                    }
                }
                else sb.Append(" (none)");
                sb.Append(" | ").Append(PlayerInfo(__instance)).Append(ChoiceSuffix());
                ShowGrantToast(sb.ToString(), "neutral");
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] Prefix_StartDroprank: {ex}"); }
            return true;
        }

        private static void Postfix_CbDecision(object[] __args) => _lastChoiceIndex = Convert.ToInt32(__args[0]);
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

        private static IEnumerable<object> EnumerateCollection(object collection)
        {
            if (collection == null) yield break;

            if (collection is IEnumerable enumerable)
            {
                foreach (var item in enumerable) yield return item;
                yield break;
            }

            var type = collection.GetType();
            var countValue = type.GetProperty("Count")?.GetValue(collection)
                             ?? type.GetProperty("Length")?.GetValue(collection);
            if (countValue == null) yield break;

            var count = Convert.ToInt32(countValue);
            var indexer = type.GetProperty("Item");
            var getItem = type.GetMethod("get_Item", new[] { typeof(int) });
            for (var index = 0; index < count; index++)
            {
                if (indexer != null) yield return indexer.GetValue(collection, new object[] { index });
                else if (getItem != null) yield return getItem.Invoke(collection, new object[] { index });
                else yield break;
            }
        }

        private static string FormatSigned(int value) => value > 0 ? $"+{value}" : value.ToString();

        private static string Classify(object typeObj, long? change = null)
        {
            var typeStr = typeObj?.ToString() ?? "";
            switch (typeStr)
            {
                case "HP_Num":
                case "HP_Per":
                case "MaxHP":
                case "Money":
                case "Speed":
                case "Dp":
                case "NoText_Dp":
                case "Exp":
                case "DropRank_Money":
                    return change > 0 ? "good" : change < 0 ? "bad" : "neutral";
                case "Grant_Item":
                case "Grant_Card":
                case "Grant_Ability":
                case "Grant_Condition":
                    return "good";
                case "Erase_Item":
                case "Erase_Card":
                case "Erase_Ability":
                case "Erase_Condition":
                case "Reset_MaxHP":
                case "Reset_Speed":
                    return "bad";
            }
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

                if (goType == null || canvasType == null || rectTransformType == null ||
                    imageType == null || textMeshProType == null || colorType == null || vector2Type == null)
                    throw new TypeLoadException("A required Unity UI type was not found.");

                var go = Plugin.CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_GrantToast");
                var dontDestroy = objectType?.GetMethod("DontDestroyOnLoad",
                    BindingFlags.Public | BindingFlags.Static, null, new[] { objectType }, null);
                dontDestroy?.Invoke(null, new[] { go });

                var canvas = Plugin.AddComponent(go, canvasType);
                Plugin.ConfigureOverlayCanvas(canvas);
                if (graphicRaycasterType != null) Plugin.AddComponent(go, graphicRaycasterType);

                var panel = Plugin.CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_GrantToastPanel");
                Plugin.Instance.SetParent(panel, go);
                var rect = Plugin.GetComponent(panel, rectTransformType);
                SetProp(rect, "anchorMin", Plugin.CreateVector2(vector2Type, 0.5f, 0f));
                SetProp(rect, "anchorMax", Plugin.CreateVector2(vector2Type, 0.5f, 0f));
                SetProp(rect, "pivot", Plugin.CreateVector2(vector2Type, 0.5f, 0f));
                SetProp(rect, "anchoredPosition", Plugin.CreateVector2(vector2Type, 0f, 70f));
                SetProp(rect, "sizeDelta", Plugin.CreateVector2(vector2Type, 760f, 42f));

                var img = Plugin.AddComponent(panel, imageType);
                SetProp(img, "color", Plugin.CreateColor(colorType, 0f, 0f, 0f, 0.8f));

                var textGO = Plugin.CreateRectTransformGameObject(goType, rectTransformType, "DescriptiveElements_GrantToastText");
                Plugin.Instance.SetParent(textGO, panel);
                var txt = Plugin.AddComponent(textGO, textMeshProType);
                var textRect = Plugin.GetComponent(textGO, rectTransformType);
                SetProp(textRect, "anchorMin", Plugin.CreateVector2(vector2Type, 0f, 0f));
                SetProp(textRect, "anchorMax", Plugin.CreateVector2(vector2Type, 1f, 1f));
                SetProp(textRect, "offsetMin", Plugin.CreateVector2(vector2Type, 10f, 4f));
                SetProp(textRect, "offsetMax", Plugin.CreateVector2(vector2Type, -10f, -4f));
                SetProp(txt, "text", $"[{classify}] {text}");
                Plugin.ConfigureOverlayText(txt, ColorFor(classify, colorType), 18f);

                Plugin.Instance.DestroyUnityObject(go, duration);
                Plugin.Log.LogInfo($"[Descriptive Elements] Displaying outcome toast: {text}");
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[DE] ShowGrantToast: {ex}"); }
        }

        private static void SetProp(object target, string propertyName, object value)
        {
            if (target == null) throw new ArgumentNullException(nameof(target), $"Cannot set '{propertyName}' on a null object.");
            var prop = target.GetType().GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            if (prop == null || !prop.CanWrite)
                throw new MissingMemberException(target.GetType().FullName, propertyName);
            prop.SetValue(target, value);
        }

        private static object ColorFor(string classify, Type colorType)
        {
            switch (classify)
            {
                case "good": return Plugin.CreateColor(colorType, 0.7f, 1f, 0.7f, 1f);
                case "bad": return Plugin.CreateColor(colorType, 1f, 0.65f, 0.65f, 1f);
                default: return Plugin.CreateColor(colorType, 0.9f, 0.9f, 0.9f, 1f);
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

        private static object CallStatic(Type type, string methodName, params object[] args)
        {
            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
            var method = type.GetMethods(flags)
                .Where(candidate => candidate.Name == methodName && !candidate.IsGenericMethodDefinition)
                .FirstOrDefault(candidate =>
                {
                    var parameters = candidate.GetParameters();
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
            return method?.Invoke(null, args);
        }
    }
}
