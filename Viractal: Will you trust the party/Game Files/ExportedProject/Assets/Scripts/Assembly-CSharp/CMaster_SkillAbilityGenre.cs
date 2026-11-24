using System.Collections.Generic;
using UnityEngine;

public class CMaster_SkillAbilityGenre : ScriptableObject, IDatabase<CMaster_SkillAbilityGenreData>
{
	private static IDatabase<CMaster_SkillAbilityGenreData> m_Instance;

	[SerializeField]
	private CMaster_SkillAbilityGenreData[] m_DataArray;

	private Dictionary<string, CMaster_SkillAbilityGenreData> m_Data;

	CMaster_SkillAbilityGenreData[] IDatabase<CMaster_SkillAbilityGenreData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_SkillAbilityGenreData> IDatabase<CMaster_SkillAbilityGenreData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_SkillAbilityGenreData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_SkillAbilityGenreData[] GetAllData()
	{
		return null;
	}
}
