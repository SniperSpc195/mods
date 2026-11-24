using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CMaster_SkillConditionData : IMasterData
{
	public string id;

	public string icon;

	public string kind;

	public string effect;

	public string effect_detail;

	public int effect_value;

	public int turn;

	public string duplicate;

	public bool death_release;

	public bool random_get;

	public static string DupTypeNo;

	public static string DupTypeStack;

	public static string DupTypeMulti;

	private CMaster_ConditionEffectData _ConditionEffectData;

	private string m_Name;

	private string m_Detail;

	private string m_IconRT;

	public string ID => null;

	public string Name => null;

	public CMaster_ConditionEffectData ConditionEffectData => null;

	public string GetName()
	{
		return null;
	}

	public string GetIconRT()
	{
		return null;
	}

	public string GetIconString()
	{
		return null;
	}

	public Sprite GetLargeIcon()
	{
		return null;
	}

	public string GetDetail()
	{
		return null;
	}

	public bool IsStackType()
	{
		return false;
	}

	public bool IsMultiType()
	{
		return false;
	}

	public bool IsNoDuplicateType()
	{
		return false;
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
}
