using System.Collections.Generic;
using UnityEngine;
using net;

public class CFieldPlayer : CCharDef
{
	private class TALKWINDOW
	{
		public CEventMessage mEventMessage;

		public bool mOn;
	}

	public enum MODE
	{
		None = 0,
		Move = 1
	}

	public int mIndex;

	public GameController.PADNUM mPadNum;

	private COnline.PlayerInfo mPlayerInfo;

	public CMaster_CharJobData mJob;

	public CParamPlayer mParam;

	public CParamWhispers mWhispers;

	private GameObject mExecArrow;

	private CFieldUI_Player mEasyUI;

	private List<CParamMission> mMission;

	private List<CParamMission> mClearMission;

	private List<string> mWithdrawMission;

	public List<string> mRecordMoveStop;

	public CDefine.GameFlag mEventFlag;

	public CDefine.GameWork mEventWork;

	[SerializeField]
	[ReadOnly]
	private CParamInt mDiceNum;

	private Transform mParentTalkWindow;

	private TALKWINDOW mTalkWindow;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private CFieldMove mMove;

	private bool mBaseChangeColor;

	private int mBaseModel_Lv;

	private int mBaseModel_Sw;

	public COnline.PlayerInfo GetOnlinePlayerInfo(bool stamp = false)
	{
		return null;
	}

	public bool IsMe()
	{
		return false;
	}

	public bool IsRoomMember()
	{
		return false;
	}

	public bool IsGuest()
	{
		return false;
	}

	public bool IsCom()
	{
		return false;
	}

	public PlayerId GetPlayerID()
	{
		return default;
	}

	public string GetGUID()
	{
		return null;
	}

	public List<CParamMission> GetClearMission()
	{
		return null;
	}

	public List<string> GetWithdrawMission()
	{
		return null;
	}

	public CParamPlayer GetParamPlayer()
	{
		return null;
	}

	public void GetAllMissions(List<CParamMission> list)
	{
	}

	public int CheckMissionStatus(string id)
	{
		return 0;
	}

	public bool IsMissionAccept(string id)
	{
		return false;
	}

	public bool AddMission(CParamMission mission)
	{
		return false;
	}

	public List<CParamMission> GetMissionList()
	{
		return null;
	}

	public bool ClearMission(CParamMission m)
	{
		return false;
	}

	public bool WithdrawMission(CMaster_MissionListData mission)
	{
		return false;
	}

	public void SetDice(int n)
	{
	}

	public int GetDice()
	{
		return 0;
	}

	public void SetRecordMoveStop(string id)
	{
	}

	public bool IsRecordMoveStop(string id)
	{
		return false;
	}

	protected override void Awake()
	{
	}

	public void SetupParam(int i, CMaster_CharJobData job)
	{
	}

	public void SetupOnline(COnline.PlayerInfo pi)
	{
	}

	public CFieldMove GetFieldMove()
	{
		return null;
	}

	public int GetBaseModel_Lv()
	{
		return 0;
	}

	public bool IsBaseModelUp()
	{
		return false;
	}

	public void UpdateBaseModel(bool debug = false)
	{
	}

	private void SetupBaseModel()
	{
	}

	public void UpdateBaseColor()
	{
	}

	public void AnimeIdle()
	{
	}

	public void SetEasyUI(CFieldUI_Player ui)
	{
	}

	public CFieldUI_Player GetEasyUI()
	{
		return null;
	}

	public bool IsInsideCamera()
	{
		return false;
	}

	private void Start()
	{
	}

	public void SetActiveArrow(bool a)
	{
	}

	public void SetRoute(CFramingCamera fCamera, List<CHexRoute.CHECK> route, int diceNum, CPlayerDiceNum playerDiceNum)
	{
	}

	public bool IsMoveRoute()
	{
		return false;
	}

	public CFieldMove.STATE GetMoveState()
	{
		return CFieldMove.STATE.None;
	}

	public int GetMoveNum()
	{
		return 0;
	}

	public void CameraTracking(CFramingCamera fCamera, bool checkCrossFade = true)
	{
	}

	private void Update()
	{
	}

	protected override void LateUpdate()
	{
	}

	public void SetTalkWindowParent(Transform p)
	{
	}

	public Dictionary<string, object> Online_GetHeader()
	{
		return null;
	}

	public Dictionary<string, object> SaveOnline()
	{
		return null;
	}

	public static bool CheckSaveData(string path, JsonNode json)
	{
		return false;
	}

	public Dictionary<string, object> Save(bool IsOnline)
	{
		return null;
	}

	public void Load(bool IsOnline, JsonNode save)
	{
	}

	private void LoadListString(List<string> list, JsonNode array)
	{
	}

	public override GameController.PADNUM GetPadNum()
	{
		return GameController.PADNUM.PAD0;
	}

	public override string ID()
	{
		return null;
	}

	public override string Name()
	{
		return null;
	}
}
