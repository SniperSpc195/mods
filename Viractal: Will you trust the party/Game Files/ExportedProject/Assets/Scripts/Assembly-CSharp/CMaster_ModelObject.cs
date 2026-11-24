using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CMaster_ModelObject : ScriptableObject, IDatabase<CMaster_ModelData>
{
	private static IDatabase<CMaster_ModelData> m_Instance;

	[SerializeField]
	private CMaster_ModelData[] m_DataArray;

	private Dictionary<string, CMaster_ModelData> m_Data;

	CMaster_ModelData[] IDatabase<CMaster_ModelData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_ModelData> IDatabase<CMaster_ModelData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_ModelData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_ModelData[] GetAllData()
	{
		return null;
	}
}
