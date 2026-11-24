using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CUIGenericMenu : MonoBehaviour
{
	[SerializeField]
	[ReadOnly]
	protected string mBaseNameCB;

	[SerializeField]
	[ReadOnly]
	protected string mBaseNameCursorPosition;

	[SerializeField]
	private UnityEvent mCbCancel;

	[SerializeField]
	private bool mEnableCancel;

	[SerializeField]
	[ReadOnly]
	private List<UnityAction> mRegCancel;

	[SerializeField]
	private UnityEvent<int> mCbItemDecision;

	[SerializeField]
	private bool mEnableItemDecision;

	[SerializeField]
	[ReadOnly]
	private List<UnityAction<int>> mRegItemDecision;

	[SerializeField]
	private UnityEvent<CUIGenericFocus> mCbButtonDecision;

	[SerializeField]
	private bool mEnableButtonDecision;

	[SerializeField]
	[ReadOnly]
	private List<UnityAction<CUIGenericFocus>> mRegButtonDecision;

	[SerializeField]
	protected RectTransform mMouseResponsive;

	[SerializeField]
	protected Vector2 mItemSize;

	[SerializeField]
	protected Vector2 mItemSpacing;

	[SerializeField]
	protected Vector2 mItemZeroPosition;

	[SerializeField]
	protected Vector2Int mDisplaySize;

	[SerializeField]
	[ReadOnly]
	protected int mMaxItems;

	[SerializeField]
	protected RectTransform mItemParent;

	[SerializeField]
	protected CUIGenericCursor mCursor;

	protected CUIGenericScrollbar mScrollbar;

	private CUIGenericSelected[] mSelectedItems;

	private int mOldCursorPosition;

	private List<CUIGenericFocus> mOtherFocusList;

	private List<CUIGenericFocus> mItemFocusList;

	private CUIGenericFocusResult mFocusResult;

	public void RemoveCbCancel(UnityAction cb)
	{
	}

	public void RemoveAllCbCancel()
	{
	}

	public bool SetCbCancel(UnityAction cb)
	{
		return false;
	}

	public void EnableCbCancel(bool a)
	{
	}

	private bool IsCbCancel()
	{
		return false;
	}

	public void RemoveCbItemDecision(UnityAction<int> cb)
	{
	}

	public void RemoveAllCbItemDecision()
	{
	}

	public bool SetCbItemDecision(UnityAction<int> cb)
	{
		return false;
	}

	public void EnableCbItemDecision(bool a)
	{
	}

	private bool IsCbItemDecision()
	{
		return false;
	}

	public void RemoveCbButtonDecision(UnityAction<CUIGenericFocus> cb)
	{
	}

	public void RemoveAllCbButtonDecision()
	{
	}

	public bool SetCbButtonDecision(UnityAction<CUIGenericFocus> cb)
	{
		return false;
	}

	public void EnableCbButtonDecision(bool a)
	{
	}

	private bool IsCbButtonDecision()
	{
		return false;
	}

	public void EnableCallbacks(bool a)
	{
	}

	public Vector2 GetItemSize()
	{
		return default;
	}

	public Vector2 GetItemSpacing()
	{
		return default;
	}

	public Vector2Int GetDisplaySize()
	{
		return default;
	}

	public int GetMaxItems()
	{
		return 0;
	}

	public RectTransform GetItemParent()
	{
		return null;
	}

	public CUIGenericCursor GetCursor()
	{
		return null;
	}

	public CUIGenericExplain GetExplain()
	{
		return null;
	}

	public void WriteExplain(int n, string a)
	{
	}

	public void WriteExplain(string a)
	{
	}

	public int GetCursorPosition()
	{
		return 0;
	}

	public Vector2Int[] GetCursorV()
	{
		return null;
	}

	public void SetCursorV(Vector2Int[] v)
	{
	}

	public void SetCursorPosition(int a)
	{
	}

	public bool IsScroll()
	{
		return false;
	}

	public bool IsLayoutV()
	{
		return false;
	}

	public bool IsLayoutH()
	{
		return false;
	}

	public void Active(bool a)
	{
	}

	public void ActiveCursor(bool a, bool scrollbar_interlock = true)
	{
	}

	public CUIGenericFocus GetFocusCursor()
	{
		return null;
	}

	public CUIGenericFocus GetFocusMouse()
	{
		return null;
	}

	protected virtual void Awake()
	{
	}

	public void Initialize(int max, bool active = true, bool resetPosition = true)
	{
	}

	public Vector2 CalcDisplaySize(bool addZeroPosition = true)
	{
		return default;
	}

	public void SetupItemTextRect(Vector2 size, Vector2 margin, bool draw)
	{
	}

	public CUIGenericFocus GetItemDecision(GamePad pad)
	{
		return null;
	}

	public CUIGenericFocus GetItemDecision(GameController.PADNUM padNum, GamePad pad)
	{
		return null;
	}

	public CUIGenericFocus GetMouseButtonDecision(GameController.PADNUM padNum)
	{
		return null;
	}

	public bool IsCancel(GamePad pad)
	{
		return false;
	}

	public CUIGenericFocus IsItemOk(GamePad pad)
	{
		return null;
	}

	public bool MoveCursor(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
	{
		return false;
	}

	public bool MoveCursor(GameController.PADNUM padNum, GamePad pad)
	{
		return false;
	}

	private void CallbackCursorFocus()
	{
	}

	private void UpdateItems(bool scbar = true)
	{
	}

	private void UpdateLayoutH(bool scbar)
	{
	}

	private void UpdateLayoutV(bool scbar)
	{
	}

	private Dictionary<string, object> MakeCursorPosition()
	{
		return null;
	}

	public void ClearFocus()
	{
	}

	private bool SetFocus(CUIGenericFocus focus, Vector2 pos)
	{
		return false;
	}

	private bool MouseCheck()
	{
		return false;
	}

	private bool MouseWheel(GamePad pad)
	{
		return false;
	}

	public int CheckItemFocus()
	{
		return 0;
	}
}
