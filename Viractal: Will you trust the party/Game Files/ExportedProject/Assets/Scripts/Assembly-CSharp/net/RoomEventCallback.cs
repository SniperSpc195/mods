using System;
using System.Collections.Generic;

namespace net
{
	public delegate void RoomEventCallback(RoomEvent eventId, PlayerId playerId, PlayerId ownerId, PlayerId myId, List<PlayerId> playerIdList, IRoomInfoList roomInfoList, IntPtr data, int dataSize, RoomResult result);
}
