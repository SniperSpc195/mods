namespace net
{
	public interface IAccount
	{
		UserId GetUserId();

		NetworkAccountId GetNetworkAccountId();

		Nickname GetNickname();

		UserHandle GetUserHandle();

		bool Initialize();
	}
}
