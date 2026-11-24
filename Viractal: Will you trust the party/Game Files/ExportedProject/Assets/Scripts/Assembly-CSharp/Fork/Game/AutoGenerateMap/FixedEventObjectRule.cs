using System;

namespace Fork.Game.AutoGenerateMap
{
	[Serializable]
	public sealed class FixedEventObjectRule
	{
		public string areaId;

		public string eventObjectId;

		public int count;

		public string location;

		public float preferredProgressMin;

		public float preferredProgressMax;
	}
}
