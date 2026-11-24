using System.Collections.Generic;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CScrollMenu : MonoBehaviour
{
	[SerializeField]
	[ReadOnly]
	protected string mBaseNameCursorPosition;

	private CSound.SE mCursorSE;

	[SerializeField]
	[ReadOnly]
	private bool mEnableMouseFocus;

	private RectTransform mRectFrame;

	public Vector4 mFrameSlice;

	private RectTransform[] mRectScrollbar;

	public Vector4 mScrollSlice;

	private float mScrollTop;

	private float mScrollOffset;

	private float mScrollHeight;

	private float mScrollBarHeight;

	private RectTransform mRectCursor;

	private Vector2 mDefCursorPosition;

	public int[] mCursor;

	private int mLines;

	private int mMax;

	private RectTransform mRectTextList;

	private List<TextMeshProUGUI> mTMproList;

	private List<Image> mImageList;

	private List<CUIMouseFocus> mListMouseFocus;

	private bool mMouseFocusItem;

	private float mLineHeight;

	public void SetCursorSE(CSound.SE se)
	{
	}

	public int GetCursorPosition()
	{
		return 0;
	}

	public int[] GetCursorArray()
	{
		return null;
	}

	public bool IsScroll()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Active(bool a)
	{
	}

	public void SetMouseFocus(bool a)
	{
	}

	public bool IsMouseFocus()
	{
		return false;
	}

	public void Init(Vector2 position, int lines, int max, bool frameAdjustment = true)
	{
	}

	public void Init(int lines, int max, bool frameAdjustment = true)
	{
	}

	public void SetText(string[] list)
	{
	}

	public void SetText(string[] list, Color color)
	{
	}

	public void SetText(List<string> list)
	{
	}

	public void SetButtonTextLines(int i_Lines)
	{
	}

	public void SetText(List<string> list, Color color)
	{
	}

	public void SetTextNull()
	{
	}

	public void SetText(int n, string txt)
	{
	}

	public string GetText(int n = -1)
	{
		return null;
	}

	public void SetColor(int n, Color c)
	{
	}

	public void SetCursorPosition(int a)
	{
	}

	public void SetCursorArray(int[] a)
	{
	}

	public bool IsMouseFocusItem()
	{
		return false;
	}

	public bool MoveCursor(bool isControl, bool isOnline, GamePad pad)
	{
		return false;
	}

	public bool MoveCursor(GamePad pad)
	{
		return false;
	}

	private bool ReqCursorSE(int oldPosition)
	{
		return false;
	}

	private void SetFrameSize(bool frameAdjustment)
	{
	}

	private void UpdateList(bool updateScbar = true)
	{
	}

	public CUISelectResult Check(CUIMouseFocus nowFocus, GamePad pad, CUISelectResult oldRes)
	{
		return null;
	}

	private Dictionary<string, object> MakeCursorPosition()
	{
		return null;
	}
}
