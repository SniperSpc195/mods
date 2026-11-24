using System.Collections.Generic;
using UnityEngine;

public class CMaster_GmFace : ScriptableObject, IDatabase<CMaster_GmFaceData>
{
	private static IDatabase<CMaster_GmFaceData> m_Instance;

	[SerializeField]
	private CMaster_GmFaceData[] m_DataArray;

	private Dictionary<string, CMaster_GmFaceData> m_Data;

	CMaster_GmFaceData[] IDatabase<CMaster_GmFaceData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_GmFaceData> IDatabase<CMaster_GmFaceData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_GmFaceData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_GmFaceData[] GetAllData()
	{
		return null;
	}

	public static string[] MakeDebugAllList()
	{
		return null;
	}
}
