using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CGameRoom_SettingOnline : MonoBehaviour
{
	[Serializable]
	public class CheckMark
	{
		public Image mCheckBase;

		public GameObject mCheck;

		public TextMeshProUGUI mText;

		public bool mEnabled;

		public void Set(bool a)
		{
		}
	}

	public enum NUM_PLAYERS
	{
		_3P = 0,
		_2P = 1,
		_2P_Guest = 2,
		_3_or_less = 3,
		Max = 4
	}

	public enum ENTRY_PERMIT
	{
		All = 0,
		Friend = 1
	}

	protected enum SELECT_STATE
	{
		None = 0,
		Change = 1,
		Cancel = 2,
		Decision = 3
	}

	protected const uint ONLINE_GAMEMODE_NEW = 0u;

	protected const string ALL_STAGE_ID = "All";

	[SerializeField]
	protected TextMeshProUGUI mText_SetupComplete;

	[SerializeField]
	protected CUIGenericFocus mSetupComplete;

	protected Vector2 mSize_SetupComplete;

	[SerializeField]
	protected CEventMessage mGMMessage;

	[SerializeField]
	protected CUIGenericMenu mMenu;

	[SerializeField]
	protected CUIGenericMenu mMenuSelection;

	[SerializeField]
	protected TextMeshProUGUI mTmSelectionBanner;

	private NUM_PLAYERS[] mHost_NumPlayersList;

	private NUM_PLAYERS[] mClient_NumPlayersList;

	protected string GetTextNumPlayers(NUM_PLAYERS n)
	{
		return null;
	}

	public void Active(bool a)
	{
	}

	protected List<string> Setup_StageSelection(string stageID, COnline.NETSTATE state)
	{
		return null;
	}

	protected NUM_PLAYERS[] Setup_NumPlayerSelection(NUM_PLAYERS n, COnline.NETSTATE state)
	{
		return null;
	}

	protected SELECT_STATE SelectMenu(GamePad pad, GamePad mouse, out CUIGenericFocus ui)
	{
		ui = null;
		return SELECT_STATE.None;
	}
}
