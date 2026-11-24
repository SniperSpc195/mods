using System.Collections.Generic;
using UnityEngine;

public class CMaster_MissionList_Text : ScriptableObject, IDatabase<CMaster_MissionList_TextData>
{
	private static IDatabase<CMaster_MissionList_TextData> m_Instance;

	[SerializeField]
	private CMaster_MissionList_TextData[] m_DataArray;

	private Dictionary<string, CMaster_MissionList_TextData> m_Data;

	CMaster_MissionList_TextData[] IDatabase<CMaster_MissionList_TextData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MissionList_TextData> IDatabase<CMaster_MissionList_TextData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MissionList_TextData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MissionList_TextData[] GetAllData()
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
