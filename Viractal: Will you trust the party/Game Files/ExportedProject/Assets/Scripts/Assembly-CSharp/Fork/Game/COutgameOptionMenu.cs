using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class COutgameOptionMenu : MonoBehaviour
	{
		public enum PLACE
		{
			GameRoom = 0,
			Field = 1
		}

		private enum MODE
		{
			End = 0,
			Open = 1,
			Execute = 2,
			Next = 3,
			Controller = 4,
			Config = 5,
			Config_Wait = 6,
			Help = 7,
			Help_Wait = 8,
			ExitGame_Inquiry = 9,
			SaveEnd_Inquiry = 10,
			Save_Start = 11,
			Save_Now = 12,
			LeaveRoom = 13,
			Return_Title_Start = 14,
			Return_Title = 15,
			Close = 16
		}

		private enum MENU
		{
			Config = 0,
			Control = 1,
			Help = 2,
			ExitGame = 3,
			Save = 4,
			Back = 5,
			Max = 6
		}

		[SerializeField]
		private float[] mFrameHeight;

		[SerializeField]
		private CUIGenericMenu mMenu;

		[SerializeField]
		private CUIControllerButtons mControllerButtons;

		[SerializeField]
		private CUIGenericOpenClose mOpenClose;

		[SerializeField]
		private TMP_Text m_HeaderText;

		[SerializeField]
		private TMP_Text m_VersionsText;

		[SerializeField]
		[ReadOnly]
		private PLACE mPlace;

		private CFieldPlayer mPlayer;

		public static readonly Color mMenuHighlightColor;

		public static readonly Color mMenuEnableColor;

		public static readonly Color mMenuDisableColor;

		[SerializeField]
		[ReadOnly]
		private MODE mMode;

		private MODE mNext;

		private double mTime;

		private bool[] mShow;

		private bool mSettingKeyboard;

		private MENU[] mMenuList;

		private List<CSaveData.WRITEDATA> mSaveList;

		public bool IsExecute()
		{
			return false;
		}

		public bool IsEnd()
		{
			return false;
		}

		private void Awake()
		{
		}

		private GameController.PADNUM GetPadNum()
		{
			return GameController.PADNUM.PAD0;
		}

		private void OnButtonAssignChanged(CConfigData.ButtonAssign assign)
		{
		}

		public void Go(PLACE place, CFieldPlayer player = null)
		{
		}

		private void MenuActive(bool a)
		{
		}

		private void Update()
		{
		}

		private void CB_Cancel()
		{
		}

		private void CB_Decision(int cur)
		{
		}

		private void UpdateButtonColor()
		{
		}
	}
}
