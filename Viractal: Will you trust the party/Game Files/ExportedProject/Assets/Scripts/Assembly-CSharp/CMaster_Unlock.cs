using System.Collections.Generic;
using UnityEngine;

public class CMaster_Unlock : ScriptableObject, IDatabase<CMaster_UnlockData>
{
	private static IDatabase<CMaster_UnlockData> m_Instance;

	[SerializeField]
	private CMaster_UnlockData[] m_DataArray;

	private Dictionary<string, CMaster_UnlockData> m_Data;

	CMaster_UnlockData[] IDatabase<CMaster_UnlockData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_UnlockData> IDatabase<CMaster_UnlockData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_UnlockData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_UnlockData GetDataBySetId(string setId)
	{
		return null;
	}

	public static CMaster_UnlockData[] GetAllData()
	{
		return null;
	}

	public static int Index(string id)
	{
		return 0;
	}
}
