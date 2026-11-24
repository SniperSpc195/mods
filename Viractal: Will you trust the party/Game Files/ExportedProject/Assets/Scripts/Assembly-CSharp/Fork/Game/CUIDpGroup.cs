using Fork.ModelButtons;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/DpGroup")]
	public class CUIDpGroup : MonoBehaviour
	{
		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIModelButton m_Button;

		private CUICharacterStatus m_Parent;

		public CUIModelButtonGroup ButtonGroup => null;

		private void Awake()
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void SetParent(CUICharacterStatus i_Parent)
		{
		}
	}
}
