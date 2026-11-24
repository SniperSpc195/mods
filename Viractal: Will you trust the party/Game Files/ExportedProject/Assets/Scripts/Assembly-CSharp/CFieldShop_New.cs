using System.Collections.Generic;
using Fork.Game;
using TMPro;
using UnityEngine;

public class CFieldShop_New : MonoBehaviour
{
	private enum BUTTON
	{
		Select_Top = 0,
		Select_Buy = 1,
		Select_Sell = 2,
		Inquiry = 3
	}

	private enum MENU
	{
		None = -1,
		Buy = 0,
		Sell = 1,
		Upgrade = 2,
		Dispose = 3,
		Exit = 4
	}

	private enum MODE
	{
		End = 0,
		Wait_Shop_SalesList = 1,
		Open = 2,
		Start = 3,
		Select_Top = 4,
		To_Buy = 5,
		Select_Buy = 6,
		Inquiry_Buy = 7,
		Wait_Buy = 8,
		To_Sell = 9,
		Select_Sell = 10,
		Inquiry_Sell = 11,
		Wait_Sell = 12,
		Menu_Status = 13,
		Wait_CardUpgrade = 14,
		Wait_CardDelete = 15,
		End_Cards = 16,
		Close = 17
	}

	[SerializeField]
	[ReadOnly]
	private string mNameSelectBuy;

	private CFramingCamera mFramingCamera;

	private CFramingCamera.Backup mCameraBackup;

	[SerializeField]
	private Vector3 mCameraOffset;

	[SerializeField]
	private Vector3 mCameraZoom;

	[SerializeField]
	private Canvas mCanvas;

	[SerializeField]
	private CEventMessage mMessage;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation_Info;

	[SerializeField]
	private GameObject mMenuTop;

	private float mAlpha;

	private const float ALPHA_SPD = 0.15f;

	[SerializeField]
	private CUIGenericMenu mMenuItem;

	[SerializeField]
	private CUIGenericMenu mMenuEmpty;

	private int[] mSaveCursor;

	[SerializeField]
	private CUITooltip[] mPopup;

	[SerializeField]
	private TextMeshProUGUI[] mPopupText;

	[SerializeField]
	private Vector2[] mOffsetPopup;

	private int mSelectPopup;

	[SerializeField]
	[ReadOnly]
	private bool[] mShowPopup;

	[SerializeField]
	private GameObject mPlateTop;

	[SerializeField]
	private TextMeshProUGUI mPlateName;

	[SerializeField]
	private CChoiceMenu mChoiceMenu;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	private CItemIcon_ThrowingAway mThrowIcon;

	private CMaster_MapTownData mTownData;

	private CRegistryShop mShopData;

	private List<CSaleItem> mSaleItems;

	private int mNumBuyItems;

	private string mShopTitle;

	private string mPlayerName;

	private string mGreetingText;

	private CFieldPlayer mPlayer;

	private CParamPlayer mParam;

	private int mDiscount;

	private CShopItemIcon mSplineIcon;

	private uint[][] mButtons;

	private CFieldMenuHeader mMenuStatus;

	private MENU[] mMenuIndex;

	private MENU mExecMenu;

	private bool m_Initialize;

	private long m_EnvironmentSEHandle;

	private bool mEnable_CameraZoom;

	private bool mInfomation;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private MODE mBackup;

	private MODE mMenuMode;

	private float mWait;

	private string mGMMessage;

	private void Initialize()
	{
	}

	public void Go(CFieldMain.HEX_TOWN town, CFieldPlayer player, CFieldMenuHeader menuStatus, bool cameraZoom = false)
	{
	}

	public void Go(CMaster_ShopDetailData data, CFieldPlayer player, CFieldMenuHeader menuStatus)
	{
	}

	public void OpenInfomation(CFieldMain.HEX_TOWN town, CFieldPlayer player, CFieldMenuHeader menuStatus)
	{
	}

	private bool IsMenuBuy()
	{
		return false;
	}

	private bool IsMenuSell()
	{
		return false;
	}

	public bool IsExecute()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}

	private void Shop_Closes()
	{
	}

	private void CbInquiry_Cancel()
	{
	}

	private string IsCardAdjustments(int price, int max, int now)
	{
		return null;
	}

	private void CbInquiry_Decision(int cur)
	{
	}

	private void CbMenu_Cancel()
	{
	}

	private void CbMenu_Decision(int cur)
	{
	}

	private string MakeCommand_Upgrade(string cmd)
	{
		return null;
	}

	private string MakeCommand_Dispose(string cmd)
	{
		return null;
	}

	private void Setup_ChoiceTop()
	{
	}

	private void Setup_Discount(bool greeting)
	{
	}

	private void Setup_GreetingText()
	{
	}

	private void Setup_Shop()
	{
	}

	private void To_Buy()
	{
	}

	private void Update_BuyItems(int cur)
	{
	}

	private void Setup_Sell()
	{
	}

	private void Update_SellItems(int cur)
	{
	}

	private void To_Sell()
	{
	}

	private void Write_TopMessage()
	{
	}

	private void ShopMessage(string a)
	{
	}

	private void ShopMessageReplace(string a, string b)
	{
	}

	private void ItemSelected(int old)
	{
	}

	private void ButtonActive(BUTTON btn)
	{
	}

	private void ShowPopup_Buy()
	{
	}

	private void ShowPopup_Sell()
	{
	}

	private void HidePopup()
	{
	}

	private void ChangePopup()
	{
	}

	private List<int> MakeSalesList()
	{
		return null;
	}

	private void Start_Menu()
	{
	}
}
