using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/DP")]
	public class CUIDp : CInOutBehaviour
	{
		private static readonly int _MainColorKey;

		[SerializeField]
		private Renderer m_TargetRenderer;

		[SerializeField]
		private int m_TargetMaterialIndex;

		[SerializeField]
		[ColorUsage(false, true)]
		private Color m_BaseColor;

		[SerializeField]
		private float m_FlashScale;

		[SerializeField]
		private float m_FlashTimecycle;

		private MaterialPropertyBlock _Props;

		public bool m_Flash;

		private MaterialPropertyBlock m_Props => null;

		public void SetFlash(bool i_IsFlash)
		{
		}

		private void Update()
		{
		}
	}
}
