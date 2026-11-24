using System;

[Serializable]
public class CMaster_MissionListData : IMasterData
{
	public string id;

	public string type;

	public string management;

	public string get_reward;

	public bool clear_direction;

	public string if_clear;

	public string clear_detail;

	public int clear_value;

	public bool reward_open;

	public string[] reward_table;

	public string script;

	public string text;

	private CMaster_MissionList_TextData m_MissionText;

	public string ID => null;

	public bool IsMain()
	{
		return false;
	}

	public bool IsSub()
	{
		return false;
	}

	public bool IsTargetAll()
	{
		return false;
	}

	public bool IsTargetSingle()
	{
		return false;
	}

	public bool IsRewardAll()
	{
		return false;
	}

	public bool IsRewardSelect()
	{
		return false;
	}

	public bool IsRewardSingle()
	{
		return false;
	}

	public bool IsConditionHex()
	{
		return false;
	}

	public bool IsConditionKill()
	{
		return false;
	}

	public bool IsConditionDelivery()
	{
		return false;
	}

	public bool IsConditionDelivery(string id)
	{
		return false;
	}

	public bool IsConditionCollect()
	{
		return false;
	}

	public bool IsConditionCollect(string id)
	{
		return false;
	}

	public bool IsConditionFlag()
	{
		return false;
	}

	public bool IsConditionWork()
	{
		return false;
	}

	public string GetName(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetDetail(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}
}
