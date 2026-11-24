using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using Fork.Game.AutoGenerateMap;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class CFieldMain : LwSingleton<CFieldMain>
{
	public enum END_STAT
	{
		None = 0,
		Clear = 1,
		GameOver = 2,
		Error = 3
	}

	public enum FLDUI
	{
		ExplanMissOpt = 0,
		Mission = 1,
		HexPopup = 2,
		Turn = 3,
		MoveMainMenu = 4,
		MoveSubMenu = 5,
		PlayerPanel = 6,
		TalkPop = 7,
		OnTheMove = 8,
		Max = 9
	}

	public enum MODE
	{
		None = 0,
		Start_Online = 1,
		LoadWait_SceneRoom = 2,
		OpenBox = 3,
		GameStartCamera = 4,
		Online_Initialize = 5,
		Online_Initialize_2 = 6,
		Initialize = 7,
		Initialize_2 = 8,
		Event_GameStart = 9,
		Root = 10,
		Root_Sync = 11,
		Inside_Camera = 12,
		All_BaseLevelup = 13,
		All_BaseLevelup_Wait = 14,
		All_BaseLevelup_End = 15,
		Event_TurnStart = 16,
		Event_TurnStart_Wait = 17,
		BaseLevelup_Loop = 18,
		BaseLevelup_Wait = 19,
		Before_AutoSave = 20,
		Multiple_MoveDice = 21,
		Event_DiceAfter = 22,
		Event_DiceAfter_Wait = 23,
		AutoSave_TurnStart = 24,
		AutoSave_Wait = 25,
		GM_TurnStart = 26,
		GM_TurnStart_2 = 27,
		Release_SkipButton = 28,
		Free = 29,
		Start_CheckMap = 30,
		CheckMap = 31,
		TownInfomation = 32,
		DiceRole = 33,
		DiceWait = 34,
		DiceDecision = 35,
		Select_Destination = 36,
		HexCursor = 37,
		Inquiry_Halt = 38,
		Before_PlayerMove = 39,
		PlayerMove_Start = 40,
		PlayerMove = 41,
		PlayerStop = 42,
		PlayerStop_Sync = 43,
		PlayerStop_Loop = 44,
		Event_Object = 45,
		Event_Object_Close = 46,
		MissionClear = 47,
		Event_MoveStop = 48,
		Recovery_Town = 49,
		Shop = 50,
		Start_NextPlayer = 51,
		CheckMission_NextPlayer = 52,
		WhispersLottery_NextPlayer = 53,
		NextPlayer = 54,
		Menu_OldItem = 55,
		Menu_Item = 56,
		AllOut_Start = 57,
		AllOut_WaitDup = 58,
		AllOut_Event = 59,
		AllOut_End = 60,
		Menu_Status = 61,
		Menu_Option = 62,
		Menu_Mission = 63,
		Event_BattleBefore = 64,
		Encounter = 65,
		Battle_Start = 66,
		Battle_LoadWait = 67,
		Battle_Wait = 68,
		Event_BattleAfter = 69,
		Command_FightingDragons = 70
	}

	private enum FOLLOW
	{
		Other = 0,
		Cursor = 1
	}

	public enum CONDITION_GETPLAYER
	{
		None = 0,
		Alive = 1,
		Dead = 2
	}

	public enum DevilsWhisperSEType
	{
		None = 0,
		Appear = 1,
		Leave = 2,
		Contract = 3
	}

	public enum SELECTHEX_MODE
	{
		None = 0,
		Player = 1,
		Enemy = 2,
		Ladder = 3,
		Town = 4,
		Cloud = 5,
		AllOut = 6
	}

	public class SELECT_HEX
	{
		public CFieldPlayer mExecPlayer;

		public Vector3Int mStartPosition;

		public SELECTHEX_MODE mSelectMode;

		public CHexPosition mResultHex;

		public SELECT_HEX(CFieldPlayer p, SELECTHEX_MODE mode)
		{
		}

		public bool IsSelectPlayer()
		{
			return false;
		}

		public bool IsSelectEnemy()
		{
			return false;
		}

		public bool IsSelectLadder()
		{
			return false;
		}

		public bool IsSelectTown()
		{
			return false;
		}

		public bool IsSelectCloud()
		{
			return false;
		}

		public bool IsSelectAllOout()
		{
			return false;
		}
	}

	[Serializable]
	public class MouseStatus
	{
		public enum STAT
		{
			None = 0,
			LeftOn = 1,
			LeftClick = 2,
			Drag = 3,
			RightOn = 4
		}

		public STAT mStat;

		private double mExecTime;

		private double mLeftBtnTime;

		public Vector2 mPosition;

		public Vector3 mVector;

		private GamePad mMouse;

		public void SetMouse()
		{
		}

		public bool IsValid()
		{
			return false;
		}

		public bool IsStat(STAT stat)
		{
			return false;
		}

		private void Reset()
		{
		}

		public void Update()
		{
		}

		private void MakeVector(Vector2 pos)
		{
		}
	}

	[Serializable]
	public class FloorOffsetSettings
	{
		public Vector3 InitialPosition;

		public Transform MoveObject;
	}

	private class JOBCARD
	{
		public CMaster_SkillCardData card;

		public int probability;

		public JOBCARD(CMaster_SkillCardData _card, int[] _probability)
		{
		}
	}

	public class HEX_TOWN
	{
		public string mID;

		public Vector3Int mHexPosition;

		public CMaster_MapTownData mTown;

		public CRegistryShop mShop;

		public string mEnvironmentSE;

		public long mEnvironmentSEHandle;

		public HEX_TOWN(CHexPosition hex)
		{
		}

		public HEX_TOWN(JsonNode json)
		{
		}

		public int GetRecoveryHP()
		{
			return 0;
		}

		public string GetTownName()
		{
			return null;
		}

		public Dictionary<string, object> Save()
		{
			return null;
		}

		public bool IsEqualHexPosition(Vector3Int p)
		{
			return false;
		}

		public static bool CheckSaveData(string savefile, JsonNode json)
		{
			return false;
		}

		public void PlayEnvironmentSE(CHexMap i_Map)
		{
		}

		public void StopEnvironmentSE(int msec = 0)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass338_0
	{
		public CItemWindow itemWindow;

		internal bool _003C_HideSoulPoint_003Eb__0()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_Enemy_003Ed__486 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public JsonNode saveField;

		public CFieldMain _003C_003E4__this;

		private JsonNode _003CarrayEne_003E5__2;

		private UniTask<GameObject[]>.Awaiter _003C_003Eu__1;

		private List<HexMap.SpawnObject> _003Cregist_003E5__3;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_EventObject_003Ed__487 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public JsonNode saveField;

		public CFieldMain _003C_003E4__this;

		private JsonNode _003Carray_003E5__2;

		private UniTask<GameObject[]>.Awaiter _003C_003Eu__1;

		private List<HexMap.SpawnObject> _003Cregist_003E5__3;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_Map_003Ed__488 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CFieldMain _003C_003E4__this;

		public JsonNode saveField;

		private UniTask.Awaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_Player_003Ed__489 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public JsonNode saveField;

		public CFieldMain _003C_003E4__this;

		private JsonNode _003CarrayPly_003E5__2;

		private int _003Ci_003E5__3;

		private GameObject _003CplayerObject_003E5__4;

		private JsonNode _003CsavePly_003E5__5;

		private CMaster_CharJobData _003Cjob_003E5__6;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private CHexPosition _003CstartPos_003E5__7;

		private List<string> _003Cplayed_003E5__8;

		private int _003Ci_003E5__9;

		private string _003CjobID_003E5__10;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__11;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_Tresure_003Ed__493 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public JsonNode saveField;

		public CFieldMain _003C_003E4__this;

		private JsonNode _003Carray_003E5__2;

		private UniTask<GameObject[]>.Awaiter _003C_003Eu__1;

		private List<HexMap.SpawnObject> _003Cregist_003E5__3;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_WillToken_003Ed__459 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public JsonNode saveField;

		public CFieldMain _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadUI_003Ed__241 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<GameObject> _003C_003Et__builder;

		public CFieldMain _003C_003E4__this;

		public string path;

		public Transform parent;

		public GameController.PADNUM padNum;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSelectHex_003Ed__449 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CancellationToken token;

		public CFieldMain _003C_003E4__this;

		private bool _003Cret_003E5__2;

		private bool _003Cloop_003E5__3;

		private CFieldMain _003CfMain_003E5__4;

		private CSound _003C_sound_003E5__5;

		private COnline _003C_online_003E5__6;

		private bool _003CpadOn_003E5__7;

		private UniTask.Awaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__475 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public CFieldMain _003C_003E4__this;

		private bool _003CIsContinue_003E5__2;

		private JsonNode _003CsaveField_003E5__3;

		private UniTask.Awaiter _003C_003Eu__1;

		private Vector3 _003Cv3_003E5__4;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__5;

		private GameObject _003Cbase1_003E5__6;

		private Transform _003CbaseParent_003E5__7;

		private Transform _003CdragonParent_003E5__8;

		private CMaster_ModelData _003CmodelData_003E5__9;

		private UniTask<GameObject>.Awaiter _003C_003Eu__2;

		private GameObject[] _003C_003E7__wrap9;

		private UniTask<CUICharacterStatusGroup>.Awaiter _003C_003Eu__3;

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

	[CompilerGenerated]
	private sealed class _003C_HideSoulPoint_003Ed__338 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CFieldMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass338_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_HideSoulPoint_003Ed__338(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_Quake_003Ed__351 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CFieldMain _003C_003E4__this;

		public float i_Amplitude;

		public float i_AttackTime;

		public float i_Time;

		public float i_DecayTime;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_Quake_003Ed__351(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_ReturnFromBattle_003Ed__319 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CFieldMain _003C_003E4__this;

		private Vector3 _003CstartEnemy_003E5__2;

		private Vector3 _003CgoalEnemy_003E5__3;

		private float _003CtimeEnemy_003E5__4;

		private CFieldEnemy _003Ctarget_003E5__5;

		private Vector3[] _003CstartPlayer_003E5__6;

		private Vector3[] _003CgoalPlayer_003E5__7;

		private float[] _003CtimePlayer_003E5__8;

		private AnimationCurve _003Ccurve_003E5__9;

		private UniTask.Awaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_TrackingDevilsWhisperSE_003Ed__333 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public DevilsWhisperSEType seType;

		public long handle;

		private double _003Ctime_003E5__2;

		private YieldAwaitable.Awaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_WakeupVolume_003Ed__479 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CFieldMain _003C_003E4__this;

		public float i_Seconds;

		private double _003Cstarttime_003E5__2;

		private YieldAwaitable.Awaiter _003C_003Eu__1;

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

	public const uint BTN_ZoomOut = 1048576u;

	public const uint BTN_ZoomIn = 2097152u;

	public const uint BTN_WhispersContract = 4194304u;

	public const uint BTN_WhispersSmall = 8388608u;

	public const uint BTN_NextPlayerL = 67108864u;

	public const uint BTN_NextPlayerR = 134217728u;

	private static string mReturnScene;

	private static END_STAT mEndStat;

	private static int mEnd_RemainingTurns;

	private static CSaveData.GAMEDATA mContinueData;

	private static bool mOnline_AutoContinue;

	private static int mAutoSaveSlot;

	private bool mContinueNoSave;

	private List<CSaveData.WRITEDATA> mSaveList;

	private static string mStageID;

	public static CMaster_MapTimeSavingData mTimeSaving;

	[SerializeField]
	[ReadOnly]
	private CMaster_MapStageData mStageData;

	private Vector3? m_BossPosition;

	private long m_BossSEHandle;

	private bool mOpenCmdLastBoss;

	[SerializeField]
	[ReadOnly]
	private string mMainBGM;

	private CDebugSw mDebugSw;

	private CHexMap mHexMap;

	private string mGenerateMapDate;

	private int mGenerateMapSeed;

	[SerializeField]
	private CHexRoute mHexRoute;

	[SerializeField]
	private Transform mCharaParent;

	[SerializeField]
	private Transform mTBoxParent;

	[SerializeField]
	private Transform mObjectParent;

	[SerializeField]
	private Transform mEventObjectParent;

	[SerializeField]
	private Transform mUIObjects;

	[SerializeField]
	private Transform mCanvasParent;

	[SerializeField]
	private Transform mCanvasTalkPop;

	private GameObject[] mUI;

	private bool mAfterRollingDice;

	private bool mContinue_AfterRollingDice;

	private bool mAfter_MultipleDice;

	[SerializeField]
	private CFieldNewDice mFieldNewDice;

	[SerializeField]
	private Camera mMainCamera;

	[SerializeField]
	private CFramingCamera mFramingCamera;

	[SerializeField]
	private CGroupCamera mGroupCamera;

	[SerializeField]
	private Transform mParentFreeCursor;

	private CHexCursor mFreeCursor;

	private CHexCursor mExecPlayerCursor;

	private Vector3Int mHexStartPosition;

	[SerializeField]
	[ReadOnly]
	private Vector3Int mHexCursorPosition;

	[SerializeField]
	[ReadOnly]
	private int mRestDiceNum;

	[SerializeField]
	[ReadOnly]
	private CDefine.GAMELEVEL mGameLevel;

	[SerializeField]
	[ReadOnly]
	private string mPlayGUID;

	[SerializeField]
	[ReadOnly]
	private string mSoulGUID;

	[SerializeField]
	[ReadOnly]
	private CParamInt mSoulPoint;

	[SerializeField]
	[ReadOnly]
	private CParamInt mLocal_WhispersReward;

	private int mStartTurns;

	[SerializeField]
	private int mRemainingTurns;

	private bool mEventZeroTurn;

	[SerializeField]
	private CFieldMenu_Main mMenuMain;

	[SerializeField]
	private CFieldMenu_NewUseItem mMenuNewItem;

	[SerializeField]
	private CFieldMenuHeader mMenuStatus;

	[SerializeField]
	private CFieldMenu_NewMission mMenuNewMission;

	[SerializeField]
	private CMissionBoard mMissionBoard;

	[SerializeField]
	private CMission_NewResult mMission_NewResult;

	[SerializeField]
	private CMissionNotification mMissionNotification;

	[SerializeField]
	private CSelectionAbilities mSelectionAbilities;

	[SerializeField]
	private CUIGenericMenu mMenuYesNo;

	[SerializeField]
	private CDevilsWhispers mDevilsWhispers;

	[SerializeField]
	private CDevilsNotice mDevilsNotice;

	[SerializeField]
	private CDevilsVoiceWeird mVoiceWeird;

	[SerializeField]
	private CFieldUI_Popup mUIPopup;

	[SerializeField]
	private CUIGenericMenu mRouletteMenu;

	[SerializeField]
	private CFieldShop_New mShopNew;

	[SerializeField]
	private CItemWindow mGetItemWindow;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation_Town;

	[SerializeField]
	private CEventChoices mEventChoices;

	[SerializeField]
	private CUIMenuControllers mMenuControllers;

	[SerializeField]
	private CMenu_Save mMenuSave;

	[SerializeField]
	private List<CScrollMenu> mListScMenu;

	private List<string> mObtainedPossessions;

	private List<CHexPosition> mHexMoveList;

	private List<CHexRoute.CHECK> mHexRouteList;

	private bool mSkillHide;

	[SerializeField]
	private Canvas mCanvas_Recommend;

	[SerializeField]
	private CFieldOnline_PlayerFace[] mPlayersFaceIcons;

	[SerializeField]
	[ReadOnly]
	private List<CFieldPlayer> mFieldPlayer;

	private int mPlayerIndex;

	private int mRotationIndex;

	private CFieldPlayer[] mPlayerOrder;

	private List<CFieldPlayer> mPlayerOrderList;

	private CFieldPlayer mExecPlayer;

	private CFieldMove.STATE mPlayerMoveState;

	[SerializeField]
	private Transform mInTownJobModel;

	private List<CFieldJobMedal> mFieldJobMedal;

	private List<CFieldEnemy> mFieldEnemy;

	[SerializeField]
	[ReadOnly]
	private string mBossGroupID;

	private CAnimePlayer mBossDragon;

	private CFieldEnemy mEnemyBoss;

	private CFieldEnemy mBattleTarget;

	private string mBattleID;

	private List<CFieldTBox> mFieldTBox;

	private List<CFieldEventObject> mFieldEventObject;

	private List<Vector3Int> mAllOut_Position;

	private CFieldTBox mAllOutTarget_Tresure;

	private CFieldEnemy mAllOutTarget_Enemy;

	private Vector3Int mAllOut_OrgHexPosition;

	public List<HexDupPosition.INIT_DATA> mDupPosition;

	private List<HexDupPosition.INIT_DATA> mDupPositionBuilding;

	private List<HexDupPosition.INIT_DATA> mDupPositionObject;

	private List<HexDupPosition.INIT_DATA> mDupPosTBox;

	[SerializeField]
	private CEventScript mEventScript;

	[SerializeField]
	private CEventMessage mGamemasterMessage;

	private bool mOnTurnStartMes;

	[SerializeField]
	private CFieldSlide mFieldSlide;

	public static bool mInBattle;

	[SerializeField]
	private Transform mActionScript;

	private CTurnIndependentAnimatorStep m_TurnIndependentAnimationStep;

	[SerializeField]
	private CTurnStartMessenger mTurnStartMessenger;

	private CVoiceChat_VolumeSetting mVCVS;

	[SerializeField]
	[Header("エンカウント\u3000マップ拡大時間")]
	private float mEncountMapScaleTime;

	[SerializeField]
	[Header("エンカウント\u3000コマ滞空時間")]
	private float mEncountJumpTime;

	private string mOnlineSyncRoot;

	private float mWait;

	[SerializeField]
	private CCardReinforcement m_CardReinforcement;

	[SerializeField]
	private CCardDelete m_CardDelete;

	[SerializeField]
	private CCardDuplicate m_CardDuplicateMenu;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	[SerializeField]
	[ReadOnly]
	private MODE mReturnMode;

	[SerializeField]
	public CGameResult mResult;

	private MODE mNextMode;

	private MODE mReturn_ClearedMission;

	private MODE mReturn_EventInterrupted;

	private CShadowDistanceModifier mShadowDistanceModifier;

	private float mShadowDistance;

	[SerializeField]
	[ReadOnly]
	private FOLLOW mFollow;

	private CFieldSound mSoundHn_GameStart;

	[SerializeField]
	[ReadOnly]
	private GameController.PADNUM mPadNumUI;

	public const float HEXSORT_DEF_SPEED = 0.1f;

	private List<CHexCloud> mClearingClouds;

	private bool mLoadingCompleteBattle;

	private PrimaryListener _AudioListener;

	[SerializeField]
	private CinemachineVirtualCamera m_VirtualCamera;

	[SerializeField]
	private SignalSourceAsset m_SignalSourceAsset;

	private Coroutine m_Quake;

	[SerializeField]
	[ReadOnly]
	private List<CFieldLight> mFieldLight;

	[SerializeField]
	private List<CParamMission> mAllMembersMission;

	[SerializeField]
	private List<CParamMission> mClearMission;

	[SerializeField]
	[ReadOnly]
	private List<string> mWithdrawMission;

	public static bool mLastGame_Online;

	private bool mOnline;

	private bool mControlPlayer;

	private int mControlIndex;

	private CFieldPlayer[] mOnline_PlayerOrder;

	private int mOnline_Error;

	private bool mEnableCheckLeaveMember;

	private int mOnline_LeaveMember;

	private string mReason_LeaveRoom;

	private const string VERSION = "1.06";

	private SELECT_HEX mSelectHex;

	private CUIButtonExplanation.DATA[] mButton_SelectHex;

	private string mText_SelectHex;

	private bool mEnableExplanation;

	private CHexPosition mHitHex_To_Mouse;

	private MouseStatus mMouseStatus;

	[SerializeField]
	private FloorOffsetSettings[] m_FloorOffsetObjectSettings;

	private List<FloorOffsetSettings> m_FloorOffsetObjects;

	private bool mLoadingCompleteLight;

	private Volume mLightmapGlobalVolume;

	private static CGameRoom_Table.PLAYER_SETTING[] mPlayerSetting;

	private static int mLocalNumPlayers;

	private static CGameRoom_Table.ONLINE_PLAYER[] mOnlinePlayer;

	[SerializeField]
	[ReadOnly]
	private bool mEndStart;

	private float[] mInitialize_PieceAngle;

	private int mIndex_PieceAngle;

	private HEX_TOWN mNowTown;

	private List<HEX_TOWN> mHexTown;

	private List<string> mVisitedTown;

	private List<List<CFieldPlayer>> mDupTownsList;

	public static END_STAT EndStat => END_STAT.None;

	public static int End_RemainingTurns => 0;

	public bool OpenCmdLastBoss => false;

	public CMenu_Save MenuSave => null;

	public List<CFieldPlayer> FieldPlayer => null;

	public CFieldTBox AllOutTarget_Tresure => null;

	public CFieldEnemy AllOutTarget_Enemy => null;

	public Transform ActionScript => null;

	public CUICharacterStatusGroup m_CharacterStatusGroup { get; private set; }

	public bool m_StatusPopupForceEnabled { get; set; }

	public float EncountMapScaleTime => 0f;

	public float EncountJumpTime => 0f;

	public UniTask m_ReturnFromBattle { get; private set; }

	public CCardReinforcement CardReinforcementMenu => null;

	public CCardDelete CardDelete => null;

	public CCardDuplicate CardDuplicate => null;

	private PrimaryListener AudioListener => null;

	public SignalSourceAsset SignalSourceAsset => null;

	public CinemachineBasicMultiChannelPerlin m_MultiChannelPerlin { get; private set; }

	public static int LocalNumPlayers => 0;

	public static void SetReturnScene(string a)
	{
	}

	public static string GetReturnScene()
	{
		return null;
	}

	public void SetEndStat(END_STAT stat)
	{
	}

	public void Inc_GameClear()
	{
	}

	public void Inc_GameOver()
	{
	}

	public void Inc_GameInterruptions()
	{
	}

	public void Dec_GameInterruptions()
	{
	}

	public void GameEnd_WhispersContracted()
	{
	}

	public static void SetContinueData(CSaveData.GAMEDATA gameData)
	{
	}

	public static CSaveData.GAMEDATA GetContinueData()
	{
		return null;
	}

	public static void SetAutoSaveSlot(int a)
	{
	}

	public static bool IsOnline_AutoContinue()
	{
		return false;
	}

	public static void SetStageID(string id, string time_saving = null)
	{
	}

	public static string GetStageID()
	{
		return null;
	}

	public CMaster_MapStageData GetMapStageData()
	{
		return null;
	}

	public float GetMagnificationSoulpoint()
	{
		return 0f;
	}

	public string GetGagnificationSoulpoint_ToText()
	{
		return null;
	}

	public int GetDragonsSoulpoint()
	{
		return 0;
	}

	public void SetOpenCmdLastBoss()
	{
	}

	public void ReqMainBGM(string bgm)
	{
	}

	public CHexMap GetHexMap()
	{
		return null;
	}

	public int GetGenerateMapSeed()
	{
		return 0;
	}

	public void SetGenerateMapSeed(int seed)
	{
	}

	public CFieldNewDice GetFieldNewDice()
	{
		return null;
	}

	public Camera GetMainCamera()
	{
		return null;
	}

	public CFramingCamera GetFramingCamera()
	{
		return null;
	}

	public CGroupCamera GetGroupCamera()
	{
		return null;
	}

	public Vector3Int GetHexCursorPosition()
	{
		return default;
	}

	public CDefine.GAMELEVEL GetGameLevel()
	{
		return CDefine.GAMELEVEL.Easy;
	}

	public int GetSoulPoint()
	{
		return 0;
	}

	public int SetSoulPoint(int a)
	{
		return 0;
	}

	public int AddSoulPoint(int n)
	{
		return 0;
	}

	public int GetBonusSoulPoint()
	{
		return 0;
	}

	public void PaymentSoulPoint()
	{
	}

	public int GetStartTurn()
	{
		return 0;
	}

	public int GetTurn()
	{
		return 0;
	}

	public int ReduceRemainingTurns(int n)
	{
		return 0;
	}

	public CFieldMenu_NewUseItem GetNewUseItem()
	{
		return null;
	}

	public CFieldMenuHeader GetMenuStatus()
	{
		return null;
	}

	public CFieldMenu_NewMission GetMenuNewMission()
	{
		return null;
	}

	public CMissionBoard GetMissionBoard()
	{
		return null;
	}

	public CMission_NewResult GetMission_NewResult()
	{
		return null;
	}

	public CSelectionAbilities GetSelectionAbilities()
	{
		return null;
	}

	public CDevilsWhispers GetDevilsWhispers()
	{
		return null;
	}

	public CDevilsNotice GetDevilsNotice()
	{
		return null;
	}

	public CUIGenericMenu GetRouletteMenu()
	{
		return null;
	}

	public CFieldShop_New GetFieldShop_New()
	{
		return null;
	}

	public CItemWindow GetItemWindow()
	{
		return null;
	}

	public CUIButtonExplanation GetButtonExplanation()
	{
		return null;
	}

	public CUIMenuControllers GetMenuControllers()
	{
		return null;
	}

	public bool IsObtained(string id)
	{
		return false;
	}

	public bool IsObtainedSet(string id)
	{
		return false;
	}

	public void SetObtained(string id)
	{
	}

	public string GetBossGroupID()
	{
		return null;
	}

	public void SetBossGroupID(string id)
	{
	}

	public int GetNumBossGroup()
	{
		return 0;
	}

	public CAnimePlayer GetBossDragon()
	{
		return null;
	}

	public CFieldEnemy GetBoss()
	{
		return null;
	}

	public CFieldEnemy GetBattleTarget()
	{
		return null;
	}

	public List<HexDupPosition.INIT_DATA> GetDupPositionList()
	{
		return null;
	}

	public CEventScript GetCEventScript()
	{
		return null;
	}

	public CEventMessage GetEventMessage()
	{
		return null;
	}

	public static bool IsBattle()
	{
		return false;
	}

	public MODE GetMode()
	{
		return MODE.None;
	}

	public MODE GetReturnMode()
	{
		return MODE.None;
	}

	private new void OnDestroy()
	{
	}

	public void SceneUnload()
	{
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CLoadUI_003Ed__241))]
	private UniTask<GameObject> LoadUI(string path, Transform parent, GameController.PADNUM padNum = GameController.PADNUM.None)
	{
		return default;
	}

	public bool IsUIPlaying(FLDUI ui)
	{
		return false;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public List<CSaveData.WRITEDATA> CreateAutoSaveList(CSaveData.STAT stat)
	{
		return null;
	}

	public void ReplaceUI(GameController.PADNUM padNum)
	{
	}

	private void SetExecPlayerArrow()
	{
	}

	private void SetPlayerRig()
	{
	}

	private void SetPlayerOrder()
	{
	}

	public List<CFieldPlayer> GetPlayerList()
	{
		return null;
	}

	public int GetExecPlayerIndex()
	{
		return 0;
	}

	public CFieldPlayer[] GetPlayerOrder()
	{
		return null;
	}

	public List<CFieldPlayer> GetPlayerOrderList()
	{
		return null;
	}

	public int GetPlayerNum()
	{
		return 0;
	}

	public CFieldPlayer GetPlayerToIndex(int i)
	{
		return null;
	}

	public CFieldPlayer GetPlayerMe()
	{
		return null;
	}

	public List<CFieldPlayer> GetPlayer(Vector3Int v, CONDITION_GETPLAYER condition = CONDITION_GETPLAYER.None)
	{
		return null;
	}

	public CFieldPlayer GetPlayer(CEventEnum.EVID evid = CEventEnum.EVID._EXEC_PLAYER)
	{
		return null;
	}

	public void ResetPlayerCamera()
	{
	}

	public void ResetCursor()
	{
	}

	public void SetCursorPositionPlayer(CFieldPlayer player, Vector3Int p)
	{
	}

	public CFieldNewDice RollThe_MoveDice()
	{
		return null;
	}

	public CFieldNewDice RollThe_Dice(bool cansel = false)
	{
		return null;
	}

	public void Show_MultipleDiceNum(bool a)
	{
	}

	public void Update_MultipleDiceNum()
	{
	}

	public CHexPosition GetCHexPosition(CFieldPlayer ply)
	{
		return null;
	}

	public CHexPosition GetCHexPosition(Vector3Int pos)
	{
		return null;
	}

	public CEventEnum.EVID GetFreeEVID_Enemy()
	{
		return CEventEnum.EVID._000;
	}

	public void AddEnemy(CFieldEnemy ene)
	{
	}

	public int GetEnemyCount()
	{
		return 0;
	}

	public CFieldEnemy GetEnemyHexPosition(Vector3Int hp, bool remove = false)
	{
		return null;
	}

	public CFieldEnemy GetEnemyPlayerPosition(bool remove = false)
	{
		return null;
	}

	public CFieldEnemy GetEnemyEVID(CEventEnum.EVID evid)
	{
		return null;
	}

	public CFieldEnemy GetEnemyGroupID(string group)
	{
		return null;
	}

	public CFieldEnemy GetNearEnemy(int num)
	{
		return null;
	}

	public void DestroyEnemy(CFieldEnemy ene)
	{
	}

	public CEventEnum.EVID GetFreeEVID_EventObject()
	{
		return CEventEnum.EVID._000;
	}

	public CFieldEventObject GetEventObject(CEventEnum.EVID evid)
	{
		return null;
	}

	public CFieldEventObject AddEventObject(string id, CEventEnum.EVID evid, CHexPosition hp)
	{
		return null;
	}

	public CFieldEventObject GetEventObject(Vector3Int hp)
	{
		return null;
	}

	public CFieldEventObject GetEventObject()
	{
		return null;
	}

	public CFieldEventObject GetNearEventObject(int num, string kind)
	{
		return null;
	}

	public void DeleteEventObject(CFieldEventObject evt, bool destroy = true)
	{
	}

	public int GetTresureboxCount()
	{
		return 0;
	}

	public CFieldTBox GetTBox(Vector3Int hp)
	{
		return null;
	}

	public CFieldTBox GetTBox()
	{
		return null;
	}

	public void DeleteTBox(CFieldTBox t, bool destroy = true)
	{
	}

	public CFieldTBox GetNearTreasure(int num)
	{
		return null;
	}

	public CParamMission GetMission(Vector3Int hp)
	{
		return null;
	}

	public CHexPosition GetNearLadder(int num)
	{
		return null;
	}

	public bool IsSetLadder(Vector3Int a)
	{
		return false;
	}

	public void UpdateLadder(Vector3Int a)
	{
	}

	public void CharHexSort(int target = -1, float ts = 0.1f, CCharDef moveChar = null, bool last = false, CFieldMove.STATE state = CFieldMove.STATE.None)
	{
	}

	public List<List<CCharDef>> GetIdentityHexChar(int start = -1)
	{
		return null;
	}

	private bool MouseWheel_CameraDistance()
	{
		return false;
	}

	private bool GamePad_LookOtherPlayer(GamePad pad)
	{
		return false;
	}

	private bool GamePad_LookOtherPlayer(uint bit)
	{
		return false;
	}

	private void FindMove(int select = 0)
	{
	}

	public void ClearingClouds(List<CHexCloud> clouds, Vector3Int p, List<CHexCloud> save = null)
	{
	}

	public void ReturnClouds(Vector3Int pos)
	{
	}

	private void ClearRoute()
	{
	}

	private void MakeRoute()
	{
	}

	public void HexinfoActive(bool a)
	{
	}

	private void UpdateHexInfo(Vector3Int p, bool walk = false)
	{
	}

	public int GetSellPrice(CMaster_ItemData item)
	{
		return 0;
	}

	public bool IsEventBattle()
	{
		return false;
	}

	private void CB_LoadingCompleteBattle(Scene s)
	{
	}

	private void MakeWall(GameObject g)
	{
	}

	private void EscapeBattle()
	{
	}

	public void ReturnFromBattle()
	{
	}

	[AsyncStateMachine(typeof(_003C_ReturnFromBattle_003Ed__319))]
	public UniTask _ReturnFromBattle(CancellationToken cancel)
	{
		return default;
	}

	private void SetAudioListenerFocusPoint()
	{
	}

	public bool IsEnableStatusPopup()
	{
		return false;
	}

	public void HideGameField()
	{
	}

	public void PlayEnvironmentSE()
	{
	}

	public void StopEnvironmentSE(int msec = 0)
	{
	}

	public void PlayEnvironmentSE(string type)
	{
	}

	public void StopEnvironmentSE(string type, int msec)
	{
	}

	public static void TrackingDevilsWhisperSE(long handle, DevilsWhisperSEType seType = DevilsWhisperSEType.None)
	{
	}

	public static Vector3 GetDevilsWhisperSEInitialPosition()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003C_TrackingDevilsWhisperSE_003Ed__333))]
	private static UniTask _TrackingDevilsWhisperSE(long handle, DevilsWhisperSEType seType)
	{
		return default;
	}

	private static Vector3 _GetSEPosition(float elapsedTime, DevilsWhisperSEType seType)
	{
		return default;
	}

	public void ShowSoulPoint()
	{
	}

	public void ShowBonusSoulPoint()
	{
	}

	public void HideSoulPoint()
	{
	}

	[IteratorStateMachine(typeof(_003C_HideSoulPoint_003Ed__338))]
	private IEnumerator _HideSoulPoint()
	{
		return null;
	}

	public void SkipMapAnimation()
	{
	}

	public void SetupCameraShake()
	{
	}

	public void StartCameraQuake(float i_Amplitude, float i_Time, float i_AttackTime, float i_DecayTime)
	{
	}

	[IteratorStateMachine(typeof(_003C_Quake_003Ed__351))]
	private IEnumerator _Quake(float i_Amplitude, float i_Time, float i_AttackTime, float i_DecayTime)
	{
		return null;
	}

	public void StopCameraQuake()
	{
	}

	public void MuteCameraQuake()
	{
	}

	public bool IsCameraShake()
	{
		return false;
	}

	public CHexPosition EnemyEntry_Range(Vector3Int center, int range, UtpnRandom rnd)
	{
		return null;
	}

	public CHexPosition EnemyEntry_Area(string area, UtpnRandom rnd)
	{
		return null;
	}

	public CHexPosition EnemyEntry_Height(int height, UtpnRandom rnd)
	{
		return null;
	}

	private bool IsHexFree(CHexPosition hex)
	{
		return false;
	}

	public void UIOn(FLDUI[] list)
	{
	}

	public void UIOn(FLDUI ui)
	{
	}

	public void UIOff(FLDUI[] list)
	{
	}

	public void UIOff(FLDUI ui)
	{
	}

	public void CameraFollow_ExecPlayer()
	{
	}

	private void Menu_Dice()
	{
	}

	private void Menu_Status()
	{
	}

	private void Menu_Item()
	{
	}

	private void Menu_Mission()
	{
	}

	private void Check_Map()
	{
	}

	private void KEYASSIGN_CheckMap()
	{
	}

	private void KEYASSIGN_CheckTown(bool all)
	{
	}

	public void SetAutoMMeshfade(bool set)
	{
	}

	private bool IsAutoMMeshfade(Vector3Int playerHex, Vector3Int dstHex, bool set)
	{
		return false;
	}

	public bool Free_CheckMap(bool debug = false)
	{
		return false;
	}

	public List<CFieldLight> GetFieldLights()
	{
		return null;
	}

	public CFieldLight GetFieldLight(int i)
	{
		return null;
	}

	public void AddLight(int i, Light light)
	{
	}

	private List<object> SaveLight()
	{
		return null;
	}

	public bool IsFadeLight()
	{
		return false;
	}

	public CParamMission AddMission(CMaster_MissionListData mission, CFieldPlayer player = null)
	{
		return null;
	}

	public void Online_AddMission(CParamMission pMiss)
	{
	}

	public List<CParamMission> GetAllMissions()
	{
		return null;
	}

	public List<CParamMission> GetMissionList()
	{
		return null;
	}

	public bool MakeMissionList(CFieldPlayer player, ref List<CParamMission> list, bool sort = true)
	{
		return false;
	}

	public List<CParamMission> GetKillMission(List<string> enemy_ids)
	{
		return null;
	}

	public void AddKillEnemy(List<string> enemy_ids)
	{
	}

	public void GetClearedKillMission(ref List<CParamMission> tmp)
	{
	}

	public List<CParamMission> GetDeliveryMission(CFieldPlayer player, string item_id)
	{
		return null;
	}

	public void GetClearedCollectMission(ref List<CParamMission> tmp)
	{
	}

	public List<CParamMission> GetCleared_FlagWorkMission(CFieldPlayer player = null)
	{
		return null;
	}

	public bool ClearMission(CFieldPlayer player, CParamMission m)
	{
		return false;
	}

	public bool WithdrawMission(CMaster_MissionListData mission)
	{
		return false;
	}

	public int CheckMissionStatus(string id)
	{
		return 0;
	}

	public int GetMissionClearAll()
	{
		return 0;
	}

	public static void GetIsControlIsOnline(out bool IsControl, out bool IsOnline)
	{
		IsControl = default;
		IsOnline = default;
	}

	public bool IsOffline()
	{
		return false;
	}

	public bool IsOnline()
	{
		return false;
	}

	public bool SetControlPlayer(CFieldPlayer player = null, bool dispTurnPlayer = false)
	{
		return false;
	}

	public bool IsControl()
	{
		return false;
	}

	public bool Online_IsControl()
	{
		return false;
	}

	public bool Online_IsUnControl()
	{
		return false;
	}

	private void Online_MakePlayerOrder()
	{
	}

	public CFieldPlayer GetThisDevicePlayer()
	{
		return null;
	}

	public List<CFieldPlayer> GetThisDevicePlayerList()
	{
		return null;
	}

	public List<Dictionary<string, object>> CreateParamPlayerAll()
	{
		return null;
	}

	public void SetParamPlayerAll(JsonNode array)
	{
	}

	public bool Online_IsError()
	{
		return false;
	}

	private bool CheckOnlineError(COnline _online)
	{
		return false;
	}

	private void SetDialog(string a)
	{
	}

	private void ErrorDialog()
	{
	}

	public bool GetEnableCheckLeaveMember()
	{
		return false;
	}

	public void SetEnableCheckLeaveMember(bool a)
	{
	}

	public bool Online_IsLeaveMember()
	{
		return false;
	}

	private bool Online_CheckLeaveMember(bool forcedActivation = false, string reason = null)
	{
		return false;
	}

	private void LeaveGame()
	{
	}

	private bool Online_NewGame_Initialize()
	{
		return false;
	}

	public static int CheckVersion(string path, JsonNode save)
	{
		return 0;
	}

	public Dictionary<string, object> SaveAll(CSaveData.STAT stat)
	{
		return null;
	}

	private string Json_Base64(JsonNode json)
	{
		return null;
	}

	public static JsonNode Base64_Json(string base64)
	{
		return null;
	}

	public static bool CheckSaveData(string path, JsonNode field)
	{
		return false;
	}

	private bool Move_MouseDragCamera(string onlineKey)
	{
		return false;
	}

	private bool Move_StickCamera(GamePad pad, string onlineKey = null)
	{
		return false;
	}

	private bool Move_HexCursor(GamePad pad, string onlineKey = null)
	{
		return false;
	}

	private bool Received_StickCamera(string onkineKey)
	{
		return false;
	}

	private bool Received_HexCursor(string onlineKey)
	{
		return false;
	}

	public void InitSelectHex_Message(string a)
	{
	}

	public void InitSelectHex(CFieldPlayer player, SELECTHEX_MODE mode)
	{
	}

	public SELECT_HEX GetSelectHex()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSelectHex_003Ed__449))]
	public UniTask<bool> SelectHex(CancellationToken token)
	{
		return default;
	}

	public int SelectHex()
	{
		return 0;
	}

	private bool CheckSelectHex()
	{
		return false;
	}

	private void UpdateButtonExplanation()
	{
	}

	private bool Mouse_EdgeScroll()
	{
		return false;
	}

	private CHexPosition Mouse_HexSelect(GamePad mouse)
	{
		return null;
	}

	private bool GetHexName_To_V3int(Transform t, out Vector3Int v3)
	{
		v3 = default;
		return false;
	}

	[AsyncStateMachine(typeof(_003CInitialize_WillToken_003Ed__459))]
	private UniTask Initialize_WillToken(JsonNode saveField)
	{
		return default;
	}

	public static void SetPlayerSetting(int numPlayers, int numPiece, CGameRoom_Table.PLAYER_SETTING[] setting)
	{
	}

	public static void SetOnlinePlayer(CGameRoom_Table.ONLINE_PLAYER[] players)
	{
	}

	public float[] MakePieceAngle()
	{
		return null;
	}

	public bool IsEndStart()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__475))]
	private UniTaskVoid Start()
	{
		return default;
	}

	private void RestoreAllMembersMission(JsonNode array, List<CParamMission> list)
	{
	}

	private void CB_LoadingCompleteLight(Scene scene)
	{
	}

	private void WakeupVolume(float i_Seconds)
	{
	}

	[AsyncStateMachine(typeof(_003C_WakeupVolume_003Ed__479))]
	private UniTask _WakeupVolume(float i_Seconds)
	{
		return default;
	}

	private void _UpdateFloorOffset(float i_Offset)
	{
	}

	private void Hidden_RoomObject()
	{
	}

	public void Show_RoomObject()
	{
	}

	private float GetPieceAngle()
	{
		return 0f;
	}

	[AsyncStateMachine(typeof(_003CInitialize_Enemy_003Ed__486))]
	private UniTask Initialize_Enemy(JsonNode saveField)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CInitialize_EventObject_003Ed__487))]
	private UniTask Initialize_EventObject(JsonNode saveField)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CInitialize_Map_003Ed__488))]
	private UniTask Initialize_Map(JsonNode saveField)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CInitialize_Player_003Ed__489))]
	private UniTask Initialize_Player(JsonNode saveField)
	{
		return default;
	}

	private void TimeSaving(CFieldPlayer fp)
	{
	}

	private int Extraction_JobCard(CFieldPlayer fp, int[] probability, ref List<JOBCARD> jobCard, List<CMaster_SkillCardData> cardList, bool possessionExempt)
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003CInitialize_Tresure_003Ed__493))]
	private UniTask Initialize_Tresure(JsonNode saveField)
	{
		return default;
	}

	public CFieldTBox AddTresure(string id, CHexPosition hp)
	{
		return null;
	}

	public void SetVisitedTown(HEX_TOWN town)
	{
	}

	public int GetVisitedTownCount()
	{
		return 0;
	}

	public bool IsVisitedTown(HEX_TOWN town)
	{
		return false;
	}

	public List<HEX_TOWN> GetVisitedTown()
	{
		return null;
	}

	public HEX_TOWN GetTown(Vector3Int hp)
	{
		return null;
	}

	public HEX_TOWN GetTown(string id)
	{
		return null;
	}

	public CHexPosition GetTownToHex(string id)
	{
		return null;
	}

	public CHexPosition GetNearTown(int num)
	{
		return null;
	}

	private List<List<CFieldPlayer>> MakeDupTownsPlayer(CFieldPlayer moveChar = null)
	{
		return null;
	}

	private List<CFieldPlayer> SearchDupTownsList(CFieldPlayer player, ref int index)
	{
		return null;
	}

	public void JobMedalSort(bool imm = false, CFieldPlayer moveChar = null)
	{
	}

	private void MakeTowns()
	{
	}

	private void RemoveTown(CHexPosition town, List<CHexPosition> list)
	{
	}

	private void RestoreTowns(JsonNode array)
	{
	}
}
