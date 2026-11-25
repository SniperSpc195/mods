using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace DescriptiveElements
{
    internal static class EventDiagnostics
    {
        private const int MaxDistinctScriptPositionsAfterChoice = 16;
        private static int _choiceId;
        private static int _activeChoiceId;
        private static int _loggedScriptPositions;
        private static readonly HashSet<int> LoggedScriptIndices = new HashSet<int>();

        internal static void Apply(Harmony harmony)
        {
            PatchNamedMethods(harmony, "CEventChoices", "Go", nameof(Postfix_ChoiceOpened),
                method => method.GetParameters().Length == 4 &&
                          (method.GetParameters()[0].ParameterType == typeof(string) ||
                           method.GetParameters()[0].ParameterType.Name == "Il2CppStringArray"));
            PatchNamedMethods(harmony, "CEventChoices", "CbDecision", nameof(Postfix_ChoiceDecision),
                method => method.GetParameters().Length == 1 &&
                          method.GetParameters()[0].ParameterType == typeof(int));
            PatchNamedMethods(harmony, "CEventChoices", "CbCancel", nameof(Postfix_ChoiceCancelled),
                method => method.GetParameters().Length == 0);
            PatchNamedMethods(harmony, "CEventScript", "ExecCommand", nameof(Postfix_ExecCommand),
                method => method.GetParameters().Length == 0);
        }

        private static void PatchNamedMethods(Harmony harmony, string typeName, string methodName,
            MethodInfo handler, Func<MethodInfo, bool> predicate)
        {
            var type = ResolveType(typeName);
            if (type == null)
            {
                Plugin.Log.LogWarning($"[Event diagnostics] Type not found: {typeName}; {methodName} diagnostics skipped.");
                return;
            }
            PatchNamedMethods(harmony, type, methodName, handler, predicate);
        }

        private static void PatchNamedMethods(Harmony harmony, Type type, string methodName,
            MethodInfo handler, Func<MethodInfo, bool> predicate)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic |
                                          BindingFlags.Instance | BindingFlags.Static)
                .Where(method => method.Name == methodName && predicate(method)).ToArray();
            if (methods.Length == 0)
            {
                Plugin.Log.LogWarning($"[Event diagnostics] Method not found: {type.Name}.{methodName}.");
                return;
            }

            foreach (var method in methods)
            {
                try
                {
                    harmony.Patch(method, postfix: new HarmonyMethod(handler));
                    Plugin.Log.LogInfo($"[Event diagnostics] Patched {type.Name}.{method.Name}({string.Join(", ", method.GetParameters().Select(parameter => parameter.ParameterType.Name))}).");
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogError($"[Event diagnostics] Could not patch {type.Name}.{method.Name}: {ex}");
                }
            }
        }

        private static void PatchNamedMethods(Harmony harmony, Type type, string methodName,
            string handlerName, Func<MethodInfo, bool> predicate) =>
            PatchNamedMethods(harmony, type, methodName,
                typeof(EventDiagnostics).GetMethod(handlerName, BindingFlags.NonPublic | BindingFlags.Static), predicate);

        private static void Postfix_ChoiceOpened(object __instance, object[] __args)
        {
            if (!IsEnabled()) return;
            _activeChoiceId = ++_choiceId;
            _loggedScriptPositions = 0;
            LoggedScriptIndices.Clear();
            Plugin.Log.LogInfo($"[Event diagnostics] ===== CHOICE OPEN id={_activeChoiceId} =====");
            if (__args.Length > 0) Plugin.Log.LogInfo($"[Event diagnostics] Choice labels: {Format(__args[0], 80)}");
            LogChoiceState(__instance, "open");
            LogScriptState("choice-open");
        }

        private static void Postfix_ChoiceDecision(object __instance, object[] __args)
        {
            if (!IsEnabled()) return;
            var selected = __args.Length > 0 ? Format(__args[0]) : "(missing)";
            _loggedScriptPositions = 0;
            LoggedScriptIndices.Clear();
            Plugin.Log.LogInfo($"[Event diagnostics] CHOICE DECISION id={_activeChoiceId} selected-index={selected}; capturing up to {MaxDistinctScriptPositionsAfterChoice} distinct script positions.");
            LogChoiceState(__instance, "decision");
            LogScriptState("choice-decision");
        }

        private static void Postfix_ChoiceCancelled(object __instance)
        {
            if (!IsEnabled()) return;
            _loggedScriptPositions = 0;
            LoggedScriptIndices.Clear();
            Plugin.Log.LogInfo($"[Event diagnostics] CHOICE CANCEL id={_activeChoiceId}.");
            LogChoiceState(__instance, "cancel");
        }

        private static void Postfix_ExecCommand(object __instance)
        {
            if (!IsEnabled() || _loggedScriptPositions >= MaxDistinctScriptPositionsAfterChoice) return;
            var index = ReadInt(__instance, "mExecIndex");
            if (index < 0 || !LoggedScriptIndices.Add(index)) return;
            _loggedScriptPositions++;
            Plugin.Log.LogInfo($"[Event diagnostics] SCRIPT POSITION id={_activeChoiceId} unique={_loggedScriptPositions}/{MaxDistinctScriptPositionsAfterChoice}");
            LogMembers(__instance, "script-step", new[] { "mExecIndex", "mCommand", "mExecData" });
        }

        private static void LogChoiceState(object choice, string phase)
        {
            LogMembers(choice, $"choice-{phase}", new[]
            {
                "mMessageText", "mSelected", "mMode", "mChoiceMenu", "mMenus", "mFieldPlayer",
                "mDpData", "mConsumeDP", "mList_SkillAbilityData"
            });
            var menu = ReadMember(choice, "mChoiceMenu");
            if (menu != null)
            {
                LogMembers(menu, $"choice-menu-{phase}", new[] { "m_Menu", "mTextColor", "mTextSize" });
                var menuObject = ReadMember(menu, "m_Menu");
                LogMembers(menuObject, $"generic-menu-{phase}", new[] { "mSelectedItems", "mMaxItems", "mCursor", "mFocusResult" });
                LogMethodResult(menu, "GetCursorPosition", $"choice-menu-{phase} cursor");
                LogMethodResult(menuObject, "GetCursorPosition", $"generic-menu-{phase} cursor");
            }
        }

        private static void LogScriptState(string phase)
        {
            var scriptType = ResolveType("CEventScript");
            if (scriptType == null)
            {
                Plugin.Log.LogWarning($"[Event diagnostics] CEventScript unavailable while logging {phase}.");
                return;
            }
            object[] scripts;
            try
            {
                scripts = Plugin.FindObjectsOfType(scriptType);
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"[Event diagnostics] Could not find active CEventScript objects: {ex}");
                return;
            }

            Plugin.Log.LogInfo($"[Event diagnostics] Active CEventScript objects during {phase}: {scripts.Length}.");
            foreach (var script in scripts) LogScriptObject(script, phase);
        }

        private static void LogScriptObject(object script, string phase)
        {
            if (script == null) return;
            Plugin.Log.LogInfo($"[Event diagnostics] SCRIPT STATE phase={phase} type={script.GetType().FullName}");
            if (phase == "step")
            {
                LogMembers(script, "script-step", new[] { "mExecIndex", "mExecData" });
                return;
            }
            LogMembers(script, $"script-{phase}", new[]
            {
                "mExecIndex", "mCommand", "mExecData", "mExecStack", "mSelfChoice",
                "mSelfLines", "mAddressablePath", "mSyncName", "mSyncCount"
            });
        }

        private static void LogMembers(object instance, string label, IEnumerable<string> names)
        {
            if (instance == null)
            {
                Plugin.Log.LogInfo($"[Event diagnostics] {label}: (null)");
                return;
            }

            foreach (var name in names)
            {
                try
                {
                    var value = ReadMember(instance, name);
                    if (value == null) continue;
                    if (name == "mExecData")
                    {
                        var index = ReadInt(instance, "mExecIndex");
                        Plugin.Log.LogInfo($"[Event diagnostics] {label}.{name}: {FormatIndexedArray(value, index, 16, 48)}");
                    }
                    else if (name == "mCommand")
                        Plugin.Log.LogInfo($"[Event diagnostics] {label}.{name}: {FormatCollection(value, 200)}");
                    else if (name == "mExecStack" || name == "mSelfChoice" || name == "mMenus" ||
                             name == "mDpData" || name == "mList_SkillAbilityData")
                        Plugin.Log.LogInfo($"[Event diagnostics] {label}.{name}: {FormatCollection(value, 24)}");
                    else
                        Plugin.Log.LogInfo($"[Event diagnostics] {label}.{name}: {Format(value, 1200)}");
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogWarning($"[Event diagnostics] Could not read {label}.{name}: {ex.Message}");
                }
            }
        }

        private static void LogMethodResult(object instance, string name, string label)
        {
            if (instance == null) return;
            var method = instance.GetType().GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                null, Type.EmptyTypes, null);
            if (method == null) return;
            try
            {
                Plugin.Log.LogInfo($"[Event diagnostics] {label}: {Format(method.Invoke(instance, null))}");
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[Event diagnostics] Could not invoke {label}: {ex.Message}");
            }
        }

        private static string FormatIndexedArray(object value, int center, int before, int after)
        {
            var count = GetCount(value);
            if (count < 0) return Format(value, 1200);
            var start = center < 0 ? 0 : Math.Max(0, center - before);
            var end = center < 0 ? Math.Min(count, after) : Math.Min(count, center + after);
            var entries = new List<string>();
            var characters = new StringBuilder(end - start);
            for (var index = start; index < end; index++)
            {
                var character = Convert.ToInt32(GetItem(value, index));
                entries.Add($"{index}{(index == center ? "*" : "")}:{character}");
                characters.Append(character >= 32 && character <= 126 ? (char)character : '.');
            }
            return $"type={value.GetType().FullName} length={count} center={center} ascii=\"{characters}\" bytes=[{string.Join(", ", entries)}]";
        }

        private static string FormatCollection(object value, int maximum)
        {
            if (value == null) return "(null)";
            var count = GetCount(value);
            if (value is string || count < 0) return Format(value, 1200);
            var entries = new List<string>();
            for (var index = 0; index < Math.Min(count, maximum); index++)
                entries.Add(Format(GetItem(value, index), 180));
            if (count > maximum) entries.Add($"... {count - maximum} more");
            return $"type={value.GetType().FullName} length={count} [{string.Join(", ", entries)}]";
        }

        private static string Format(object value, int maximum = 400)
        {
            if (value == null) return "(null)";
            if (value is string text) return Truncate($"\"{text.Replace("\r", "\\r").Replace("\n", "\\n")}\"", maximum);
            var type = value.GetType();
            if (type.Name.StartsWith("Tuple`", StringComparison.Ordinal))
            {
                var values = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(property => property.Name.StartsWith("Item", StringComparison.Ordinal))
                    .OrderBy(property => property.Name, StringComparer.Ordinal)
                    .Select(property => Format(property.GetValue(value), 120));
                return Truncate($"({string.Join(", ", values)})", maximum);
            }
            if (type.IsPrimitive || type.IsEnum || value is decimal)
                return Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture);

            var count = GetCount(value);
            if (count >= 0 && value is not IDictionary)
                return FormatCollection(value, Math.Min(count, 20));
            return Truncate($"{type.FullName}({value})", maximum);
        }

        private static string Truncate(string value, int maximum) =>
            value.Length <= maximum ? value : value.Substring(0, maximum) + "...";

        private static int ReadInt(object instance, string name)
        {
            var value = ReadMember(instance, name);
            return value == null ? -1 : Convert.ToInt32(value);
        }

        private static int GetCount(object value)
        {
            if (value == null || value is string) return -1;
            var type = value.GetType();
            var count = type.GetProperty("Length", BindingFlags.Public | BindingFlags.Instance)?.GetValue(value)
                        ?? type.GetProperty("Count", BindingFlags.Public | BindingFlags.Instance)?.GetValue(value);
            return count == null ? -1 : Convert.ToInt32(count);
        }

        private static object GetItem(object value, int index)
        {
            if (value is IList list) return list[index];
            var type = value.GetType();
            var indexer = type.GetProperty("Item", BindingFlags.Public | BindingFlags.Instance);
            if (indexer != null) return indexer.GetValue(value, new object[] { index });
            var getter = type.GetMethod("get_Item", BindingFlags.Public | BindingFlags.Instance, null,
                new[] { typeof(int) }, null);
            if (getter != null) return getter.Invoke(value, new object[] { index });
            if (value is IEnumerable enumerable) return enumerable.Cast<object>().Skip(index).FirstOrDefault();
            throw new MissingMemberException(type.FullName, "Item");
        }

        private static object ReadMember(object instance, string name)
        {
            if (instance == null) return null;
            const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic |
                                       BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy;
            var type = instance.GetType();
            var property = type.GetProperty(name, flags);
            if (property?.GetMethod != null) return property.GetValue(property.GetMethod.IsStatic ? null : instance);
            var field = type.GetField(name, flags);
            return field?.GetValue(field.IsStatic ? null : instance);
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

        private static bool IsEnabled() =>
            Plugin.Instance?.EnableEventDiagnostics?.Value == true && Plugin.Log != null;

        private static void PatchNamedMethods(Harmony harmony, string typeName, string methodName,
            string handlerName, Func<MethodInfo, bool> predicate) =>
            PatchNamedMethods(harmony, typeName, methodName,
                typeof(EventDiagnostics).GetMethod(handlerName, BindingFlags.NonPublic | BindingFlags.Static), predicate);
    }
}
