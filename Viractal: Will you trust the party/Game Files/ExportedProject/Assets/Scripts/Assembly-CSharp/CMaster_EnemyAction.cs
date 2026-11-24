using System.Collections.Generic;
using UnityEngine;

public class CMaster_EnemyAction : ScriptableObject, IDatabase<CMaster_EnemyActionData>
{
	private static IDatabase<CMaster_EnemyActionData> m_Instance;

	[SerializeField]
	private CMaster_EnemyActionData[] m_DataArray;

	private Dictionary<string, CMaster_EnemyActionData> m_Data;

	CMaster_EnemyActionData[] IDatabase<CMaster_EnemyActionData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EnemyActionData> IDatabase<CMaster_EnemyActionData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EnemyActionData GetData(string i_ID)
	{
		return null;
	}

	public static List<CMaster_EnemyActionData> GetSameActionData(string i_ActionID)
	{
		return null;
	}

	public static CMaster_EnemyActionData[] GetAllData()
	{
		return null;
	}
}
