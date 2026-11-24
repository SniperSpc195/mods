using System.Collections.Generic;

namespace net
{
	public struct SearchRoomCondition
	{
		public uint mGameMode;

		public ushort mParticipantMax;

		public ushort mParticipantMin;

		public RoomType mRoomType;

		public bool mIncludeUserPasswordSet;

		public string mSessionConfigName;

		public List<RoomAttrCondition> mAttribute;

		public SearchRoomCondition(uint gameMode)
		{
			mGameMode = 0u;
			mParticipantMax = 0;
			mParticipantMin = 0;
			mRoomType = RoomType.Anybody;
			mIncludeUserPasswordSet = false;
			mSessionConfigName = null;
			mAttribute = null;
		}
	}
}
