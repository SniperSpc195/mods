using UnityEngine;

public class CUIGenericCursor : MonoBehaviour
{
	public enum SCROLL_STATE
	{
		Invalid = 0,
		Disable = 1,
		Enable = 2
	}

	private enum PINGPONG
	{
		None = 0,
		LeftCenter_0 = 1
	}

	[SerializeField]
	private CUIGenericScrollbar mScrollbar;

	[SerializeField]
	private GameObject mArrowTopLeft;

	[SerializeField]
	private GameObject mArrowBottomRight;

	[SerializeField]
	private CUIGenericExplain mExplainPop;

	[SerializeField]
	private bool mPage;

	[SerializeField]
	private RectTransform mCursor;

	[SerializeField]
	[ReadOnly]
	private Vector2 mUIPosition;

	[SerializeField]
	private Vector2 mZeroPosition;

	[SerializeField]
	private Vector2 mMoveOffset;

	[SerializeField]
	private string mSE;

	[SerializeField]
	[ReadOnly]
	private Vector2Int mDisplaySize;

	[SerializeField]
	[ReadOnly]
	private int mMaxItems;

	[SerializeField]
	[ReadOnly]
	private Vector2Int mMaxRect;

	[SerializeField]
	[ReadOnly]
	private Vector2Int[] mPosition;

	private bool mEnableLeftStick;

	private bool mLimitRight;

	[SerializeField]
	[ReadOnly]
	private SCROLL_STATE mScrollState;

	private static float mPingPongPeriod;

	private static float mPingPongResult;

	private static Vector2[] mPingPongV;

	[SerializeField]
	private PINGPONG mModePP;

	public int MaxItems => 0;

	public CUIGenericScrollbar GetScrollbar()
	{
		return null;
	}

	public CUIGenericExplain GetExplain()
	{
		return null;
	}

	public bool IsLayoutV()
	{
		return false;
	}

	public bool IsLayoutH()
	{
		return false;
	}

	public Vector2 GetZeroPosition()
	{
		return default;
	}

	public Vector2 GetMoveOffset()
	{
		return default;
	}

	public void EnableLeftStick()
	{
	}

	public void DisableLeftStick()
	{
	}

	public void SetLimitRight(bool a)
	{
	}

	public Vector2Int[] GetCursorV()
	{
		return null;
	}

	public int SetCursorV(Vector2Int[] v)
	{
		return 0;
	}

	public int SetCursorV(JsonNode json)
	{
		return 0;
	}

	public void SetPosition(int a)
	{
	}

	public void SetSize(Vector2Int dispSize, int max, bool resetPosition)
	{
	}

	public bool IsScroll()
	{
		return false;
	}

	public void Active(bool a, bool scrollbar_interlock = true)
	{
	}

	public int GetPosition()
	{
		return 0;
	}

	public int GetScrollX()
	{
		return 0;
	}

	public int GetScrollY()
	{
		return 0;
	}

	public int GetScroll()
	{
		return 0;
	}

	public void SetOffset(int a)
	{
	}

	public bool MoveCursor(GamePad pad)
	{
		return false;
	}

	private bool MoveLayoutH(GamePad pad)
	{
		return false;
	}

	private bool MoveLayoutV(GamePad pad)
	{
		return false;
	}

	public void UpdateDrawPosition()
	{
	}

	public Vector2 GetDrawPosition()
	{
		return default;
	}

	public bool SetScrollPosition(int scPos)
	{
		return false;
	}

	public bool ScrollUp()
	{
		return false;
	}

	public bool ScrollDown()
	{
		return false;
	}

	public bool ScrollPageUp()
	{
		return false;
	}

	public bool ScrollPageDown()
	{
		return false;
	}

	private void SetTop()
	{
	}

	private void SetBottom()
	{
	}

	private void CursorUp()
	{
	}

	private void CursorDown()
	{
	}

	private void CursorLeft()
	{
	}

	private void CursorRight()
	{
	}

	public void SEPlay()
	{
	}

	private void UpdateArrow(bool a = true)
	{
	}

	private void LateUpdate()
	{
	}

	public static void ProgressPingPong()
	{
	}

	public static float GetProgressPingPong()
	{
		return 0f;
	}
}
