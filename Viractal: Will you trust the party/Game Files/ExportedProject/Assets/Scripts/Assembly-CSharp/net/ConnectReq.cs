namespace net
{
	public struct ConnectReq
	{
		public NetworkType mNetworkType;

		public bool mHostMigrationEnabled;

		public bool mAddRecentPlayRecordEnabled;

		public string mGameTitle;

		public string mProductId;

		public string mGameDir;

		public string mServerVersion;

		public bool mDebugPacketLatencyEnabled;

		public bool mDebugPacketLossEnabled;

		public ConnectReq(NetworkType networkType)
		{
			mNetworkType = NetworkType.Internet;
			mHostMigrationEnabled = false;
			mAddRecentPlayRecordEnabled = false;
			mGameTitle = null;
			mProductId = null;
			mGameDir = null;
			mServerVersion = null;
			mDebugPacketLatencyEnabled = false;
			mDebugPacketLossEnabled = false;
		}
	}
}
