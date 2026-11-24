using System.Collections.Generic;
using UnityEngine;

public class CMaster_Shelf : ScriptableObject, IDatabase<CMaster_ShelfData>
{
	private static IDatabase<CMaster_ShelfData> m_Instance;

	[SerializeField]
	private CMaster_ShelfData[] m_DataArray;

	private Dictionary<string, CMaster_ShelfData> m_Data;

	CMaster_ShelfData[] IDatabase<CMaster_ShelfData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_ShelfData> IDatabase<CMaster_ShelfData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_ShelfData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_ShelfData GetDataToModelID(string i_ModelID)
	{
		return null;
	}

	public static CMaster_ShelfData[] GetAllData()
	{
		return null;
	}
}
