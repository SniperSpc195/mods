using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CFieldMenuStatus : MonoBehaviour
{
	private enum PRM
	{
		Lv = 0,
		NowHp = 1,
		MaxHp = 2,
		Money = 3,
		Exp = 4,
		Sp = 5,
		Dp = 6
	}

	private enum SELECT
	{
		Card = 0,
		Item = 1,
		Mission = 2
	}

	private enum MODE
	{
		None = 0,
		Open = 1,
		Select_Top = 2,
		Move_PlateName = 3,
		Select_Ability = 4,
		Select_Condition = 5,
		Select_Card = 6,
		Select_Item = 7,
		Select_Mission = 8,
		Close = 9,
		End = 10
	}

	[SerializeField]
	[ReadOnly]
	private string mNameSelectTop;

	[SerializeField]
	[ReadOnly]
	private string mNameSelectAbility;

	[SerializeField]
	[ReadOnly]
	private string mNameSelectCondition;

	[SerializeField]
	[ReadOnly]
	private string mNameSelectCard;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private RectTransform mCursor;

	[SerializeField]
	private GameObject mStatusFrame;

	[SerializeField]
	private CFieldMenuStatus_PlayerChange mPlayerChange;

	[SerializeField]
	private TextMeshProUGUI[] mTextParam;

	[SerializeField]
	private TextMeshProUGUI[] mTextDRank;

	[SerializeField]
	private RectTransform mParentCommand;

	[SerializeField]
	private RectTransform mParentConditionsInnerTop;

	[SerializeField]
	private RectTransform mParentAbilitiesInnerTop;

	[SerializeField]
	private RectTransform mParentDroprank;

	[SerializeField]
	private CMenuStatusInner mMenuAbilities;

	[SerializeField]
	private TextMeshProUGUI mNumAbilities;

	[SerializeField]
	private CMenuStatusInner mMenuConditions;

	private bool mExplainDisp;

	[SerializeField]
	private CUIGenericMenu mMenuCards;

	[SerializeField]
	private TextMeshProUGUI mTitleDeck;

	[SerializeField]
	private RectTransform mDebugInfo;

	[SerializeField]
	private CUIGenericMenu mDebugMenu;

	private CFieldMenuItem mMenuItem;

	private CFieldMenuMission mMenuMission;

	[SerializeField]
	[ReadOnly]
	private SELECT mSelect;

	private CFieldPlayer[] mPlayer;

	private CFieldPlayer mSelectPlayer;

	private CParamPlayer mParam;

	private CFramingCamera mCamera;

	private CFramingCamera.Backup mBackupCamera;

	[SerializeField]
	private Vector3 mZoomCamera;

	[SerializeField]
	private Vector3 mOffsetCameraTarget;

	private MODE mMode;

	private MODE mBackup;

	private bool[] mJudg;

	public bool IsExec()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	private void FitCursor(RectTransform rt)
	{
	}

	private int GetCountAbility()
	{
		return 0;
	}

	private int GetCountCondition()
	{
		return 0;
	}

	public void Go(CFramingCamera camera, CFieldPlayer[] players, CFieldMenuItem menuItem, CFieldMenuMission menuMission)
	{
	}

	public void Close()
	{
	}

	private void Update()
	{
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

	private void ActiveMission()
	{
	}

	private void UpdateStatus()
	{
	}

	private void UpdateCommandCursor(int cursor, bool se = true)
	{
	}

	private void UpdateCards(List<CSkillCardData> list)
	{
	}

	private void ChangeNamePlate(int dir)
	{
	}

	private void ChangePlayerState()
	{
	}
}
