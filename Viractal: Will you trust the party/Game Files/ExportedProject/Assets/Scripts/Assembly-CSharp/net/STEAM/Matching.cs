using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Steamworks;
using UnityEngine;

namespace net.STEAM
{
	public class Matching : IMatching, IDisposable
	{
		private class P2PConnection
		{
			public PlayerId mPlayerId;

			public HSteamNetConnection mhConnection;

			public bool mRequestP2P;

			public bool mActive;
		}

		private struct SendDataSaveTable
		{
			public RoomEvent mEventId;

			public List<PlayerId> mpPlayerIdList;

			public byte[] mpData;

			public uint mSize;

			public bool mReliable;
		}

		[StructLayout((LayoutKind)2)]
		public struct MatchingCmd
		{
			public enum Cmd : uint
			{
				GameStart = 696455188u,
				Kick = 3203334471u
			}

			[FieldOffset(0)]
			public Cmd mCmd;

			[FieldOffset(0)]
			public CmdGameStart mCmdGameStart;

			[FieldOffset(0)]
			public CmdKick mCmdKick;
		}

		public struct CmdGameStart
		{
			public MatchingCmd.Cmd mCmd;

			private MatchingCmd.Cmd CmdId => (MatchingCmd.Cmd)0u;

			private CmdGameStart(MatchingCmd.Cmd cmd = MatchingCmd.Cmd.GameStart)
			{
				mCmd = (MatchingCmd.Cmd)0u;
			}
		}

		public struct CmdKick
		{
			public MatchingCmd.Cmd mCmd;

			public PlayerId mPlayerId;

			private MatchingCmd.Cmd CmdId => (MatchingCmd.Cmd)0u;

			public CmdKick(MatchingCmd.Cmd cmd = MatchingCmd.Cmd.Kick)
			{
				mCmd = (MatchingCmd.Cmd)0u;
				mPlayerId = default;
			}
		}

		private RtChat mRtChat;

		private RtChat.ISound mSound;

		private CancellationTokenSource mRtcCts;

		private bool mIsConnectedRtChat;

		private bool mIsReopenRtChat;

		private Vector3[] mSeatPosition;

		private const string logPrefix = "[Matching]";

		private static Matching mInstance;

		private const int SEND_DATA_SAVE_COUNT_MAX = 100;

		private Queue<SendDataSaveTable> mSendDataSaveQueue;

		private Room mpCurrentRoom;

		private byte[] mpSendDataSave;

		private List<PlayerId> mpSendMemberSave;

		private uint mSendDataSize;

		private uint mSendBuffSize;

		private uint mReceiveBuffSize;

		private ConnectEventCallback mConnectCallback;

		private DisconnectEventCallback mDisconnectCallback;

		private ErrorEventCallback mErrorCallback;

		private RoomEventCallback mRoomCallback;

		private FriendListCallback mFriendCallback;

		private BlockListCallback mBlockCallback;

		private ConnectReq mConnectReq;

		private CreateRoomReq mCreateRoomReq;

		private List<PlayerId> mpPlayerIdList;

		[SerializeField]
		private MatchingState mMatchingState;

		private MatchingState mRetMatchingState;

		private RoomEvent mRoomEvent;

		private bool mIsGameStart;

		private bool mIsDebugLatency;

		private bool mIsDebugPacketLoss;

		private int mDebugSendPacketLatency;

		private int mDebugReceivePacketLatency;

		private int mDebugSendPacketLossRatio;

		private int mDebugReceivePacketLossRatio;

		private ILogger mpLogger;

		private Func<RoomResult> mMatchingStateCallback;

		private CallResult<LobbyMatchList_t> mCallResultRequestLobbyList;

		private CallResult<LobbyCreated_t> mCallResultCreateLobby;

		private CallResult<LobbyEnter_t> mCallResultJoinLobby;

		private PlayerId mEventPlayerId;

		private PlayerId mMyOwnId;

		private PlayerId mOwnerId;

		private RoomInfoList mRoomInfoList;

		private HSteamNetConnection mhServerConnection;

		private HSteamListenSocket mhListenSocket;

		private HSteamNetPollGroup mhPollGroup;

		private uint mFriendIndex;

		private uint mFriendCount;

		private List<NetworkAccountId> mFriendIdList;

		private List<NetworkAccountId> mBlockIdList;

		private List<P2PConnection> mP2PConnections;

		private const int ConnectionConfigNum = 2;

		private SteamNetworkingConfigValue_t[] mConnectionConfig;

		private GameServer mpGameServer;

		protected Callback<LobbyGameCreated_t> mLobbyGameCreated;

		protected Callback<LobbyChatUpdate_t> mLobbyChatUpdate;

		protected Callback<LobbyChatMsg_t> mLobbyChatMsg;

		protected Callback<SteamServersConnected_t> mSteamServersConnected;

		protected Callback<SteamServerConnectFailure_t> mSteamServerConnectFailure;

		protected Callback<SteamServersDisconnected_t> mSteamServersDisconnected;

		protected Callback<SteamNetConnectionStatusChangedCallback_t> mSteamNetConnectionStatusChangedCallback;

		private IAccount mAccountInstance;

		public void ConnectRtc()
		{
		}

		public void SetSeatPosition(int participantMax, float distance)
		{
		}

		public void SetSound(RtChat.ISound sound)
		{
		}

		public void SetReceiveVolume(float volume)
		{
		}

		public float GetReceiveVolume()
		{
			return 0f;
		}

		public void SetReceiveMute(bool flag)
		{
		}

		public bool GetReceiveMute()
		{
			return false;
		}

		public void SetReceiveClientVolume(PlayerId playerId, float volume)
		{
		}

		public float GetReceiveClientVolume(PlayerId playerId)
		{
			return 0f;
		}

		public void SetReceiveClientMute(PlayerId playerId, bool flag)
		{
		}

		public bool GetReceiveClientMute(PlayerId playerId)
		{
			return false;
		}

		public void SetSendVolume(float volume)
		{
		}

		public float GetSendVolume()
		{
			return 0f;
		}

		public void SetSendMute(bool flag)
		{
		}

		public bool GetSendMute()
		{
			return false;
		}

		public float GetRms(PlayerId playerId)
		{
			return 0f;
		}

		public void SetPitch(PlayerId playerId, float pitch)
		{
		}

		public void SetBusSendLevel(PlayerId playerId, string busName, float sendLevel)
		{
		}

		public void ReopenRtChat(MatchingError forceError = MatchingError.NoneError)
		{
		}

		public int GetNumAvailableAudioInputDevices()
		{
			return 0;
		}

		public bool GetAudioInputDeviceInfoByIndex(int index, ref RtChat.AudioInputDeviceInfo info)
		{
			return false;
		}

		public string GetAudioInputDeviceId()
		{
			return null;
		}

		public string GetCurrentAudioInputDeviceId()
		{
			return null;
		}

		public void SetAudioInputDeviceId(string id)
		{
		}

		private void OnRtcSessionEventCallback(List<RtChat.Member> rtChatMemberList)
		{
		}

		private void OnRtcConnectedEventCallback()
		{
		}

		private void OnRtcDisconnectedEventCallback()
		{
		}

		private void OnRtcErrorEventCallback(RtChat.RtcError error)
		{
		}

		private Matching()
		{
		}

		~Matching()
		{
		}

		public void Dispose()
		{
		}

		public static Matching GetInstance()
		{
			return null;
		}

		public void SetAccount(IAccount accountInstance)
		{
		}

		public void Open(ConnectReq connectReq)
		{
		}

		public void Close()
		{
		}

		public void Update()
		{
		}

		public void CreateRoom(CreateRoomReq createRoomReq)
		{
		}

		public void SearchRooms(SearchRoomCondition condition, int offset, int count)
		{
		}

		public void GetFriendList()
		{
		}

		public void GetFriendList(int index, int count)
		{
		}

		public void GetBlockList()
		{
		}

		public void GetBlockList(int index, int count)
		{
		}

		public void EnterRoom(IRoomInfo roomInfo, Password password)
		{
		}

		public void LeaveRoom()
		{
		}

		public void CloseJoin()
		{
		}

		public void GameStart()
		{
		}

		public void Broadcast(string data, bool reliable)
		{
		}

		public void Broadcast(IntPtr data, uint dataSize, bool reliable)
		{
		}

		public void Othercast(string data, bool reliable)
		{
		}

		public void Othercast(IntPtr data, uint dataSize, bool reliable)
		{
		}

		public void Unicast(PlayerId playerId, string data, bool reliable)
		{
		}

		public void Unicast(PlayerId playerId, IntPtr data, uint dataSize, bool reliable)
		{
		}

		public void Multicast(List<PlayerId> playerIdList, string data, bool reliable)
		{
		}

		public void Multicast(List<PlayerId> playerIdList, IntPtr data, uint dataSize, bool reliable)
		{
		}

		public void SetRoomMemberData(uint index, byte[] data, uint dataSize)
		{
		}

		public void SetRoomMemberValue(uint index, uint value)
		{
		}

		public void SetRoomMemberString(uint index, string text)
		{
		}

		public uint GetRoomMemberData(PlayerId playerId, uint index, out byte[] outData)
		{
			outData = null;
			return 0u;
		}

		public uint GetRoomMemberValue(PlayerId playerId, uint index)
		{
			return 0u;
		}

		public string GetRoomMemberString(PlayerId playerId, uint index)
		{
			return null;
		}

		public IRoom GetRoom()
		{
			return null;
		}

		public uint GetReceiveBufferSize()
		{
			return 0u;
		}

		public void SetReceiveBufferSize(uint receiveBufferSize)
		{
		}

		public uint GetSendBufferSize()
		{
			return 0u;
		}

		public void SetSendBufferSize(uint sendBufferSize)
		{
		}

		public bool IsGameStarted()
		{
			return false;
		}

		public void SetDebugSendPacketLatencyMin(int latency)
		{
		}

		public void SetDebugSendPacketLatencyMax(int latency)
		{
		}

		public void SetDebugReceivePacketLatencyMin(int latency)
		{
		}

		public void SetDebugReceivePacketLatencyMax(int latency)
		{
		}

		public void SetDebugSendPacketLossRatio(byte ratio)
		{
		}

		public void SetDebugReceivePacketLossRatio(byte ratio)
		{
		}

		public bool IsSendBufferAvailable(uint dataSize)
		{
			return false;
		}

		public bool IsSendBufferAvailable(PlayerId playerId, uint dataSize)
		{
			return false;
		}

		public bool SendSavedSendData()
		{
			return false;
		}

		public void SaveSendData(RoomEvent eventId, List<PlayerId> playerIdList, byte[] pData, uint size, bool reliable)
		{
		}

		public void SetConnectEventCallback(ConnectEventCallback connectCallback)
		{
		}

		public void SetDisconnectEventCallback(DisconnectEventCallback disconnectCallback)
		{
		}

		public void SetErrorEventCallback(ErrorEventCallback errorCallback)
		{
		}

		public void SetRoomEventCallback(RoomEventCallback roomCallback)
		{
		}

		public void SetFriendListCallback(FriendListCallback friendCallback)
		{
		}

		public void SetBlockListCallback(BlockListCallback blockCallback)
		{
		}

		public void SetLogManager(ILogger logger)
		{
		}

		private Room MakeRoom(CSteamID steamIDLobby)
		{
			return null;
		}

		private void OnLeaveRoom()
		{
		}

		private string MatchingStateToStr(MatchingState state)
		{
			return null;
		}

		private string RoomEventToStr(RoomEvent roomEvent)
		{
			return null;
		}

		private string RoomResultToStr(RoomResult roomResult)
		{
			return null;
		}

		private MatchingState ChangeState(MatchingState newState)
		{
			return MatchingState.Idoling;
		}

		private MatchingState ReturnState()
		{
			return MatchingState.Idoling;
		}

		private void Error(uint errorResult, string pFile, int line)
		{
		}

		private void Logging(LogLevel.Level logLevel, string message)
		{
		}

		private void OnCreateLobbyCallback(LobbyCreated_t arg, bool bFailure)
		{
		}

		private void OnJoinLobbyCallback(LobbyEnter_t arg, bool bFailure)
		{
		}

		private void OnRequestLobbyListCallback(LobbyMatchList_t arg, bool bFailure)
		{
		}

		private void OnChangeLobbyMemberCallback(LobbyChatUpdate_t arg)
		{
		}

		private void OnLobbyGameCreatedCallback(LobbyGameCreated_t pArg)
		{
		}

		private void OnLobbyMsgCallback(LobbyChatMsg_t pArg)
		{
		}

		public void OnSteamServersConnected(SteamServersConnected_t pArg)
		{
		}

		public void OnSteamServerConnectFailure(SteamServerConnectFailure_t pArg)
		{
		}

		public void OnSteamServersDisconnected(SteamServersDisconnected_t pArg)
		{
		}

		private void OnNetConnectionStatusChangedCallback(SteamNetConnectionStatusChangedCallback_t pArg)
		{
		}
	}
}
