using System.Collections.Generic;
using Steamworks;

namespace net.STEAM
{
	public class Room : IRoom
	{
		public CSteamID mSteamIDLobby;

		public List<IMember> mMembers;

		public Room(CSteamID steamIDLobby)
		{
		}

		~Room()
		{
		}

		public List<IMember> GetMembers()
		{
			return null;
		}

		public IMember GetMember(PlayerId playerId)
		{
			return null;
		}

		public PlayerId GetOwnerId()
		{
			return default;
		}

		public RoomId GetRoomId()
		{
			return default;
		}

		public uint GetGameMode()
		{
			return 0u;
		}

		public ushort GetCurrentParticipantNum()
		{
			return 0;
		}

		public ushort GetParticipantMax()
		{
			return 0;
		}

		public void GetBinData(ref byte[] pBinDataOut, uint dataSize)
		{
		}

		public uint GetBinDataSize()
		{
			return 0u;
		}

		public bool IsRestrictedByPassword()
		{
			return false;
		}

		public bool IsUseVoiceChat()
		{
			return false;
		}

		public float GetDistance()
		{
			return 0f;
		}
	}
}
