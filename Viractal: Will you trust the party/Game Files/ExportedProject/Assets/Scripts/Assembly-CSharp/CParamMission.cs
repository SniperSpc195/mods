using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CParamMission
{
	public class Reward
	{
		public CMaster_MissionRewardData mData;

		public string mName;

		public Reward(CMaster_MissionRewardData data, string name)
		{
		}

		public Reward(JsonNode json)
		{
		}

		public Dictionary<string, object> Save()
		{
			return null;
		}

		public string GetRewardName(CMaster_MissionListData mission, bool forceOpen = false)
		{
			return null;
		}
	}

	[SerializeField]
	[ReadOnly]
	private CMaster_MissionListData mData;

	[SerializeField]
	[ReadOnly]
	private string mSortName;

	[SerializeField]
	[ReadOnly]
	private string mEnemyName;

	[SerializeField]
	[ReadOnly]
	private int mPlayerIndex;

	[SerializeField]
	[ReadOnly]
	private bool mCleard;

	private List<Reward> mReward;

	private int mAchieved;

	public int PlayerIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool Cleard
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string ID => null;

	public CParamMission(string id)
	{
	}

	public CParamMission(CMaster_MissionListData data)
	{
	}

	public CParamMission(JsonNode json)
	{
	}

	private void Initialize(CMaster_MissionListData data)
	{
	}

	private void MakeRewards()
	{
	}

	public static void Sort(List<CParamMission> list)
	{
	}

	private void MakeSortName()
	{
	}

	public CMaster_MissionListData GetData()
	{
		return null;
	}

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

	public string GetTargetIcon()
	{
		return null;
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

	public bool IsConditionKill(List<string> enemy_id)
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

	public string GetClearDetailID()
	{
		return null;
	}

	public int GetClearValue()
	{
		return 0;
	}

	public int GetAchieved()
	{
		return 0;
	}

	public void SetAchieved(int n)
	{
	}

	public bool IsClearAchieved()
	{
		return false;
	}

	public string GetName(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetNameAddType(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetDetail(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetInfoType(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public bool IsReward()
	{
		return false;
	}

	public int GetRewardCount()
	{
		return 0;
	}

	public string GetRewardName(int n, bool forceOpen = false)
	{
		return null;
	}

	public List<Reward> GetRewardList()
	{
		return null;
	}

	public int AddEnemy(string id)
	{
		return 0;
	}

	public int AddEnemy(List<string> ids)
	{
		return 0;
	}

	public int AddDelivery(string id)
	{
		return 0;
	}

	public int CheckCollect(List<CFieldPlayer> player)
	{
		return 0;
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public static bool CheckSaveData(string savefile, JsonNode json)
	{
		return false;
	}
}
