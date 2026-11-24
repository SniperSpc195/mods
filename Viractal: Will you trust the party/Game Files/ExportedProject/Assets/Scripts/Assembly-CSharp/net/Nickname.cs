namespace net
{
	public struct Nickname
	{
		private string mNickname;

		public Nickname(string nickname)
		{
			mNickname = null;
		}

		public static implicit operator string(Nickname nickname)
		{
			return null;
		}

		public static implicit operator Nickname(string nickname)
		{
			return default;
		}
	}
}
