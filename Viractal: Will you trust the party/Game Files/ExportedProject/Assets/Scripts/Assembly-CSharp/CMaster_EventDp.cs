using System.Collections.Generic;
using UnityEngine;

public class CMaster_EventDp : ScriptableObject, IDatabase<CMaster_EventDpData>
{
	private static IDatabase<CMaster_EventDpData> m_Instance;

	[SerializeField]
	private CMaster_EventDpData[] m_DataArray;

	private Dictionary<string, CMaster_EventDpData> m_Data;

	CMaster_EventDpData[] IDatabase<CMaster_EventDpData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EventDpData> IDatabase<CMaster_EventDpData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EventDpData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EventDpData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_EventDpData> GetDataKind(string kind, CFieldPlayer player)
	{
		return null;
	}
}
