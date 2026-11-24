using System.Collections.Generic;
using UnityEngine;

public class CMaster_TutorialGenre : ScriptableObject, IDatabase<CMaster_TutorialGenreData>
{
	private static IDatabase<CMaster_TutorialGenreData> m_Instance;

	[SerializeField]
	private CMaster_TutorialGenreData[] m_DataArray;

	private Dictionary<string, CMaster_TutorialGenreData> m_Data;

	CMaster_TutorialGenreData[] IDatabase<CMaster_TutorialGenreData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_TutorialGenreData> IDatabase<CMaster_TutorialGenreData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_TutorialGenreData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_TutorialGenreData[] GetAllData()
	{
		return null;
	}
}
