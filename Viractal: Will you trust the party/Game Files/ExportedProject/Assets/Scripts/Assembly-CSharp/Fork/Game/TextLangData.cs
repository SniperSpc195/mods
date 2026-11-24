using System.Collections.Generic;

namespace Fork.Game
{
	public class TextLangData
	{
		private string id;

		private List<List<string>> text_table;

		private const string COLOR_GRANT = "<COLOR_GRANT>";

		private const string COLOR_USE_ITEM = "<COLOR_USE_ITEM>";

		public string ID => null;

		public TextLangData(JsonNode json)
		{
		}

		private static string ConvColor(string a)
		{
			return null;
		}

		public string GetString(int num = 0, CFontType.LANG lang = CFontType.LANG.Default)
		{
			return null;
		}

		public string GetStringIndex(int num = 0, int lang = -1)
		{
			return null;
		}
	}
}
