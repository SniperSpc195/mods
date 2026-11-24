using System.Collections.Generic;
using UnityEngine;

public class CMaster_DevilsContract : ScriptableObject, IDatabase<CMaster_DevilsContractData>
{
	private static IDatabase<CMaster_DevilsContractData> m_Instance;

	[SerializeField]
	private CMaster_DevilsContractData[] m_DataArray;

	private Dictionary<string, CMaster_DevilsContractData> m_Data;

	CMaster_DevilsContractData[] IDatabase<CMaster_DevilsContractData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_DevilsContractData> IDatabase<CMaster_DevilsContractData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_DevilsContractData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_DevilsContractData[] GetAllData()
	{
		return null;
	}

	public static bool IsCheckID(string id)
	{
		return false;
	}

	public static List<CMaster_DevilsContractData> GetLevel(int lv, UtpnRandom rnd = null)
	{
		return null;
	}
}
