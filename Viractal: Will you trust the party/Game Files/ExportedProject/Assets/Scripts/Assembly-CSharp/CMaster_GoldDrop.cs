using System.Collections.Generic;
using UnityEngine;

public class CMaster_GoldDrop : ScriptableObject, IDatabase<CMaster_GoldDropData>
{
	private static IDatabase<CMaster_GoldDropData> m_Instance;

	[SerializeField]
	private CMaster_GoldDropData[] m_DataArray;

	private Dictionary<string, CMaster_GoldDropData> m_Data;

	private static Dictionary<string, List<CMaster_GoldDropData>> m_DicTableList;

	CMaster_GoldDropData[] IDatabase<CMaster_GoldDropData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_GoldDropData> IDatabase<CMaster_GoldDropData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_GoldDropData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_GoldDropData[] GetAllData()
	{
		return null;
	}

	public static CMaster_GoldDropData GetData(int i_DropRank)
	{
		return null;
	}
}
