using System;
using System.Collections.Generic;

public class UtpnRandom
{
	private static int mDefSeed;

	private static List<UtpnRandom> mStaticList;

	private Random mSysRandom;

	private const int SYSRND_SEED_MAX = 8388607;

	public string mName;

	private int mSeedIndex;

	private static ushort[] random_seed;

	public UtpnRandom(int s = -1)
	{
	}

	public UtpnRandom(string name, int s = -1, bool useSystemRandom = false)
	{
	}

	public void SetSeed(int s = -1, bool useSystemRandom = false)
	{
	}

	public int GetSeed()
	{
		return 0;
	}

	public int Get()
	{
		return 0;
	}

	public int Get(int max)
	{
		return 0;
	}

	public int Value(int max)
	{
		return 0;
	}

	public int Range(int min, int max)
	{
		return 0;
	}

	public float GetF()
	{
		return 0f;
	}

	public float ValueF(float max = 1f)
	{
		return 0f;
	}

	public float RangeF(float min, float max)
	{
		return 0f;
	}

	public bool Lottery100(int n, string log = null)
	{
		return false;
	}

	public bool Lottery100F(float n)
	{
		return false;
	}

	public void SyncSeed(int[][] sync, int playerMax)
	{
	}

	public static Dictionary<string, object> SaveJson()
	{
		return null;
	}

	public static void LoadJson(JsonNode json)
	{
	}

	public static void SeedLog()
	{
	}
}
