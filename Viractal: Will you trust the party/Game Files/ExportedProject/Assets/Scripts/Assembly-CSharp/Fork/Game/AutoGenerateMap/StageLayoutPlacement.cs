using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public static class StageLayoutPlacement
	{
		public static bool TryPlace(StageAreaPlacement rule, Vector2Int size, Vector2Int boardSize, Vector2Int start, IReadOnlyList<RectInt> placed, out RectInt result, bool mirroredX = false)
		{
			result = default;
			return false;
		}

		private static int CenterOffset(int difference, bool mirroredX)
		{
			return 0;
		}
	}
}
