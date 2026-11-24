using System.Collections.Generic;
using UnityEngine;

public class CSetting_RoomResult : CSetting_Online
{
	private enum MODE
	{
		None = 0,
		Select_Start = 1,
		Select = 2,
		Inquiry_UnopenedStage = 3,
		Password = 4,
		Retry = 5,
		Complete = 6
	}

	private const long RETRY_TIME = 3000L;

	private long mTime;

	private bool mRetry;

	[SerializeField]
	private CUIGenericDialog mDialog;

	[SerializeField]
	protected GameObject mParentStage;

	private List<ROOM_RESULT> mResults;

	private ROOM_RESULT mSelectRoom;

	private bool IsContinue;

	private const uint BTN_RETRY = 262144u;

	private CUIButtonExplanation.DATA[] Result_ButtonData;

	private MODE mMode;

	private void Awake()
	{
	}

	public ROOM_RESULT GetEnterRoom()
	{
		return null;
	}

	public void GoMenu(List<ROOM_RESULT> list, bool isContinue = false)
	{
	}

	public void GoResume()
	{
	}

	private bool IsResultEmpty()
	{
		return false;
	}

	private bool IsTimeExceeded()
	{
		return false;
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool IsRetry()
	{
		return false;
	}

	public bool IsComplete()
	{
		return false;
	}

	private void Update()
	{
	}

	private void Cb_Cancel()
	{
	}

	private void Cb_ItemDecision(int i)
	{
	}

	private void Next_Mode()
	{
	}

	private void Set_Contents(Transform parent, ROOM_RESULT result)
	{
	}

	private void Active_Contents(Transform parent, bool a)
	{
	}
}
