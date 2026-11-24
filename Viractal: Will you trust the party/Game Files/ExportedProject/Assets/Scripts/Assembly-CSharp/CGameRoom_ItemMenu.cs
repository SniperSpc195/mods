using System.Collections.Generic;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CGameRoom_ItemMenu : MonoBehaviour
{
	private enum MENU
	{
		Possession = 0,
		Overflow = 1
	}

	private enum MODE
	{
		End = 0,
		End_AllOut = 1,
		Open = 2,
		Start = 3,
		Execute = 4,
		Close = 5
	}

	private const int PendingMax = 6;

	[SerializeField]
	[ReadOnly]
	private string mNameSelectTop;

	[SerializeField]
	[ReadOnly]
	private string mNameInquiry_Use;

	[SerializeField]
	[ReadOnly]
	private string mNameDebugEnd;

	[SerializeField]
	[ReadOnly]
	private string mNameDebugChange;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private GameObject mMenuTop;

	[SerializeField]
	private CanvasGroup mMenuTop_CanvasGroup;

	[SerializeField]
	private float[] mAlpha;

	[SerializeField]
	private CUIGenericMenu[] mMenuList;

	[SerializeField]
	private CUITooltip mPopup;

	[SerializeField]
	private TextMeshProUGUI mPopupText;

	[SerializeField]
	private Vector2[] mOffsetPopup;

	[SerializeField]
	[ReadOnly]
	private bool[] mShowPopup;

	[SerializeField]
	private CUIGenericMenu mMenuEmpty;

	[SerializeField]
	private GameObject mPlateTop;

	[SerializeField]
	private TextMeshProUGUI mPlateName;

	[SerializeField]
	private GameObject mPendingFrame;

	[SerializeField]
	private TextMeshProUGUI mPendingTitle;

	[SerializeField]
	private CChoiceMenu mChoiceMenu;

	[SerializeField]
	private Transform mDebugInfo;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	private Vector2[] mNormalPosition;

	private Vector2[] mStatusPosition;

	private int[] mCursorPosition;

	private CFieldPlayer mSelectPlayer;

	private CParamPlayer mParam;

	private int mMaxPossessionItems;

	private List<CMaster_ItemData> mOverflowItems;

	[SerializeField]
	[ReadOnly]
	private MENU mSelectMenu;

	[SerializeField]
	[ReadOnly]
	private CUIGenericMenu mExecMenu;

	private List<CMaster_ItemData> mSelectItems;

	private bool mFullItem;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private float mWait;

	private Dictionary<int, bool> mSummon;

	public List<CMaster_ItemData> GetItemsObtained()
	{
		return null;
	}

	private bool IsMemuPossession()
	{
		return false;
	}

	private bool IsMemuOverflow()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Initialize()
	{
	}

	public bool IsExecute()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsEnd_AllOut()
	{
		return false;
	}

	public bool IsEndGrant()
	{
		return false;
	}

	public bool IsSelecting()
	{
		return false;
	}

	public void Go(bool battle, CFieldPlayer player)
	{
	}

	private void MenuOpen(Vector2[] openPos, bool innerCall = false)
	{
	}

	private void Update()
	{
	}

	private void SetCallbacks(UnityAction cancel, UnityAction<int> decision)
	{
	}

	private void Startup(bool resetCursorPosition = true)
	{
	}

	private void SetupItemIcon(bool resetCursorPosition)
	{
	}

	private void SelectItemIcon(CUIGenericMenu menu, int n, bool select)
	{
	}

	private void ItemSelected(int old, bool debug = false)
	{
	}

	private void ItemDeselect()
	{
	}

	private void ChangeMemu(MENU menu, bool seReq = true, int cursor = -1)
	{
	}

	private bool UseMouse_To_MemuPossession(out int cursor)
	{
		cursor = default;
		return false;
	}

	private bool UseMouse_To_MemuOverflow(out int cursor)
	{
		cursor = default;
		return false;
	}

	private void Update_PopupInfo(bool debug = false)
	{
	}

	private void CbCancel_Use()
	{
	}

	public void MenuClose()
	{
	}
}
