using Steamworks;

namespace net.STEAM
{
	public class RoomInfo : IRoomInfo
	{
		private CSteamID mSteamIDLobby;

		public RoomInfo()
		{
		}

		public RoomInfo(CSteamID steamIDLobby)
		{
		}

		~RoomInfo()
		{
		}

		public RoomId GetRoomId()
		{
			return default;
		}

		public PlayerId GetOwnerId()
		{
			return default;
		}

		public string GetOwnerName()
		{
			return null;
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
