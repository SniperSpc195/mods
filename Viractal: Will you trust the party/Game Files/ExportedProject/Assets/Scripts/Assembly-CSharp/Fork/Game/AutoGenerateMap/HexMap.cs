using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public class HexMap
	{
		public struct Bounds
		{
			public Vector2Int mMin;

			public Vector2Int mMax;

			public Dictionary<string, object> Save()
			{
				return null;
			}

			public void Load(JsonNode top)
			{
			}
		}

		public struct SpawnObject
		{
			public CEventEnum.EVID mEVID;

			public string mId;

			public Vector3Int mPosition;

			public SpawnObject(CEventEnum.EVID evid, string id, Vector3Int pos)
			{
				mEVID = CEventEnum.EVID._000;
				mId = null;
				mPosition = default;
			}

			public Dictionary<string, object> Save()
			{
				return null;
			}

			public void Load(JsonNode top)
			{
			}
		}

		public int mSuccessSeed;

		private HexObject[,] mHexObject;

		private Bounds mMapBounds;

		private List<SpawnObject> mEnemyPosList;

		private List<SpawnObject> mEventPosList;

		private List<Vector2Int> mValidPosition;

		public List<Vector2Int> ValidPosition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SpawnObject> EnemyPosList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SpawnObject> EventPosList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HexObject[,] HexObject => null;

		public int MaxWidth => 0;

		public int MaxHeight => 0;

		public ref Bounds MapBounds
		{
			get
			{
				throw null;
			}
		}

		public Dictionary<string, object> Save()
		{
			return null;
		}

		public HexMap(JsonNode top)
		{
		}

		public HexMap(int maxWidth, int maxHeight)
		{
		}

		public void Add(Vector3Int position, string objectId, Vector3 objectAngle, string groundId, string groundType, string areaId, int level, float height, AutoGenerateMap.RoadDir roadDir, Vector3 groundAngle, bool isPass)
		{
		}

		public void Clear()
		{
		}
	}
}
