using System;
using System.Collections.Generic;
using Cysharp.Text;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CCardView : MonoBehaviour
	{
		[SerializeField]
		private CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		private CUIGenericMenu m_Menu;

		[SerializeField]
		private CCardDetail m_CardDetail;

		[SerializeField]
		private TMP_Text m_TitleText;

		[SerializeField]
		private TMP_Text m_NumberText;

		[SerializeField]
		private CanvasGroup m_Cursor;

		[SerializeField]
		public CChoiceMenu m_ChoiceMenu;

		private int? m_PrevFocusIndex;

		private bool m_DeleteMode;

		private readonly string[] ButtonList;

		public List<CUICardSelectorCard> m_Cards { get; private set; }

		public List<CToggle> m_Toggles { get; private set; }

		public CUIGenericMenu Menu => null;

		public CUIGenericOpenClose OpenClose => null;

		public int m_InquiryDecision { get; private set; }

		private void Awake()
		{
		}

		public void Active(bool i_IsActive, bool i_ResetPosition = false)
		{
		}

		public void Initialize(CFieldPlayer i_Player, List<CSkillCardData> i_List)
		{
		}

		public void Initialize(Utf16ValueStringBuilder i_Title, List<CSkillCardData> i_List)
		{
		}

		public void Initialize(Utf16ValueStringBuilder i_Title, List<CSkillCardData> i_List, string i_NumberLabel)
		{
		}

		private void _Initialize(List<CSkillCardData> i_List)
		{
		}

		public bool MoveCursor(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
		{
			return false;
		}

		public void SetView()
		{
		}

		public void SetSelect()
		{
		}

		public void SwitchToggle()
		{
		}

		public void ShowToggleButton()
		{
		}

		public void HideToggleButton()
		{
		}

		public bool IsViewMode()
		{
			return false;
		}

		public void ToggleUpgrade()
		{
		}

		public void RefleshDetail()
		{
		}

		public bool IsMouseFocus()
		{
			return false;
		}

		public bool IsMouseFocusToggle()
		{
			return false;
		}

		public void EnterDeleteMode()
		{
		}

		public void LeaveDeleteMode()
		{
		}

		public void OpenInquiry(bool i_InitialYes = false, Action<int> onResult = null)
		{
		}

		public void CloseInquiry()
		{
		}

		public void UpdateInquiry(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
		{
		}

		private void CbInquiry_Cancel()
		{
		}

		private void CbInquiry_Decision(int result)
		{
		}

		public void SetCursor(int i_Index)
		{
		}
	}
}
