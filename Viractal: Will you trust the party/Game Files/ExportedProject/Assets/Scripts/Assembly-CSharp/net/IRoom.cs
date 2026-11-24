using System.Collections.Generic;

namespace net
{
	public interface IRoom
	{
		List<IMember> GetMembers();

		IMember GetMember(PlayerId playerId);

		PlayerId GetOwnerId();

		RoomId GetRoomId();

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
