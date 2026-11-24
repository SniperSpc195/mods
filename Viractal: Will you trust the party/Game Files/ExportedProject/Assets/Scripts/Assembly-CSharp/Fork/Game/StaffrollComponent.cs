using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class StaffrollComponent : MonoBehaviour
	{
		[SerializeField]
		protected CanvasGroup m_CanvasGroup;

		[SerializeField]
		protected LayoutElement m_LayoutElement;

		public CUIStaffroll m_Parent { get; set; }

		public float Height => 0f;

		public virtual void SetValue(CMaster_StaffrollData i_Data, CUIStaffroll i_Parent)
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
