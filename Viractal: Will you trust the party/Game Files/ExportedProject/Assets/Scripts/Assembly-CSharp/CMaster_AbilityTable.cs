using System.Collections.Generic;
using UnityEngine;

public class CMaster_AbilityTable : ScriptableObject, IDatabase<CMaster_AbilityTableData>
{
	private static IDatabase<CMaster_AbilityTableData> m_Instance;

	[SerializeField]
	private CMaster_AbilityTableData[] m_DataArray;

	private Dictionary<string, CMaster_AbilityTableData> m_Data;

	CMaster_AbilityTableData[] IDatabase<CMaster_AbilityTableData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_AbilityTableData> IDatabase<CMaster_AbilityTableData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_AbilityTableData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_AbilityTableData[] GetAllData()
	{
		return null;
	}

	public static CMaster_SkillAbilityData Lottery(string i_ID, int random)
	{
		return null;
	}
}
