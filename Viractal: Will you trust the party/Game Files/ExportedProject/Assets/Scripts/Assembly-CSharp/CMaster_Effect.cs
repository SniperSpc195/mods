using System.Collections.Generic;
using UnityEngine;

public class CMaster_Effect : ScriptableObject, IDatabase<CMaster_EffectData>
{
	private static IDatabase<CMaster_EffectData> m_Instance;

	[SerializeField]
	private CMaster_EffectData[] m_DataArray;

	private Dictionary<string, CMaster_EffectData> m_Data;

	CMaster_EffectData[] IDatabase<CMaster_EffectData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EffectData> IDatabase<CMaster_EffectData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EffectData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EffectData[] GetAllData()
	{
		return null;
	}
}
