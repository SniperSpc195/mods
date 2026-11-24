using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CDefine
{
	public enum GAMELEVEL
	{
		Easy = 0,
		Normal = 1,
		Hard = 2,
		Max = 3
	}

	public enum BaseColor
	{
		None = -1,
		Player1 = 0,
		Player2 = 1,
		Player3 = 2,
		Enemy = 3,
		EventObject = 4,
		EnemyFormidable = 6
	}

	public enum SWORK
	{
		_GAMECLEAR = 0,
		_GAMEOVER = 1,
		_INTERRUPTIONS = 2,
		_LAST_CONTRACTED = 3,
		_LAST_SOULPOINT = 4,
		_LAST_SOULPOINT_B = 5
	}

	public class GameFlag
	{
		public string mName;

		public string mHead;

		public ulong[] mFlag;

		public int mMax;

		public GameFlag(string name, string head, int max)
		{
		}

		public GameFlag(GameFlag g)
		{
		}

		public List<ulong> Save()
		{
			return null;
		}

		public void Load(JsonNode array)
		{
		}

		public void Clear()
		{
		}

		public void AllON()
		{
		}

		public void Copy(GameFlag g)
		{
		}

		public void Copy(ulong[] flag)
		{
		}

		public bool IsOn(int f)
		{
			return false;
		}

		public bool IsOff(int f)
		{
			return false;
		}

		public ulong On(int f)
		{
			return 0uL;
		}

		public ulong Off(int f)
		{
			return 0uL;
		}

		public bool IsOn(string key)
		{
			return false;
		}

		public bool IsOff(string key)
		{
			return false;
		}

		public ulong On(string key)
		{
			return 0uL;
		}

		public ulong Off(string key)
		{
			return 0uL;
		}
	}

	public class GameWork
	{
		public string mName;

		public string mHead;

		private CryptInt[] mWork;

		public int mMax;

		private const int WORK_MIN = -999999999;

		private const int WORK_MAX = 999999999;

		public GameWork(string name, string head, int max)
		{
		}

		public GameWork(GameWork g)
		{
		}

		public List<int> Save()
		{
			return null;
		}

		public void Load(JsonNode array)
		{
		}

		public void Clear()
		{
		}

		public void Copy(GameWork g)
		{
		}

		public void Copy(int[] work)
		{
		}

		public int Get(int i)
		{
			return 0;
		}

		public int Get(string key)
		{
			return 0;
		}

		public int[] GetAll()
		{
			return null;
		}

		public int Set(int i, int n)
		{
			return 0;
		}

		public static int CheckMinMax(int n)
		{
			return 0;
		}
	}

	[Serializable]
	public class CryptInt
	{
		private static readonly object _lockObj;

		private static UtpnRandom mRandom;

		[SerializeField]
		[ReadOnly]
		protected uint mCrypt;

		protected int mSeed;

		public static void SetRandom(UtpnRandom rnd)
		{
		}

		public CryptInt(int n = 0)
		{
		}

		public void Set(int n)
		{
		}

		public int Get()
		{
			return 0;
		}
	}

	[Serializable]
	public class CryptUint
	{
		private static readonly object _lockObj;

		private static UtpnRandom mRandom;

		[SerializeField]
		[ReadOnly]
		private uint mCrypt;

		private int mSeed;

		public static void SetRandom(UtpnRandom rnd)
		{
		}

		public CryptUint(uint n = 0u)
		{
		}

		public void Set(uint n)
		{
		}

		public uint Get()
		{
			return 0u;
		}
	}

	[Serializable]
	public class DictionaryCount
	{
		[SerializeField]
		[ReadOnly]
		private SerializedDictionary<string, CParamInt> mDict;

		[SerializeField]
		[ReadOnly]
		private CParamInt mMax;

		public DictionaryCount(int max)
		{
		}

		public void Clear()
		{
		}

		public void Remove(string key)
		{
		}

		public DictionaryCount(JsonNode json)
		{
		}

		public Dictionary<string, object> Save()
		{
			return null;
		}

		public int GetDictCount()
		{
			return 0;
		}

		public int GetInt(string key)
		{
			return 0;
		}

		public void SetInt(string key, int a)
		{
		}

		public int increment(string key)
		{
			return 0;
		}

		public int GetAllCount()
		{
			return 0;
		}

		private void Sort()
		{
		}
	}

	public static float FRAMERATE;

	public static int I_FRAMERATE;

	public static int VSYNCCOUNT;

	public const float SCREEN_WIDTH = 1920f;

	public const float SCREEN_HEIGHT = 1080f;

	public const float SCREEN_HEIGHT_UI = -1080f;

	public const int I_SCREEN_WIDTH = 1920;

	public const int I_SCREEN_HEIGHT = 1080;

	public const int I_SCREEN_HEIGHT_UI = -1080;

	public const int DICE_USE_MAX = 3;

	public const int DICE_WK_MAX = 4;

	public const int PLAYER_MAX = 3;

	public const float IN_FRONT_DIR = 180f;

	public const int MAX_SOUL_GUID = 200;

	public const long MAX_TOTAL_PLAYING_TIME = 35999999L;

	public const int SFLAG_MAX = 1024;

	public const int LFLAG_MAX = 1024;

	public const int CFLAG_MAX = 1024;

	public const int TUTORIAL_MAX = 10000;

	public const int ITEM_FLAG_MAX = 10048;

	public const int CARD_FLAG_MAX = 10048;

	public const int EOBJ_FLAG_MAX = 10048;

	public const int STAGE_FLAG_MAX = 1024;

	public const int TRANSMUTATION_FLAG_MAX = 10048;

	public const int MEMO_FLAG_MAX = 10000;

	public const int SWORK_MAX = 512;

	public const int LWORK_MAX = 512;

	public const int CWORK_MAX = 512;

	public static Color DEBUG_SELECT_COLOR;

	public static Color FONT_COLOR;

	public static Color NOT_SELECTED_COLOR;

	public static Color CHOSE_COLOR;

	public static Color UP_COLOR;

	public static Color DOWN_COLOR;

	public static Color DEMERIT_COLOR;

	public static Color HP_COLOR_DEF;

	public static Color HP_COLOR_LOW;

	public static Color HP_COLOR_MINIMAL;

	public static float BUTTON_SIZE;

	public static int FONT_SIZE;

	public static int RUBY_FONT_SIZE;

	public static float FONT_SCALE;

	public static Vector3 FONT_SCALE_V3;

	public static Vector3 DEFAULT_ANGLE;

	public static string SYSTEM_SAVE_VERSION;

	public static string FIELD_SAVE_VERSION;

	public static int SetFrame(int f)
	{
		return 0;
	}
}
