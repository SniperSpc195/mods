using System;
using System.Collections.Generic;
using UnityEngine;

public class CMaster_SkillCondition : ScriptableObject, IDatabase<CMaster_SkillConditionData>
{
	private static IDatabase<CMaster_SkillConditionData> m_Instance;

	[SerializeField]
	private CMaster_SkillConditionData[] m_DataArray;

	private Dictionary<string, CMaster_SkillConditionData> m_Data;

	CMaster_SkillConditionData[] IDatabase<CMaster_SkillConditionData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_SkillConditionData> IDatabase<CMaster_SkillConditionData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_SkillConditionData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_SkillConditionData GetData(ReadOnlySpan<char> i_ID)
	{
		return null;
	}

	public static CMaster_SkillConditionData[] GetAllData()
	{
		return null;
	}
}
