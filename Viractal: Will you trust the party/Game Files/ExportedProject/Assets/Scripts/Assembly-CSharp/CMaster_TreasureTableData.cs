using System;

[Serializable]
public class CMaster_TreasureTableData : IMasterData
{
	public string id;

	public string table_id;

	public string kind;

	public string rarity;

	public string type;

	public int[] probability_table;

	public string item_id;

	public string ID => null;

	public CMaster_SkillCardData GetSkillCardData()
	{
		return null;
	}

	public CMaster_ItemData GetItemData()
	{
		return null;
	}

	public bool IsItem()
	{
		return false;
	}

	public bool IsCard()
	{
		return false;
	}

	public bool IsCommon()
	{
		return false;
	}

	public bool IsRare()
	{
		return false;
	}

	public bool IsTypeHit()
	{
		return false;
	}

	public bool IsTypeNormal()
	{
		return false;
	}

	public bool IsTypeMiss()
	{
		return false;
	}

	public string GetIconName()
	{
		return null;
	}

	public string GetName()
	{
		return null;
	}

	public string GetIconGenreName()
	{
		return null;
	}

	public bool IsOpen()
	{
		return false;
	}
}
