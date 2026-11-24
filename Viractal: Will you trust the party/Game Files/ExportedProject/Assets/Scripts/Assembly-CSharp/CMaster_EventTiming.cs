using System.Collections.Generic;
using UnityEngine;

public class CMaster_EventTiming : ScriptableObject, IDatabase<CMaster_EventTimingData>
{
	private static IDatabase<CMaster_EventTimingData> m_Instance;

	[SerializeField]
	private CMaster_EventTimingData[] m_DataArray;

	private Dictionary<string, CMaster_EventTimingData> m_Data;

	CMaster_EventTimingData[] IDatabase<CMaster_EventTimingData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EventTimingData> IDatabase<CMaster_EventTimingData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EventTimingData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EventTimingData[] GetAllData()
	{
		return null;
	}
}
