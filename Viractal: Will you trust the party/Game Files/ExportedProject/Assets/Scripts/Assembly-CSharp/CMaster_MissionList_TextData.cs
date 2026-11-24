using System;

[Serializable]
public class CMaster_MissionList_TextData : IMasterData
{
	public string id;

	public string[] text_table;

	public string[] detail_table;

	public string ID => null;

	public string GetName(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetDetail(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}
}
