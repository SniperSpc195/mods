using System.Collections.Generic;
using UnityEngine;

public class CMaster_HexGroundType : ScriptableObject, IDatabase<CMaster_HexGroundTypeData>
{
	private static IDatabase<CMaster_HexGroundTypeData> m_Instance;

	private CMaster_HexGroundTypeData[] m_DataArray;

	private Dictionary<string, CMaster_HexGroundTypeData> m_Data;

	CMaster_HexGroundTypeData[] IDatabase<CMaster_HexGroundTypeData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_HexGroundTypeData> IDatabase<CMaster_HexGroundTypeData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_HexGroundTypeData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_HexGroundTypeData[] GetAllData()
	{
		return null;
	}
}
