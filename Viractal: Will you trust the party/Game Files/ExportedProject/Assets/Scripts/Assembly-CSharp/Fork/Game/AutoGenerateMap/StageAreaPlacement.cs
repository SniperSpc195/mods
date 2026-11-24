using System;

namespace Fork.Game.AutoGenerateMap
{
	[Serializable]
	public sealed class StageAreaPlacement
	{
		public string areaId;

		public string direction;

		public bool centerX;

		public int offsetX;

		public int offsetY;

		public bool required;

		public bool alignBottom;
	}
}
