using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUIStaffrollHeadline : StaffrollComponent
	{
		[SerializeField]
		private TMP_Text m_LabelText;

		public override void SetValue(CMaster_StaffrollData i_Data, CUIStaffroll i_Parent)
		{
		}
	}
}
