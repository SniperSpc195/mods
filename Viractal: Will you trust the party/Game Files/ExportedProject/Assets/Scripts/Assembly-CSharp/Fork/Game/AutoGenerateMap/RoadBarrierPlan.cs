using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public sealed class RoadBarrierPlan
	{
		public RoadBarrierRule Rule { get; }

		public string AreaId { get; }

		public Vector2Int Entrance { get; }

		public Vector2Int Exit { get; }

		public Vector2Int Gate { get; }

		public IReadOnlyList<Vector2Int> Walls { get; }

		public int ReusedObstacleCount { get; }

		internal RoadBarrierPlan(RoadBarrierRule rule, string areaId, Vector2Int entrance, Vector2Int exit, Vector2Int gate, List<Vector2Int> walls, int reusedObstacleCount)
		{
		}
	}
}
