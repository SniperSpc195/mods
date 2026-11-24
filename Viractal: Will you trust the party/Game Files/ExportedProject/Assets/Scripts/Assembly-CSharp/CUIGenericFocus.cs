using UnityEngine;

public class CUIGenericFocus : MonoBehaviour
{
	private enum FocusState
	{
		None = 0,
		Cursor = 1,
		Mouse = 2,
		Cursor_Mouse = 3
	}

	public enum TYPE
	{
		Item = 0,
		Button = 1,
		ScrollbarV = 2,
		ScrollbarH = 3
	}

	[SerializeField]
	[ReadOnly]
	private FocusState mFocusState;

	[SerializeField]
	[ReadOnly]
	private int mItemIndex;

	[SerializeField]
	private bool mMouseScan;

	[SerializeField]
	private TYPE mType;

	private RectTransform mRectTransform;

	public void Active(bool a)
	{
	}

	public void ClearFocusStatus()
	{
	}

	public bool IsFocusStateCursor()
	{
		return false;
	}

	public bool IsFocusStateMouse()
	{
		return false;
	}

	public int GetItemIndex()
	{
		return 0;
	}

	public void SetItemIndex(int i)
	{
	}

	public bool IsMouseScan()
	{
		return false;
	}

	public void SetMouseScan(bool a)
	{
	}

	public bool IsTypeItem()
	{
		return false;
	}

	public bool IsTypeButton()
	{
		return false;
	}

	public bool IsTypeScrollbar()
	{
		return false;
	}

	private void Awake()
	{
	}

	public Vector2 SetupItemTextRect(Vector2 size, Vector2 margin, bool draw)
	{
		return default;
	}

	public bool IsPointerEnter(Vector2 pos)
	{
		return false;
	}

	public static bool IsPointerEnter(Vector3 pos, RectTransform rt)
	{
		return false;
	}

	public static Vector3[] MakeCorners(RectTransform rt)
	{
		return null;
	}

	protected void SetFocusStateCursor(bool a)
	{
	}

	protected void SetFocusStateMouse(bool a)
	{
	}

	public virtual void SetCursorFocus(bool a)
	{
	}

	public virtual void MouseIn()
	{
	}

	public virtual void MouseOut()
	{
	}

	public virtual void MouseClick()
	{
	}

	public bool IsMouseButtonDecision(bool isOnline, bool isMe, GameController.PADNUM padNum)
	{
		return false;
	}
}
