using System.Collections.Generic;
using UnityEngine;

public class CMaster_CharMotion : ScriptableObject, IDatabase<CMaster_CharMotionData>
{
	private static IDatabase<CMaster_CharMotionData> m_Instance;

	[SerializeField]
	private CMaster_CharMotionData[] m_DataArray;

	private Dictionary<string, CMaster_CharMotionData> m_Data;

	CMaster_CharMotionData[] IDatabase<CMaster_CharMotionData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_CharMotionData> IDatabase<CMaster_CharMotionData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_CharMotionData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_CharMotionData[] GetAllData()
	{
		return null;
	}
}
