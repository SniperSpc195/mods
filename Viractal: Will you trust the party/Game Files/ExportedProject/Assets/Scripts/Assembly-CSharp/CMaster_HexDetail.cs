using System.Collections.Generic;
using UnityEngine;

public class CMaster_HexDetail : ScriptableObject, IDatabase<CMaster_HexDetailData>
{
	private static IDatabase<CMaster_HexDetailData> m_Instance;

	[SerializeField]
	private CMaster_HexDetailData[] m_DataArray;

	private Dictionary<string, CMaster_HexDetailData> m_Data;

	CMaster_HexDetailData[] IDatabase<CMaster_HexDetailData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_HexDetailData> IDatabase<CMaster_HexDetailData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_HexDetailData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_HexDetailData[] GetAllData()
	{
		return null;
	}

	public static CMaster_HexDetailData GetDataFromGroundType(string groundType, int mapIndex)
	{
		return null;
	}
}
