using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapAreaTable : ScriptableObject, IDatabase<CMaster_MapAreaTableData>
{
	private static IDatabase<CMaster_MapAreaTableData> m_Instance;

	private CMaster_MapAreaTableData[] m_DataArray;

	private Dictionary<string, CMaster_MapAreaTableData> m_Data;

	CMaster_MapAreaTableData[] IDatabase<CMaster_MapAreaTableData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapAreaTableData> IDatabase<CMaster_MapAreaTableData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapAreaTableData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapAreaTableData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_MapAreaData> GetMapArea(string table_id)
	{
		return null;
	}
}
