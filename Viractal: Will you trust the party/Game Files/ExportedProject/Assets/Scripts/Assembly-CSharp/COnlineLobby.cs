using TMPro;
using UnityEngine;
using net;

public class COnlineLobby : CUIGenericMenu
{
	private enum MODE
	{
		None = 0,
		Owner_Wait = 1,
		Owner_CloseRoom = 2,
		Owner_ForcedExit = 3,
		Owner_GameStart = 4,
		Owner_GameStart_Wait = 5,
		Client_Start = 6,
		Client_Wait = 7,
		Client_WaitStart = 8,
		LeaveRoom = 9,
		End = 10,
		ToField = 11,
		GameStart = 12
	}

	[SerializeField]
	private RectTransform mUIPlayers;

	private CUIGenericDialog mDialog;

	private double mNowTime;

	[SerializeField]
	private GameObject mInfoRoot;

	[SerializeField]
	private GameObject mInstHost;

	[SerializeField]
	private GameObject mInstClient;

	[SerializeField]
	private TextMeshProUGUI mRoomName;

	private bool mEnableGuest;

	private COnline.PlayerInfo mPlayerGuest;

	private int mNowMember;

	private int mOnlineMaxMember;

	private int mGameMaxMember;

	private int mPrepNum;

	private int mCompNum;

	private JsonNode mContinueSavedata;

	private JsonNode mContinueField;

	private JsonNode mContineOnlinePlayerInfo;

	private MODE mMode;

	public void EnableGuest(bool a)
	{
	}

	private void SetSaveData(JsonNode saveData)
	{
	}

	private void SetSaveData(string saveData)
	{
	}

	public void StartHost(CUIGenericDialog dialog, CreateRoomReq req, JsonNode saveData = null)
	{
	}

	public void StartClient(CUIGenericDialog dialog, IRoomInfo room, JsonNode saveData = null)
	{
	}

	private bool IsContinue()
	{
		return false;
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsGameStart()
	{
		return false;
	}

	private bool ElapsedTime(float t = 0.5f)
	{
		return false;
	}

	private void OpenDialog(string a)
	{
	}

	private void Update()
	{
	}

	private void UpdatePlayerUI()
	{
	}

	private void UpdatePlayerList(Transform parent, COnline.PlayerInfo player)
	{
	}

	private void Owner_SendPlayerInfo()
	{
	}
}
