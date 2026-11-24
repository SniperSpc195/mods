using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapBattle : ScriptableObject, IDatabase<CMaster_MapBattleData>
{
	private static IDatabase<CMaster_MapBattleData> m_Instance;

	[SerializeField]
	private CMaster_MapBattleData[] m_DataArray;

	private Dictionary<string, CMaster_MapBattleData> m_Data;

	CMaster_MapBattleData[] IDatabase<CMaster_MapBattleData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapBattleData> IDatabase<CMaster_MapBattleData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapBattleData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapBattleData[] GetAllData()
	{
		return null;
	}
}
