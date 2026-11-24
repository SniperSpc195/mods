using Fork.ModelButtons;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/NamePlate")]
	public class CUINamePlate : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text m_NameText;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIModelButton m_Button;

		private CUICharacterStatus m_Parent;

		private string m_Value;

		private void Awake()
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void SetParent(CUICharacterStatus i_Parent)
		{
		}

		public void SetValue(string i_Name)
		{
		}
	}
}
