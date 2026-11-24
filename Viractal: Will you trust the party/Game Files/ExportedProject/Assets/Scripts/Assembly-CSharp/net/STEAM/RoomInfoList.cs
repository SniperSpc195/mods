using System.Collections.Generic;

namespace net.STEAM
{
	public class RoomInfoList : IRoomInfoList
	{
		private List<IRoomInfo> mRoomInfoList;

		public RoomInfoList(List<IRoomInfo> roomInfoList)
		{
		}

		public int GetRoomInfoNum()
		{
			return 0;
		}

		public IRoomInfo GetRoomInfo(int index)
		{
			return null;
		}

		public List<IRoomInfo> GetList()
		{
			return null;
		}
	}
}
