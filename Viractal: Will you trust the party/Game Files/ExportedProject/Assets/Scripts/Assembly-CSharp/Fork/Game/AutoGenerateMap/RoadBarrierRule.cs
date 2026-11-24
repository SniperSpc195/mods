using System;

namespace Fork.Game.AutoGenerateMap
{
	[Serializable]
	public sealed class RoadBarrierRule
	{
		public string areaId;

		public int count;

		public string obstacleId;

		public string enemyGroupId;

		public string direction;

		public float preferredProgressMin;

		public float preferredProgressMax;
	}
}
