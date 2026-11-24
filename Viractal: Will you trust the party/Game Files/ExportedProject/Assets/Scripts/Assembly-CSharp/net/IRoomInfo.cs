namespace net
{
	public interface IRoomInfo
	{
		RoomId GetRoomId();

		PlayerId GetOwnerId();

		string GetOwnerName();

		uint GetGameMode();

		ushort GetCurrentParticipantNum();

		ushort GetParticipantMax();

		void GetBinData(ref byte[] pBinDataOut, uint dataSize);

		uint GetBinDataSize();

		bool IsRestrictedByPassword();

		bool IsUseVoiceChat();

		float GetDistance();
	}
}
