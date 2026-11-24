using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public class MapArea
	{
		public string mId;

		public int mAreaNum;

		public int mX;

		public int mY;

		public int mWidth;

		public int mHeight;

		public int mLevel;

		public string mGroundType;

		public RouteGenerate mRouteGenerate;

		public Vector2Int mStartPoint;

		public Vector2Int mViaPoint;

		public Vector2Int mEndPoint;

		public string mTownDetailId;

		public Vector2Int mTown;

		public AlongType mAlongType;

		public string mAreaShapeType;

		public List<Vector2Int> mAreaPosList;

		public List<Vector2Int> mViaCandidacyList;

		public List<HexObject> mRoadList;
	}
}
