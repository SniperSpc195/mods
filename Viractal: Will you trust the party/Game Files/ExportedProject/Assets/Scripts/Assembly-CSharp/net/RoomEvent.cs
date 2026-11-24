namespace net
{
	public enum RoomEvent
	{
		Nothing = 0,
		CreateRoom = 1,
		JoinRoom = 2,
		OtherJoinRoom = 3,
		LeaveRoom = 4,
		OtherLeaveRoom = 5,
		CloseJoin = 6,
		HostChanged = 7,
		SearchRoom = 8,
		MemberDataUpdate = 9,
		Broadcast = 10,
		Othercast = 11,
		Unicast = 12,
		Multicast = 13,
		Receive = 14,
		GameStart = 15,
		JoinRtChat = 16,
		LeaveRtChat = 17
	}
}
