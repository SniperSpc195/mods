using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CDevilsWhispers : SingletonMonoBehaviour<CDevilsWhispers>
{
	private enum UI
	{
		Base = 0,
		Inquiry = 1,
		Contract = 2,
		Small = 3,
		None = -1
	}

	public class Reserved
	{
		public CMaster_DevilsContractData mContractData;

		public CMaster_DevilsEffectData mEffectData;

		public int mPlayerIndex;

		public int mNumContracted;

		public int mTurn;

		public int mUniqueNum;

		public Reserved()
		{
		}

		public Reserved(JsonNode json)
		{
		}

		public Dictionary<string, object> Save()
		{
			return null;
		}
	}

	private struct EXECUTE_STATUS
	{
		public int mElapsedTime;

		public MODE mMode;
	}

	public enum MODE
	{
		None = 0,
		Base_Open = 1,
		Base = 2,
		Base_Wait = 3,
		Inquiry = 4,
		Small = 5,
		Contract = 6,
		Contract_Wait = 7,
		Contract_Close = 8,
		TimeOut = 9,
		TimeOut_Wait = 10,
		Close = 11,
		Waiting_Receive = 12
	}

	private const float LINEWAIT = 1.5f;

	[SerializeField]
	[ReadOnly]
	private int mUniqueNum;

	[SerializeField]
	[ReadOnly]
	private List<CWhispersEffect> mEffects;

	[SerializeField]
	private Canvas mRenderCanvas;

	[SerializeField]
	private Camera mRenderCamera;

	private RenderTexture mRenderTexture;

	[SerializeField]
	private RawImage mRawImage;

	[SerializeField]
	private Color mRawImageColor;

	[SerializeField]
	private CUIVortexParameter mVortex;

	[SerializeField]
	private float mMaxVortexPower;

	[SerializeField]
	private float mVortexSpeed;

	[SerializeField]
	private GameObject mBase;

	[SerializeField]
	private Image[] mBase_Circle;

	[SerializeField]
	private TextMeshProUGUI mBase_TextTitle;

	[SerializeField]
	private TextMeshProUGUI mBase_TextInfo;

	[SerializeField]
	private GameObject mInquiry;

	[SerializeField]
	private TextMeshProUGUI mInquiry_TextTitle;

	[SerializeField]
	private TextMeshProUGUI mInquiry_TextInfo;

	[SerializeField]
	private TextMeshProUGUI mInquiry_TimerNum;

	[SerializeField]
	private Image mInquiry_TimerProgress;

	[SerializeField]
	private TextMeshProUGUI mLeftButton;

	[SerializeField]
	private TextMeshProUGUI mRightButton;

	[SerializeField]
	private GameObject mSmall;

	[SerializeField]
	private TextMeshProUGUI mSmall_R2;

	[SerializeField]
	private TextMeshProUGUI mSmall_TimerNum;

	[SerializeField]
	private Image mSmall_TimerProgress;

	[SerializeField]
	private TextMeshProUGUI mSmall_RightButton;

	[SerializeField]
	private CDevilsVoiceWeird mVoiceWeird;

	[SerializeField]
	private Vector2[] mUIPosition;

	private UI mSelectUI;

	[SerializeField]
	private bool mEnableTimer;

	[SerializeField]
	private int mRemainingSec;

	private int mNowRemainingSec;

	private long mTimer;

	private int mElapsedTime;

	private int mOldElapsedTime;

	[SerializeField]
	[ReadOnly]
	private string mWhispersID;

	[SerializeField]
	[ReadOnly]
	private CMaster_DevilsContractData mContractData;

	[SerializeField]
	[ReadOnly]
	private CMaster_DevilsEffectData mEffectData;

	[SerializeField]
	[ReadOnly]
	private CFieldPlayer mPlayer;

	[SerializeField]
	[ReadOnly]
	private bool mSelfExecution;

	private Reserved mReserved;

	private EXECUTE_STATUS mExecuteStatus;

	private bool mInitialize;

	private JsonNode mSaveExec;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private float mTextWait;

	private void OnDestroy()
	{
	}

	public bool IsReserved()
	{
		return false;
	}

	public Reserved GetReserved()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Active(bool a)
	{
	}

	private void Initialize()
	{
	}

	private float MakeTextureSize(float min, Vector2 size)
	{
		return 0f;
	}

	private void EnableBaseCircle(int n)
	{
	}

	public void Go(CMaster_DevilsContractData contractData, CFieldPlayer player)
	{
	}

	public Dictionary<string, object> Save_IncludeSend()
	{
		return null;
	}

	public void Load_IncludeSend(JsonNode json)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public static bool CheckSaveData(string savefile, JsonNode json)
	{
		return false;
	}

	public void Load(JsonNode json)
	{
	}

	public void LoadExec()
	{
	}

	public void Stop()
	{
	}

	private void HideAll()
	{
	}

	private void ActiveBase(bool a)
	{
	}

	private void ActiveInquiry(bool a)
	{
	}

	private void ActiveSmall(bool a)
	{
	}

	public MODE GetMode()
	{
		return MODE.None;
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsExecMe()
	{
		return false;
	}

	public bool IsAddPoint()
	{
		return false;
	}

	private void Update()
	{
	}

	private void SetupBase()
	{
	}

	private void SetupBaseText()
	{
	}

	private void SetupInquiry()
	{
	}

	private void SetupSmall()
	{
	}

	private void SetupContract()
	{
	}

	private void SetupTimeout()
	{
	}

	private bool UpdateTimer(GamePad pad, TextMeshProUGUI textNum, Image progress)
	{
		return false;
	}

	private bool OpenVortex()
	{
		return false;
	}

	private bool CloseVortex()
	{
		return false;
	}

	public CWhispersEffect GetWhispersEffect(int unique)
	{
		return null;
	}

	private void SendExecute()
	{
	}

	public Dictionary<string, object> CreateParamWhispers()
	{
		return null;
	}

	public void SendWhispers()
	{
	}

	public void ReceivedParamWhispers()
	{
	}

	public bool LotteryActivation(bool IsOnline, CFieldPlayer execPlayer)
	{
		return false;
	}

	public void Remove(CWhispersEffect eff)
	{
	}

	public bool IsExistEffect(CMaster_DevilsContractData data)
	{
		return false;
	}

	private Dictionary<string, object> MakeReserved()
	{
		return null;
	}

	public void Processed_ApplyReservation()
	{
	}

	public void ApplyReservation(JsonNode json)
	{
	}
}
