using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CUIMenuControllers : MonoBehaviour
{
	public class PAD_SETTING
	{
		public int mIndex;

		public GameController.PADNUM mPadNum;

		public string mName;

		public PAD_SETTING(int i, GameController.PADNUM padNum, string name)
		{
		}

		public PAD_SETTING(PAD_SETTING org)
		{
		}

		public void Update()
		{
		}
	}

	private enum MODE
	{
		End = 0,
		Open = 1,
		Close = 2,
		Start = 3,
		Select_Player = 4,
		Change_Controller = 5,
		Inquiry_Start = 6,
		Inquiry = 7
	}

	private enum RESULT
	{
		None = 0,
		Cancel = 1,
		Confirm = 2
	}

	private const string mSignalChange = "CUIMenuControllers.Change";

	private const string mSignalClose = "CUIMenuControllers.Close";

	[SerializeField]
	private CEventMessage mMessage;

	[SerializeField]
	[ReadOnly]
	private bool mOpenMessage;

	[SerializeField]
	private CUIButtonExplanation mButtonExp;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private CChoiceMenu mChoiceMenu;

	[SerializeField]
	private CUIGenericMenu mLayout;

	[SerializeField]
	private TextMeshProUGUI mTextOther;

	private CUISettingController[] mContSettings;

	[SerializeField]
	[ReadOnly]
	private int mSelect;

	private static GameController.PADNUM[] mUsedPadNum;

	private PAD_SETTING[] mOrgPadSettings;

	private PAD_SETTING[] mPadSettings;

	private int mMaxPlayers;

	private List<CFieldPlayer> mPlayers;

	private CFieldPlayer mExecPlayer;

	private GameController.PADNUM mPadNum_ExecPlayer;

	private GameController.PADNUM mDefaultPadNum;

	private static CUIButtonExplanation.DATA[] mKEYASSIGN_Start;

	private static CUIButtonExplanation.DATA[] mKEYASSIGN_Inquiry;

	private bool mExistField;

	private bool mIsOnlineField;

	private bool mIsControl;

	private MODE mMode;

	private RESULT mResult;

	public bool mPressedEnter;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static GameController.PADNUM GetFirstPadNum()
	{
		return GameController.PADNUM.PAD0;
	}

	private bool IsChange()
	{
		return false;
	}

	private void Active(bool a)
	{
	}

	public void Hide()
	{
	}

	private void Initialize()
	{
	}

	public void Go(PAD_SETTING[] setting = null)
	{
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool IsConfirm()
	{
		return false;
	}

	private void Update()
	{
	}

	private void EndedWithNothing()
	{
	}

	private void OnInquiry_Cancel()
	{
	}

	private void Back_ModeOpen()
	{
	}

	private void OnInquiry_Decision(int n)
	{
	}
}
