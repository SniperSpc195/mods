using System;
using Steamworks;

namespace net.STEAM
{
	public class GameServer : IDisposable
	{
		private const string logPrefix = "[GameServer]";

		private ILogger mpLogger;

		private bool mIsConnected;

		private CreateRoomReq mCreateRoomReq;

		private IAccount mAccountInstance;

		protected Callback<SteamServersConnected_t> mSteamServersConnected;

		protected Callback<SteamServerConnectFailure_t> mSteamServerConnectFailure;

		protected Callback<SteamServersDisconnected_t> mSteamServersDisconnected;

		protected Callback<SteamNetConnectionStatusChangedCallback_t> mSteamNetConnectionStatusChangedCallback;

		private const uint INADDR_ANY = 0u;

		private const uint INADDR_LOOPBACK = 2130706433u;

		private const uint INADDR_BROADCAST = 4294967295u;

		private const uint INADDR_NONE = 4294967295u;

		public GameServer(CreateRoomReq roomReq, ILogger pLogger, IAccount accountInstance)
		{
		}

		~GameServer()
		{
		}

		public void Dispose()
		{
		}

		public bool Connect(ConnectReq connectReq)
		{
			return false;
		}

		public void Disconnect()
		{
		}

		public ServerId GetServerId()
		{
			return default;
		}

		public void Logging(LogLevel.Level logLevel, string message)
		{
		}

		public bool IsConnected()
		{
			return false;
		}

		public void OnSteamServersConnected(SteamServersConnected_t pArg)
		{
		}

		public void OnSteamServerConnectFailure(SteamServerConnectFailure_t pArg)
		{
		}

		public void OnSteamServersDisconnected(SteamServersDisconnected_t pArg)
		{
		}

		public void OnNetConnectionStatusChangedCallback(SteamNetConnectionStatusChangedCallback_t pArg)
		{
		}
	}
}
