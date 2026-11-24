using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapLight : ScriptableObject, IDatabase<CMaster_MapLightData>
{
	private static IDatabase<CMaster_MapLightData> m_Instance;

	[SerializeField]
	private CMaster_MapLightData[] m_DataArray;

	private Dictionary<string, CMaster_MapLightData> m_Data;

	CMaster_MapLightData[] IDatabase<CMaster_MapLightData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapLightData> IDatabase<CMaster_MapLightData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapLightData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapLightData[] GetAllData()
	{
		return null;
	}

	public static CMaster_MapLightData GetStageData(string stageID)
	{
		return null;
	}
}
