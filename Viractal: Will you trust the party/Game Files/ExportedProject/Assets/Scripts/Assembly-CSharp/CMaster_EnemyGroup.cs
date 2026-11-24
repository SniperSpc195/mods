using System.Collections.Generic;
using UnityEngine;

public class CMaster_EnemyGroup : ScriptableObject, IDatabase<CMaster_EnemyGroupData>
{
	private static IDatabase<CMaster_EnemyGroupData> m_Instance;

	[SerializeField]
	private CMaster_EnemyGroupData[] m_DataArray;

	private Dictionary<string, CMaster_EnemyGroupData> m_Data;

	CMaster_EnemyGroupData[] IDatabase<CMaster_EnemyGroupData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EnemyGroupData> IDatabase<CMaster_EnemyGroupData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EnemyGroupData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EnemyGroupData[] GetAllData()
	{
		return null;
	}

	public static string[] GetIDs()
	{
		return null;
	}
}
