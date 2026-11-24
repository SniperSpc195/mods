using System.Collections.Generic;
using UnityEngine;

public class CMaster_ConstWord : ScriptableObject, IDatabase<CMaster_ConstWordData>
{
	private static IDatabase<CMaster_ConstWordData> m_Instance;

	[SerializeField]
	private CMaster_ConstWordData[] m_DataArray;

	private Dictionary<string, CMaster_ConstWordData> m_Data;

	CMaster_ConstWordData[] IDatabase<CMaster_ConstWordData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_ConstWordData> IDatabase<CMaster_ConstWordData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static string GetString(string i_ID)
	{
		return null;
	}

	public static CMaster_ConstWordData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_ConstWordData[] GetAllData()
	{
		return null;
	}
}
