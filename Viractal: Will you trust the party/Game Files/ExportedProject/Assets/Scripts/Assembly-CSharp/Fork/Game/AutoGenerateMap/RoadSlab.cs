using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public class RoadSlab
	{
		private Vector2Int mStartPos;

		private List<AdjacentSlab> mAdjacentList;

		private int mDistance;

		private int mLevel;

		private float mCost;

		private string mGroundType;

		private float mHeight;

		private int mArea;

		public List<AdjacentSlab> AdjacentList => null;

		public Vector2Int StartPos => default;

		public int Distance
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Cost
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string GroundType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Area
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public RoadSlab(Vector2Int startPos)
		{
		}

		public void AddAdjacent(RoadSlab roadSlab)
		{
		}

		public bool ExistsAdjacent(int x, int y)
		{
			return false;
		}
	}
}
