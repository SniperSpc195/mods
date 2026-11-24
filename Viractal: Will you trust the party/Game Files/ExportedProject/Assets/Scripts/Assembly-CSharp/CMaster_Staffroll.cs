using System.Collections.Generic;
using UnityEngine;

public class CMaster_Staffroll : ScriptableObject, IDatabase<CMaster_StaffrollData>
{
	private static IDatabase<CMaster_StaffrollData> m_Instance;

	[SerializeField]
	private CMaster_StaffrollData[] m_DataArray;

	private Dictionary<string, CMaster_StaffrollData> m_Data;

	CMaster_StaffrollData[] IDatabase<CMaster_StaffrollData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_StaffrollData> IDatabase<CMaster_StaffrollData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_StaffrollData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_StaffrollData[] GetAllData()
	{
		return null;
	}
}
