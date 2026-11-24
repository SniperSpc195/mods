using System;
using System.Collections.Generic;

[Serializable]
public class CMaster_SkillAbilityData : IMasterData
{
	public string id;

	public string icon;

	public int drop;

	public string genre;

	public string kind;

	public string effect;

	public string[] effect_detail_table;

	public int[] value_table;

	private string m_Name;

	private string m_StreetName;

	private string m_Detail;

	private string m_ColorString;

	public string ID => null;

	public string GetName()
	{
		return null;
	}

	public string GetStreetName()
	{
		return null;
	}

	public string GetDetail()
	{
		return null;
	}

	public string GetBaseColorString()
	{
		return null;
	}

	private string ReplaceConditionTag(string i_Text)
	{
		return null;
	}

	private string ReplaceWillTag(string i_Text)
	{
		return null;
	}

	public bool IsNeedExplanationCondition()
	{
		return false;
	}

	public List<CMaster_SkillConditionData> GetConditions()
	{
		return null;
	}

	public bool IsChoiceALL()
	{
		return false;
	}

	public void Copy(ref CMaster_SkillAbilityData dest)
	{
	}
}
