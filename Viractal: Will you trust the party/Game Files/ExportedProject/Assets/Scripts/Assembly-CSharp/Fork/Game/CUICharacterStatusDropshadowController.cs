using UnityEngine;
using UnityEngine.Animations;
using Zelude;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/DropshadowController")]
	public class CUICharacterStatusDropshadowController : MonoBehaviour
	{
		[SerializeField]
		private ParentConstraint m_StatusViewConstraint;

		[SerializeField]
		private Renderer m_Shadow;

		[SerializeField]
		[MinMaxSlider(0f, 1f, SliderFieldPosition.Left, SliderFieldPosition.Right)]
		private Vector2 m_ShadowByConstraint;

		[SerializeField]
		private float m_MaxAlpha;

		private MaterialPropertyBlock m_Props;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetMaxAlpha(float i_Alpha)
		{
		}
	}
}
