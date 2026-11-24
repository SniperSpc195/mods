using System;
using System.Collections.Generic;
using UnityEngine;

public class CMaster_SkillAbility : ScriptableObject, IDatabase<CMaster_SkillAbilityData>
{
	private static IDatabase<CMaster_SkillAbilityData> m_Instance;

	[SerializeField]
	private CMaster_SkillAbilityData[] m_DataArray;

	private Dictionary<string, CMaster_SkillAbilityData> m_Data;

	CMaster_SkillAbilityData[] IDatabase<CMaster_SkillAbilityData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_SkillAbilityData> IDatabase<CMaster_SkillAbilityData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_SkillAbilityData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_SkillAbilityData GetData(ReadOnlySpan<char> i_ID)
	{
		return null;
	}

	public static CMaster_SkillAbilityData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_SkillAbilityData> GetGenre(string genre)
	{
		return null;
	}
}
