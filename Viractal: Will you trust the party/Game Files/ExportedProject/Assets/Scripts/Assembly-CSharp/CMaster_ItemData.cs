using System;
using UnityEngine;

[Serializable]
public class CMaster_ItemData : IMasterData
{
	public static readonly string GOLD_ID;

	public static readonly string SOULPOINT_ID;

	public string id;

	public string name_id;

	public string rare;

	public string icon;

	public bool use_flag;

	public bool btl_use_flag;

	public bool discard_flag;

	public bool increase_flag;

	public int price;

	public int sell;

	public int open;

	public int drop;

	public bool move_value_erase;

	public string effect;

	public string target;

	public string effect_detail;

	public string effect_detail2;

	public int value;

	public int range;

	public string action_script;

	private string m_IconRT;

	private string m_Name;

	private string m_Detail;

	private string m_EnName;

	private int? _Index;

	public string ID => null;

	public int Index => 0;

	public int GetFullHpMaxHpIncrease()
	{
		return 0;
	}

	public int GetHealDpLoss()
	{
		return 0;
	}

	public int GetHealConditionStacks()
	{
		return 0;
	}

	public int GetEnemyDamage()
	{
		return 0;
	}

	public bool IsMoveValueErase()
	{
		return false;
	}

	public bool IsAllOut()
	{
		return false;
	}

	public bool IsWater()
	{
		return false;
	}

	public string GetIconName(bool space = false)
	{
		return null;
	}

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

	public string GetDetailOverwrite(int i_Value)
	{
		return null;
	}

	private string ReplaceSecondaryEffectValue(string text)
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
}
