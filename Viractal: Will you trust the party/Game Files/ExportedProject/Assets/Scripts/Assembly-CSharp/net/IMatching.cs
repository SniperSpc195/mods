using System;
using System.Collections.Generic;

namespace net
{
	public interface IMatching
	{
		void SetAccount(IAccount accountInstance);

		void Open(ConnectReq connectReq);

		void Close();

		void Update();

		void CreateRoom(CreateRoomReq roomReq);

		void SearchRooms(SearchRoomCondition condition, int index, int count);

		void GetFriendList(int index, int count);

		void GetBlockList(int index, int count);

		void EnterRoom(IRoomInfo roomInfo, Password passwrd);

		void LeaveRoom();

		void CloseJoin();

		void GameStart();

		void SetRoomMemberData(uint index, byte[] data, uint dataSize);

		void SetRoomMemberValue(uint index, uint value);

		void SetRoomMemberString(uint index, string text);

		uint GetRoomMemberData(PlayerId playerId, uint index, out byte[] outData);

		uint GetRoomMemberValue(PlayerId playerId, uint index);

		string GetRoomMemberString(PlayerId playerId, uint index);

		void Broadcast(IntPtr data, uint dataSize, bool reliable);

		void Broadcast(string data, bool reliable);

		void Othercast(IntPtr data, uint dataSize, bool reliable);

		void Othercast(string data, bool reliable);

		void Unicast(PlayerId playerId, IntPtr data, uint dataSize, bool reliable);

		void Unicast(PlayerId playerId, string data, bool reliable);

		void Multicast(List<PlayerId> playerIdList, IntPtr data, uint dataSize, bool reliable);

		void Multicast(List<PlayerId> playerIdList, string data, bool reliable);

		IRoom GetRoom();

		uint GetReceiveBufferSize();

		void SetReceiveBufferSize(uint receiveBufferSize);

		uint GetSendBufferSize();

		void SetSendBufferSize(uint sendBufferSize);

		bool IsGameStarted();

		void SetDebugSendPacketLatencyMin(int latency);

		void SetDebugSendPacketLatencyMax(int latency);

		void SetDebugReceivePacketLatencyMin(int latency);

		void SetDebugReceivePacketLatencyMax(int latency);

		void SetDebugSendPacketLossRatio(byte ratio);

		void SetDebugReceivePacketLossRatio(byte ratio);

		bool IsSendBufferAvailable(uint dataSize);

		bool IsSendBufferAvailable(PlayerId playerId, uint dataSize);

		void SetConnectEventCallback(ConnectEventCallback connectCallback);

		void SetDisconnectEventCallback(DisconnectEventCallback disconnectCallback);

		void SetErrorEventCallback(ErrorEventCallback errorCallback);

		void SetRoomEventCallback(RoomEventCallback roomCallback);

		void SetFriendListCallback(FriendListCallback friendCallback);

		void SetBlockListCallback(BlockListCallback blockCallback);

		void SetLogManager(ILogger logger);

		void ConnectRtc();

		void SetSeatPosition(int participantMax, float distance);

		void SetSound(RtChat.ISound sound);

		void SetReceiveVolume(float volume);

		float GetReceiveVolume();

		void SetReceiveMute(bool flag);

		bool GetReceiveMute();

		void SetReceiveClientVolume(PlayerId playerId, float volume);

		float GetReceiveClientVolume(PlayerId playerId);

		void SetReceiveClientMute(PlayerId playerId, bool flag);

		bool GetReceiveClientMute(PlayerId playerId);

		void SetSendVolume(float volume);

		float GetSendVolume();

		void SetSendMute(bool flag);

		bool GetSendMute();

		float GetRms(PlayerId playerId);

		void SetPitch(PlayerId playerId, float pitch);

		void SetBusSendLevel(PlayerId playerId, string busName, float sendLevel);

		void ReopenRtChat(MatchingError forceError = MatchingError.NoneError);

		int GetNumAvailableAudioInputDevices();

		bool GetAudioInputDeviceInfoByIndex(int index, ref RtChat.AudioInputDeviceInfo info);

		string GetAudioInputDeviceId();

		string GetCurrentAudioInputDeviceId();

		void SetAudioInputDeviceId(string id);
	}
}
