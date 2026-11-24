using System;
using System.Globalization;
using Fork.Game;
using TMPro;
using UnityEngine;

public class CEventMessage : MonoBehaviour
{
	[Serializable]
	public class BALLOON_SETTING
	{
		public CEventEnum.MESWIN mWindow;

		public Transform mTransform;

		public Vector3 mOffsetWorld;

		public Vector2 mOffsetUI;

		public void Clear()
		{
		}

		public void Setup(CEventEnum.MESWIN win, Vector2 v)
		{
		}

		public void Setup(CEventEnum.MESWIN win, Transform t, Vector3 v3, Vector2 v2)
		{
		}

		public bool IsTransform()
		{
			return false;
		}

		public bool IsPositionUI()
		{
			return false;
		}
	}

	[Serializable]
	public struct LINE_INFO
	{
		public int firstIndex;

		public int lastIndex;

		public float width;

		public float height;

		public string lastCode;

		public LINE_INFO(TMP_LineInfo lineInfo, float h, StringInfo stInfo)
		{
			firstIndex = 0;
			lastIndex = 0;
			width = 0f;
			height = 0f;
			lastCode = null;
		}

		public bool IsNewLine(int index)
		{
			return false;
		}
	}

	private enum FORMAT
	{
		Rect = 0,
		Center = 1
	}

	private enum DRAW
	{
		All = 0,
		One = 1
	}

	private enum MODE
	{
		None = 0,
		Open = 1,
		Close = 2,
		Write = 3,
		PageWait = 4,
		AutoWait = 5,
		End = 6
	}

	private const float SKIP_ONE = 2f;

	[SerializeField]
	private Canvas m_Canvas;

	private bool m_CanvasOverrideSortDefault;

	private int m_CanvasSortOrderDefault;

	private CInOutPattern mInOut;

	[SerializeField]
	private BALLOON_SETTING mBalloonSetting;

	private const int INSERT_DATA_MAX = 10;

	private static string[] mInsertText;

	private static int[] mInsertNum;

	private static string[] mObtainName;

	private static Camera mCamera;

	[SerializeField]
	private RectTransform mFrameWidthCtrl;

	[SerializeField]
	private Vector2 mFrameSize;

	[SerializeField]
	private float mFramePaddingLeft;

	[SerializeField]
	private float mFramePaddingRight;

	[SerializeField]
	private int mRectMaxLine;

	[SerializeField]
	private TextMeshProUGUI mTMproRect;

	private Vector2 mSaveRectPosition;

	private Vector2 mSaveRectSize;

	private Vector2 mSaveCenterPosition;

	[SerializeField]
	private TextMeshProUGUI mTMproCenter;

	[SerializeField]
	private GameObject mPageButton;

	private Vector2 mPositionPageButton;

	private TextMeshProUGUI mTMproUse;

	[SerializeField]
	private string mText;

	[SerializeField]
	[ReadOnly]
	private string mParsedText;

	[SerializeField]
	[ReadOnly]
	private int mWriteTextNum;

	[SerializeField]
	[ReadOnly]
	private int mTextLength;

	[SerializeField]
	[ReadOnly]
	private int mMaxLineCount;

	[SerializeField]
	[ReadOnly]
	private int mNowLineCount;

	[SerializeField]
	[ReadOnly]
	private LINE_INFO[] mLineInfo;

	[SerializeField]
	private float[] mOneWait;

	private static float[] mLangWaitChar;

	private static float[] mLangWaitLine;

	[SerializeField]
	[ReadOnly]
	private float mWriteEndWait;

	private static GameController.PADNUM mExecPadNum;

	private bool mAwake;

	private bool mExistGameRoom;

	private FORMAT mFormat;

	[SerializeField]
	[ReadOnly]
	private DRAW mDraw;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	[SerializeField]
	[ReadOnly]
	private MODE mSubMode;

	[SerializeField]
	[ReadOnly]
	private bool mIsOpen;

	private float mWait;

	private bool mSkip;

	[SerializeField]
	[ReadOnly]
	private float mAlpha;

	private bool mOnPageButton;

	public float Alpha => 0f;

	public void SetBalloonSetting(BALLOON_SETTING s)
	{
	}

	public void ClearBalloonSetting()
	{
	}

	public static void SetCamera(Camera a)
	{
	}

	public string GetText()
	{
		return null;
	}

	public int GetLines()
	{
		return 0;
	}

	public static void SetPadNum(GameController.PADNUM num)
	{
	}

	public static GameController.PADNUM GetPadNum()
	{
		return GameController.PADNUM.PAD0;
	}

	public static GamePad GetPad()
	{
		return null;
	}

	public void Active(bool a)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public bool IsControl()
	{
		return false;
	}

	public bool IsOnline()
	{
		return false;
	}

	public void Awake()
	{
	}

	public void ClearText()
	{
	}

	private void ActiveText()
	{
	}

	private bool IsFormatRect()
	{
		return false;
	}

	private bool IsFormatCenter()
	{
		return false;
	}

	public bool IsOpen()
	{
		return false;
	}

	public void Open(bool fade = true)
	{
	}

	public void Close(bool fade = true)
	{
	}

	public bool IsFade()
	{
		return false;
	}

	public bool IsFadeEnd()
	{
		return false;
	}

	public string SetText(string text, bool pb = false, bool motionGM = true)
	{
		return null;
	}

	public string SetTextOne(string text, float wait = 0f, bool motionGM = true)
	{
		return null;
	}

	public string SetCenterText(string text, bool pb = false, bool motionGM = true)
	{
		return null;
	}

	public string SetCenterTextOne(string text, float wait = 0f, bool motionGM = true)
	{
		return null;
	}

	public void SetPageButton(bool a)
	{
	}

	public void SetSkip()
	{
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsPureWrite()
	{
		return false;
	}

	public bool IsWrite()
	{
		return false;
	}

	public bool IsWriteEnd()
	{
		return false;
	}

	private void Initialize(TextMeshProUGUI use, string text, FORMAT form, DRAW draw)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetTextCenterPosition()
	{
	}

	public static void SetInsertText(int ii, string code)
	{
	}

	public static void SetInsertNum(int ii, int num)
	{
	}

	public static void SetInsertObtain(int ii, string id, bool addIcon = true)
	{
	}

	public static string ProcessingText(string org)
	{
		return null;
	}

	public ButtonIconChange GetPageButtonIconChange()
	{
		return null;
	}

	public void SetSortOrder(int i_Order)
	{
	}

	public void ResetSortOrder()
	{
	}
}
