using System.Collections.Generic;
using UnityEngine;

public class CMaster_MissionReward : ScriptableObject, IDatabase<CMaster_MissionRewardData>
{
	private static IDatabase<CMaster_MissionRewardData> m_Instance;

	[SerializeField]
	private CMaster_MissionRewardData[] m_DataArray;

	private Dictionary<string, CMaster_MissionRewardData> m_Data;

	CMaster_MissionRewardData[] IDatabase<CMaster_MissionRewardData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MissionRewardData> IDatabase<CMaster_MissionRewardData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MissionRewardData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MissionRewardData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_MissionRewardData> GetRewardList(string table_id)
	{
		return null;
	}
}
