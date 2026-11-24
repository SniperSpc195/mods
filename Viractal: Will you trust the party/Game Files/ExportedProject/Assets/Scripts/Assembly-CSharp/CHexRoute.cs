using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CHexRoute
{
	public enum SELECT
	{
		Move = 0,
		Event = 1,
		Other = 2,
		Max = 3
	}

	public class CHECK
	{
		public CHexPosition mHex;

		public int[] mCheckDir;

		public int mWalkLen;

		public const int INVALID_WALK_LEN = 999999999;

		public CHECK()
		{
		}

		public CHECK(CHECK org)
		{
		}

		public CHECK(CHexPosition hex)
		{
		}

		public int GetWalkLen()
		{
			return 0;
		}

		public Vector3Int GetHexPosition()
		{
			return default;
		}

		public Vector3 GetWorldPosition()
		{
			return default;
		}

		public bool IsEnemy()
		{
			return false;
		}

		public bool IsPass()
		{
			return false;
		}

		public void SetNumTexture(int backHeight = -2)
		{
		}

		public void HiddenNumTexture()
		{
		}

		public static List<CHECK> CreateCache(List<CHECK> org)
		{
			return null;
		}
	}

	private CHexMap mHexMap;

	private List<List<CHexPosition>> mHexList;

	private List<CHECK[][]> mCheckList;

	private int mMasterRequiredClimb;

	private int mPlayerRequiredClimb;

	private Dictionary<string, List<CHECK>> mRouteCache;

	private List<CHECK> mRoute;

	public void SetRequiredClimb(int a)
	{
	}

	public CHexRoute(int n)
	{
	}

	public List<CHexPosition> FindMove(CFieldPlayer player, SELECT select, CHexMap hexMap, Vector3Int startPos, int dice, bool skillHide)
	{
		return null;
	}

	private void CheckMove(CHECK[][] check, CHexDef.DIR dir, Vector3Int pos, int walk, int diceNum, bool skillHide)
	{
	}

	public int GetWalkNum(SELECT select, Vector3Int pos)
	{
		return 0;
	}

	public void ClearCache()
	{
	}

	public int MakeRequiredClimb(CFieldPlayer player)
	{
		return 0;
	}

	public List<CHECK> MakeRoute(CFieldPlayer player, SELECT select, Vector3Int startPos, Vector3Int goalPos, int dice, bool skillHide)
	{
		return null;
	}

	private void Route_GoalStart(CHECK[] route, CHECK[][] check, int walkNum, CHECK nowCheck, CHECK startCheck)
	{
	}
}
