using System.Collections.Generic;
using UnityEngine;

public class CMaster_MissionList : ScriptableObject, IDatabase<CMaster_MissionListData>
{
	private static IDatabase<CMaster_MissionListData> m_Instance;

	[SerializeField]
	private CMaster_MissionListData[] m_DataArray;

	private Dictionary<string, CMaster_MissionListData> m_Data;

	CMaster_MissionListData[] IDatabase<CMaster_MissionListData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MissionListData> IDatabase<CMaster_MissionListData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MissionListData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MissionListData[] GetAllData()
	{
		return null;
	}

	public static string GetName(string id, CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public static string GetDetail(string id, CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}
}
