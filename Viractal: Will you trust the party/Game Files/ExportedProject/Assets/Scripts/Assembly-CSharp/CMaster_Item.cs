using System;
using System.Collections.Generic;
using UnityEngine;

public class CMaster_Item : ScriptableObject, IDatabase<CMaster_ItemData>
{
	private static IDatabase<CMaster_ItemData> m_Instance;

	[SerializeField]
	private CMaster_ItemData[] m_DataArray;

	private Dictionary<string, CMaster_ItemData> m_Data;

	CMaster_ItemData[] IDatabase<CMaster_ItemData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_ItemData> IDatabase<CMaster_ItemData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_ItemData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_ItemData GetData(ReadOnlySpan<char> i_ID)
	{
		return null;
	}

	public static CMaster_ItemData[] GetAllData()
	{
		return null;
	}

	public static int Index(string i_ID)
	{
		return 0;
	}
}
