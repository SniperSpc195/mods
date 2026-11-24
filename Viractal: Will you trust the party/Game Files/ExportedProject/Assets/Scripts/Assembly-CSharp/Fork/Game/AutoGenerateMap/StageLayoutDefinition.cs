using System;

namespace Fork.Game.AutoGenerateMap
{
	[Serializable]
	public sealed class StageLayoutDefinition
	{
		public bool debugOnlyLayout;

		public string placement;

		public StageAreaPlacement[] areas;

		public StageLayoutPattern[] patterns;

		public string startEndpoint;

		public string endEndpoint;

		public float endpointTolerance;

		public bool allowShortStartRoad;

		public bool preserveY;

		public int topPadding;

		public bool resetBounds;

		public bool shiftAreaOrigins;

		public bool centerLand;

		public int centerOffsetY;

		public string[] excludedEnemyGroups;

		public RoadBarrierRule[] roadBarriers;

		public EventObjectRule[] eventObjectRules;

		public FixedEventObjectRule[] fixedEventObjects;

		public bool MirroredX { get; internal set; }

		public bool LayoutEnabled => false;

		internal StageLayoutDefinition Copy()
		{
			return null;
		}

		public static StageLayoutDefinition Load(string stageId)
		{
			return null;
		}

		public static StageLayoutDefinition FromJson(string json)
		{
			return null;
		}

		public void Validate(string stageId, string[] areaIds)
		{
		}

		private static bool ValidEndpoint(string value)
		{
			return false;
		}
	}
}
