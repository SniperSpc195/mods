using System;
using UnityEngine;

[Serializable]
public class CUIGenericFocusResult
{
	public enum STATUS
	{
		None = 0,
		Focus = 1,
		Cancel = 2,
		Drag = 3,
		ScrollbarMove = 4,
		ScrollbarStop = 5
	}

	public string mName;

	public Vector2 mPosition;

	public CUIGenericFocus mMouseFocus;

	public STATUS mStatus;

	public bool IsValid()
	{
		return false;
	}

	public bool IsMouseScan()
	{
		return false;
	}

	public bool IsEqual(CUIGenericFocus f)
	{
		return false;
	}

	public bool IsStateFocus()
	{
		return false;
	}

	public bool IsStateCancel()
	{
		return false;
	}

	public bool IsStateDrag()
	{
		return false;
	}

	public bool IsStateScrollbarMove()
	{
		return false;
	}

	public bool IsStateScrollbarStop()
	{
		return false;
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

	public CUIGenericFocusResult(CUIGenericFocus focus)
	{
	}

	public void MouseOut()
	{
	}
}
