using System.Collections.Generic;
using UnityEngine;

public class CMaster_CharLevel : ScriptableObject, IDatabase<CMaster_CharLevelData>
{
	private static IDatabase<CMaster_CharLevelData> m_Instance;

	[SerializeField]
	private CMaster_CharLevelData[] m_DataArray;

	private Dictionary<string, CMaster_CharLevelData> m_Data;

	CMaster_CharLevelData[] IDatabase<CMaster_CharLevelData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_CharLevelData> IDatabase<CMaster_CharLevelData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_CharLevelData GetData(int lv)
	{
		return null;
	}

	public static CMaster_CharLevelData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_CharLevelData[] GetAllData()
	{
		return null;
	}
}
