using System;
using Fork.Game;

[Serializable]
public class CMaster_HexDetailData : IMasterData
{
	public string id;

	public string[] name_table;

	public string kind;

	public bool isGround;

	public string groundType;

	public int mapIndex;

	public string file;

	public string message;

	public string battlemap;

	public string eventmap;

	private CMaster_HexKindData m_Kind;

	private TextLangData m_Message;

	public string ID => null;

	public bool IsPlain()
	{
		return false;
	}

	public bool IsRoad()
	{
		return false;
	}

	public CMaster_HexKindData GetKind()
	{
		return null;
	}

	public string GetName()
	{
		return null;
	}

	public string GetMessage()
	{
		return null;
	}
}
