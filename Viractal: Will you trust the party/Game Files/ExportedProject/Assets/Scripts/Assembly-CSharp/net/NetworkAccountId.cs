using Steamworks;

namespace net
{
	public struct NetworkAccountId
	{
		private CSteamID mNetworkAccountId;

		public NetworkAccountId(CSteamID networkAccountId)
		{
			mNetworkAccountId = default;
		}

		public static implicit operator NetworkAccountId(CSteamID steamId)
		{
			return default;
		}

		public static implicit operator NetworkAccountId(ulong id)
		{
			return default;
		}

		public static implicit operator CSteamID(NetworkAccountId networkAccountId)
		{
			return default;
		}

		public static implicit operator ulong(NetworkAccountId networkAccountId)
		{
			return 0uL;
		}

		public static implicit operator PlayerId(NetworkAccountId networkAccountId)
		{
			return default;
		}

		public bool Equals(NetworkAccountId obj)
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
