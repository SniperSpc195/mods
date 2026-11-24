using TMPro;
using UnityEngine;

public class CFieldMenu_Main : MonoBehaviour
{
	public enum COMMAND
	{
		DiceMove = 0,
		Item = 1,
		Status = 2,
		Map = 3,
		FightingDragons = 4
	}

	private enum MODE
	{
		None = 0,
		Open = 1,
		Select = 2,
		Close = 3
	}

	private enum SW
	{
		MOVE_UP = 0,
		GET_ABILITY = 1,
		DR_PARAM_UP = 2,
		CARD = 3,
		SOUL = 4,
		COPY = 5,
		BRQ_MEET = 6
	}

	[SerializeField]
	private RectTransform mBackFrame;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private CUIGenericMenu mMenu;

	[SerializeField]
	private Transform mItemFightingDragons;

	[SerializeField]
	private TextMeshProUGUI mSoulpoint;

	[SerializeField]
	private Color[] mTextColor;

	[SerializeField]
	private Color[] mTextColor_FightingDragons;

	[SerializeField]
	[ReadOnly]
	private bool mPermission;

	[SerializeField]
	private Vector2 m_NextItemIcons;

	[SerializeField]
	private Vector2 m_SizeItemIcons;

	private Transform mItemIcons;

	private bool mMenu_4to5;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private float[] mFrameItems;

	private int mShowIconCount;

	public CUIGenericMenu GetMenu()
	{
		return null;
	}

	public void SetPermission(bool a)
	{
	}

	private void Active(bool a)
	{
	}

	public bool IsFightingDragons()
	{
		return false;
	}

	public void Dice_Change_Move()
	{
	}

	public void Reset(bool setPosition = false)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public COMMAND GetCommand()
	{
		return COMMAND.DiceMove;
	}

	public bool IsOpenClose()
	{
		return false;
	}

	private void Update()
	{
	}

	public void MoveCursor(bool IsControl, bool IsOnline, CFieldPlayer player, GamePad pad)
	{
	}

	private void UpdateMenu()
	{
	}

	private void Show_ItemIcons()
	{
	}
}
