namespace net
{
	public struct UserHandle
	{
		private ulong mUserHandle;

		public UserHandle(ulong userHandle)
		{
			mUserHandle = 0uL;
		}

		public static implicit operator ulong(UserHandle userHandle)
		{
			return 0uL;
		}

		public static implicit operator UserHandle(ulong userHandle)
		{
			return default;
		}
	}
}
