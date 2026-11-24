using UnityEngine;

namespace Fork.Game
{
	public class CUIArrow : MonoBehaviour
	{
		[SerializeField]
		public CUIGenericFocus m_Focus;

		[SerializeField]
		public Animator m_Animator;

		public bool IsAnimationPlaying()
		{
			return false;
		}

		public bool IsMouseButtonDecision()
		{
			return false;
		}

		public void On()
		{
		}

		public bool IsOnCursor(Vector2 position)
		{
			return false;
		}
	}
}
