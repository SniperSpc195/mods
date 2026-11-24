using TMPro;
using UnityEngine;

public class CGameRoom_InputName : MonoBehaviour
{
	private enum MODE
	{
		End = 0,
		Open = 1,
		Close = 2,
		Input_Start = 3,
		Input_Name = 4,
		Input_End = 5
	}

	private double[] mTime;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private TextMeshProUGUI mTextContract;

	[SerializeField]
	private CUIGenericInputText mInputText;

	private CUIButtonExplanation mButtonExplanation;

	private CUIButtonExplanation.DATA[] DataButtons;

	private CEventMessage mGMMessage;

	private CGameRoom_Table.PLAYER_SETTING[] mSettings;

	private int mNumPlayers;

	private int mIndex;

	private string mUnparsedName;

	private bool mSinglePlayer;

	private MODE mMode;

	private bool mCancel;

	private GameController.PADNUM mPadNum;

	private bool mInputFocus;

	private float mWait;

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	public void SetName(string name)
	{
	}

	private static string UnEscape(string s)
	{
		return null;
	}

	public void Open(CUIButtonExplanation button, CEventMessage gmMessage, CGameRoom_Table.PLAYER_SETTING[] setting, int num, int index = -1)
	{
	}

	public void ChangeName(CUIButtonExplanation button, CEventMessage gmMessage, CGameRoom_Table.PLAYER_SETTING[] setting, int num, int index = -1)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsCancel()
	{
		return false;
	}

	private void Update()
	{
	}

	private void Update_ButtonExplanation()
	{
	}

	private string CheckName(string text)
	{
		return null;
	}
}
