using System.Diagnostics;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;

public static class DebugUT
{
	private struct CHECK_TASK_STATE
	{
		public bool state;

		public bool result;
	}

	[Conditional("UNITY_DEBUG")]
	public static void Log(object mes)
	{
	}

	[Conditional("UNITY_DEBUG")]
	public static void LogColor(string c, object mes)
	{
	}

	[Conditional("UNITY_DEBUG")]
	public static void LogError(object mes)
	{
	}

	public static bool CheckTask(Task task, string method)
	{
		return false;
	}

	public static bool IsUnitaskComplete(UniTask task)
	{
		return false;
	}

	public static bool CheckUniTask(UniTask task, string method)
	{
		return false;
	}
}
