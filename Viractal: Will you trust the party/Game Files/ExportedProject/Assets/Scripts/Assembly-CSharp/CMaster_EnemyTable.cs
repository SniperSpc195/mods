using System.Collections.Generic;
using UnityEngine;

public class CMaster_EnemyTable : ScriptableObject, IDatabase<CMaster_EnemyTableData>
{
	private static IDatabase<CMaster_EnemyTableData> m_Instance;

	[SerializeField]
	private CMaster_EnemyTableData[] m_DataArray;

	private Dictionary<string, CMaster_EnemyTableData> m_Data;

	CMaster_EnemyTableData[] IDatabase<CMaster_EnemyTableData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EnemyTableData> IDatabase<CMaster_EnemyTableData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EnemyTableData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EnemyTableData[] GetAllData()
	{
		return null;
	}

	public static string[] GetIDs()
	{
		return null;
	}
}
