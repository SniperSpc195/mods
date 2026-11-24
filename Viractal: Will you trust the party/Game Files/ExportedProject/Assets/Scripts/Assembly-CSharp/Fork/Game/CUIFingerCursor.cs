using UnityEngine;

namespace Fork.Game
{
	public class CUIFingerCursor : MonoBehaviour
	{
		private static readonly float m_PingPongPeriod;

		private static readonly Vector2 m_PingPongV;

		[SerializeField]
		private RectTransform m_Finger;

		[SerializeField]
		private CanvasGroup m_CanvasGroup;

		private Vector2 m_CachedViewportPoint;

		private void Start()
		{
		}

		public void Activate(bool i_Switch, Vector2? i_ViewportPoint = null)
		{
		}

		private void Update()
		{
		}
	}
}
