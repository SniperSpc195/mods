using System.Collections.Generic;
using UnityEngine;

public class CMaster_Memo : ScriptableObject, IDatabase<CMaster_MemoData>
{
	private static IDatabase<CMaster_MemoData> m_Instance;

	[SerializeField]
	private CMaster_MemoData[] m_DataArray;

	private Dictionary<string, CMaster_MemoData> m_Data;

	CMaster_MemoData[] IDatabase<CMaster_MemoData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_MemoData> IDatabase<CMaster_MemoData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_MemoData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_MemoData[] GetAllData()
	{
		return null;
	}

	public static int GetIndex(string id)
	{
		return 0;
	}

	private static CMaster_MemoData GetAppearance()
	{
		return null;
	}

	public static CMaster_MemoData SetMemo()
	{
		return null;
	}
}
