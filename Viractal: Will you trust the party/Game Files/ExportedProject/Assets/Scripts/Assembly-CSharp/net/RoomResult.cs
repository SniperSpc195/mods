namespace net
{
	public enum RoomResult
	{
		Success = 0,
		Failure = -1,
		PlayerNotExist = -2,
		RoomNotExist = -3,
		PasswordUnmatch = -4,
		RoomIsClosed = -5,
		RoomIsFull = -6,
		BufferIsFull = -7,
		Retry = -8
	}
}
