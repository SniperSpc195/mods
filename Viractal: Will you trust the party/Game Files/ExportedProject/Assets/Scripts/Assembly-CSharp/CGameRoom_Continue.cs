using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using net;

public class CGameRoom_Continue : MonoBehaviour
{
	private enum TCOLOR
	{
		Date = 0,
		Empty = 1,
		Corrupted = 2,
		DoesNotContain = 3
	}

	public enum SELECT_TYPE
	{
		Continue = 0,
		Online_Slot = 1,
		Local_Slot = 2,
		Local_Save = 3
	}

	private enum MODE
	{
		None = 0,
		Load_SaveData = 1,
		Select_Data = 2,
		Setup_JobModels = 3,
		LocalSave_OverWrite = 4,
		LocalSave = 5,
		OnlineSlot_Move = 6,
		OnlineSlot_Inqury = 7,
		Delete_Move = 8,
		Delete_Inqury = 9,
		Delete_Return = 10,
		Move_Camera = 11,
		GameStart_Inqury = 12,
		GameStart_Wait = 13,
		GameStart = 14,
		Online = 15,
		Return_Camera = 16,
		Cancel = 17,
		End = 18
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckSaveData_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Continue _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private Camera mThisSceneCamera;

	[SerializeField]
	private CinemachineVirtualCamera mDollyCamera;

	private Vector3[] mDollyCameraPosition;

	[SerializeField]
	private CUIGenericMenu mMenuList;

	[SerializeField]
	private CUIGenericOpenClose mListOpenClose;

	[SerializeField]
	private Color[] mTextColor;

	[SerializeField]
	private CUIGenericMenu mMenuYesNo;

	[SerializeField]
	private TextMeshProUGUI mText_KeyAssignDelete;

	[SerializeField]
	private GameObject mKeyAssignDelete;

	[SerializeField]
	private TextMeshProUGUI mDebugFilename;

	[SerializeField]
	private GameObject mParentSaveInfo;

	private Vector2[] mOrgAnchoredPosition;

	[SerializeField]
	private TextMeshProUGUI mInfoStage;

	[SerializeField]
	private TextMeshProUGUI mInfoPlaymode;

	[SerializeField]
	private TextMeshProUGUI mRemainingTurns;

	[SerializeField]
	private TextMeshProUGUI mSituation;

	[SerializeField]
	private Transform[] mPlayers;

	[SerializeField]
	private float mMoveSec;

	private float mMenuAlpha;

	[SerializeField]
	private CEventMessage mGMMessage;

	[SerializeField]
	[ReadOnly]
	private CSaveData.NET mNetType;

	[SerializeField]
	[ReadOnly]
	private SELECT_TYPE mSelectType;

	private List<CSaveData.GAMEDATA> mSaveData;

	private CSaveData.GAMEDATA mSelectSaveData;

	private bool mOnlineContinue;

	private CSaveData.GAMEDATA mOnline_ResumeData;

	private int mDeleteIndex;

	private int mInquruIndex;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private UniTask mTask;

	private bool mModelUpdate;

	public CEventMessage GetEventMessage()
	{
		return null;
	}

	private bool IsModel()
	{
		return false;
	}

	private bool IsSlot()
	{
		return false;
	}

	public void SetOnline_Resume(CSaveData.GAMEDATA gameData)
	{
	}

	public CSaveData.GAMEDATA GetSaveData()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Active(bool a)
	{
	}

	public void Start_Continue()
	{
	}

	public void Start_OnlineSlot(CSaveData.NET netType, CSaveData.GAMEDATA gameData = null)
	{
	}

	public void Start_LocalSlot(CSaveData.GAMEDATA gameData)
	{
	}

	public void Start_LocalSave(GameController.PADNUM padNum, CSaveData.GAMEDATA gameData)
	{
	}

	private void Initialize(GameController.PADNUM padNum)
	{
	}

	public bool IsCancel()
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

	public bool IsOnline()
	{
		return false;
	}

	public void SelectMessage()
	{
	}

	private void Update()
	{
	}

	[AsyncStateMachine(typeof(_003CCheckSaveData_003Ed__52))]
	private UniTask CheckSaveData(CancellationToken token)
	{
		return default;
	}

	private void Extraction_Local()
	{
	}

	private void Extraction_Net(NetworkType type)
	{
	}

	private int MakeList(bool delete = false)
	{
		return 0;
	}

	private void SaveListColor(Color c, int index = -1)
	{
	}

	private void MakeMoreInformation(CSaveData.GAMEDATA gameData)
	{
	}

	private bool MenuDelete()
	{
		return false;
	}

	private int YesNo(GamePad pad, GamePad mouse)
	{
		return 0;
	}

	private void Show_BlueMan()
	{
	}

	private void CbSaveDecision(int n)
	{
	}

	private void CbSaveCanncel()
	{
	}
}
