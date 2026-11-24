using System.Collections.Generic;

public class CUISelect : SingletonMonoBehaviour<CUISelect>
{
	private List<CScrollMenu> mScrollMenu;

	private CUISelectResult mEmpty;

	private CUISelectResult mResult;

	private CUIMouseFocus mMouseFocus;

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	public CUISelectResult GetResult()
	{
		return null;
	}

	public void AddMenu(CScrollMenu menu)
	{
	}

	public void RemoveMenu(CScrollMenu menu)
	{
	}

	public int IsPointerEnter(CUIMouseFocus[] list, bool checkRear = true)
	{
		return 0;
	}

	public int IsPointerEnter(List<CUIMouseFocus> list, bool checkRear = true)
	{
		return 0;
	}

	public bool MouseControl()
	{
		return false;
	}

	public void PointerEnter(CUIMouseFocus m)
	{
	}

	public void PointerExit(CUIMouseFocus m)
	{
	}

	public void MouseOn()
	{
	}

	public void MouseOff()
	{
	}

	private void Update()
	{
	}
}
