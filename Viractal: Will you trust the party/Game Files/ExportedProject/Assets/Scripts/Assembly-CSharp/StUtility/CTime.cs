using System;

namespace StUtility
{
	public class CTime
	{
		public static long GetTimeMillis()
		{
			return 0L;
		}

		public static float GetTimeApp(bool i_IsScaledTime = true)
		{
			return 0f;
		}

		public static double GetTimeAppAdDouble(bool i_IsScaledTime = true)
		{
			return 0.0;
		}

		public static DateTime GetDate(string i_Str, DateTime i_DefaultValue, int i_RetryCount = 2)
		{
			return default;
		}

		public static bool TryGetDate(string i_Str, out DateTime o_DateTime, int i_RetryCount = 2)
		{
			o_DateTime = default;
			return false;
		}

		public static string GetDateString(DateTime i_DataTime)
		{
			return null;
		}

		public static long GetUtc(DateTime i_DataTime)
		{
			return 0L;
		}

		public static long GetUtc(string i_Str)
		{
			return 0L;
		}
	}
}
