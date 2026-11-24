using System.Diagnostics;

namespace StUtility
{
	internal class CSystem
	{
		public static string LogTagDefault;

		[Conditional("UNITY_DEBUG")]
		public static void Log(object i_Mes, string i_Tag = null, bool truncated = true)
		{
		}

		[Conditional("UNITY_DEBUG")]
		public static void LogColor(object i_Color, object i_Mes, string i_Tag = null)
		{
		}

		[Conditional("UNITY_DEBUG")]
		public static void LogError(object i_Mes, string i_Tag = null)
		{
		}

		[Conditional("UNITY_DEBUG")]
		public static void LogWarning(object i_Mes, string i_Tag = null)
		{
		}

		[Conditional("UNITY_DEBUG")]
		public static void Assert(bool i_Condition, object i_Mes, string i_Tag = null)
		{
		}

		public static int GetFps()
		{
			return 0;
		}
	}
}
