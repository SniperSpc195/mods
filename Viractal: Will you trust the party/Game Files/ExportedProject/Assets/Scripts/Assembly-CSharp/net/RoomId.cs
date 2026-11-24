using Steamworks;

namespace net
{
	public struct RoomId
	{
		private CSteamID mRoomId;

		public RoomId(CSteamID steamId)
		{
			mRoomId = default;
		}

		public static implicit operator RoomId(CSteamID steamId)
		{
			return default;
		}

		public static implicit operator RoomId(ulong id)
		{
			return default;
		}

		public static implicit operator CSteamID(RoomId roomId)
		{
			return default;
		}

		public static implicit operator ulong(RoomId roomId)
		{
			return 0uL;
		}

		public bool Equals(RoomId obj)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
