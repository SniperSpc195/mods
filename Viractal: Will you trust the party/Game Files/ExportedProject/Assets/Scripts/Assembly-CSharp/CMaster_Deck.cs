using System.Collections.Generic;
using UnityEngine;

public class CMaster_Deck : ScriptableObject, IDatabase<CMaster_DeckData>
{
	private static IDatabase<CMaster_DeckData> m_Instance;

	[SerializeField]
	private CMaster_DeckData[] m_DataArray;

	private Dictionary<string, CMaster_DeckData> m_Data;

	CMaster_DeckData[] IDatabase<CMaster_DeckData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_DeckData> IDatabase<CMaster_DeckData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_DeckData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_DeckData[] GetAllData()
	{
		return null;
	}
}
