using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public static class FixedEventObjectPlacement
	{
		public const int TreasureCapacity = 100;

		public const int ObjectCapacity = 100;

		public static void Validate(FixedEventObjectRule[] rules, string[] areaIds, string stageId)
		{
		}

		public static bool HasProgressPreference(FixedEventObjectRule rule)
		{
			return false;
		}

		public static int SelectCandidate(FixedEventObjectRule rule, List<Vector2Int> candidates, Dictionary<Vector2Int, float> progress, UtpnRandom random)
		{
			return 0;
		}

		public static void ValidateMasters(FixedEventObjectRule[] rules, CMaster_EventObjectData[] masters)
		{
		}
	}
}
