namespace net
{
	public enum MatchingError
	{
		NoneError = 0,
		InitializeError = -1,
		ConnectError = -2,
		DisconnectError = -3,
		SessionIsLost = -4,
		ConnectionIsLost = -5,
		ServerIsMaintenance = -6,
		DuplicateLogin = -7,
		KickedOut = -8,
		CanceledByUser = -9,
		RtcTokenError = -100,
		RtcConnectError = -101,
		RtcDisconnectError = -102,
		RtcConnectionIsLost = -103,
		RtcServerIsMaintenance = -104,
		RtcDuplicateLogin = -105,
		RtcAccessDenied = -106,
		RtcUnknownError = -1000
	}
}
