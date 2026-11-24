using Steamworks;

namespace net
{
	public struct UserId
	{
		private CSteamID mUserId;

		public UserId(CSteamID userId)
		{
			mUserId = default;
		}

		public static implicit operator UserId(CSteamID steamId)
		{
			return default;
		}

		public static implicit operator UserId(ulong id)
		{
			return default;
		}

		public static implicit operator CSteamID(UserId userId)
		{
			return default;
		}

		public static implicit operator ulong(UserId userId)
		{
			return 0uL;
		}

		public bool Equals(UserId obj)
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
