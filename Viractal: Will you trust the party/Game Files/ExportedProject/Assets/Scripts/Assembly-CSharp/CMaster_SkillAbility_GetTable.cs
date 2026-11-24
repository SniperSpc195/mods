using System.Collections.Generic;
using UnityEngine;

public class CMaster_SkillAbility_GetTable : ScriptableObject, IDatabase<CMaster_SkillAbility_GetTableData>
{
	private static IDatabase<CMaster_SkillAbility_GetTableData> m_Instance;

	[SerializeField]
	private CMaster_SkillAbility_GetTableData[] m_DataArray;

	private Dictionary<string, CMaster_SkillAbility_GetTableData> m_Data;

	CMaster_SkillAbility_GetTableData[] IDatabase<CMaster_SkillAbility_GetTableData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_SkillAbility_GetTableData> IDatabase<CMaster_SkillAbility_GetTableData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_SkillAbility_GetTableData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_SkillAbility_GetTableData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_SkillAbility_GetTableData> GetTable(string table_id, CParamPlayer param = null, List<CMaster_SkillAbility_GetTableData> possession = null)
	{
		return null;
	}

	public static string Lottely(string table_id, UtpnRandom rnd, CParamPlayer param)
	{
		return null;
	}

	public static void Lottely(ref List<CMaster_SkillAbility_GetTableData> list, ref List<string> output, UtpnRandom rnd, CParamPlayer param)
	{
	}

	public static void RemoveDuplicates(ref List<List<CMaster_SkillAbility_GetTableData>> list)
	{
	}
}
