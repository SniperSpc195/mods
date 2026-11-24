using System.Collections.Generic;
using UnityEngine;

public class CMaster_ConditionEffect : ScriptableObject, IDatabase<CMaster_ConditionEffectData>
{
	private static IDatabase<CMaster_ConditionEffectData> m_Instance;

	[SerializeField]
	private CMaster_ConditionEffectData[] m_DataArray;

	private Dictionary<string, CMaster_ConditionEffectData> m_Data;

	CMaster_ConditionEffectData[] IDatabase<CMaster_ConditionEffectData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_ConditionEffectData> IDatabase<CMaster_ConditionEffectData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_ConditionEffectData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_ConditionEffectData[] GetAllData()
	{
		return null;
	}
}
