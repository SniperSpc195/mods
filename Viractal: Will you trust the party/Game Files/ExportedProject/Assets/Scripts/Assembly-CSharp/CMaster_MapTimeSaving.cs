using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapTimeSaving : ScriptableObject, IDatabase<CMaster_MapTimeSavingData>
{
	private static IDatabase<CMaster_MapTimeSavingData> m_Instance;

	[SerializeField]
	private CMaster_MapTimeSavingData[] m_DataArray;

	private Dictionary<string, CMaster_MapTimeSavingData> m_Data;

	CMaster_MapTimeSavingData[] IDatabase<CMaster_MapTimeSavingData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapTimeSavingData> IDatabase<CMaster_MapTimeSavingData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapTimeSavingData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapTimeSavingData[] GetAllData()
	{
		return null;
	}
}
