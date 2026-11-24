using System.Collections.Generic;
using UnityEngine;

public class CMaster_PutEnemy : ScriptableObject, IDatabase<CMaster_PutEnemyData>
{
	private static IDatabase<CMaster_PutEnemyData> m_Instance;

	[SerializeField]
	private CMaster_PutEnemyData[] m_DataArray;

	private Dictionary<string, CMaster_PutEnemyData> m_Data;

	CMaster_PutEnemyData[] IDatabase<CMaster_PutEnemyData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_PutEnemyData> IDatabase<CMaster_PutEnemyData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_PutEnemyData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_PutEnemyData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_PutEnemyData> GetStage(string stage)
	{
		return null;
	}
}
