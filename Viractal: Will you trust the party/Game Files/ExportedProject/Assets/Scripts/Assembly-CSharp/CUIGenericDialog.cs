using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CUIGenericDialog : MonoBehaviour
{
	private struct INQUIRY_POSITION
	{
		public Vector2 text;

		public Vector2 menu;

		public INQUIRY_POSITION(Vector2 _text, Vector2 _menu)
		{
			text = default;
			menu = default;
		}
	}

	[SerializeField]
	protected RectTransform mParent;

	[SerializeField]
	protected TextMeshProUGUI mCenterText;

	[SerializeField]
	protected Vector2 mOffsetCenterText;

	[SerializeField]
	protected Image mButton;

	[SerializeField]
	protected TextMeshProUGUI mButtonText;

	[SerializeField]
	protected CChoiceMenu mChoiceMenu;

	[SerializeField]
	[ReadOnly]
	private Vector2 mSizeFrame;

	[SerializeField]
	[ReadOnly]
	private int mTextLines;

	[SerializeField]
	[ReadOnly]
	private Vector2 mSizeCenterText;

	[SerializeField]
	[ReadOnly]
	private Vector2 mPositionCenterText;

	private INQUIRY_POSITION[] yesno_position;

	private INQUIRY_POSITION[] inquiry_position;

	[SerializeField]
	[ReadOnly]
	private bool mDecision;

	[SerializeField]
	[ReadOnly]
	private bool mEnableCancel_Inquiry;

	[SerializeField]
	[ReadOnly]
	private int mResult_Inquiry;

	public const int _CANCEL = -2;

	public CChoiceMenu GetMenu()
	{
		return null;
	}

	public int GetCursorPosition()
	{
		return 0;
	}

	public void Active(bool a)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	private void Awake()
	{
	}

	public void SetTextDefSize(string a, bool active = true)
	{
	}

	public void SetText(string a, Vector2 padding, bool active = true)
	{
	}

	public void SetText(string a, Vector2 minSize, Vector2 padding, bool active = true)
	{
	}

	public void SetFrameSize(Vector2 size)
	{
	}

	public Vector2 GetTextSize(TextMeshProUGUI tmPro, bool meshUpdate = false)
	{
		return default;
	}

	public void ButtonOff()
	{
	}

	public void ButtonOn(GameController.PADNUM padNum = GameController.PADNUM.None)
	{
	}

	public void ButtonOn(string a)
	{
	}

	private void Inquiry_Setup(int menuItemCount)
	{
	}

	public void YesNoOn(CUIGenericYesNo.RESULT result = CUIGenericYesNo.RESULT.No)
	{
	}

	public CUIGenericYesNo.RESULT ExecYesNo(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
	{
		return CUIGenericYesNo.RESULT.Yes;
	}

	public CUIGenericYesNo.RESULT ExecYesNo(GameController.PADNUM padNum, GamePad pad)
	{
		return CUIGenericYesNo.RESULT.Yes;
	}

	public void Inquiry_On(int cursor, bool cancel, string text)
	{
	}

	public void Inquiry_On(int cursor, bool cancel, string[] text)
	{
	}

	public int Exec_Inquiry(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
	{
		return 0;
	}

	public int Exec_Inquiry(GameController.PADNUM padNum, GamePad pad)
	{
		return 0;
	}

	private void CbCancel_Inquiry()
	{
	}

	private void CbDecision_Inquiry(int n)
	{
	}
}
