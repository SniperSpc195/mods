using UnityEngine;

public class CUIGenericScrollbar : MonoBehaviour
{
	public enum TYPE
	{
		Virtical = 0,
		Horizontal = 1
	}

	[SerializeField]
	private TYPE mType;

	[SerializeField]
	private Vector2 mMoveSize;

	[SerializeField]
	private RectTransform mBarCursor;

	[SerializeField]
	private Vector2 mZeroPosition;

	private Vector2Int mDisplaySize;

	private int mMaxItems;

	private Vector2Int mMaxRect;

	private Vector2 mBarSize;

	private Vector2 mBarPosition;

	public bool IsV()
	{
		return false;
	}

	public bool IsH()
	{
		return false;
	}

	public void Active(bool a)
	{
	}

	public Vector2Int SetSize(Vector2Int disp, int max, int scrollPos = 0)
	{
		return default;
	}

	public bool IsScroll()
	{
		return false;
	}

	public int Drag(Vector2 v)
	{
		return 0;
	}

	public void UpdatePosition(int scrollPos)
	{
	}

	public int IsFocusPosition(Vector2 pos)
	{
		return 0;
	}
}
