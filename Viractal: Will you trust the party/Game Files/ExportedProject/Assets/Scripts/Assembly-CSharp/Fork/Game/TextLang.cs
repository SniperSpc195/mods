using System.Collections.Generic;

namespace Fork.Game
{
	public class TextLang
	{
		private static Dictionary<string, TextLangCache> mData;

		private static GameController.PADNUM mPadNum;

		public static CFontType.LANG CheckLang(string[] table, CFontType.LANG lang = CFontType.LANG.Default)
		{
			return CFontType.LANG.Ja;
		}

		public static void Load(string path, bool overwrite = false)
		{
		}

		public static void LoadDownloadMaster(string path, bool overwrite = false)
		{
		}

		private static void Setup(string file_name, string text)
		{
		}

		public static void SetPadNum(GameController.PADNUM pad = GameController.PADNUM.None)
		{
		}

		private static string CheckPlayerJOB(string key, out bool jobSelect)
		{
			jobSelect = default;
			return null;
		}

		private static string GetStringID(bool jobSelect, string file, string id, CFontType.LANG lang, GameController.PADNUM padNum)
		{
			return null;
		}

		private static string GetStringNum(bool jobSelect, string file, string id, int num, CFontType.LANG lang, GameController.PADNUM padNum)
		{
			return null;
		}

		public static string GetString(string key, GameController.PADNUM padNum)
		{
			return null;
		}

		public static string GetString(string key, int num, GameController.PADNUM padNum)
		{
			return null;
		}

		public static string GetString(string key, CFontType.LANG lang = CFontType.LANG.Default, GameController.PADNUM padNum = GameController.PADNUM.None)
		{
			return null;
		}

		public static string GetString(string key, int num, CFontType.LANG lang = CFontType.LANG.Default, GameController.PADNUM padNum = GameController.PADNUM.None)
		{
			return null;
		}

		public static string GetString(string filename, string id, CFontType.LANG lang = CFontType.LANG.Default, GameController.PADNUM padNum = GameController.PADNUM.None)
		{
			return null;
		}

		public static string GetString(string filename, string id, int num, CFontType.LANG lang = CFontType.LANG.Default, GameController.PADNUM padNum = GameController.PADNUM.None)
		{
			return null;
		}

		public static string GetString(string[] list, CFontType.LANG lang = CFontType.LANG.Default)
		{
			return null;
		}

		public static TextLangData[] GetArrayLangData(string filename)
		{
			return null;
		}

		public static TextLangData GetLangData(string key)
		{
			return null;
		}

		public static TextLangData GetLangData(string filename, string id)
		{
			return null;
		}
	}
}
