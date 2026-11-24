using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapTown : ScriptableObject, IDatabase<CMaster_MapTownData>
{
	private static IDatabase<CMaster_MapTownData> m_Instance;

	[SerializeField]
	private CMaster_MapTownData[] m_DataArray;

	private Dictionary<string, CMaster_MapTownData> m_Data;

	CMaster_MapTownData[] IDatabase<CMaster_MapTownData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapTownData> IDatabase<CMaster_MapTownData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapTownData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapTownData[] GetAllData()
	{
		return null;
	}
}
