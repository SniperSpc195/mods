using System.Collections.Generic;

internal class JsonMng
{
	private struct JsonData
	{
		public List<string> mKeys;

		public JsonNode mJson;

		public JsonData(JsonNode json)
		{
			mKeys = null;
			mJson = null;
		}
	}

	private static Dictionary<string, JsonData> mList;

	private static object mLockObject;

	private static JsonNode mAsyncJson;

	private static string CreateKey(string path)
	{
		return null;
	}

	public static void SetJson(string name, string txt, bool update = false)
	{
	}

	public static JsonNode GetJsonAsync()
	{
		return null;
	}

	private static void JsonParse(string t)
	{
	}

	public static string Load(string path)
	{
		return null;
	}

	public static JsonNode GetJsonNode(string name)
	{
		return null;
	}

	public static JsonNode GetJsonNode(string name, string key)
	{
		return null;
	}

	public static Dictionary<string, object> GetDictionary(string name)
	{
		return null;
	}

	public static List<string> GetKeyList(string name)
	{
		return null;
	}

	public bool KeyIsValid(string name, string key)
	{
		return false;
	}
}
