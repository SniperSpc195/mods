using System.Collections.Generic;
using UnityEngine;

public class CMaster_ConstDefine : ScriptableObject, IDatabase<CMaster_ConstDefineData>
{
	private static IDatabase<CMaster_ConstDefineData> m_Instance;

	[SerializeField]
	private CMaster_ConstDefineData[] m_DataArray;

	private Dictionary<string, CMaster_ConstDefineData> m_Data;

	CMaster_ConstDefineData[] IDatabase<CMaster_ConstDefineData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_ConstDefineData> IDatabase<CMaster_ConstDefineData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static int GetValue(string i_ID)
	{
		return 0;
	}

	public static float GetFloat(string i_ID, float i_DefaulValue = 0f)
	{
		return 0f;
	}

	public static string GetString(string i_ID, string i_DefaultValue = null)
	{
		return null;
	}

	public static CMaster_ConstDefineData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_ConstDefineData[] GetAllData()
	{
		return null;
	}
}
