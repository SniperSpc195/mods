using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CDebugFlagMenu : MonoBehaviour
{
	[SerializeField]
	private RectTransform mCursor;

	[SerializeField]
	private Vector2 mCursorInitPosition;

	[SerializeField]
	private Vector2 mCursorOffset;

	[SerializeField]
	private float mXSpace;

	[SerializeField]
	private float mOnOffset;

	[SerializeField]
	private int mXPos;

	[SerializeField]
	private int[] mYPos;

	private static Dictionary<string, int[]> mSaveCursor;

	[SerializeField]
	private RectTransform mList;

	[SerializeField]
	private TextMeshProUGUI mNameText;

	[SerializeField]
	private TextMeshProUGUI mInfoText;

	[SerializeField]
	private CScrollMenu mSubMenu;

	private CDefine.GameFlag mOriginal;

	private CDefine.GameFlag mGameFlag;

	private ulong[] mFlag;

	private int mMax;

	private int mLines;

	private const int mDispLines = 10;

	private string[] mTextLines;
}
