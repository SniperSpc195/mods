using System.Collections.Generic;
using UnityEngine;

public class CMaster_EventList : ScriptableObject, IDatabase<CMaster_EventListData>
{
	private static IDatabase<CMaster_EventListData> m_Instance;

	[SerializeField]
	private CMaster_EventListData[] m_DataArray;

	private Dictionary<string, CMaster_EventListData> m_Data;

	CMaster_EventListData[] IDatabase<CMaster_EventListData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EventListData> IDatabase<CMaster_EventListData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EventListData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EventListData[] GetAllData()
	{
		return null;
	}

	private static bool IsCheckRead(CMaster_EventListData data, List<string> alreadyRead)
	{
		return false;
	}

	public static List<EventBase_Activation> Get_ToHex(string hexName, List<string> alreadyRead)
	{
		return null;
	}
}
