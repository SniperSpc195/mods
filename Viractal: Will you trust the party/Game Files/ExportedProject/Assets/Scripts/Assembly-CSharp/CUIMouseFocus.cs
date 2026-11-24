using UnityEngine;
using UnityEngine.EventSystems;

public class CUIMouseFocus : MonoBehaviour
{
	public enum TYPE
	{
		Item = 0,
		Scrollbar = 1
	}

	[SerializeField]
	[ReadOnly]
	private bool mEnableScan;

	public TYPE mType;

	private RectTransform mRectTransform;

	public bool IsTypeItem()
	{
		return false;
	}

	public bool IsTypeScrollbar()
	{
		return false;
	}

	public bool IsEnableScan()
	{
		return false;
	}

	public void SetEnableScan(bool a)
	{
	}

	private void Awake()
	{
	}

	public bool IsPointerEnter(Vector2 pos)
	{
		return false;
	}

	public void OnPointerEnter(PointerEventData eventData = null)
	{
	}

	public void OnPointerExit(PointerEventData eventData = null)
	{
	}
}
