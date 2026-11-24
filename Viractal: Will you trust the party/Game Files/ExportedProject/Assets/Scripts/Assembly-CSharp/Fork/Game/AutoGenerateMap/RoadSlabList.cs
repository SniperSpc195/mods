using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public class RoadSlabList
	{
		public class PriorityQueue<TElement, TPriority>
		{
			private SortedDictionary<TPriority, Queue<TElement>> dictionary;

			private int count;

			public int Count => 0;

			public PriorityQueue()
			{
			}

			public PriorityQueue(IComparer<TPriority> comparer)
			{
			}

			public void Enqueue(TElement element, TPriority priority)
			{
			}

			public TElement Dequeue()
			{
				return default;
			}

			public void Clear()
			{
			}
		}

		private List<RoadSlab> mSlabList;

		public List<RoadSlab> SlabList => null;

		public RoadSlabList(HexMap hexMap, (int area, float weight)[,] areaMap, int mapWidth, int mapHeight)
		{
		}

		public List<RoadSlab> RouteSearch(Vector2Int origin, Vector2Int destination)
		{
			return null;
		}

		private float CalcCost(RoadSlab origin, RoadSlab destination, RoadSlab current, RoadSlab old)
		{
			return 0f;
		}

		public List<RoadSlab> RouteSearch(RoadSlab origin, RoadSlab destination)
		{
			return null;
		}

		public RoadSlab SlabSearch(Vector2Int position)
		{
			return null;
		}
	}
}
