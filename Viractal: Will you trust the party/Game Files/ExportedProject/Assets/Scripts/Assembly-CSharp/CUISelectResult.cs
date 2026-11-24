using System;
using UnityEngine;

[Serializable]
public class CUISelectResult
{
	public enum STATUS
	{
		None = 0,
		Focus = 1,
		Drag = 2
	}

	public string mName;

	public Vector2 mPosition;

	public CUIMouseFocus mMouseFocus;

	public CScrollMenu mScrollMenu;

	public int mIndex;

	public STATUS mStatus;

	public bool IsValid()
	{
		return false;
	}

	public bool IsStateFocus()
	{
		return false;
	}

	public bool IsStateDrag()
	{
		return false;
	}

	public bool IsTypeItem()
	{
		return false;
	}

	public bool IsTypeScrollbar()
	{
		return false;
	}

	public bool IsItemFocus(CScrollMenu menu = null)
	{
		return false;
	}

	public int IsItemIndex(CUIMouseFocus[] list)
	{
		return 0;
	}

	public CUISelectResult(CUIMouseFocus focus, CScrollMenu parent = null)
	{
	}
}
