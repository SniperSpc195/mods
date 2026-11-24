using Steamworks;

namespace net
{
	public struct ServerId
	{
		private CSteamID mServerId;

		public ServerId(CSteamID serverId)
		{
			mServerId = default;
		}

		public static implicit operator ServerId(CSteamID steamId)
		{
			return default;
		}

		public static implicit operator ServerId(ulong id)
		{
			return default;
		}

		public static implicit operator CSteamID(ServerId serverId)
		{
			return default;
		}

		public static implicit operator ulong(ServerId serverId)
		{
			return 0uL;
		}

		public bool Equals(ServerId obj)
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
