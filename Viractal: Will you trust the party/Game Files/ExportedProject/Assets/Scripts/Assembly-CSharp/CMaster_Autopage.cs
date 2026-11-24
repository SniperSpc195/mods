using System.Collections.Generic;
using UnityEngine;

public class CMaster_Autopage : ScriptableObject, IDatabase<CMaster_AutopageData>
{
	private static IDatabase<CMaster_AutopageData> m_Instance;

	[SerializeField]
	private CMaster_AutopageData[] m_DataArray;

	private Dictionary<string, CMaster_AutopageData> m_Data;

	CMaster_AutopageData[] IDatabase<CMaster_AutopageData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_AutopageData> IDatabase<CMaster_AutopageData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_AutopageData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_AutopageData[] GetAllData()
	{
		return null;
	}
}
