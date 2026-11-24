using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CFieldMenuItem : CUIGenericMenu
{
	private enum MODE
	{
		End = 0,
		Open = 1,
		Execute = 2,
		Full_Inquiry = 3,
		Use_Wait = 4,
		Mission_Result = 5,
		Move_PlateName = 6,
		Close = 7
	}

	[SerializeField]
	[ReadOnly]
	private string mNameSelectTop;

	[SerializeField]
	[ReadOnly]
	private string mNameDebugEnd;

	[SerializeField]
	[ReadOnly]
	private string mNameDebugChange;

	private bool mBattle;

	private CFieldPlayer mSelectPlayer;

	private CParamPlayer mParam;

	private CFieldPlayer mControlPlayer;

	private CFieldPlayer[] mPlayerList;

	private Vector3? mOffsetCameraTarget;

	[SerializeField]
	private Transform mNumPossession;

	[SerializeField]
	private CFieldMenuStatus_PlayerChange mPlayerChange;

	[SerializeField]
	private RectTransform mInfoRect;

	[SerializeField]
	private TextMeshProUGUI mInfoName;

	[SerializeField]
	private TextMeshProUGUI mInfoText;

	[SerializeField]
	private RectTransform mFullExplanation;

	[SerializeField]
	private TextMeshProUGUI mTextFullExplanation;

	[SerializeField]
	private CUIGenericMenu mFullInquiry;

	private int mFullItem_AddCount;

	private int mMaxPossessionItems;

	private bool mFullItem;

	private bool mReturnMenuUse;

	[SerializeField]
	private RectTransform mDebugInfo;

	private List<CParamMission> mMissionList;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	public int GetPlayerIndex()
	{
		return 0;
	}

	private new void Awake()
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

	public void Go(bool battle, CFieldPlayer player)
	{
	}

	public void Go(CFieldPlayer[] playerList, int index, Vector3 offset)
	{
	}

	public void GoFull(bool battle, CFieldPlayer player, List<string> addItem)
	{
	}

	private void SetCallbacks(UnityAction cancel, UnityAction<int> decision)
	{
	}

	private void Startup(bool resetCursorPosition = true)
	{
	}

	private void UpdateNumPossession()
	{
	}

	private bool IsPlayerChange()
	{
		return false;
	}

	private void SetupIcon()
	{
	}

	private void UpdateInfo(bool debug = false)
	{
	}

	private void CursorFollowPosition(RectTransform dst, Vector2 scale)
	{
	}

	private void Update()
	{
	}

	private void OnExecuteCancel()
	{
	}

	private void OnExecuteDecision(int n)
	{
	}

	private void WriteInquiry(int n, string text, bool ok)
	{
	}

	private bool IsUsable(CMaster_ItemData item)
	{
		return false;
	}

	private bool UseItem()
	{
		return false;
	}

	private bool DisposeItem()
	{
		return false;
	}

	private bool DeliveryItem()
	{
		return false;
	}

	private void ChangeNamePlate(int dir)
	{
	}
}
