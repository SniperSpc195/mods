namespace net.STEAM
{
	public class Account : IAccount
	{
		private static Account mInstance;

		private Account()
		{
		}

		~Account()
		{
		}

		public UserId GetUserId()
		{
			return default;
		}

		public NetworkAccountId GetNetworkAccountId()
		{
			return default;
		}

		public Nickname GetNickname()
		{
			return default;
		}

		public UserHandle GetUserHandle()
		{
			return default;
		}

		public static IAccount GetInstance()
		{
			return null;
		}

		public bool Initialize()
		{
			return false;
		}
	}
}
