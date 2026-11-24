using System;
using System.Collections.Generic;
using UnityEngine;

public class CMaster_SkillCard : ScriptableObject, IDatabase<CMaster_SkillCardData>
{
	private static IDatabase<CMaster_SkillCardData> m_Instance;

	[SerializeField]
	private CMaster_SkillCardData[] m_DataArray;

	private Dictionary<string, CMaster_SkillCardData> m_Data;

	private static List<CMaster_SkillCardData> mPlayerCard;

	private static List<CMaster_SkillCardData> mEnemyCard;

	CMaster_SkillCardData[] IDatabase<CMaster_SkillCardData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_SkillCardData> IDatabase<CMaster_SkillCardData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_SkillCardData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_SkillCardData GetData(ReadOnlySpan<char> i_ID)
	{
		return null;
	}

	public static CMaster_SkillCardData[] GetAllData()
	{
		return null;
	}

	public static List<CMaster_SkillCardData> GetPlayerCard()
	{
		return null;
	}

	public static List<CMaster_SkillCardData> GetEnemyCard()
	{
		return null;
	}

	private static void MakeCardList(ref List<CMaster_SkillCardData> list, int user)
	{
	}

	public static int Index(string i_ID)
	{
		return 0;
	}
}
