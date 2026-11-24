using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapAreaShapeTable : ScriptableObject, IDatabase<CMaster_MapAreaShapeTableData>
{
	private static IDatabase<CMaster_MapAreaShapeTableData> m_Instance;

	private CMaster_MapAreaShapeTableData[] m_DataArray;

	private Dictionary<string, CMaster_MapAreaShapeTableData> m_Data;

	CMaster_MapAreaShapeTableData[] IDatabase<CMaster_MapAreaShapeTableData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapAreaShapeTableData> IDatabase<CMaster_MapAreaShapeTableData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapAreaShapeTableData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapAreaShapeTableData[] GetAllData()
	{
		return null;
	}
}
