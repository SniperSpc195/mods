using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace net
{
	public class RtChat : IDisposable
	{
		public interface ISound
		{
			bool IsVoiceFocus();

			void SetVoiceFocus(bool flag);

			bool IsEnabledBinauralizer();

			void Update();
		}

		public enum ConnectionType
		{
			p2p = 0,
			sfu = 1
		}

		public enum RoomKind
		{
			np = 0,
			p3d = 1
		}

		public enum RtcState
		{
			Idoling = 0,
			Opening = 1,
			Connecting = 2,
			Connected = 3,
			Closing = 4,
			Error = 5
		}

		public enum RtcError
		{
			NoneError = 0,
			TokenError = -1,
			ConnectError = -2,
			DisconnectError = -3,
			ConnectionIsLost = -5,
			ServerIsMaintenance = -6,
			DuplicateLogin = -7,
			AccessDenied = -8,
			ListenerIsNull = -200,
			ExPlayerIsNull = -201,
			Ex3dSourceIsNull = -202,
			UnknownError = -1000
		}

		public enum Platform
		{
			Steam = 0,
			Switch = 1
		}

		public struct ConnectReq
		{
			public ConnectionType mConnectionType;

			public uint mMaxParticipant;

			public RoomId mRoomId;

			public PlayerId mPlayerId;

			public bool mEncrypt;

			public RoomKind mRoomKind;

			public bool mMute;

			public Platform mPlatform;

			public RtcError mForceError;

			public string mAppId;

			public string mInterfaceVer;
		}

		public struct AudioInputDeviceInfo
		{
			public CriRtc.AudioInputDeviceInfo mInfo;

			public string Id
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string Name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class Member
		{
			private CriRtcRoomSession.Member mMember;

			private CriAtomExPlayer mAtomExPlayer;

			private CriAtomEx3dSource m3dSource;

			private bool mMute;

			private float mVolume;

			public bool Mute
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public float Volume
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public string ClientId => null;

			public PlayerId PlayerId => default;

			public CriAtomExPlayer AtomExPlayer => null;

			public CriAtomEx3dSource AtomEx3dSource
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Member(CriRtcRoomSession.Member member, bool mute, float volume, CriAtomEx3dSource source, CriAtomExPlayer exPlayer)
			{
			}

			public void ClearResource()
			{
			}

			public void SetPosition(float x, float y, float z)
			{
			}

			public void SetOrientation(Vector3 front, Vector3 top)
			{
			}

			public void SetAttenuationDistanceSetting(bool flag)
			{
			}

			public void Update()
			{
			}
		}

		public delegate void AccessTokenCallback(string token, string clientId);

		public delegate void ConnectCallback();

		public delegate void DisconnectCallback();

		public delegate void SessionCallback(List<Member> memberList);

		public delegate void ErrorCallback(RtcError error);

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTokenRequest_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Dictionary<string, object> tokenReqParam;

			public RtChat _003C_003E4__this;

			private UnityWebRequest _003CwebRequest_003E5__2;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private const string logPrefix = "[RtChat]";

		private RtcState mRtcState;

		private CriRtcRoomSession mCriRtcRoomSession;

		private CriRtcClient mCriRtcClient;

		private CriRtcRoomSession.Status mLastRoomSessionStatus;

		private CriRtcRoomSession.Config mRoomSessionConfig;

		private CriRtcClient.Config mClientConfig;

		private ILogger mpLogger;

		private List<Member> mMemberList;

		private ConnectReq mConnectReq;

		private CriAtomEx3dListener m3dListener;

		private float mReceiveVolume;

		private float mReceiveVolumeGain;

		[CompilerGenerated]
		private AccessTokenCallback m_AccessTokenEventCallback;

		[CompilerGenerated]
		private ConnectCallback m_ConnectedEventCallback;

		[CompilerGenerated]
		private DisconnectCallback m_DisconnectedEventCallback;

		[CompilerGenerated]
		private SessionCallback m_SessionEventCallback;

		[CompilerGenerated]
		private ErrorCallback m_ErrorEventCallback;

		private IAccount mAccountInstance;

		private ISound mSound;

		private event AccessTokenCallback AccessTokenEventCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event ConnectCallback ConnectedEventCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event DisconnectCallback DisconnectedEventCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event SessionCallback SessionEventCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event ErrorCallback ErrorEventCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public RtChat(IAccount accountInstance, ISound voiceFocus)
		{
		}

		~RtChat()
		{
		}

		public void Dispose()
		{
		}

		private RtcState ChangeState(RtcState newState)
		{
			return RtcState.Idoling;
		}

		private void OnAccessTokenEventCallback(string token, string clientId)
		{
		}

		[AsyncStateMachine(typeof(_003CTokenRequest_003Ed__49))]
		private void TokenRequest(Dictionary<string, object> tokenReqParam)
		{
		}

		public void Update()
		{
		}

		private void ClearMemberList(List<Member> memberList)
		{
		}

		private void ClearListener(CriAtomEx3dListener listener)
		{
		}

		public void SetListenerPosition(float x, float y, float z)
		{
		}

		public void SetListenerOrientation(Vector3 front, Vector3 top)
		{
		}

		public void ListenerUpdate()
		{
		}

		public int GetNumAvailableAudioInputDevices()
		{
			return 0;
		}

		public bool GetAudioInputDeviceInfoByIndex(int index, ref AudioInputDeviceInfo info)
		{
			return false;
		}

		public string GetAudioInputDeviceId()
		{
			return null;
		}

		public string GetCurrentAudioInputDeviceId()
		{
			return null;
		}

		public void SetAudioInputDeviceId(string id)
		{
		}

		public void Open(ConnectReq connectReq)
		{
		}

		public void Close()
		{
		}

		public void AddConnectedEventCallback(ConnectCallback callback)
		{
		}

		public void AddDisconnectedEventCallback(DisconnectCallback callback)
		{
		}

		public void AddSessionEventCallback(SessionCallback callback)
		{
		}

		public void AddErrorEventCallback(ErrorCallback callback)
		{
		}

		public void SetLogManager(ILogger logger)
		{
		}

		public void SetReceiveVolume(float volume)
		{
		}

		public float GetReceiveVolume()
		{
			return 0f;
		}

		public void SetReceiveMute(bool flag)
		{
		}

		public bool GetReceiveMute()
		{
			return false;
		}

		public void SetReceiveClientVolume(PlayerId playerId, float volume)
		{
		}

		public float GetReceiveClientVolume(PlayerId playerId)
		{
			return 0f;
		}

		public void SetReceiveClientMute(PlayerId playerId, bool flag)
		{
		}

		public bool GetReceiveClientMute(PlayerId playerId)
		{
			return false;
		}

		public void SetSendVolume(float volume)
		{
		}

		public float GetSendVolume()
		{
			return 0f;
		}

		public void SetSendMute(bool flag)
		{
		}

		public bool GetSendMute()
		{
			return false;
		}

		public bool IsVoiceActive()
		{
			return false;
		}

		public float GetInputRms()
		{
			return 0f;
		}

		public float GetReceivedAudioRms(PlayerId playerId)
		{
			return 0f;
		}

		public void SetPitch(PlayerId playerId, float pitch)
		{
		}

		public void SetBusSendLevel(PlayerId playerId, string busName, float sendLevel)
		{
		}

		private void Logging(LogLevel.Level logLevel, string message)
		{
		}

		private string DisconnectedReasonToStr(CriRtcRoomSession.DisconnectedReason disconnectedReason)
		{
			return null;
		}

		private string RoomSessionStatusToStr(CriRtcRoomSession.Status status)
		{
			return null;
		}

		private string RtcStateToStr(RtcState state)
		{
			return null;
		}

		private string FromBase64UrlToString(string base64url)
		{
			return null;
		}

		private void Connect(string token)
		{
		}
	}
}
