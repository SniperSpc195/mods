using System.Collections.Generic;
using UnityEngine;

public class CGameRoom_Setting_Controller : MonoBehaviour
{
	public class SETTING_CONT
	{
		public string mName;

		public GameController.PADNUM mPadNum;

		public bool mMe;

		public SETTING_CONT(string name, GameController.PADNUM pad, bool me = true)
		{
		}
	}

	private enum MODE
	{
		None = 0,
		Player = 1,
		Controller = 2,
		Cancel = 3,
		Confirm = 4
	}

	[SerializeField]
	private CUIGenericMenu mMenuPlayers;

	[SerializeField]
	private CUIGenericFocus[] mArrow;

	private Dictionary<GameController.PADNUM, string> PadNumToContcollers;

	private static GameController.PADNUM[] PadNumList;

	private SETTING_CONT[] mSetting;

	private int mSelectPlayer;

	private List<CFieldPlayer> mFieldPlayers;

	private bool IsOnline;

	private MODE mMode;

	public void Active(bool a)
	{
	}

	public void GoMenu(SETTING_CONT[] setting)
	{
	}

	public void GoMenu(List<CFieldPlayer> players, int execPlayerIndex, bool online)
	{
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool IsConfirm()
	{
		return false;
	}

	public void Select()
	{
	}

	private void WritePlayers()
	{
	}

	private void SetFrameSize(CUIGenericMenu menu, int length)
	{
	}

	private void UpdatePlayers(bool all)
	{
	}

	private void UpdateArrow()
	{
	}

	private bool ChangeController(SETTING_CONT setting, int lr)
	{
		return false;
	}

	private void SelectLeft(bool IsControl, int cur)
	{
	}

	private void SelectRight(bool IsControl, int cur)
	{
	}

	private bool IsAllConnected()
	{
		return false;
	}
}
