using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CDebugWorkMenu : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Start = 1,
		Select = 2,
		Setting = 3,
		SubMenu = 4,
		End = 5
	}

	[SerializeField]
	private CScrollMenu mListMenu;

	[SerializeField]
	private CScrollMenu mSubMenu;

	[SerializeField]
	private TextMeshProUGUI mSettingName;

	[SerializeField]
	private TextMeshProUGUI mSettingHead;

	[SerializeField]
	private RectTransform mSettingCursor;

	[SerializeField]
	private TextMeshProUGUI mSettingNumText;

	private int mXPos;

	[SerializeField]
	private Vector2 mInitialPos;

	[SerializeField]
	private Vector2 mMoveOffset;

	[SerializeField]
	private GameObject[] mInstructions;

	private CDefine.GameWork mOriginal;

	private CDefine.GameWork mGameWork;

	private int[] mWork;

	private static Dictionary<string, int[]> mSaveCursor;

	private MODE mMode;

	private bool[] mJudg2;

	private int[] divWork;

	private int mSettingNum;

	public void Go(CDefine.GameWork work)
	{
	}

	private void SaveCursor()
	{
	}

	private void LoadCursor()
	{
	}

	private void AllWorkWrite()
	{
	}

	private string MakeLineWork(int i)
	{
		return null;
	}

	private string MakeNumText(int degit, bool zero, int num)
	{
		return null;
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateInfo(bool zero = false)
	{
	}

	private void UpdateNumCursorCursor()
	{
	}

	private void Setting(bool IsControl, bool IsOnline, GamePad pad)
	{
	}
}
