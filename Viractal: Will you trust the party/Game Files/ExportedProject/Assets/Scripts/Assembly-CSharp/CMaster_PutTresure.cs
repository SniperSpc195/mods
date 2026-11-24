using System.Collections.Generic;
using UnityEngine;

public class CMaster_PutTresure : ScriptableObject, IDatabase<CMaster_PutTresureData>
{
	private static IDatabase<CMaster_PutTresureData> m_Instance;

	[SerializeField]
	private CMaster_PutTresureData[] m_DataArray;

	private Dictionary<string, CMaster_PutTresureData> m_Data;

	CMaster_PutTresureData[] IDatabase<CMaster_PutTresureData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_PutTresureData> IDatabase<CMaster_PutTresureData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_PutTresureData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_PutTresureData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_PutTresureData> GetStage(string stage)
	{
		return null;
	}
}
