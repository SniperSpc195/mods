using System.Collections.Generic;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CFieldMenu_NewUseItem : MonoBehaviour
{
	public enum RESULT_STAT
	{
		None = 0,
		Cancel = 1,
		AddItem = 2,
		DidNotObtain = 3
	}

	private enum MENU
	{
		Possession = 0,
		Overflow = 1
	}

	private enum BUTTON
	{
		None = -1,
		Top_Use = 0,
		Top_Use_Battle = 1,
		Overflow = 2,
		Inquiry = 3,
		Give_Select = 4,
		Copy_Select = 5
	}

	private class BACKUP
	{
		public int mCursorPosition;

		public CFieldPlayer mSelectPlayer;

		public bool mAvailable;

		public bool mFullItem;

		public MODE mMode;
	}

	private enum MODE
	{
		End = 0,
		End_AllOut = 1,
		Open = 2,
		Start = 3,
		Execute = 4,
		Use_Inquiry = 5,
		Use_Close = 6,
		Use_Wait = 7,
		Use_End = 8,
		UnUse_Wait = 9,
		Dispose_Inquiry = 10,
		Dispose_Close = 11,
		Full_Inquiry = 12,
		Mission_Result = 13,
		Move_PlateName = 14,
		Obtained_Overflow = 15,
		Close = 16,
		NgMessage = 17,
		Give_Select = 18,
		Give_Obtained = 19,
		Give_End = 20,
		Result_SelectPlayer = 21,
		Result_AddItem = 22,
		Result_AddItem_End = 23,
		Result_End = 24,
		Copy_Select = 25,
		Copy_Inquiry = 26,
		Copy_Cancel = 27,
		Copy_Decision = 28,
		Copy_Receive = 29,
		Copy_Random = 30,
		Copy_Zoom = 31,
		Look_AllOut = 32
	}

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
	private CEventMessage mMessage;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation_HandOver;

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
	private CChoiceMenu mChoiceMenu;

	[SerializeField]
	private Transform[] mExplanationBtn;

	[SerializeField]
	private Transform mDebugInfo;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	private Vector2[] mNormalPosition;

	private Vector2[] mStatusPosition;

	private Vector2 mOpendPositionChoiceMenu;

	private Vector2 mPositionBattleResult;

	private CItemIcon_ThrowingAway mThrowIcon;

	private bool mBattle;

	private bool mBtlResult;

	private CEventMessage mBtlResultMessage;

	private RESULT_STAT mBtlResultStat;

	private List<CBattlePlayer> mBtlResultBattlePlayers;

	private int[] mCursorPosition;

	private CFieldPlayer mSelectPlayer;

	private CParamPlayer mParam;

	private CFieldPlayer mControlPlayer;

	private CFieldPlayer[] mPlayerList;

	private int mPlayerIndex;

	private Vector3? mOffsetCameraTarget;

	private CMaster_ItemData mGiveItem;

	private string mGiveText;

	private int mMaxPossessionItems;

	private List<CMaster_ItemData> mOverflowItems;

	[SerializeField]
	[ReadOnly]
	private MENU mSelectMenu;

	[SerializeField]
	[ReadOnly]
	private CUIGenericMenu mExecMenu;

	private List<CMaster_ItemData> mSelectItems;

	private CMaster_ItemData mUseItem;

	private int mUseItemIndex;

	private bool mWriteNgCopy;

	private int[] mRandomCopyIndex;

	private float mFrame;

	private const float NEXT_CURSOR_FRAME = 28f;

	private Transform mTransform_CopyItem;

	private float[] mScale_CopyItem;

	private const float MAX_SCALE_ITEM_ICON = 0.5f;

	private List<CItemIcon_Obtained> mIconObtained;

	private List<Vector3Int> mTBoxs;

	private int mAllOutTreasures;

	private List<Vector3Int> mEnemies;

	private int mAllOutEnemies;

	private bool mAvailable;

	private bool mFullItem;

	private bool mReturnMenuUse;

	private List<CParamMission> mMissionList;

	private uint[][] mButtons;

	private bool mIsShowNotUseMessage;

	private BACKUP mBackup;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private float mWait;

	private string mStartText;

	private Dictionary<int, bool> mSummon;

	private bool mActiveGive;

	public CMaster_ItemData UseItem => null;

	public RESULT_STAT GetResultStat()
	{
		return RESULT_STAT.None;
	}

	public int GetNowSelectPlayerIndex()
	{
		return 0;
	}

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

	public List<Vector3Int> GetAllOut_Tresures()
	{
		return null;
	}

	public List<Vector3Int> GetAllOut_Enemies()
	{
		return null;
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

	public void Go(CFieldPlayer[] playerList, int index, Vector3 offset)
	{
	}

	public void GoFull(bool battle, CFieldPlayer player, List<string> addItem, bool innerCall = false)
	{
	}

	public void GoBattleResult(CFieldPlayer player, List<CBattlePlayer> choicePlayer, int selectPlayerIndex, string addItem, CEventMessage eventMessage, bool full = false)
	{
	}

	private void WriteChoice_Players()
	{
	}

	private void MenuOpen(Vector2[] openPos, bool innerCall = false)
	{
	}

	private bool IsPlayerChange()
	{
		return false;
	}

	private void Update()
	{
	}

	private void CopyItem()
	{
	}

	private void SetCallbacks(UnityAction cancel, UnityAction<int> decision)
	{
	}

	private void Startup(bool resetCursorPosition = true)
	{
	}

	private void SetupItemIcon(bool resetCursorPosition, bool isCopy = false)
	{
	}

	private void SelectItemIcon(CUIGenericMenu menu, int n, bool select)
	{
	}

	private void GiveItemIcon(CFieldPlayer player)
	{
	}

	private void GivePlayers()
	{
	}

	private bool IsUsable(CMaster_ItemData item)
	{
		return false;
	}

	private int IsPosessionCopy()
	{
		return 0;
	}

	private List<int> CopyableList()
	{
		return null;
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

	private void CbCancel_Overflow()
	{
	}

	public void MenuClose()
	{
	}

	private void CbDecision_Use(int n)
	{
	}

	private void CbDecision_Overflow(int n)
	{
	}

	private void OpenInquiry(int n = 0)
	{
	}

	private void CbInquiry_Cancel()
	{
	}

	private void CbInquiry_Decision(int n)
	{
	}

	private bool DeliveryItem()
	{
		return false;
	}

	private bool IsGive()
	{
		return false;
	}

	private void ButtonActive(BUTTON btn)
	{
	}

	private void ButtonActive(bool a)
	{
	}

	private void ButtonChangeActive(BUTTON btn, bool activeUse, bool activeDiscard)
	{
	}

	private void CreateThrowIcon()
	{
	}

	private bool Full_IsChangeOverflow(GamePad pad)
	{
		return false;
	}

	private void ShowMessageUseNg(CMaster_ItemData i_Item)
	{
	}

	private void Init_AllOut()
	{
	}

	private void CreateTBoxs(CFieldPlayer player, int distance, bool showHex = false)
	{
	}

	private void CreateEnemys(CFieldPlayer player, int distance, bool showHex = false)
	{
	}

	private void HideHex()
	{
	}
}
