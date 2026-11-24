using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CTreeView : MonoBehaviour
{
	public class ButtonParam
	{
		public bool toggle;

		public bool isShowIcon;

		public Action<ButtonParam> onDecide;

		public VisualElement element;

		public string name { get; }

		public int indent { get; }

		public int index { get; }

		public ButtonParam(string name, bool toggle, bool isShowIcon, int indent, int index, Action<ButtonParam> onDecide = null)
		{
		}
	}

	[SerializeField]
	private UIDocument m_UiDocument;

	[SerializeField]
	private VisualTreeAsset m_ItemLabel;

	private ButtonParam[] m_ButtonParam;

	public TreeView m_TreeView { get; private set; }

	private void Awake()
	{
	}

	private void BlockKeyInput(EventBase evt)
	{
	}

	public void Create(ButtonParam[] i_Buttons)
	{
	}

	public void DecideItem(IEnumerable<object> i_SelectedItems)
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
