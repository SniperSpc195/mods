using System;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CUIGenericYesNo : MonoBehaviour
{
	public enum RESULT
	{
		None = -1,
		Yes = 0,
		No = 1,
		Cancel = 2
	}

	[Serializable]
	public class CSelect
	{
		public Image mImage;

		public TextMeshProUGUI mText;

		public RESULT mResult;
	}

	public enum MOVE
	{
		Virtical = 0,
		Horizontal = 1
	}

	[SerializeField]
	[ReadOnly]
	private string mNameCursorPosition;

	[SerializeField]
	[ReadOnly]
	private string mNameOkCancel;

	[SerializeField]
	private CUIGenericOpenClose mUIOpenClose;

	[SerializeField]
	private CSelect[] mSelect;

	[SerializeField]
	private Color[] mFrameColors;

	[SerializeField]
	private Sprite[] mFrameSprites;

	[SerializeField]
	private MOVE mMoveType;

	[SerializeField]
	private string m_SeMove;

	[SerializeField]
	private string m_SeOk;

	[SerializeField]
	private string m_SeCansel;

	[SerializeField]
	private string m_SeConfirmYes;

	[SerializeField]
	private string m_SeConfirmNo;

	[SerializeField]
	[ReadOnly]
	protected int mCursor;

	[SerializeField]
	[ReadOnly]
	protected RESULT mResult;

	protected CUIGenericFocus[] mFocusList;

	protected CUIGenericFocusResult mFocusResult;

	private bool[] mJudg;

	public Color[] FrameColors => null;

	public CSelect GetCSelect(RESULT result)
	{
		return null;
	}

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	public void Initialize(RESULT result = RESULT.No)
	{
	}

	public void UIOpen()
	{
	}

	public void UIClose()
	{
	}

	public bool IsUIOpenClose()
	{
		return false;
	}

	public bool IsUIOpenCloseEnd()
	{
		return false;
	}

	public RESULT GetSelect()
	{
		return RESULT.Yes;
	}

	public bool GetSelectBool()
	{
		return false;
	}

	public RESULT GetResult()
	{
		return RESULT.Yes;
	}

	public RESULT Select(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
	{
		return RESULT.Yes;
	}

	public RESULT Select(GameController.PADNUM padNum, GamePad pad)
	{
		return RESULT.Yes;
	}

	protected void PlaySE(string se, CSound.SE def)
	{
	}

	protected void UpdateSelect()
	{
	}

	protected bool IsOk(GameController.PADNUM padNum, GamePad pad)
	{
		return false;
	}

	protected bool MouseCheck()
	{
		return false;
	}

	protected void ClearFocus()
	{
	}

	protected void SetFocus(CUIGenericFocus focus)
	{
	}

	protected int CheckTransform(Transform t)
	{
		return 0;
	}
}
