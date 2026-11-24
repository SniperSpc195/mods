using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CEnemyDescription : MonoBehaviour
	{
		public class EnemyConditionView
		{
			public CParamCondition m_Condition;

			public List<int> m_Values;
		}

		[SerializeField]
		private CUITooltip m_TooltipAbilityInfo;

		[SerializeField]
		private CUITooltip m_TooltipConditionInfo;

		[SerializeField]
		private TMP_Text m_AbilityText;

		[SerializeField]
		private TMP_Text m_ConditionText;

		[SerializeField]
		private CanvasGroup m_CanvasGroup;

		[SerializeField]
		private TMP_Text m_NameText;

		[SerializeField]
		private CFollowUI m_FollowUI;

		private List<EnemyConditionView> m_EnemyConditionsView;

		private bool m_UpdateConditionSize;

		private const float m_BaseConditionTooltipY = -40f;

		private const float m_BaseConditionLabelY = 94f;

		private const float m_ConditonMaxHeight = 780f;

		public CFollowUI FollowUI => null;

		private void Awake()
		{
		}

		public void SetEnemy(CBattleEnemy i_Enemy)
		{
		}

		private void CheckConditions(List<CParamCondition> i_Conditions)
		{
		}

		private void LateUpdate()
		{
		}

		private bool IsOverSized()
		{
			return false;
		}
	}
}
