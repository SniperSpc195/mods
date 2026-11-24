using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class CDebugBattleGroupTabWindow : MonoBehaviour
{
	private enum TAB
	{
		All = 0,
		Normal = 1,
		Mission = 2,
		MainEvent = 3,
		Trial = 4,
		Hard = 5,
		Other = 6,
		Max = 7
	}

	private struct TabDefinition
	{
		public string Label;

		public int Min;

		public int Max;

		public TabDefinition(string label, int min, int max)
		{
			Label = null;
			Min = 0;
			Max = 0;
		}
	}

	private static readonly TabDefinition[] TabDefinitions;

	private static readonly Color SelectedTabColor;

	private static readonly Color NormalTabColor;

	private static readonly Color SelectedTextColor;

	private static readonly Color NormalTextColor;

	private const float WindowWidth = 1166f;

	private const float WindowHeight = 112f;

	private const float WindowSpacing = 12f;

	private const float ShoulderIconWidth = 54f;

	private const float ButtonSpacing = 6f;

	private const float ButtonHeight = 52f;

	private const int VisibleLines = 10;

	private readonly int[] mCursorPositions;

	private readonly List<string> mFilteredGroupIDs;

	private RectTransform mWindow;

	private Image[] mTabImages;

	private TextMeshProUGUI[] mTabTexts;

	private CScrollMenu mGroupMenu;

	private TextMeshProUGUI mTextTemplate;

	private string[] mAllGroupIDs;

	private Vector2 mGroupMenuPosition;

	private int mSelectedTab;

	private Action mOnListChanged;

	public bool HasGroups => false;

	public void Show(CScrollMenu groupMenu, TextMeshProUGUI textTemplate, string[] allGroupIDs, Action onListChanged)
	{
	}

	public void Restore()
	{
	}

	public void Hide()
	{
	}

	public void SwitchTab(int direction)
	{
	}

	private void OnDisable()
	{
	}

	private void CreateWindow(CScrollMenu groupMenu)
	{
	}

	private void CreateShoulderIcon(string objectName, string iconText, float x)
	{
	}

	private void CreateTab(int index, float x, float y, float width)
	{
	}

	private void ApplyTextTemplate(TextMeshProUGUI text)
	{
	}

	private void UpdatePosition(RectTransform groupRect)
	{
	}

	private void RebuildGroupList()
	{
	}

	private void UpdateTabColors()
	{
	}

	private static bool IsMatch(string groupID, int tabIndex)
	{
		return false;
	}

	private static bool TryGetGroupNumber(string groupID, out int groupNumber)
	{
		groupNumber = default;
		return false;
	}
}
