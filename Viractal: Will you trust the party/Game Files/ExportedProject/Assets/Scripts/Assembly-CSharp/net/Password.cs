namespace net
{
	public struct Password
	{
		private string mPassword;

		public Password(string password)
		{
			mPassword = null;
		}

		public static implicit operator Password(string password)
		{
			return default;
		}

		public static implicit operator string(Password password)
		{
			return null;
		}

		public bool Equals(Password obj)
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
