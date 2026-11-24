using Fork.ModelButtons;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/DroprankColumn")]
	public class CUIModelDroprankColumn : MonoBehaviour
	{
		[SerializeField]
		private Renderer m_Reel;

		private MaterialPropertyBlock m_Property;

		private CUIDropRankGroup.Type m_Type;

		private float m_ValueBackup;

		private float m_Value;

		private Vector2 m_Velocity;

		private CUICharacterStatus m_Parent;

		public CUIModelButton Button { get; private set; }

		private void Awake()
		{
		}

		public void SetValue(float i_Value)
		{
		}

		private void Update()
		{
		}

		public CUIModelButton SetupButton(CUIDropRankGroup.Type i_Type, MeshRenderer i_HighlightSource)
		{
			return null;
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void SetParent(CUICharacterStatus i_Parent)
		{
		}
	}
}
