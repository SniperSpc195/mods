using System;

[Serializable]
public class CMaster_EventObjectData : IMasterData
{
	public string id;

	public string kind;

	public string model;

	public int open;

	public float fieldScale;

	public string script;

	public string text;

	public string treasure_type;

	public int[] layer_random_point1_table;

	public int max_point;

	public string[] stage_table;

	private string m_Name;

	private string m_Detail;

	private int? _Index;

	public string ID => null;

	public int Index => 0;

	public int GetLayerRandomPoint(int height)
	{
		return 0;
	}

	public void SetLayerRandomPoint(int height, int value)
	{
	}

	public bool IsTreasureTypeNormal()
	{
		return false;
	}

	public bool IsTreasureTypeDice()
	{
		return false;
	}

	public bool IsKindTreasureBox()
	{
		return false;
	}

	public bool IsKindSpring()
	{
		return false;
	}

	public bool IsKindTablet()
	{
		return false;
	}

	public bool IsKindCave()
	{
		return false;
	}

	public CMaster_EventObjectData(CMaster_EventObjectData eventObjectData)
	{
	}

	public string GetName()
	{
		return null;
	}

	public string GetDetail()
	{
		return null;
	}
}
