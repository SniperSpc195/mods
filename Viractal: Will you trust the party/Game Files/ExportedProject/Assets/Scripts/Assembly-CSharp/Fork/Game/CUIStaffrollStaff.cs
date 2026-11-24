using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUIStaffrollStaff : StaffrollComponent
	{
		[SerializeField]
		private TMP_Text m_LabelText;

		[SerializeField]
		private TMP_Text m_ValueText;

		public override void SetValue(CMaster_StaffrollData i_Data, CUIStaffroll i_Parent)
		{
		}
	}
}
