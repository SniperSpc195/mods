using Fork.ModelButtons;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/DeckHolder")]
	public class CUIDeckHolder : MonoBehaviour
	{
		private const int CardLimit = 10;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIModelButton m_Button;

		[SerializeField]
		private TMP_Text m_NumberText;

		[SerializeField]
		private CUICharacterStatus m_Parent;

		[SerializeField]
		private Transform m_Card;

		[SerializeField]
		private Vector3 m_CardFullPos;

		[SerializeField]
		private Vector3 m_CardEmptyPos;

		private int m_RemainNumber;

		private void Start()
		{
		}

		public void SetValue(int i_RemainNumber)
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}
	}
}
