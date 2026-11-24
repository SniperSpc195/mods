using System.Collections.Generic;
using UnityEngine;

public class CMaster_TreasureTable : ScriptableObject, IDatabase<CMaster_TreasureTableData>
{
	private static IDatabase<CMaster_TreasureTableData> m_Instance;

	[SerializeField]
	private CMaster_TreasureTableData[] m_DataArray;

	private Dictionary<string, CMaster_TreasureTableData> m_Data;

	CMaster_TreasureTableData[] IDatabase<CMaster_TreasureTableData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_TreasureTableData> IDatabase<CMaster_TreasureTableData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_TreasureTableData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_TreasureTableData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_TreasureTableData> GetTable(string tbl_id)
	{
		return null;
	}

	public static List<CMaster_TreasureTableData> GetTable(string tbl_id, string kind, string rare)
	{
		return null;
	}

	public static string Lottery(CFieldPlayer player, UtpnRandom rnd, string tbl_id, string kind, string rare)
	{
		return null;
	}
}
