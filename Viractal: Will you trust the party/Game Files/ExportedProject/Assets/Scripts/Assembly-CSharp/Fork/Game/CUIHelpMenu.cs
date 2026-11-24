using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUIHelpMenu : SingletonMonoBehaviour<CUIHelpMenu>
	{
		private enum State
		{
			None = 0,
			Wait = 1,
			Open = 2,
			Select = 3,
			Close = 4
		}

		public static readonly Color m_ActiveColor;

		public static readonly Color m_InactiveColor;

		private const int SingleRowHeight = 51;

		[SerializeField]
		private TMP_Text m_HeaderText;

		[SerializeField]
		private CUIGenericMenu m_Menu;

		[SerializeField]
		private RectTransform m_ItemParent;

		[SerializeField]
		private CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		private CUIHelpDetail m_HelpDetail;

		[SerializeField]
		private CanvasGroup m_CanvasGroup;

		[SerializeField]
		private CUIGenericCursor m_Cursor;

		private State m_State;

		private bool m_Prepared;

		private int m_PreviousIndex;

		private List<object> m_Helps;

		private Vector2Int[] m_PreviousPositions;

		private Vector2Int[] m_TempPositions;

		private int blockCounter;

		public static bool IsOnline_ErrorOrLeave()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void InvalidateList()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public void Active(bool i_Switch, GameController.PADNUM i_PadNum)
		{
		}

		private void Update()
		{
		}

		private void UpdateSelect()
		{
		}

		private void SetDetail(object i_Help)
		{
		}

		private void CreateHelp()
		{
		}

		private void CreateButtonContent()
		{
		}

		private void UpdateButtons()
		{
		}
	}
}
