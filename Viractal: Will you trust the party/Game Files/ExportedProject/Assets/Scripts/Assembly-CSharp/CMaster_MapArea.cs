using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapArea : ScriptableObject, IDatabase<CMaster_MapAreaData>
{
	private static IDatabase<CMaster_MapAreaData> m_Instance;

	[SerializeField]
	private CMaster_MapAreaData[] m_DataArray;

	private Dictionary<string, CMaster_MapAreaData> m_Data;

	CMaster_MapAreaData[] IDatabase<CMaster_MapAreaData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapAreaData> IDatabase<CMaster_MapAreaData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapAreaData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapAreaData[] GetAllData()
	{
		return null;
	}
}
