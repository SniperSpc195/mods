using System.Collections.Generic;
using UnityEngine;

public class CFieldTBox : CCharDef
{
	private enum MODE
	{
		None = 0,
		Received = 1,
		Start = 2,
		Select_Item = 3,
		Dice = 4,
		Dice_Wait = 5,
		Open_TrasureBox = 6,
		Normal_Start = 7,
		Get_Item = 8,
		Get_Item_Wait = 9,
		Get_Card = 10,
		Get_Card_Wait = 11,
		FullItem = 12,
		Start_Empty = 13,
		Wait_Empty = 14,
		Dice_End = 15,
		End = 16
	}

	public string mObjectID;

	private Transform mBoxModel;

	private MODE mMode;

	private CEventMessage mMesWin;

	private CFieldNewDice mFieldNewDice;

	private CUIGenericMenu mRouletteMenu;

	private CUIGenericOpenClose mRouletteOpenClose;

	private bool mRouletteSelect;

	private CUIButtonExplanation mButtonExplanation;

	private CItemWindow mItemWindow;

	private CEffectHandle mEffectHandle;

	private bool mOpenEffect;

	private float mWait;

	private bool mFullItem;

	private List<CMaster_TreasureTableData> mTBoxList;

	private int mTresureCount;

	private List<CMaster_TreasureTableData>[] mDiceList;

	private List<CMaster_TreasureTableData> mTBoxData;

	private int mGetIndex;

	private bool mUseDice;

	public CMaster_EventObjectData GetEventObjectData()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private new void LateUpdate()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void GetSeq(CEventMessage mes, string id, string kind, string rare)
	{
	}

	private void Update()
	{
	}

	private void OpenBox()
	{
	}

	private void Effect()
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public void Load(JsonNode save)
	{
	}

	private void Lottery(List<CMaster_TreasureTableData> list, int drItem, int drCard, UtpnRandom rnd)
	{
	}

	private void SetupTreasure(string id, string kind, string rare)
	{
	}

	private void SetupRoulette()
	{
	}

	private void SelectCursor()
	{
	}

	private void SelectRoulette(int n)
	{
	}

	private void Close_SelectRoulette()
	{
	}

	private void CbItemDecision(int n)
	{
	}
}
