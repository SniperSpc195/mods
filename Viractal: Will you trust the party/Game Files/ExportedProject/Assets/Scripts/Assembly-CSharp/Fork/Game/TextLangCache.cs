using System.Collections.Generic;

namespace Fork.Game
{
	public class TextLangCache
	{
		private TextLangData[] mLangData;

		private Dictionary<string, TextLangData> mCache;

		public TextLangCache(JsonNode json)
		{
		}

		public TextLangData[] GetArrayLangData()
		{
			return null;
		}

		public string GetString(string id, CFontType.LANG lang = CFontType.LANG.Default)
		{
			return null;
		}

		public string GetString(string id, int num, CFontType.LANG lang = CFontType.LANG.Default)
		{
			return null;
		}

		public TextLangData GetLangData(string id)
		{
			return null;
		}
	}
}
