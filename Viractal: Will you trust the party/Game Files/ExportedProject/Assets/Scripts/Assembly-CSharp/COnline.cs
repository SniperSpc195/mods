using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using Test;
using UnityEngine;
using net;

public class COnline : SingletonMonoBehaviour<COnline>
{
	public enum NETSTATE
	{
		None = 0,
		Success = 1,
		Failed = 2,
		Canceled = 3,
		Connected = 4,
		Room_Open = 5,
		Room_Close = 6,
		Room_Host = 7,
		Room_Client = 8,
		Room_Full = 9,
		Room_NotExist = 10,
		Room_PasswordUnmatch = 11,
		Room_KickedOut = 12,
		Event_ChangeHost = 13,
		Event_NumPlayerChangees = 14,
		Exec_Connect = 15,
		Exec_Close = 16,
		Exec_CreateRoom = 17,
		Exec_SearchRoom = 18,
		Exec_EnterRoom = 19,
		Exec_LeaveRoom = 20,
		Exec_CloseJoin = 21,
		Exec_GameStart = 22,
		Exec_GetFriend = 23,
		Exec_GetFriend_Continue = 24,
		Exec_GetBlock = 25,
		Exec_GetBlock_Continue = 26,
		Exec_Send = 27,
		Exec_ReopenRtChat = 28,
		Error = -1
	}

	public enum SENDTYPE
	{
		Sync = 0,
		Recommend = 1,
		Signal = 2,
		Data = 3
	}

	public class ListOthers
	{
		public enum STAT
		{
			None = 0,
			Continue = 1,
			End = 2
		}

		public List<NetworkAccountId> mIDs;

		public int mStartIndex;

		public int mLoadMax;

		public STAT mStat;

		public bool IsContinue()
		{
			return false;
		}

		public bool IsEnd()
		{
			return false;
		}

		public ListOthers(int loadMax)
		{
		}

		public void Clear()
		{
		}

		public void Add(List<NetworkAccountId> ids)
		{
		}

		public bool IsIncluded(PlayerId id)
		{
			return false;
		}

		public bool IsIncluded(NetworkAccountId id)
		{
			return false;
		}
	}

	public enum JOINTYPE
	{
		Host = 0,
		Client = 1,
		Guest = 2,
		Com = 3
	}

	[Serializable]
	public class PlayerInfo
	{
		public enum STATE
		{
			None = 0,
			InPreparation = 1,
			Completion = 2,
			Leave = 3
		}

		public int mIndex;

		public PlayerId mPlayerID;

		public string mGUID;

		public string mName;

		public string mEntryTime;

		public JOINTYPE mJoinType;

		public GameController.PADNUM mPadNum;

		public string mVoiceEffect;

		public bool mOwnMute;

		public MatchingError mVCError;

		public bool mMe;

		public bool mLateArrival;

		public STATE mState;

		private int mStamp;

		public bool IsValid()
		{
			return false;
		}

		public void SetVoiceEffect(string effect)
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

		public bool IsVoiceChatRestricted()
		{
			return false;
		}

		public bool IsNone()
		{
			return false;
		}

		public bool IsStatePrep()
		{
			return false;
		}

		public bool IsStateComp()
		{
			return false;
		}

		public bool IsLeave()
		{
			return false;
		}

		public void SetNone()
		{
		}

		public void SetPrep()
		{
		}

		public void SetComp()
		{
		}

		public void SetLeave()
		{
		}

		public string GetIDName()
		{
			return null;
		}

		public PlayerInfo(IMember member)
		{
		}

		public PlayerInfo(JsonNode json)
		{
		}

		public PlayerInfo(PlayerInfo host)
		{
		}

		public void SetMember(IMember member)
		{
		}

		public Dictionary<string, object> MakeJson(bool exIndex = true)
		{
			return null;
		}

		public void SetJson(JsonNode json)
		{
		}

		public void UpdateMute(bool m)
		{
		}

		public bool GetMute()
		{
			return false;
		}

		public bool IsVCError()
		{
			return false;
		}

		public void UpdateStamp(int s)
		{
		}

		public int GetStamp()
		{
			return 0;
		}
	}

	public class ReceivedData
	{
		public PlayerId mPlayerID;

		public long mSendNum;

		public SENDTYPE mType;

		public string mName;

		public JsonNode mHeader;

		public JsonNode mJson;

		public bool IsTypeSync()
		{
			return false;
		}

		public bool IsTypeSignal()
		{
			return false;
		}

		public bool IsTypeData()
		{
			return false;
		}

		public bool IsTypeRecommend()
		{
			return false;
		}

		public ReceivedData(PlayerId id, string a)
		{
		}

		public void DevilsWhispers()
		{
		}
	}

	public class ConvPtr
	{
		private IntPtr mSendPtr;

		private int mSendPtrSize;

		private int mDataSize;

		private byte[] mReceived;

		~ConvPtr()
		{
		}

		public void MakeSendBuffer(int size)
		{
		}

		public void MakeReceivedBuffer(int size)
		{
		}

		public IntPtr StringToPtr(string a, out int size)
		{
			size = default;
			return (IntPtr)0;
		}

		public int GetDataSize()
		{
			return 0;
		}

		public string PtrToString(IntPtr ptr, int size)
		{
			return null;
		}
	}

	public enum VCHAT
	{
		NotConnected = 0,
		Connected = 1,
		Restricted = 2
	}

	private enum SYNC
	{
		None = 0,
		Wait = 1
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSendWait_003Ed__170 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public COnline _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

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

	private const int FriendCountMax = 30;

	private const int BlockedUserCountMax = 10;

	private const double mRetrySearchTime = 4.0;

	private double mRoomSearchTime;

	private const int BUFFER_SIZE = 262144;

	private bool m_Initialize;

	[SerializeField]
	[ReadOnly]
	private NetworkType mNetworkType;

	[SerializeField]
	[ReadOnly]
	private long mSendNum;

	private Logger mLogManager;

	private NetworkLogProc mNetworkLogProc;

	private IMatching mMatching;

	private bool mMatchingEnable;

	private string mNickName;

	private IRoomInfoList mRoomInfoList;

	private ListOthers mFriendList;

	private ListOthers mBlockList;

	private List<ReceivedData> mReceivedSync;

	private List<ReceivedData> mReceivedRecom;

	private List<ReceivedData> mReceivedData;

	private ConvPtr mSendBuffer;

	private ConvPtr mReceivedBuffer;

	[SerializeField]
	[ReadOnly]
	private MatchingError mErrorID;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mErrorState;

	[SerializeField]
	[ReadOnly]
	private MatchingError mVCErrorID;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mOwn_VCErrorState;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mOther_VCErrorState;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mExecState;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mStateConect;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mStateRoom;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mStateEnterRoom;

	[SerializeField]
	[ReadOnly]
	private bool mGameStart;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mChangeEvent;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mJoinEvent;

	[SerializeField]
	[ReadOnly]
	private NETSTATE mLeaveEvent;

	[SerializeField]
	[ReadOnly]
	private PlayerId mOwnerPlayerID;

	[SerializeField]
	[ReadOnly]
	private PlayerId mMyPlayerID;

	[SerializeField]
	[ReadOnly]
	private List<PlayerInfo> mPlayerInfo;

	[SerializeField]
	[ReadOnly]
	private List<PlayerInfo> mLateArrival;

	[SerializeField]
	[ReadOnly]
	private List<PlayerInfo> mSyncPlayerInfo;

	private PlayerInfo mOwner;

	private PlayerInfo mLeavePlayer;

	[SerializeField]
	private Canvas mDebugCanvas;

	[SerializeField]
	private TextMeshProUGUI mDebugTextMember;

	[SerializeField]
	private GameObject mParentReceivedCommand;

	[SerializeField]
	private TextMeshProUGUI mDebugTextReceivedCommand;

	[SerializeField]
	private GameObject mParentCheckCommand;

	[SerializeField]
	private TextMeshProUGUI mDebugTextCheckCommand;

	private long gSendNum;

	private SENDTYPE gSendType;

	private string gSendName;

	private string gSendData;

	private int gSendSize;

	private const int MAX_NAME_LENGTH = 16;

	public static string[] VCEffectName;

	[SerializeField]
	[ReadOnly]
	private VCHAT mStateVChat;

	private long mCheckStateVChatTime;

	private const long CHECK_VCHATTIME = 5000L;

	[SerializeField]
	[ReadOnly]
	private SYNC mModeSync;

	[SerializeField]
	[ReadOnly]
	private string mSyncName;

	[SerializeField]
	[ReadOnly]
	private int mSyncNumMax;

	private int[][][] mSyncRandomSeed;

	private uint[] mSyncMasterAvailabilityNum;

	public IMatching Matching => null;

	public MatchingError ErrorID => MatchingError.NoneError;

	public VCHAT StateVChat => VCHAT.NotConnected;

	public bool IsSearchTheRooms()
	{
		return false;
	}

	public string GetNickName()
	{
		return null;
	}

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void Initialize(JsonNode debugJson)
	{
	}

	public MatchingError GetVCErrorID()
	{
		return MatchingError.NoneError;
	}

	public bool IsGameStart()
	{
		return false;
	}

	public bool IsConnect()
	{
		return false;
	}

	public bool IsConnectInternet()
	{
		return false;
	}

	public bool IsConnectLAN()
	{
		return false;
	}

	public bool IsConnectAdHoc()
	{
		return false;
	}

	public NetworkType GetNetworkType()
	{
		return NetworkType.Internet;
	}

	public bool IsErrorOrLeave()
	{
		return false;
	}

	public bool IsNetworkError()
	{
		return false;
	}

	public void ClearNetworkError()
	{
	}

	public bool IsOwnVoiceChatError()
	{
		return false;
	}

	public void ClearOwnVoiceChatError()
	{
	}

	public bool IsOtherVoiceChatError()
	{
		return false;
	}

	public void ClearOtherVoiceChatError()
	{
	}

	public bool IsSuccess()
	{
		return false;
	}

	public bool IsFailed()
	{
		return false;
	}

	public bool IsCanceled()
	{
		return false;
	}

	public bool IsOpenRoom()
	{
		return false;
	}

	public bool IsCloseRoom()
	{
		return false;
	}

	public void SetCloseRoom()
	{
	}

	public NETSTATE GetStateEnterRoom()
	{
		return NETSTATE.None;
	}

	public bool IsHost()
	{
		return false;
	}

	public bool IsClient()
	{
		return false;
	}

	public bool IsEnterRoom()
	{
		return false;
	}

	public void ClearEnterRoom()
	{
	}

	public bool IsChangeHost()
	{
		return false;
	}

	public void ClearChangeHost()
	{
	}

	public bool IsJoinEvent()
	{
		return false;
	}

	public void ClearJoinEvent()
	{
	}

	public bool IsLeaveEvent()
	{
		return false;
	}

	public void ClearLeaveEvent()
	{
	}

	public void ClearLeavePlayer()
	{
	}

	public bool IsUseVoiceChat()
	{
		return false;
	}

	public IMember GetMember(PlayerId id)
	{
		return null;
	}

	private void Host_MakePlayerInfo()
	{
	}

	private PlayerInfo AddPlayerInfo(PlayerId id, bool late = false)
	{
		return null;
	}

	public void MakePlayerInfo(JsonNode array)
	{
	}

	public List<PlayerInfo> MakeContinuePlayerList(JsonNode array, bool includeNonEntered = true)
	{
		return null;
	}

	public void SetContinuePlayerList(List<PlayerInfo> list)
	{
	}

	public void UpdatePlayerInfo(bool updateMember = true, bool sort = true)
	{
	}

	private int RemovePlayerInfo(PlayerId id)
	{
		return 0;
	}

	private void ChangeOwner(PlayerId id)
	{
	}

	public PlayerId GetOwnerPlayerID()
	{
		return default;
	}

	public PlayerId GetMyPlayerID()
	{
		return default;
	}

	public IMember GetMyIMember()
	{
		return null;
	}

	public string GetMyName()
	{
		return null;
	}

	public PlayerInfo GetMyPlayerInfo()
	{
		return null;
	}

	public bool IsOwnerMe()
	{
		return false;
	}

	public PlayerInfo GetOwnerPlayerInfo()
	{
		return null;
	}

	public PlayerInfo GetLeavePlayerInfo()
	{
		return null;
	}

	public int IsLateArrival()
	{
		return 0;
	}

	public List<PlayerInfo> GetPlayerInfoAll()
	{
		return null;
	}

	public void AddGuest(PlayerInfo guest)
	{
	}

	public PlayerInfo GetPlayerInfo(PlayerId pid)
	{
		return null;
	}

	public PlayerInfo GetPlayerInfo(string guid)
	{
		return null;
	}

	public List<PlayerInfo> GetPlayerInfoToClient()
	{
		return null;
	}

	public bool IsLeavePlayer(PlayerId pid, bool remove)
	{
		return false;
	}

	public void ClearAll()
	{
	}

	private void SetSuccess()
	{
	}

	public bool Connect(NetworkType ntype, bool checkOnly = false)
	{
		return false;
	}

	public void Close()
	{
	}

	public void CreateRoom(CreateRoomReq req)
	{
	}

	public void SearchRoom(SearchRoomCondition req, int startIndex = 0, int maxNum = 20)
	{
	}

	public List<IRoomInfo> GetRoomList(bool onFriend = false)
	{
		return null;
	}

	public bool IsEntryPermitted(IRoomInfo info, bool onFriend, bool enterRoom = false)
	{
		return false;
	}

	public void EnterRoom(IRoomInfo room)
	{
	}

	public void EnterRoom(IRoomInfo room, string pass)
	{
	}

	public void LeaveRoom(bool force = false)
	{
	}

	public void LoadFriendList()
	{
	}

	public bool IsIncludedFriendList(PlayerId id)
	{
		return false;
	}

	public void LoadBlockList()
	{
	}

	public bool IsIncludedBlockList(PlayerId id)
	{
		return false;
	}

	public void CloseJoin()
	{
	}

	public void GameStart()
	{
	}

	public void ForcedExit(string signal)
	{
	}

	private void Update()
	{
	}

	public bool GetMute(PlayerId playerId)
	{
		return false;
	}

	public bool IsVCError(PlayerId playerId)
	{
		return false;
	}

	public void ReopenRtChat(MatchingError err = MatchingError.NoneError)
	{
	}

	public static void LogSys(string a)
	{
	}

	public static void LogRoom(string a)
	{
	}

	public static void LogSync(string a)
	{
	}

	public void OnConnect()
	{
	}

	public void OnDisconnect()
	{
	}

	public void OnError(MatchingError errorId)
	{
	}

	public void OnRoom(RoomEvent eventId, PlayerId playerId, PlayerId ownerId, PlayerId myId, List<PlayerId> playerIdList, IRoomInfoList roomInfoList, IntPtr data, int dataSize, RoomResult result)
	{
	}

	private void Sort(List<ReceivedData> list)
	{
	}

	public void OnFriendList(List<NetworkAccountId> friendIdList, int count, RoomResult result)
	{
	}

	public void OnBlockList(List<NetworkAccountId> blockIdList, int count, RoomResult result)
	{
	}

	public bool JudgSignal(bool isControl, bool isOnline, string name, bool conditions)
	{
		return false;
	}

	public int JudgArray(bool isControl, bool isOnline, string name, bool[] array, int max = 0)
	{
		return 0;
	}

	public void SendRecommend(string name, object data)
	{
	}

	public JsonNode GetRecommend(string name)
	{
		return null;
	}

	private Dictionary<string, object> MakeHeader(PlayerId playerID, SENDTYPE type, string name)
	{
		return null;
	}

	private string MakeSendSignal(string name)
	{
		return null;
	}

	private string MakeSendData(string name, object tmp)
	{
		return null;
	}

	public void BroadcastSignal(string name)
	{
	}

	public void BroadcastData(string name, object data)
	{
	}

	public void OthercastSignal(string name)
	{
	}

	public void OthercastData(string name, object data)
	{
	}

	public void UnicastOwnerSignal(string name)
	{
	}

	public void UnicastOwnerData(string name, object data)
	{
	}

	public void UnicastSignal(PlayerId playerId, string name)
	{
	}

	public void UnicastData(PlayerId playerId, string name, object data)
	{
	}

	public void MulticastSignal(List<PlayerId> list, string name)
	{
	}

	public void MulticastData(List<PlayerId> list, string name, object data)
	{
	}

	[AsyncStateMachine(typeof(_003CSendWait_003Ed__170))]
	private void SendWait()
	{
	}

	public bool GetSignal(string name)
	{
		return false;
	}

	public ReceivedData GetReceivedSignal(string name)
	{
		return null;
	}

	public bool IsReceivedSignal(string name)
	{
		return false;
	}

	public ReceivedData GetReceivedData(string name)
	{
		return null;
	}

	public JsonNode GetReceivedJson(string name)
	{
		return null;
	}

	public bool IsReceivedData(string name)
	{
		return false;
	}

	public static string CheckOnlinePlayerName(string name)
	{
		return null;
	}

	public bool IsVoiceChatConnected()
	{
		return false;
	}

	public bool IsVoiceChatUnRestricted()
	{
		return false;
	}

	public bool IsVoiceChatRestricted()
	{
		return false;
	}

	public bool BeginFreeCommunication()
	{
		return false;
	}

	public void EndFreeCommunication()
	{
	}

	private string MakeSendSync(string name, bool includeWhispers)
	{
		return null;
	}

	private void Sync_LeaveRoom(PlayerId id)
	{
	}

	public bool Sync(string name, float wait_displaying_syncing = 3f)
	{
		return false;
	}

	public bool Sync_ChangePlayer(string name, float wait_displaying_syncing = 3f)
	{
		return false;
	}

	private bool Sync_Start(string name, float wait_displaying_syncing, bool includeWhispers = false)
	{
		return false;
	}

	private void Sync_Wait()
	{
	}
}
