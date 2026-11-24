using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using net;

public class CSaveData
{
	public enum SITUATION
	{
		None = 0,
		Return_GameRoom = 1,
		Online = 2
	}

	public enum STAT
	{
		None = 0,
		FileNotFound = 1,
		DifferentVersion = 2,
		UnknownGameVersion = 3,
		Corrupted = 4,
		Cleard = 5,
		Gameover = 6
	}

	public enum NET
	{
		Offline = 0,
		Internet = 1,
		LAN = 2,
		Localnet = 3,
		All = 4
	}

	public class GAMEDATA
	{
		public int mIndex;

		public string mPath;

		public string mFileName;

		public JsonNode mJson;

		public JsonNode mOrgJson;

		public string mGameVersion;

		public bool[] mBlueMan;

		public bool mOnGuest;

		public int mNumPlayers;

		public int mNumPiece;

		public string[] mGUIDs;

		public STAT mStat;

		public NET mNet;

		public bool mVoiceChat;

		public bool mExistsGUID;

		public bool mContinue;

		public bool mResumeGameover;

		public STAT mContinueStat;

		public bool IsValidNumber()
		{
			return false;
		}

		public bool IsTreatedEmpty()
		{
			return false;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public bool IsCorrupted()
		{
			return false;
		}

		public bool IsUnknownGameVersion()
		{
			return false;
		}

		public bool IsCorrect()
		{
			return false;
		}

		public bool IsContinue()
		{
			return false;
		}

		public bool IsCleard()
		{
			return false;
		}

		public bool IsGameover()
		{
			return false;
		}

		public bool IsLocal()
		{
			return false;
		}

		public bool IsOnline()
		{
			return false;
		}

		public bool IsInternet()
		{
			return false;
		}

		public bool IsLAN()
		{
			return false;
		}

		public bool IsLocalnet()
		{
			return false;
		}

		public void Empty()
		{
		}

		public GAMEDATA(int index, string path, JsonNode json, STAT stat)
		{
		}

		public int GetPlayerIndex(string guid)
		{
			return 0;
		}

		public void SetHostSaveData(JsonNode hostSaveData)
		{
		}
	}

	public class WRITEDATA
	{
		public int mIndex;

		public string mPath;

		public object mObject;

		public GAMEDATA mGameData;

		public WRITEDATA(int i, string path, object obj)
		{
		}
	}

	public class READDATA
	{
		public string mPath;

		public string mVersion;

		public JsonNode mJson;

		public STAT mStat;

		public READDATA(string path, string version)
		{
		}
	}

	public enum MODE
	{
		None = 0,
		Start = 1,
		Loop = 2,
		Wait = 3,
		Error_Retry = 4,
		Error_Return_GameRoom = 5,
		Error_Online = 6,
		End = 7
	}

	public enum State
	{
		None = 0,
		Execute = 1,
		End = 2,
		Error = 3,
		Cancel_ReturnGameRoom = 4
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckSaveData_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public static string SYS_VERSION;

	public static string GAME_VERSION;

	public static int GAMEDATA_MAX;

	private const string SYSTEMSAVE_NAME = "system.bin";

	private static string mSaveDataPath;

	private static string mOldSavePath;

	private static string mPrevious_SaveSystem;

	private static List<WRITEDATA> mSaveList;

	private static List<READDATA> mLoadList;

	private static int mSaveListIndex;

	private static CUIGenericDialog mDialog;

	private static GameObject mSaveUI;

	private static double mTime;

	private static double mLastSaveTime;

	private static SITUATION mSituation;

	private static MODE mMode;

	private static State mEndState;

	public static NET GetNET()
	{
		return NET.Offline;
	}

	public static string GetSaveDataPath()
	{
		return null;
	}

	public static void Initialize()
	{
	}

	private static void CreateSaveDirectory()
	{
	}

	public static void CopySaveData()
	{
	}

	public static void End()
	{
	}

	public static int GetNewPosition(List<GAMEDATA> list, GAMEDATA conv = null)
	{
		return 0;
	}

	private static int CompareDate(string d1, string d2)
	{
		return 0;
	}

	public static string CreateSaveName(int num, bool online = false, bool text = false)
	{
		return null;
	}

	public static string CreateSaveName(int num, NetworkType type, bool text = false)
	{
		return null;
	}

	public static string CreateSaveSystemName(bool text = false)
	{
		return null;
	}

	public static Dictionary<string, object> Create(string version)
	{
		return null;
	}

	public static Dictionary<string, object> MakeDate()
	{
		return null;
	}

	public static byte[] EncryptBin(object saveData)
	{
		return null;
	}

	public static string Decrypt(byte[] tmp)
	{
		return null;
	}

	public static JsonNode DecryptToJson(byte[] tmp)
	{
		return null;
	}

	public static void Delete(string path)
	{
	}

	private static bool Save(string path, object data, bool text = false)
	{
		return false;
	}

	public static JsonNode Load(string version, string path, out STAT stat, bool checkVersion = true, bool log = true)
	{
		stat = default;
		return null;
	}

	public static GAMEDATA LoadGameData(int i, string version, string path, bool checkVersion = true, bool log = true)
	{
		return null;
	}

	public static bool IsChanged_SystemData()
	{
		return false;
	}

	private static void Update_SystemData(Dictionary<string, object> tmp)
	{
	}

	public static void AddSaveSystem(List<WRITEDATA> list)
	{
	}

	public static STAT LoadSystem()
	{
		return STAT.None;
	}

	public static List<WRITEDATA> CreateSystemSaveList()
	{
		return null;
	}

	public static List<WRITEDATA> CreateFieldSaveList(int num, STAT stat)
	{
		return null;
	}

	public static bool IsOnlineSaveData(JsonNode save, out string networktype)
	{
		networktype = null;
		return false;
	}

	public static bool IsOnlineSaveData(JsonNode save)
	{
		return false;
	}

	public static bool SaveStart(string path, object data, bool text = false)
	{
		return false;
	}

	public static void SaveStart(List<WRITEDATA> list, SITUATION sit = SITUATION.None)
	{
	}

	private static void Dialog_Saving()
	{
	}

	public static void LoadStart(List<READDATA> list)
	{
	}

	public static GAMEDATA GetGameData(int n = 0)
	{
		return null;
	}

	public static bool IsSaveExec()
	{
		return false;
	}

	public static State GetEndState()
	{
		return State.None;
	}

	public static State SaveExec()
	{
		return State.None;
	}

	public static State LoadExec()
	{
		return State.None;
	}

	[AsyncStateMachine(typeof(_003CCheckSaveData_003Ed__62))]
	public static UniTask<bool> CheckSaveData(CancellationToken token)
	{
		return default;
	}

	public static JsonNode OnlineToLocal(GAMEDATA source)
	{
		return null;
	}

	private static void Remove_FieldOnline(JsonNode field)
	{
	}
}
