using System.Collections.Generic;

namespace net
{
	public struct CreateRoomReq
	{
		public uint mGameMode;

		public ushort mParticipantMax;

		public ushort mParticipantMin;

		public List<uint> mAttribute;

		public byte[] mBinData;

		public bool mIsRestrictedByPassword;

		public Password mPassword;

		public PlayerId mOwnerId;

		public RoomType mRoomType;

		public string mMapName;

		public string mSessionConfigName;

		public bool mUseVoiceChat;

		public float mDistance;

		public CreateRoomReq(uint gameMode)
		{
			mGameMode = 0u;
			mParticipantMax = 0;
			mParticipantMin = 0;
			mAttribute = null;
			mBinData = null;
			mIsRestrictedByPassword = false;
			mPassword = default;
			mOwnerId = default;
			mRoomType = RoomType.Anybody;
			mMapName = null;
			mSessionConfigName = null;
			mUseVoiceChat = false;
			mDistance = 0f;
		}
	}
}
