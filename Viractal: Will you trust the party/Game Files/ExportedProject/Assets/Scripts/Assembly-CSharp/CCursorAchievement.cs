using System.Collections.Generic;
using UnityEngine;

public class CCursorAchievement : MonoBehaviour
{
	[SerializeField]
	private Vector2[] mResponseArea;

	[SerializeField]
	private RectTransform mTransformScroll;

	[SerializeField]
	private Vector2 mPositionScroll;

	[SerializeField]
	private Vector2 mOffsetScroll;

	[SerializeField]
	private int mLineDisplay;

	[SerializeField]
	private CUIGenericScrollbar mScrollbar;

	[SerializeField]
	private GameObject mArrowTopLeft;

	[SerializeField]
	private GameObject mArrowBottomRight;

	[SerializeField]
	private Vector2 mMoveOffset;

	[SerializeField]
	[ReadOnly]
	private Vector2Int[] mLinePosition;

	[SerializeField]
	[ReadOnly]
	private int mPosition;

	[SerializeField]
	[ReadOnly]
	private int mMaxItems;

	[SerializeField]
	[ReadOnly]
	private List<List<CUIPhysicsShapeFocus>> mFocusLists;

	[SerializeField]
	private float mPingPongPeriod;

	[SerializeField]
	private Color[] mPingPongColor;

	private List<bool> mFarRight;

	private bool mEnableMouseScroll;

	private long mWaitScroll;

	private CUIGenericFocus[] mGenericFocusList;

	private CUIGenericFocusResult mFocusResult;

	private Vector2Int LinePosition => default;

	public int Position => 0;

	public void Active(bool a)
	{
	}

	private void Update()
	{
	}

	public CUIPhysicsShapeFocus GetCursorFocus()
	{
		return null;
	}

	private bool IsScroll()
	{
		return false;
	}

	public void Initialize(int max, RectTransform parent)
	{
	}

	private void CalcPosition(int position)
	{
	}

	private void CalcPosition()
	{
	}

	private void UpdateCursor(bool updateScrollbar)
	{
	}

	public CUIPhysicsShapeFocus MoveCursor()
	{
		return null;
	}

	private bool IsFarRight()
	{
		return false;
	}

	private bool MoveMouse(GamePad mouse)
	{
		return false;
	}

	private bool CheckScrollbar(GamePad mouse, ref bool updateScrollbar)
	{
		return false;
	}

	private bool SetFocus(CUIGenericFocus focus, Vector2 pos)
	{
		return false;
	}

	private bool MouseWheel(GamePad mouse)
	{
		return false;
	}

	private bool Scroll(bool up, bool down)
	{
		return false;
	}

	private void UpdateScrollPosition(int oldScrollY)
	{
	}
}
