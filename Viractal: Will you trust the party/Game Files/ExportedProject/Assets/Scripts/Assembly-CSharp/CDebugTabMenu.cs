using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CDebugTabMenu : MonoBehaviour
{
	public struct ButtonParam
	{
		public string name;

		public bool? toggle;

		public float? toggleScale;

		public CUiValueChanger.SetupParam? changer;

		public float offsetx;

		public int indent;
	}

	private enum Mode
	{
		Menu = 0,
		TreeView = 1
	}

	private readonly Color SelectedColor;

	private readonly Color NormalColor;

	[SerializeField]
	private CTreeView[] m_CustomTreeView;

	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private ScrollRect[] m_Menu;

	[SerializeField]
	private Button[] m_TabButtons;

	[SerializeField]
	private GameObject m_TogglePrefab;

	[SerializeField]
	private GameObject m_ValueChangerPrefab;

	private ScrollRect m_ActiveScrollRect;

	private RectTransform m_ActiveScrollViewport;

	private RectTransform m_ActiveScrollContent;

	private HorizontalOrVerticalLayoutGroup m_ActiveScrollLayoutGroup;

	private List<Button> m_ActiveMenuButtons;

	private UnityAction<Toggle> m_DecisionFunc;

	private UnityAction<int> m_DecisionFuncTreeView;

	private UnityAction m_CancelFunc;

	private Action<int> m_OnTabChanged;

	private Mode m_Mode;

	public Button m_SelectedMenuButton { get; private set; }

	public int m_SelectedTab { get; private set; }

	public int[] m_CursorPosition { get; private set; }

	public List<Toggle>[] m_Toggle { get; private set; }

	public CTreeView GetCustomTreeView(int tab)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void UpdateMenu()
	{
	}

	private void UpdateTreeView()
	{
	}

	private void LateUpdate()
	{
	}

	public void InitializeMenu(UnityAction<Toggle> onDecision, UnityAction onCancel, Action<int> onTabChanged = null)
	{
	}

	public void InitializeTreeView(UnityAction<int> onDecision, UnityAction onCancel, Action<int> onTabChanged = null)
	{
	}

	public void CreateMenu(int tab, params string[] buttons)
	{
	}

	public void SetText(int tab, int index, string text, Color color)
	{
	}

	public void CreateMenu(int tab, params ButtonParam[] buttons)
	{
	}

	public void CreateTreeView(int i_Tab, CTreeView.ButtonParam[] i_Buttons, bool i_Rebuild)
	{
	}

	public void CreateCharcterMenu(int tab)
	{
	}

	public void CreateEnemyMenu(int tab)
	{
	}

	public void DeleteMenu()
	{
	}

	public void RecreateTab(params string[] tabs)
	{
	}

	public void RefleshPosition()
	{
	}

	public void RefleshPosition(int tab)
	{
	}

	public void ChangeTab(int tab)
	{
	}

	public void SwList()
	{
	}

	private void ScrollVertical(int nodeIndex)
	{
	}

	private void ScrollPage(bool up = false)
	{
	}

	private bool IsExistTab()
	{
		return false;
	}

	private Toggle AddToggle(GameObject button, float scale)
	{
		return null;
	}

	private CUiValueChanger AddValueChanger(GameObject button)
	{
		return null;
	}

	public Transform GetButton(int tab, string name)
	{
		return null;
	}

	public Transform GetButton(int tab, int index)
	{
		return null;
	}

	public int CountButton(int tab)
	{
		return 0;
	}

	public int GetSelectedButtonIndex()
	{
		return 0;
	}

	public void ShowHeaderIcon(Sprite sprite, int tab, int index)
	{
	}

	public void HideHeaderIcon(int tab, int index)
	{
	}

	public void SetHeaderColor(Color color, int tab, int index)
	{
	}
}
