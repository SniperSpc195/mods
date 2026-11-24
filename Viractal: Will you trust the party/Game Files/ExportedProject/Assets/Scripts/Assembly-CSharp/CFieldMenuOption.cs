using UnityEngine;

public class CFieldMenuOption : MonoBehaviour
{
	private enum MODE
	{
		End = 0,
		Open = 1,
		Execute = 2,
		Controller = 3,
		Config = 4,
		Config_Wait = 5,
		Help = 6,
		Help_Wait = 7,
		Save_Start = 8,
		Save_Now = 9,
		Return_Title_Inquiry = 10,
		Return_Title_Sync = 11,
		Return_Title_Start = 12,
		Return_Title = 13,
		Close = 14,
		LeaveRoom = 15
	}

	private enum MENU
	{
		None0 = 0,
		Config = 1,
		Controle = 2,
		Help = 3,
		Save = 4,
		Title = 5,
		Max = 6
	}

	[SerializeField]
	private CUIGenericMenu mMenu;

	[SerializeField]
	private CUIMenuControllers mNewControllers;

	[SerializeField]
	private CGameRoom_Continue mGameRoom_Continue;

	private CFieldPlayer mPlayer;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private double mTime;

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

	public void Go(CFieldPlayer player)
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
}
