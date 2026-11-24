using System.Collections.Generic;
using UnityEngine;

public class CMaster_DevilsEffect : ScriptableObject, IDatabase<CMaster_DevilsEffectData>
{
	private static IDatabase<CMaster_DevilsEffectData> m_Instance;

	[SerializeField]
	private CMaster_DevilsEffectData[] m_DataArray;

	private Dictionary<string, CMaster_DevilsEffectData> m_Data;

	CMaster_DevilsEffectData[] IDatabase<CMaster_DevilsEffectData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_DevilsEffectData> IDatabase<CMaster_DevilsEffectData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_DevilsEffectData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_DevilsEffectData[] GetAllData()
	{
		return null;
	}
}
