namespace net
{
	public interface IMember
	{
		bool IsOwner();

		bool IsMe();

		string GetName();

		PlayerId GetPlayerId();

		uint GetOrder();

		uint GetIndex();
	}
}
