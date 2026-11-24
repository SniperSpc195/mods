using Steamworks;

namespace net
{
	public struct PlayerId
	{
		private CSteamID mPlayerId;

		public PlayerId(CSteamID playerId)
		{
			mPlayerId = default;
		}

		public static implicit operator PlayerId(CSteamID steamId)
		{
			return default;
		}

		public static implicit operator PlayerId(ulong id)
		{
			return default;
		}

		public static implicit operator CSteamID(PlayerId playerId)
		{
			return default;
		}

		public static implicit operator ulong(PlayerId playerId)
		{
			return 0uL;
		}

		public static implicit operator NetworkAccountId(PlayerId playerId)
		{
			return default;
		}

		public bool Equals(PlayerId playerId)
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
