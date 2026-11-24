using System;
using System.Collections.Generic;
using UnityEngine;
using net;

namespace Test
{
	public class TestDbgNet : MonoBehaviour
	{
		private enum DbgNetState
		{
			Uninitialized = 0,
			IdolState = 1,
			WaitState = 2,
			LoginState = 3,
			ConnectedState = 4,
			CreateRoomState = 5,
			WaitJoinState = 6,
			SearchRoomState = 7,
			SelectRoomState = 8,
			WaitStartState = 9,
			LeaveState = 10,
			LogoutState = 11,
			GameStartState = 12
		}

		private Logger mLogManager;

		private NetworkLogProc mNetworkLogProc;

		[SerializeField]
		private DbgNetState mDbgNetState;

		private IMatching mMatching;

		private IRoomInfoList mRoomInfoList;

		[SerializeField]
		private CScrollMenu mNetMenu;

		private static readonly string[] IdolMenuText;

		private static readonly string[] ConnectedMenuText;

		private static readonly string[] WaitJoinMenuText;

		private static readonly string[] WaitStartMenuText;

		private static readonly string[] GameMenuText;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Update()
		{
		}

		private void ChangeState(DbgNetState state)
		{
		}

		public void OnConnect()
		{
		}

		public void OnDisconnect()
		{
		}

		public void OnError(MatchingError errorId)
		{
		}

		public void OnRoom(RoomEvent eventId, PlayerId playerId, PlayerId ownerId, PlayerId myId, List<PlayerId> playerIdList, IRoomInfoList roomInfoList, IntPtr data, int dataSize, RoomResult result)
		{
		}

		public void OnFriendList(List<NetworkAccountId> friendIdList, int count, RoomResult result)
		{
		}

		public void OnBlockList(List<NetworkAccountId> blockIdList, int count, RoomResult result)
		{
		}
	}
}
