namespace net.STEAM
{
	public class Member : IMember
	{
		public bool mIsOwner;

		public bool mIsMe;

		public PlayerId mPlayerId;

		public string mNickname;

		public uint mOrder;

		public uint mIndex;

		~Member()
		{
		}

		public bool IsOwner()
		{
			return false;
		}

		public bool IsMe()
		{
			return false;
		}

		public string GetName()
		{
			return null;
		}

		public PlayerId GetPlayerId()
		{
			return default;
		}

		public uint GetOrder()
		{
			return 0u;
		}

		public uint GetIndex()
		{
			return 0u;
		}
	}
}
