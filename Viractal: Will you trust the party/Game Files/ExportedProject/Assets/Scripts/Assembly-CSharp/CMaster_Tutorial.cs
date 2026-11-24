using System.Collections.Generic;
using UnityEngine;

public class CMaster_Tutorial : ScriptableObject, IDatabase<CMaster_TutorialData>
{
	private static IDatabase<CMaster_TutorialData> m_Instance;

	[SerializeField]
	private CMaster_TutorialData[] m_DataArray;

	private Dictionary<string, CMaster_TutorialData> m_Data;

	CMaster_TutorialData[] IDatabase<CMaster_TutorialData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_TutorialData> IDatabase<CMaster_TutorialData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_TutorialData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_TutorialData[] GetAllData()
	{
		return null;
	}
}
