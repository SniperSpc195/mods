using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public class HexObject
	{
		public Vector3Int mPosition;

		public string mObjectId;

		public Vector3 mObjectAngle;

		public string mGroundId;

		public string mAreaId;

		public AutoGenerateMap.RoadDir mRoadDir;

		public string mGroundType;

		public bool mIsPass;

		public Vector3 mGroundAngle;

		public int mLevel;

		public float mHeight;

		public bool mIsStep;

		public bool mIsCloud;

		public Dictionary<string, object> Save()
		{
			return null;
		}

		public HexObject()
		{
		}

		public HexObject(JsonNode top)
		{
		}
	}
}
