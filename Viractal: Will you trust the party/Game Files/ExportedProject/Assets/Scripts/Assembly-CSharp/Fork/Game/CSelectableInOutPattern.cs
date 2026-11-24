using UnityEngine;

namespace Fork.Game
{
	public class CSelectableInOutPattern : CInOutPattern
	{
		public static readonly int SelectKey;

		public static readonly int DeselectKey;

		public CSelectableInOutPattern(Animator i_Animator)
			: base(null)
		{
		}

		public void Select()
		{
		}

		public void Deselect()
		{
		}

		public bool IsSelected()
		{
			return false;
		}
	}
}
