using System;
using System.Collections.Generic;
using UnityEngine;

public class CMaster_DeckCard : ScriptableObject, IDatabase<CMaster_DeckCardData>
{
	private static IDatabase<CMaster_DeckCardData> m_Instance;

	[SerializeField]
	private CMaster_DeckCardData[] m_DataArray;

	private Dictionary<string, CMaster_DeckCardData> m_Data;

	[NonSerialized]
	private static Dictionary<string, List<CMaster_DeckCardData>> m_Table;

	CMaster_DeckCardData[] IDatabase<CMaster_DeckCardData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_DeckCardData> IDatabase<CMaster_DeckCardData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_DeckCardData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_DeckCardData[] GetAllData()
	{
		return null;
	}

	public static DeckCardList GetDeckCardList(string i_JobID, bool i_CheckAppear)
	{
		return default;
	}
}
