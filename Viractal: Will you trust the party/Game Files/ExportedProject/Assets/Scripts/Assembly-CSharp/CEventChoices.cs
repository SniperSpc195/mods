using System.Collections.Generic;
using Fork.Game;
using UnityEngine;

public class CEventChoices : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Choices = 2,
		Close = 3,
		Setup_Ability = 4,
		Inquiry_Ability = 5,
		Confirmed_Ability = 6,
		Get_Ability = 7,
		End = 8
	}

	[SerializeField]
	private CChoiceMenu[] mMenus;

	[SerializeField]
	private CChoiceMenu mChoiceMenu;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private CUITooltip mTooltip_Bottom;

	[SerializeField]
	private CEventMessage mEventMessage;

	[SerializeField]
	[ReadOnly]
	private string mMessageText;

	private Vector2[] mDefMenuPosition;

	[SerializeField]
	[ReadOnly]
	private int mSelected;

	[SerializeField]
	[ReadOnly]
	private int mIndex_DP0;

	[SerializeField]
	private string mColorMissingDP;

	private List<CMaster_EventDpData> mDpData;

	public int mConsumeDP;

	private CFieldPlayer mFieldPlayer;

	private List<CMaster_SkillAbilityData> mList_SkillAbilityData;

	private CEventGrant mEventGrant;

	private MODE mMode;

	public int GetChoices()
	{
		return 0;
	}

	public CMaster_EventDpData GetChoicesDp()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Active(bool a)
	{
	}

	public void Go(string txt, GameController.PADNUM padNum, int cursorPosition = 0, bool enableCancel = false)
	{
	}

	public void Go(string[] lines, GameController.PADNUM padNum, int cursorPosition = 0, bool enableCancel = false)
	{
	}

	public void GoDp(List<CMaster_EventDpData> data, CFieldPlayer player)
	{
	}

	public void GoAbility(string ablList, int num1, int num2, CEventGrant eventGrant)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool Select(bool isControl, bool isOnline, GamePad pad)
	{
		return false;
	}

	private void MenuPosition(int menuMum)
	{
	}

	private void BlinkConsumeDP(bool blink = true)
	{
	}

	private void TooltipPosition(CUITooltip tooltip)
	{
	}

	private void CbDecision(int cur)
	{
	}

	private void CbCancel()
	{
	}

	private void CancelAbility()
	{
	}
}
