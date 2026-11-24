using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapAreaShape : ScriptableObject, IDatabase<CMaster_MapAreaShapeData>
{
	private static IDatabase<CMaster_MapAreaShapeData> m_Instance;

	private CMaster_MapAreaShapeData[] m_DataArray;

	private Dictionary<string, CMaster_MapAreaShapeData> m_Data;

	CMaster_MapAreaShapeData[] IDatabase<CMaster_MapAreaShapeData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapAreaShapeData> IDatabase<CMaster_MapAreaShapeData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapAreaShapeData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapAreaShapeData[] GetAllData()
	{
		return null;
	}
}
