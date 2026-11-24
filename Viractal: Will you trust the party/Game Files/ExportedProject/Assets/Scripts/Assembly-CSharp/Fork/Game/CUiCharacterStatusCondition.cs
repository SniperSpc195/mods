using Fork.ModelButtons;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUiCharacterStatusCondition : MonoBehaviour
	{
		private TMP_Text m_TurnText;

		private Animator m_Animator;

		private bool m_TooltipBottomMode;

		public string m_ID => null;

		public int? m_Number { get; private set; }

		public CParamCondition m_Condition { get; private set; }

		public CUIModelButton Button { get; private set; }

		public CInOutPattern m_InOut { get; private set; }

		public CUICharacterStatus m_Status { get; private set; }

		public CUICharacterStatusGroup m_StatusGroup { get; private set; }

		private void Awake()
		{
		}

		public void SetTooltipForEnemy(bool is_BottomMode)
		{
		}

		public void SetCharacterStatus(CUICharacterStatus i_Status)
		{
		}

		public void SetCharacterStatusGroup(CUICharacterStatusGroup i_StatusGroup)
		{
		}

		private void Start()
		{
		}

		public void UpdateValue(CParamCondition i_Condition)
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}
	}
}
