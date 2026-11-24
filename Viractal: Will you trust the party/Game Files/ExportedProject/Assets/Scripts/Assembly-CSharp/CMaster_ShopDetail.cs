using System.Collections.Generic;
using UnityEngine;

public class CMaster_ShopDetail : ScriptableObject, IDatabase<CMaster_ShopDetailData>
{
	private static IDatabase<CMaster_ShopDetailData> m_Instance;

	[SerializeField]
	private CMaster_ShopDetailData[] m_DataArray;

	private Dictionary<string, CMaster_ShopDetailData> m_Data;

	CMaster_ShopDetailData[] IDatabase<CMaster_ShopDetailData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_ShopDetailData> IDatabase<CMaster_ShopDetailData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_ShopDetailData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_ShopDetailData[] GetAllData()
	{
		return null;
	}
}
