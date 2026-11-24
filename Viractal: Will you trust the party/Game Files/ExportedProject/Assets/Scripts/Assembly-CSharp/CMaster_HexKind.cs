using System.Collections.Generic;
using UnityEngine;

public class CMaster_HexKind : ScriptableObject, IDatabase<CMaster_HexKindData>
{
	private static IDatabase<CMaster_HexKindData> m_Instance;

	[SerializeField]
	private CMaster_HexKindData[] m_DataArray;

	private Dictionary<string, CMaster_HexKindData> m_Data;

	CMaster_HexKindData[] IDatabase<CMaster_HexKindData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_HexKindData> IDatabase<CMaster_HexKindData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_HexKindData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_HexKindData[] GetAllData()
	{
		return null;
	}
}
