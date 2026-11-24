using System.Collections.Generic;
using UnityEngine;

public class CMaster_CharJob : ScriptableObject, IDatabase<CMaster_CharJobData>
{
	private static IDatabase<CMaster_CharJobData> m_Instance;

	[SerializeField]
	private CMaster_CharJobData[] m_DataArray;

	private Dictionary<string, CMaster_CharJobData> m_Data;

	CMaster_CharJobData[] IDatabase<CMaster_CharJobData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_CharJobData> IDatabase<CMaster_CharJobData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_CharJobData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_CharJobData[] GetAllData()
	{
		return null;
	}

	public static int GetDataIndex(string jobID)
	{
		return 0;
	}
}
