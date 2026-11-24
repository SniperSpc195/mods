using System.Collections.Generic;
using UnityEngine;

public class CMaster_TreasureBox : ScriptableObject, IDatabase<CMaster_TreasureBoxData>
{
	private static IDatabase<CMaster_TreasureBoxData> m_Instance;

	[SerializeField]
	private CMaster_TreasureBoxData[] m_DataArray;

	private Dictionary<string, CMaster_TreasureBoxData> m_Data;

	CMaster_TreasureBoxData[] IDatabase<CMaster_TreasureBoxData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_TreasureBoxData> IDatabase<CMaster_TreasureBoxData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_TreasureBoxData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_TreasureBoxData[] GetAllData()
	{
		return null;
	}
}
