using System;

namespace Fork.Game.AutoGenerateMap
{
	[Serializable]
	public sealed class EventObjectRule
	{
		public string areaId;

		public int weightLayer;

		public EventObjectWeight[] weights;
	}
}
