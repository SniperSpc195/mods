using System;
using System.Collections.Generic;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Fork.Game;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class CEventScript : MonoBehaviour
{
	public enum TIMING
	{
		GAMEROOM_enter_room = 0,
		GAMEROOM_return_room = 1,
		GAMEROOM_facility_before = 2,
		GAMEROOM_facility_after = 3,
		GAMEROOM_talk_gamemaster = 4,
		GameStart = 5,
		TurnStart = 6,
		BaseLevelup_2 = 7,
		BaseLevelup_3 = 8,
		DiceAfter = 9,
		MoveEnd = 10,
		BattleBefore = 11,
		BattleAfter = 12,
		TurnEnd = 13,
		Turn_0 = 14,
		GameOver = 15,
		Max = 16
	}

	public enum STACK_TYPE
	{
		Start = 0,
		Call = 1
	}

	private class EXEC_STACK
	{
		public STACK_TYPE mType;

		public CEventBinary.EVENT_DATA mEventData;

		public int mIndex;

		public EXEC_STACK(STACK_TYPE type, CEventBinary.EVENT_DATA data, int index)
		{
		}

		public byte[] GetByte()
		{
			return null;
		}

		public bool IsCall()
		{
			return false;
		}
	}

	private enum TY
	{
		_NONE = 255,
		_I = 1,
		_F = 2,
		_A = _F,
		_P = _F,
		_PY = 3,
		_COLOR = 4,
		_ADR = 10,
		_STR = 20,
		_MSG = 21,
		_EVID = 30,
		_MESWIN = 31,
		_SWITCH = 32
	}

	private class LOAD_MODEL
	{
		public CEventEnum.EVID mEVID;

		private string mPath;

		private CMaster_ModelData mModelData;

		private CMaster_EnemyGroupData mEnemyGroup;

		private GameObject mParentGameObject;

		private AsyncOperationHandle<GameObject> mHandle;

		public bool mLoad;

		public static string MakePath(string model_id)
		{
			return null;
		}

		public LOAD_MODEL(Scene scene, Transform parent, CEventEnum.EVID evid, string model_id)
		{
		}

		public LOAD_MODEL(Scene scene, Transform parent, CEventEnum.EVID evid, CMaster_EnemyGroupData data)
		{
		}

		public bool IsNpc()
		{
			return false;
		}

		public bool IsFieldEnemy()
		{
			return false;
		}

		public bool IsLoadEnd()
		{
			return false;
		}

		public CEventNpc GetNpc()
		{
			return null;
		}

		public CFieldEnemy GetFieldEnemy()
		{
			return null;
		}

		private void SetPrefabParent()
		{
		}

		public void Release(Scene scene)
		{
		}
	}

	private class SCENE_GAMEOBJECT
	{
		public string mScene;

		public string mName_Transform;

		public GameObject mGameObject;

		private CAnimePlayer mAnimePlayer;

		public Transform GetTransform()
		{
			return null;
		}

		public SCENE_GAMEOBJECT(GameObject g, string scene, string transform)
		{
		}

		public bool IsExist()
		{
			return false;
		}

		public CAnimePlayer GetAnimePlayer()
		{
			return null;
		}
	}

	private class DiceControle
	{
		private enum MODE
		{
			Dice = 0,
			Dice_Wait = 1,
			Hit_Wait = 2,
			Exit_Menu = 3,
			End = 4
		}

		private CFieldNewDice mFieldNewDice;

		private int mGetIndex;

		private CUIGenericMenu mRouletteMenu;

		private CUIGenericOpenClose mRouletteOpenClose;

		private double mTime;

		private MODE mMode;

		public DiceControle(CFieldNewDice dice, CUIGenericMenu menu, string[] text)
		{
		}

		public int GetRestDiceNum()
		{
			return 0;
		}

		public bool Exec()
		{
			return false;
		}

		private void SelectRoulette(int n)
		{
		}

		private void Close_SelectRoulette()
		{
		}
	}

	private class MovingForward
	{
		public Camera mCamera;

		public Vector3 mStartCamera;

		public Vector3 mStartLookAt;

		public Vector3 mEndPosition;

		public float mLerp;

		public float mSpeed;

		public MovingForward(Camera mainCamera, CinemachineVirtualCamera dollyCamera, float dist, float speed)
		{
		}

		public bool Update()
		{
			return false;
		}
	}

	private class SINGLE_CLOUD
	{
		public CHexCloud mCloud;

		public float mWait;

		public SINGLE_CLOUD(CHexCloud cloud, float time = 0.5f)
		{
		}

		public bool Wait()
		{
			return false;
		}
	}

	private class ObtainCard
	{
		private enum MODE
		{
			None = 0,
			Load_Scene = 1,
			Initializing = 2,
			Wait = 3,
			Exit = 4,
			End = 5
		}

		private UniTask<CCardSelector>.Awaiter mAwaiter;

		private CCardSelector mSelector;

		private CFieldPlayer mPlayer;

		private bool mSetPossession;

		private MODE mMode;

		public ObtainCard(CFieldMain fMain, CFieldPlayer player, string card)
		{
		}

		public bool IsEnd()
		{
			return false;
		}

		public bool IsThrough()
		{
			return false;
		}

		public void Exit()
		{
		}

		public void Get()
		{
		}

		public void Update()
		{
		}
	}

	private class TABLE_JUMP
	{
		public string mWork;

		public int mNum;

		public int mIndex;

		public TABLE_JUMP(int num, int i)
		{
		}

		public TABLE_JUMP(string work, int i)
		{
		}

		public int GetNum(CEventScript evt)
		{
			return 0;
		}

		public bool Check(CEventScript evt, int i, int rnd, ref string log)
		{
			return false;
		}
	}

	private class CARD_SELECT
	{
		public bool mSelect;

		public bool mCancel;

		public void Start()
		{
		}

		public void End(bool cancel)
		{
		}
	}

	private enum I_CARD_SELECT
	{
		Dispose = 0,
		Upgrade = 1
	}

	private class EraseRandomItems
	{
		public List<PairStrInt> mErases;

		public List<CMaster_ItemData> mItems;

		public EraseRandomItems()
		{
		}

		public EraseRandomItems(Dictionary<string, int> eraseItems, List<CMaster_ItemData> items)
		{
		}

		public EraseRandomItems(JsonNode json)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public Dictionary<string, object> Save()
		{
			return null;
		}

		public void SetItem(CFieldPlayer player)
		{
		}
	}

	public static float[] mFastWait;

	private static string mAddressablePath;

	private Dictionary<string, CEventBinary> mEventData;

	private string[][] mTimingEventID;

	private byte[] mExecData;

	private int mExecIndex;

	private List<EXEC_STACK> mExecStack;

	private float mWait;

	private UtpnRandom mEventRandom;

	[SerializeField]
	private CFieldMain mFieldMain;

	[SerializeField]
	private CinemachineVirtualCamera mVCam;

	[SerializeField]
	private CFramingCamera mFramingCamera;

	[SerializeField]
	private Transform[] mLookAt;

	[SerializeField]
	private CEventMessage[] mEventMessage;

	[SerializeField]
	private CEventChoices mEventChoices;

	[SerializeField]
	private Transform mUIDiceTbox;

	[SerializeField]
	private Transform[] mTransformEffect;

	[SerializeField]
	private Transform mTransformCamFollow;

	[SerializeField]
	private List<CEffectHandle> mEffect;

	[SerializeField]
	private CFieldSlide mFieldSlide;

	[SerializeField]
	private Transform mLoadParent;

	[SerializeField]
	private float[] mAppearanceDist;

	private CFieldNewDice mFieldNewDice;

	private CFieldTBox mExecTBox;

	private uint mSyncCount;

	private string mSyncName;

	private int mEnemyPreemptive;

	private CMaster_EnemyGroupData mEnemyGroupData;

	private bool mBattleInterrupted;

	private bool mBattleBoss;

	private CFieldSound mLastFadeBGM;

	private CEventGrant mEventGrant;

	private bool mStartPosition;

	private CMission_NewResult mMission_NewResult;

	private bool mDebugExec;

	private string[] mCommand;

	private static string[] EventFileList;

	private List<LOAD_MODEL> mLoadModel;

	private List<LOAD_MODEL> mCompModel;

	private List<CEventNpc> mNpc;

	private List<CFieldEnemy> mFieldEnemy;

	private bool mMotionWait;

	private float mMotionFrame;

	private CAnimePlayer.TYPE aType;

	private CHexPosition mEnemyEntryHex;

	private bool mMoveCamera;

	private bool mEnable_CameraReset;

	private long mLookAt_Time;

	private float mDifference_EulerAngles;

	private Vector3 mLookAt_EulerAngles;

	private SCENE_GAMEOBJECT mSceneGameObject;

	private string[] mDiceText;

	private DiceControle mDiceControle;

	private CHexPosition mEvtObjEntryHex;

	private CEventEnum.EVID mEvtObjEntryEVID;

	private Vector3Int mHexAppearance;

	private int mDisplayAcquiredSoulpoints;

	private double mDisplaySoulpointsTime;

	private bool mSaveSoulpoints;

	private CEffectHandle mEndRoll;

	private bool mGMAnimation;

	private MovingForward mMovingForward;

	private CHexPosition mCheckHex;

	private string mCheckHexID;

	private SINGLE_CLOUD mSingleCloud;

	private CEventMessage.BALLOON_SETTING mBalloonSetting;

	private List<Tuple<string, int>> mSelfChoice;

	private string[] mSelfLines;

	private ObtainCard mObtainCard;

	private List<TABLE_JUMP> mTableJump;

	private List<TABLE_JUMP> mExcludeHits_TableJump;

	private int backMode;

	private CItemPopup m_Congratulations;

	private float mCameraWait;

	private List<string> mDroprankName;

	private List<int> mDroprankNum;

	private int[] FloorMagnification;

	private int[] DescendingFloorMagnification;

	private CARD_SELECT[] mCardSelect;

	private bool mAbilityRoulette;

	private CFieldShop_New mShopNew;

	private bool mReadingTutorial;

	public static void SetAddressablePath(string a)
	{
	}

	public Dictionary<string, CEventBinary> GetEventData()
	{
		return null;
	}

	public void SetupButtonUI(GameController.PADNUM num)
	{
	}

	public int GetEnemyPreemptive()
	{
		return 0;
	}

	public bool IsEnemyGroupData()
	{
		return false;
	}

	public CMaster_EnemyGroupData GetEnemyGroupData()
	{
		return null;
	}

	public bool IsBattleInterrupted()
	{
		return false;
	}

	public bool IsBossBattle()
	{
		return false;
	}

	public void SetBattleInterrupted(bool a)
	{
	}

	public void GetStartPosition(out bool ret)
	{
		ret = default;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public bool IsControl()
	{
		return false;
	}

	public bool IsOnline()
	{
		return false;
	}

	public void AssetLoadScript(bool isOnline = false)
	{
	}

	public void SetupTimingGameRoom()
	{
	}

	public void SetupTimingStage(string stageID)
	{
	}

	public void AddressableLoad(string filename)
	{
	}

	private string[] SetupEventDataKey(string timing)
	{
		return null;
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsExec()
	{
		return false;
	}

	public bool EventGo(TIMING timing)
	{
		return false;
	}

	public void EventGoID(string id)
	{
	}

	private bool Startup(STACK_TYPE stackType, string evtKey, string evtID)
	{
		return false;
	}

	public void PushStack(STACK_TYPE type, CEventBinary.EVENT_DATA data, int index)
	{
	}

	public void PushStack(STACK_TYPE type, int index)
	{
	}

	public bool PosStack()
	{
		return false;
	}

	private EXEC_STACK GetStackEnd()
	{
		return null;
	}

	private int GetValue_EventListData(string valueKey)
	{
		return 0;
	}

	public int GetFlagWorkNum(string key)
	{
		return 0;
	}

	public CDefine.GameFlag GetFlag(string key, out int num)
	{
		num = default;
		return null;
	}

	public CDefine.GameWork GetWork(string key, out int num)
	{
		num = default;
		return null;
	}

	private void Update()
	{
	}

	private CEventEnum.EVID GetEVID(int i)
	{
		return CEventEnum.EVID._000;
	}

	private CEventEnum.SW GetSW(int i)
	{
		return CEventEnum.SW._JMP;
	}

	private int GetInt(int i)
	{
		return 0;
	}

	private uint GetUInt(int i)
	{
		return 0u;
	}

	private float GetFloat(int i)
	{
		return 0f;
	}

	private short GetShort(int i)
	{
		return 0;
	}

	private ushort GetUShort(int i)
	{
		return 0;
	}

	private Vector2 GetVector2(int i)
	{
		return default;
	}

	private Vector3 GetVector3(int i)
	{
		return default;
	}

	private string GetString(int i)
	{
		return null;
	}

	private string GetString(int i, ref int nextData)
	{
		return null;
	}

	private string GetStringSJIStoUTF8(int i)
	{
		return null;
	}

	private CCharDef GetEVID_CCharDef(CEventEnum.EVID evid)
	{
		return null;
	}

	private Transform GetEVID_Transform(CEventEnum.EVID evid)
	{
		return null;
	}

	private CAnimePlayer GetEVID_AnimePlayer(CEventEnum.EVID evid)
	{
		return null;
	}

	private int GetCommand()
	{
		return 0;
	}

	private int NextCommand()
	{
		return 0;
	}

	private void ExecCommand()
	{
	}

	private bool STRIDtoVector3(string strID, out Vector3 target)
	{
		target = default;
		return false;
	}

	private bool IsEVID_Npc(CEventEnum.EVID evid)
	{
		return false;
	}

	private bool IsEVID_Enemy(CEventEnum.EVID evid)
	{
		return false;
	}

	private bool DuplicateCheckEVID(CEventEnum.EVID evid)
	{
		return false;
	}

	private void LoadModel(CEventEnum.EVID evid, string model_id)
	{
	}

	private void LoadModel(CEventEnum.EVID evid, CMaster_EnemyGroupData data)
	{
	}

	private void ReleaseModel(CEventEnum.EVID evid = CEventEnum.EVID._NONE)
	{
	}

	private bool LoadMonitoring()
	{
		return false;
	}

	private bool Command_Anime(int cIndex)
	{
		return false;
	}

	private bool Command_Battle(int cIndex)
	{
		return false;
	}

	private void CameraReset()
	{
	}

	private bool Command_CAM(int cIndex)
	{
		return false;
	}

	private bool Command_CHR(int cIndex)
	{
		return false;
	}

	private bool Command_DevilsWhispers(int cIndex)
	{
		return false;
	}

	private bool Command_DICE(int cIndex)
	{
		return false;
	}

	private List<CEffectHandle> GetEffectName(string name)
	{
		return null;
	}

	private List<CEffectHandle> GetEffectEvid(CEventEnum.EVID evid)
	{
		return null;
	}

	private bool Command_EFFECT(int cIndex)
	{
		return false;
	}

	private CFieldLight GetFieldLight(int cIndex)
	{
		return null;
	}

	private bool IsEffectLoadEnd(List<CEffectHandle> list)
	{
		return false;
	}

	private bool IsEffectPlayEnd(List<CEffectHandle> list)
	{
		return false;
	}

	private bool IsEffectLoopOver(List<CEffectHandle> list, int sCount)
	{
		return false;
	}

	private bool IsEffectFrameOver(List<CEffectHandle> list, float frame)
	{
		return false;
	}

	private void EffectDestroy(List<CEffectHandle> list)
	{
	}

	private void EffectLoopOff(List<CEffectHandle> list)
	{
	}

	private bool Command_EventObject(int cIndex)
	{
		return false;
	}

	private bool Command_Flag(int cIndex)
	{
		return false;
	}

	private void GMAnimationActive(bool a)
	{
	}

	private bool Command_GameRoom(int cIndex)
	{
		return false;
	}

	private bool Command_Hex(int cIndex)
	{
		return false;
	}

	private bool IsBalloon(CEventEnum.MESWIN a)
	{
		return false;
	}

	private CEventEnum.MESWIN GetMESWIN(int i)
	{
		return CEventEnum.MESWIN._SYSTEM;
	}

	private CEventMessage GetMessageWindow(int cIndex)
	{
		return null;
	}

	public CEventMessage GetMessageWindow(CEventEnum.MESWIN meswin)
	{
		return null;
	}

	private bool Command_MES(int cIndex)
	{
		return false;
	}

	private bool Command_MISSION(int cIndex)
	{
		return false;
	}

	private bool Command_Obtainin(int cIndex)
	{
		return false;
	}

	private bool RandomCondition(int rNum, string condition, int num)
	{
		return false;
	}

	private int GetRandomNum_Control(string send_cmd, int rMax)
	{
		return 0;
	}

	private bool GetRandomNum_OtherControl(string send_cmd, out int rNum, out int max)
	{
		rNum = default;
		max = default;
		return false;
	}

	private bool Command_Random(int cIndex)
	{
		return false;
	}

	private bool Command_Rewards(int cIndex)
	{
		return false;
	}

	private bool Command_SOUND(int cIndex)
	{
		return false;
	}

	private void ResumeBGM()
	{
	}

	private bool Command_StageClear(int cIndex)
	{
		return false;
	}

	private int GetSubCommandNameLastNum()
	{
		return 0;
	}

	private int GetFloorMagnification(int floor)
	{
		return 0;
	}

	private bool Command_Status(int cIndex)
	{
		return false;
	}

	private bool CheckPossession(int cIndex, int max, CFieldPlayer player)
	{
		return false;
	}

	private bool CheckPossessionAllPlayer(int cIndex, int max)
	{
		return false;
	}

	private bool Command_Status_ID(int cIndex)
	{
		return false;
	}

	private List<PairStrInt> MakeGrantID(string cmd, int cIndex, int num, string type)
	{
		return null;
	}

	private List<string> MakeGrantAbility(string cmd, int cIndex, int num)
	{
		return null;
	}

	private EraseRandomItems MakeEraseRandomItems(int eraseNum)
	{
		return null;
	}

	private List<PairStrInt> MakeEraseItems(int cIndex, int max)
	{
		return null;
	}

	private List<PairStrInt> MakeEraseCards(int cIndex, int max)
	{
		return null;
	}

	private List<string> MakeEraseAbility(int cIndex, int max)
	{
		return null;
	}

	private List<string> MakeErase_RandomAbility(int max)
	{
		return null;
	}

	private List<string> MakeEraseCondition(int cIndex, int max)
	{
		return null;
	}

	private bool Command_SYS(int cIndex)
	{
		return false;
	}

	private bool Command_TBOX(int cIndex)
	{
		return false;
	}

	private bool Command_Town(int cIndex)
	{
		return false;
	}

	private bool IsValidTutorial(string tuto_id)
	{
		return false;
	}

	private bool Command_Tutorial(int cIndex)
	{
		return false;
	}

	private bool Command_Work(int cIndex)
	{
		return false;
	}

	private void WorkCalc(CDefine.GameWork work, int index, string opration, int num)
	{
	}

	private bool WorkCondition(CDefine.GameWork work, int index, string condition, int num)
	{
		return false;
	}

	private bool CopyParam(CDefine.GameWork dstWork, int dstIndex, string srcName, CFieldPlayer player = null)
	{
		return false;
	}

	private bool GetDictionaryCount(string cmdName, CDefine.DictionaryCount dict, string id, out int prm)
	{
		prm = default;
		return false;
	}

	private bool OnlinePrm(string cmdName, int sendPrm, out int prm)
	{
		prm = default;
		return false;
	}
}
