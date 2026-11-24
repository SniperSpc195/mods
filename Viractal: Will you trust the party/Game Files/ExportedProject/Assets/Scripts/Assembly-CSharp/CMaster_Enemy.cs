using System.Collections.Generic;
using UnityEngine;

public class CMaster_Enemy : ScriptableObject, IDatabase<CMaster_EnemyData>
{
	private static IDatabase<CMaster_EnemyData> m_Instance;

	[SerializeField]
	private CMaster_EnemyData[] m_DataArray;

	private Dictionary<string, CMaster_EnemyData> m_Data;

	CMaster_EnemyData[] IDatabase<CMaster_EnemyData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EnemyData> IDatabase<CMaster_EnemyData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EnemyData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EnemyData[] GetAllData()
	{
		return null;
	}
}
