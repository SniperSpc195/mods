using System.Collections.Generic;
using UnityEngine;

public class CMaster_CardSpring : ScriptableObject, IDatabase<CMaster_CardSpringData>
{
	private static IDatabase<CMaster_CardSpringData> m_Instance;

	[SerializeField]
	private CMaster_CardSpringData[] m_DataArray;

	private Dictionary<string, CMaster_CardSpringData> m_Data;

	CMaster_CardSpringData[] IDatabase<CMaster_CardSpringData>.DataArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Dictionary<string, CMaster_CardSpringData> IDatabase<CMaster_CardSpringData>.Dictionary => null;

	private void OnEnable()
	{
	}

	public static CMaster_CardSpringData GetData(string i_ID)
	{
		return null;
	}

	public static CMaster_CardSpringData[] GetAllData()
	{
		return null;
	}

	public static string LotteryCard(string id, int dropRank, UtpnRandom rnd)
	{
		return null;
	}

	public static string LotteryCard_Detail(string id, string job, string kind, CParamPlayer pp, UtpnRandom rnd)
	{
		return null;
	}
}
