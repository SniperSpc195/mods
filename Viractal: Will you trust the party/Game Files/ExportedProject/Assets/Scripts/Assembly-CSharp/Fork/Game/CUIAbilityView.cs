using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game
{
	public class CUIAbilityView : MonoBehaviour
	{
		[SerializeField]
		private Transform m_ContentRoot;

		[SerializeField]
		private CUIGenericOpenClose m_OpenClose;

		private CUIAbilityViewAbility[] m_Abilities;

		public CUIGenericOpenClose OpenClose => null;

		private CUIAbilityViewAbility[] Abilities => null;

		public void SetAbilities(List<CSkillAbilityData> i_Abilities)
		{
		}
	}
}
