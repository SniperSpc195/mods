using System.Collections.Generic;
using TMPro;
using UnityEngine;
using net;

public class CGameRoom_RoomResult : CUIGenericMenu
{
	public class OLD_ROOM_RESULT
	{
		public int mPoint;

		public IRoomInfo mRoomInfo;

		public CSetting_Host.SETTING_HOST mHost;

		public string mPassword;

		public bool IsDummy()
		{
			return false;
		}

		public OLD_ROOM_RESULT(IRoomInfo info, CSetting_Host.SETTING_HOST host = null)
		{
		}

		public bool IsRestrictedByPassword()
		{
			return false;
		}

		public bool CheckSteamBuildID(int id)
		{
			return false;
		}
	}

	public enum STAT
	{
		None = 0,
		Cancel = 1,
		Retry = 2,
		Decision = 3
	}

	private enum MODE
	{
		None = 0,
		InputPass = 1,
		InputEnd = 2
	}

	[SerializeField]
	protected CEventMessage mGMMessage;

	[SerializeField]
	private GameObject mMenuFrame;

	[SerializeField]
	private TextMeshProUGUI mText_Bunner;

	[SerializeField]
	private TextMeshProUGUI mText_ButtonRetry;

	[SerializeField]
	private CUIGenericFocus mButtonRetry;

	private Vector2 mSize_ButtonRetry;

	private long mTime;

	[SerializeField]
	private TMP_InputField mInputField;

	[SerializeField]
	private TextMeshProUGUI mEmptyText;

	private const long RETRY_TIME = 3000L;

	private List<OLD_ROOM_RESULT> mRoomResultList;

	private OLD_ROOM_RESULT mSelectRoom;

	private bool IsContinue;

	private STAT mStat;

	private MODE mMode;

	private new void Awake()
	{
	}

	public void GoMenu(List<OLD_ROOM_RESULT> list, bool isContinue = false)
	{
	}

	public bool IsRetry()
	{
		return false;
	}

	public STAT Select(GamePad pad, GamePad mouse, out OLD_ROOM_RESULT room)
	{
		room = null;
		return STAT.None;
	}

	private void WriteItem(int index, Transform parent, OLD_ROOM_RESULT result)
	{
	}

	private void CB_Cancel()
	{
	}

	private void CB_Decision(int index)
	{
	}

	private void CB_Button(CUIGenericFocus ui)
	{
	}

	private void Setup_InputPass()
	{
	}

	private bool IsInputCancel(GamePad pad, GamePad mouse)
	{
		return false;
	}

	public void OnPassComplete(string a)
	{
	}
}
