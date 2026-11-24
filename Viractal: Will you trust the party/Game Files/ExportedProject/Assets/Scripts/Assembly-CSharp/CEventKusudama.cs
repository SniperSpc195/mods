using System.Collections.Generic;
using UnityEngine;

public class CEventKusudama
{
	private enum RESULT
	{
		Big = 0,
		Hit = 1,
		None = 2
	}

	private enum MODE
	{
		Start = 0,
		ResultStart = 1,
		FallingCoin = 2,
		Close = 3,
		End = 4
	}

	private CEventNpc mNpc;

	private Transform mCoins;

	private Transform[] mCoinSets;

	private int mCoinMax;

	private Vector3 mCoinCenter;

	private List<CEventCoin> mEventCoins;

	private CEventKusudamaClose mKusudamaClose;

	private RESULT mResult;

	private MODE mMode;

	public CEventKusudama(CEventNpc npc)
	{
	}

	public void RssultStart()
	{
	}

	public void Close()
	{
	}

	public int GetResult()
	{
		return 0;
	}

	public bool IsExecute()
	{
		return false;
	}

	public void Execute()
	{
	}

	private void CoinPosition(Transform parent, int max, Vector3 center, float diameter)
	{
	}

	private void FallCoins(Transform parent)
	{
	}
}
