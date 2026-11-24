using System;
using System.Collections.Generic;
using Cinemachine;
using TMPro;
using UnityEngine;
using net;

public class CGameRoom_Table : MonoBehaviour
{
	public enum TOPMENU
	{
		Offline = 0,
		Internet = 1,
		Continue = 2
	}

	private enum CONT_TYPE
	{
		None = 0,
		Select = 1,
		Resume = 2
	}

	private enum MODE
	{
		None = 0,
		Select_PlayMode = 1,
		Continue = 2,
		Online_SelectHostClient = 3,
		Online_Initialize = 4,
		Online = 5,
		Online_Continue = 6,
		Local_SelectSave = 7,
		Local_SelectSave_1 = 8,
		Local_SelectStage = 9,
		Local_SelectNumPlayer = 10,
		Local_SelectNumPlayer_2x3 = 11,
		Local_Before_SelectController = 12,
		Local_SelectController = 13,
		Local_InputName = 14,
		Local_SelectName = 15,
		Local_ModelWait = 16,
		Local_SelectJob = 17,
		Local_SelectedEnd = 18,
		Local_SelectedInquily = 19,
		Local_InquilyYes = 20,
		End = 21
	}

	private enum ONLINE_MODE
	{
		None = 0,
		Cancel = 1,
		Start_Internet = 2,
		Connect_Internet = 3,
		Connect_Wait = 4,
		LoadFriend = 5,
		LoadBlock = 6,
		Error = 7,
		Setting_SaveSlot = 8,
		Setting_Host = 9,
		Host_Start_LoadFriend = 10,
		Host_LoadFriend = 11,
		CreateRoom = 12,
		Failed_CreateRoom = 13,
		Host_EnterDialog = 14,
		Host_Before_SelectController = 15,
		Host_SelectController = 16,
		Host_SelectJob_Start = 17,
		Host_SelectJob = 18,
		Host_Leave_Inquily = 19,
		Host_LeaveRoom = 20,
		Host_Lobby_Start = 21,
		Host_Lobby_Wait = 22,
		Host_Lobby_Return = 23,
		Host_GameStart_Inquily = 24,
		Host_GameStart_Inquily_Cancel = 25,
		Host_CloseRoom = 26,
		Host_GameStart = 27,
		Host_GameStart_Wait = 28,
		Host_ForcedExit = 29,
		Sync_GameStart = 30,
		Wait_Fade = 31,
		ToField = 32,
		Setting_Client = 33,
		Client_StartBefore_LoadFriend = 34,
		Client_Before_LoadFriend = 35,
		Client_Before_LoadBlock = 36,
		SearchRoom = 37,
		Client_SelectRoom = 38,
		Client_StartEnter_LoadFriend = 39,
		Client_Enter_LoadFriend = 40,
		Client_Enter_LoadBlock = 41,
		Client_EnterRoom = 42,
		Client_Failed_EnterRoom = 43,
		Client_EnterWait = 44,
		Client_EnterDialog = 45,
		Client_Before_SelectController = 46,
		Client_SelectController = 47,
		Client_SelectJob_Start = 48,
		Client_SelectJob = 49,
		Client_LeaveInquily = 50,
		Client_Leave = 51,
		Client_Leave_End = 52,
		Client_Lobby_Start = 53,
		Client_Lobby_Wait = 54,
		Client_Lobby_Return = 55,
		Client_WaitStart = 56,
		Client_Wait_ForceExit = 57,
		Continue_SearchRoom = 58,
		Continue_SelectRoom = 59,
		Continue_EnterRoom = 60,
		Continue_EnterRoom_Wait = 61,
		Continue_CreateRoom = 62,
		Continue_Host_EnterDialog = 63,
		Continue_LobbyHost = 64,
		Continue_ForceInquily = 65,
		Continue_CloseRoom = 66,
		Continue_GameStart = 67,
		Continue_GameStart_Wait = 68,
		Continue_Fade_Wait = 69,
		Continue_Client_EnterDialog = 70,
		Continue_LobbyClient = 71,
		Continue_LobbyClient_CloseJoin = 72,
		Continue_LeaveInquily = 73,
		Continue_Leave = 74,
		Continue_Leave_End = 75,
		Continue_Failed = 76
	}

	private enum GS_STAT
	{
		None = 0,
		Prep = 1,
		NotEnough = 2,
		Complete = 3
	}

	public enum _SI
	{
		None = 0,
		LC_Md = 1,
		LC_Md_St = 2,
		LC_Md_St_Nm = 3,
		IN_Md = 4,
		IN_Md_Hc = 5,
		IN_All = 6
	}

	[Serializable]
	public class PLAYER_SETTING
	{
		public string mName;

		public string mAddName;

		public bool mGuest;

		public string mGuestName;

		public GameController.PADNUM mPadNum;

		public string mJobID;

		public static string MakeDefaultName(int i)
		{
			return null;
		}

		public static bool IsDefaultName(string name)
		{
			return false;
		}

		public PLAYER_SETTING(string name)
		{
		}

		public PLAYER_SETTING(PLAYER_SETTING org)
		{
		}

		public string GetName()
		{
			return null;
		}

		public CGameRoom_Setting_Controller.SETTING_CONT MakeSettingCont()
		{
			return null;
		}
	}

	[Serializable]
	public class ONLINE_PLAYER
	{
		public COnline.PlayerInfo mInfo;

		public CMaster_CharJobData mJobData;

		public bool mTakeYou;

		public GameController.PADNUM mPadNum;

		public ONLINE_PLAYER(COnline.PlayerInfo info, CMaster_CharJobData jobData = null)
		{
		}

		public ONLINE_PLAYER(JsonNode json)
		{
		}

		public bool IsMe()
		{
			return false;
		}

		public bool IsHost()
		{
			return false;
		}

		public bool IsClient()
		{
			return false;
		}

		public bool IsGuest()
		{
			return false;
		}

		public bool IsCom()
		{
			return false;
		}

		public bool IsRoomMember()
		{
			return false;
		}

		public string GetPlayerName()
		{
			return null;
		}

		public string GetJobID()
		{
			return null;
		}

		public string GetJobName()
		{
			return null;
		}

		public CMaster_CharJobData SetJob(string id)
		{
			return null;
		}

		public void ClearJob()
		{
		}

		public void Update(COnline.PlayerInfo pInfo)
		{
		}

		public void Update(JsonNode json)
		{
		}

		public Dictionary<string, object> MakeJson()
		{
			return null;
		}

		public int GetStamp()
		{
			return 0;
		}
	}

	[SerializeField]
	private CGameRoom mGameRoom;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private GameObject mMenuBase;

	[SerializeField]
	private Transform mGameSettingInfo;

	[SerializeField]
	private TextMeshProUGUI mTextPlayMode;

	[SerializeField]
	private CUIGenericMenu mMenuTop;

	[SerializeField]
	private CGameRoom_Select_Stages mSelectStages;

	[SerializeField]
	private Vector2[] mPositionMenu;

	[SerializeField]
	private CUIGenericMenu mMenu;

	[SerializeField]
	private CMenu_Save mMenuSave;

	[SerializeField]
	private CUIMenuControllers mNewControllers;

	private static CUIMenuControllers.PAD_SETTING[] mPadSettings;

	[SerializeField]
	private CGameRoom_InputName mInputName;

	[SerializeField]
	private CGameRoom_SelectName mSelectName;

	[SerializeField]
	private CEventMessage mGMMessage;

	[SerializeField]
	private Camera mThisSceneCamera;

	[SerializeField]
	private CinemachineVirtualCamera mDollyCamera;

	[SerializeField]
	private CinemachineVirtualCamera mLookAtCamera;

	[SerializeField]
	private Transform mLookAtTarget;

	private static int mCursorTop;

	private static int mCursorHostClient;

	private static CMaster_MapStageData mStageData;

	private Vector2Int[] NumPlayers_Pieces;

	private Vector2Int[] SharingPlayers_Pieces;

	private static int mCursorNumPlayer;

	private static int mNumPlayer;

	private static int mNumPiece;

	private CSaveData.GAMEDATA mLocal_NewGameSaveSlot;

	private int mJobPlayerIndex;

	private CONT_TYPE mSelectSaveContinue;

	private bool mGameStart;

	private static bool mOnline;

	private CVoiceChat_VolumeSetting mVCVS;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private bool mFirstSelect;

	private int mCancelDelay;

	private const int CancelDelayFrame = 2;

	private int[] InfoNum;

	private string[] mText_TopMenuName;

	private bool mInitialize_MenuTop;

	private const double mSecTimeout = 60.0;

	private double mElapsedTimeout;

	[SerializeField]
	private Vector2 mPositionTimeout;

	[SerializeField]
	private Color mColorTimeout;

	private CUIGenericDialog mDialog;

	private double mNowTime;

	[SerializeField]
	[ReadOnly]
	private bool mErrorOnline;

	[SerializeField]
	private CSetting_Host mNew_SettingHost;

	[SerializeField]
	private CSetting_Client mNew_SettingClient;

	[SerializeField]
	private CSetting_RoomResult mNew_RoomResult;

	[SerializeField]
	[ReadOnly]
	private CSetting_Host.SETTING_HOST mSettingDataHost;

	[SerializeField]
	[ReadOnly]
	private CSetting_Client.SETTING_CLIENT mSettingDataClient;

	[SerializeField]
	[ReadOnly]
	private COnline.NETSTATE mRoomState;

	[SerializeField]
	private CUIGenericOpenClose mParent_UIOnlinePlayerInfo;

	[SerializeField]
	private CGameRoom_UIOnlinePlayerInfo[] mUIOnlinePlayerInfo;

	[SerializeField]
	private TextMeshProUGUI mSteamBuildID;

	[SerializeField]
	[ReadOnly]
	private NetworkType mNetworkType;

	private CreateRoomReq mCreateReq;

	private SearchRoomCondition mSearchReq;

	private List<CSetting_Online.ROOM_RESULT> mRoomResultList;

	private CSetting_Online.ROOM_RESULT mEnterRoom;

	private CSaveData.GAMEDATA mOnline_NewGameSaveSlot;

	private int mWait;

	[SerializeField]
	[ReadOnly]
	private ONLINE_MODE mOnlineMode;

	[SerializeField]
	[ReadOnly]
	private ONLINE_MODE mBack_OnlineMode;

	[SerializeField]
	[ReadOnly]
	private COnline.PlayerInfo mGuest;

	public ONLINE_PLAYER[] mOnlinePlayer;

	private List<ONLINE_PLAYER> mRemovePlayer;

	private string mReasonForLeaving;

	private ONLINE_MODE mErrorOccurred;

	private int mSwEnterLeave;

	private CUIButtonExplanation.DATA[] ButtonGameStart;

	private bool mBrightGameStart;

	private bool mStartVcDialog;

	private CSaveData.GAMEDATA mContinue_GameData;

	private JsonNode mSaveOnline;

	private JsonNode mSaveOnline_Field;

	private JsonNode mSaveOnline_FieldPlayer;

	private JsonNode mSaveOnline_PlayerInfo;

	private string mContinueString;

	private uint mContinueGameMode;

	private CreateRoomReq mContinue_CreateRoomReq;

	private SearchRoomCondition mContinue_SearchRoomCondition;

	private static COnline.PlayerInfo[] mContinuePlayerInfo;

	private bool mAutoResume;

	private static PLAYER_SETTING[] mSavePlayerSetting;

	[SerializeField]
	[ReadOnly]
	private PLAYER_SETTING[] mPlayerSetting;

	public CGameRoom_Select_Stages SelectStages => null;

	public CMenu_Save MenuSave => null;

	public static int NumPlayer => 0;

	public NetworkType NetworkType => NetworkType.Internet;

	public static void SetTopCursor(int n)
	{
	}

	public bool IsContinue()
	{
		return false;
	}

	public bool IsContinue_Resume()
	{
		return false;
	}

	public bool IsGameStart()
	{
		return false;
	}

	public static bool IsOnline()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void PadInitialize()
	{
	}

	private void PadInitialize_Name()
	{
	}

	public void GoLocal()
	{
	}

	public void Go_AutoResume(CSaveData.GAMEDATA gameData)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}

	private void ButtonExplanation_Hide()
	{
	}

	private void ButtonExplanation_Back()
	{
	}

	public void ActiveGameSettingInfo(_SI infoNum)
	{
	}

	private void SetupMenuTop()
	{
	}

	private void MenuTop_SelectColor()
	{
	}

	private void Cb_MenuTop_Cancel()
	{
	}

	private void Cb_MenuTop_Decision(int n)
	{
	}

	private void SetupContinue()
	{
	}

	private void SetupOnline()
	{
	}

	private void SetupStageSelection()
	{
	}

	private void SetupNumPlayerSelection()
	{
	}

	private void Menu_SelectColor()
	{
	}

	private void Cb_Menu_Cancel()
	{
	}

	private void Cb_Menu_Decision(int n)
	{
	}

	private void SetupInputName(int index = -1)
	{
	}

	private void SetupControllerSelection()
	{
	}

	public bool IsHost()
	{
		return false;
	}

	public bool IsClient()
	{
		return false;
	}

	private void OnlineInitialize()
	{
	}

	private void SettingHost()
	{
	}

	private void SettingClient()
	{
	}

	private bool IsOnlineEnd()
	{
		return false;
	}

	private bool IsOnlineCancel()
	{
		return false;
	}

	private bool IsOnlineToField()
	{
		return false;
	}

	private void OnlineUpdate()
	{
	}

	private bool ElapsedTime(float t = 0.5f)
	{
		return false;
	}

	private void OpenDialog(string a, bool btn = false, bool getTextLang = true)
	{
	}

	private void Error_Close()
	{
	}

	private bool IsOnlineError()
	{
		return false;
	}

	private int GetMeIndex()
	{
		return 0;
	}

	private bool Host_UpdateRoom()
	{
		return false;
	}

	private Dictionary<string, object> Host_SendPlayerInfo(string sendName)
	{
		return null;
	}

	private void Disp_GameStart()
	{
	}

	private void Open_GameStart()
	{
	}

	private void Close_GameStart()
	{
	}

	private GS_STAT Host_CheckLobby()
	{
		return GS_STAT.None;
	}

	private void Host_CloseJoin(COnline _online)
	{
	}

	private void Host_SetTakeYou()
	{
	}

	private bool Client_IsRoomClose()
	{
		return false;
	}

	private bool Client_ForceLeave()
	{
		return false;
	}

	private ONLINE_PLAYER GetMyOnlinePlayer()
	{
		return null;
	}

	private bool Client_UpdateRoom()
	{
		return false;
	}

	private ONLINE_PLAYER[] CreatePlayerInfo(JsonNode top, bool saveContinue = false)
	{
		return null;
	}

	private ONLINE_PLAYER GetOnlinePlayerPID(PlayerId pID)
	{
		return null;
	}

	private ONLINE_PLAYER GetOnlinePlayerGUID(string guid)
	{
		return null;
	}

	private void Initialize_OnlinePlayerInfo(bool clear = false)
	{
	}

	private void Update_OnlinePlayerInfo()
	{
	}

	private CUIMenuControllers.PAD_SETTING[] CreatePadSetting_Host()
	{
		return null;
	}

	private CUIMenuControllers.PAD_SETTING[] CreatePadSetting_Client()
	{
		return null;
	}

	private void Host_ShowClientBlueMan(COnline.PlayerInfo info)
	{
	}

	private void Host_HideClientBlueMan(bool isContinue = false)
	{
	}

	private void OpenDialog_EnterRoom_VoiceChat()
	{
	}

	private bool Wait_VcCallback()
	{
		return false;
	}

	public static COnline.PlayerInfo GetContinuePlayerInfo(int i)
	{
		return null;
	}

	private void SettingOnline_Continue(CSaveData.GAMEDATA gameData, bool AutoResume)
	{
	}

	private bool IsRoomCorrect(IRoomInfo info)
	{
		return false;
	}

	private void OnlineContinue_Update()
	{
	}

	private bool Create_JoinedPlayers(COnline _online)
	{
		return false;
	}

	private bool Check_Guest(ONLINE_PLAYER[] players)
	{
		return false;
	}

	private bool Update_ContinueHost()
	{
		return false;
	}

	private int Search_ContineGUID(string guid)
	{
		return 0;
	}

	private List<object> Create_HostReferencedField()
	{
		return null;
	}

	private bool ContinueHost_UpdatePlayerInfo(CGameRoom_Job _roomJob)
	{
		return false;
	}

	private bool ContinueClient_UpdatePlayerInfo(CGameRoom_Job _roomJob)
	{
		return false;
	}

	private void Continue_SetupBlueman()
	{
	}

	private void Create_ClientReferencedField(JsonNode top)
	{
	}

	private void SetupField()
	{
	}
}
