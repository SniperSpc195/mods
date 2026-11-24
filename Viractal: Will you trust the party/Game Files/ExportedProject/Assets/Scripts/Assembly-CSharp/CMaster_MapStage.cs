using System.Collections.Generic;
using UnityEngine;

public class CMaster_MapStage : ScriptableObject, IDatabase<CMaster_MapStageData>
{
	private static IDatabase<CMaster_MapStageData> m_Instance;

	[SerializeField]
	private CMaster_MapStageData[] m_DataArray;

	private Dictionary<string, CMaster_MapStageData> m_Data;

	CMaster_MapStageData[] IDatabase<CMaster_MapStageData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MapStageData> IDatabase<CMaster_MapStageData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MapStageData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MapStageData[] GetAllData()
	{
		return null;
	}

	public static int Index(string i_ID)
	{
		return 0;
	}
}
