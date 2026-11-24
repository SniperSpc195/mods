using System.Collections.Generic;
using UnityEngine;

public class CMaster_Equip : ScriptableObject, IDatabase<CMaster_EquipData>
{
	private static IDatabase<CMaster_EquipData> m_Instance;

	[SerializeField]
	private CMaster_EquipData[] m_DataArray;

	private Dictionary<string, CMaster_EquipData> m_Data;

	CMaster_EquipData[] IDatabase<CMaster_EquipData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_EquipData> IDatabase<CMaster_EquipData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_EquipData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_EquipData[] GetAllData()
	{
		return null;
	}
}
