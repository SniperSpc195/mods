using System.Collections.Generic;
using UnityEngine;

public class CMaster_EnemyBossRush : ScriptableObject, IDatabase<CMaster_EnemyBossRushData>
{
	private static IDatabase<CMaster_EnemyBossRushData> m_Instance;

	[SerializeField]
	private CMaster_EnemyBossRushData[] m_DataArray;

	private Dictionary<string, CMaster_EnemyBossRushData> m_Data;

	CMaster_EnemyBossRushData[] IDatabase<CMaster_EnemyBossRushData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EnemyBossRushData> IDatabase<CMaster_EnemyBossRushData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EnemyBossRushData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EnemyBossRushData[] GetAllData()
	{
		return null;
	}

	public static string[] GetIDs()
	{
		return null;
	}
}
