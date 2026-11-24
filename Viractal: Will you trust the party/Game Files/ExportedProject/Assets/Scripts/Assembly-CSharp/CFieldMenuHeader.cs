using System.Collections.Generic;
using Fork.Game;
using UnityEngine;

public class CFieldMenuHeader : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Select_Top = 2,
		Move_PlateName = 3,
		Select_Card = 4,
		View_Card = 5,
		Select_Delete_Card = 6,
		Inquiry_Delete_Card = 7,
		Delete_Card = 8,
		Select_Item = 9,
		Select_Mission = 10,
		Close = 11,
		End = 12,
		View_Abilities = 13
	}

	private enum SELECT
	{
		Status = 0,
		Item = 1,
		Card = 2,
		_Max = 3
	}

	private string mNameSelectTop;

	private string mNameSelectAbility;

	private string mNameSelectCondition;

	private string mNameSelectCard;

	private string mNameSelectDeleteCard;

	private string mNameSelectItem;

	private string mNameSelectDebug;

	private string mNameCommitDebug;

	private string mNameViewAbility;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private RectTransform mParentCommand;

	[SerializeField]
	private GameObject[] mMenuHilights;

	[SerializeField]
	public CUIGenericButtonGuide mButtonGuide;

	[SerializeField]
	private CCardView mMenuCards;

	[SerializeField]
	private Vector3 mZoomCamera;

	[SerializeField]
	private Vector3 mOffsetCameraTarget;

	[SerializeField]
	private CUIGenericFocus m_FocusStatus;

	[SerializeField]
	private CUIGenericFocus m_FocusItem;

	[SerializeField]
	private CUIGenericFocus m_FocusCard;

	[SerializeField]
	private CFieldMenu_SoulPoint m_SoulPoint;

	private CFramingCamera mCamera;

	private CFramingCamera.Backup mBackupCamera;

	private CFieldMenu_NewUseItem mMenuItem;

	private CFieldMenuMission mMenuMission;

	private CFieldPlayer[] mPlayer;

	private CFieldPlayer mSelectPlayer;

	private CParamPlayer mParam;

	private MODE mMode;

	private MODE mBackup;

	private SELECT mSelect;

	private bool[] mJudg;

	private void Awake()
	{
	}

	public void Active(bool a)
	{
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsEnableStatusPopup()
	{
		return false;
	}

	private void ActiveStatus()
	{
	}

	private void ActiveCard()
	{
	}

	private void ActiveItem()
	{
	}

	private void UpdateCards(CFieldPlayer player, List<CSkillCardData> list)
	{
	}

	private void SetupViewAbilities()
	{
	}

	public void Go(CFramingCamera camera, CFieldPlayer[] players, CFieldMenu_NewUseItem menuItem)
	{
	}

	private void SetupButtonGuide()
	{
	}

	private void SetupButtonGuideForSelectCard()
	{
	}

	private void SetupButtonGuideForDeleteCard()
	{
	}

	private void SetupButtonGuideForViewCard()
	{
	}

	private void SetupButtonGuideForSelectItem()
	{
	}

	private void SetupButtonGuideForViewAbilities()
	{
	}

	public void Close()
	{
	}

	private void ChangePlayerState()
	{
	}

	private void Update()
	{
	}

	private void ChangePlayer(int dir)
	{
	}

	private void EnterCardDeleteMode()
	{
	}

	private void LeaveCardDeleteMode()
	{
	}

	private bool EnableCardDelete()
	{
		return false;
	}

	private void UpdateCommandCursor(int cursor, bool se = true)
	{
	}

	private void OnTabChanged()
	{
	}
}
