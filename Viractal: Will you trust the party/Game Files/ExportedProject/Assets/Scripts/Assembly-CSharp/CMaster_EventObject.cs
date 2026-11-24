using System.Collections.Generic;
using UnityEngine;

public class CMaster_EventObject : ScriptableObject, IDatabase<CMaster_EventObjectData>
{
	private static IDatabase<CMaster_EventObjectData> m_Instance;

	[SerializeField]
	private CMaster_EventObjectData[] m_DataArray;

	private Dictionary<string, CMaster_EventObjectData> m_Data;

	CMaster_EventObjectData[] IDatabase<CMaster_EventObjectData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EventObjectData> IDatabase<CMaster_EventObjectData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EventObjectData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EventObjectData[] GetAllData()
	{
		return null;
	}

	public static int Index(string i_ID)
	{
		return 0;
	}
}
