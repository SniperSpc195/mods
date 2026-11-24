using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public static class RoadBarrierPlacement
	{
		private sealed class Search
		{
			private sealed class AreaScope
			{
				internal string Id;

				internal Vector2Int Entrance;

				internal Vector2Int Exit;

				internal Dictionary<Vector2Int, float> RoadProgress;
			}

			private const int MaxCombinations = 4096;

			private readonly HexObject[,] tiles;

			private readonly IReadOnlyList<MapArea> areas;

			private readonly Dictionary<string, AreaScope> scopes;

			private readonly ISet<Vector2Int> protectedTiles;

			private readonly List<List<RoadBarrierPlan>> slots;

			private readonly List<RoadBarrierPlan> selected;

			private readonly HashSet<Vector2Int> occupied;

			private readonly HashSet<Vector2Int> blocked;

			private int combinations;

			private static readonly AutoGenerateMap.RoadDir[] RoadDirections;

			internal Search(HexObject[,] tiles, IReadOnlyList<MapArea> areas, ISet<Vector2Int> protectedTiles)
			{
			}

			private bool Land(Vector2Int p)
			{
				return false;
			}

			private bool InArea(Vector2Int p, string areaId)
			{
				return false;
			}

			private bool ExistingObstacle(Vector2Int p)
			{
				return false;
			}

			private bool Protected(Vector2Int p, AreaScope scope)
			{
				return false;
			}

			private AreaScope Scope(string areaId)
			{
				return null;
			}

			private bool TryEndpoint(string areaId, Vector2Int point, out Vector2Int endpoint)
			{
				endpoint = default;
				return false;
			}

			internal bool Run(RoadBarrierRule[] rules, UtpnRandom random, out List<RoadBarrierPlan> plan, out string error)
			{
				plan = null;
				error = null;
				return false;
			}

			private List<RoadBarrierPlan> Candidates(RoadBarrierRule rule)
			{
				return null;
			}

			private static bool HasProgressPreference(RoadBarrierRule rule)
			{
				return false;
			}

			private float PreferenceDistance(RoadBarrierPlan candidate)
			{
				return 0f;
			}

			private Dictionary<Vector2Int, float> Progress(AreaScope scope)
			{
				return null;
			}

			private Dictionary<Vector2Int, int> RoadDistances(AreaScope scope, Vector2Int start)
			{
				return null;
			}

			private static Vector2Int NextInLine(Vector2Int p, int axis, bool reverse)
			{
				return default;
			}

			private bool Trace(Vector2Int gate, int axis, bool reverse, bool stopAtExisting, AreaScope scope, List<Vector2Int> walls, ref int reused)
			{
				return false;
			}

			private bool Choose(int index, int previous)
			{
				return false;
			}

			private HashSet<Vector2Int> Flood(AreaScope scope)
			{
				return null;
			}
		}

		public static bool TryPlan(HexObject[,] tiles, IReadOnlyList<MapArea> areas, ISet<Vector2Int> protectedTiles, RoadBarrierRule[] rules, UtpnRandom random, out List<RoadBarrierPlan> plan, out string error)
		{
			plan = null;
			error = null;
			return false;
		}

		public static Vector2Int Neighbor(Vector2Int p, int direction)
		{
			return default;
		}
	}
}
