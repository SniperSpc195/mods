using System.Collections.Generic;
using UnityEngine;

public class CMaster_Achievement : ScriptableObject, IDatabase<CMaster_AchievementData>
{
	private static IDatabase<CMaster_AchievementData> m_Instance;

	[SerializeField]
	private CMaster_AchievementData[] m_DataArray;

	private Dictionary<string, CMaster_AchievementData> m_Data;

	CMaster_AchievementData[] IDatabase<CMaster_AchievementData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_AchievementData> IDatabase<CMaster_AchievementData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_AchievementData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_AchievementData[] GetAllData()
	{
		return null;
	}
}
