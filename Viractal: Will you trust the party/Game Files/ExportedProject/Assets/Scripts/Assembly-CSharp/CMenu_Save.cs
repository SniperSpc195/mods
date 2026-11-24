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
using UnityEngine.UI;
using net;

public class CMenu_Save : MonoBehaviour
{
	public enum SELECT_TYPE
	{
		Continue = 0,
		Online_Slot = 1,
		Local_Slot = 2,
		Save = 3
	}

	private enum MODE
	{
		None = 0,
		Load_SaveData = 1,
		Select_Start = 2,
		Select_Data = 3,
		Detail_JobModels = 4,
		Detail = 5,
		Detail_OpenCharacterParam = 6,
		Detail_CharacterParam = 7,
		Detail_CloseCharacterParam = 8,
		Slot_Overwrite_Inqury = 9,
		LocalSave_OverWrite = 10,
		LocalSave = 11,
		Delete_JobModels = 12,
		Delete_Inqury = 13,
		Delete_Return = 14,
		Continue_JobModels = 15,
		Continue_Inqury = 16,
		Continue_Cancel = 17,
		Conv_JobModels = 18,
		Conv_Inqury = 19,
		Conv_SelectLocal = 20,
		Conv_OverWrite_JobModels = 21,
		Conv_OverWrite_Inqury = 22,
		Conv_SaveStart = 23,
		Conv_SaveNow = 24,
		Conv_SaveEnd = 25,
		Conv_SaveError = 26,
		Conv_Return_SelectLocal = 27,
		Return_Camera = 28,
		GameStart_Wait = 29,
		GameStart = 30,
		Online = 31,
		Cancel = 32,
		End = 33
	}

	private class SaveInfo
	{
		private Transform mParent;

		public CSaveData.GAMEDATA mGameData;

		public SaveInfo(Transform parent, CSaveData.GAMEDATA gameData, Dictionary<string, Sprite> cache, bool selected = false)
		{
		}

		public void SetFrame(bool selected)
		{
		}

		public void Write(Dictionary<string, Sprite> cache)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckSaveData_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMenu_Save _003C_003E4__this;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMenu_Save _003C_003E4__this;

		public CUIButtonExplanation btnExplanation;

		private List<string> _003Ctmp_003E5__2;

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
	private CUIGenericMenu[] mMenus;

	[SerializeField]
	private CUIGenericMenu mMenuList;

	[SerializeField]
	private CChoiceMenu mChoiceMenu;

	[SerializeField]
	private Image mMenuDark;

	[SerializeField]
	private CUIGenericMenu mMenuSharing;

	[SerializeField]
	private Transform mParent_TargetSaveInfo;

	private SaveInfo mTargetSaveInfo;

	[SerializeField]
	private TextMeshProUGUI mDebugFilename;

	[SerializeField]
	private CEventMessage mGMMessage;

	[SerializeField]
	[ReadOnly]
	private CSaveData.NET mNetType;

	[SerializeField]
	[ReadOnly]
	private SELECT_TYPE mSelectType;

	private List<CSaveData.GAMEDATA>[] mSaveDatas;

	private List<CSaveData.GAMEDATA> mSaveDataList;

	private List<SaveInfo>[] mSaveInfos;

	private List<SaveInfo> mSaveInfoList;

	private CSaveData.GAMEDATA mSelectSaveData;

	private CSaveData.GAMEDATA mConvSource;

	private CSaveData.GAMEDATA mConvDestination;

	private bool mOnlineContinue;

	private CSaveData.GAMEDATA mOnline_ResumeData;

	private int mDeleteIndex;

	private int mInquruIndex;

	private double mNowTime;

	[SerializeField]
	private CCharacterSaveDetail m_CharacterDetail;

	private float mTimeLensShift;

	private Vector3 m_LookAtCameraPosResume;

	private Vector3 m_LookAtTargetPosResume;

	private Vector3 m_LookAtCameraPosStart;

	private Vector3 m_LookAtCameraPosGoal;

	private Vector3 m_LookAtTargetPosStart;

	private Vector3 m_LookAtTargetPosGoal;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation_Conv;

	private CUIButtonExplanation mButtonExplanation;

	private Dictionary<string, Sprite> mPlayerFace;

	private bool mExistField;

	private CUIButtonExplanation.DATA[] Def_ButtonData;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private bool mEnable_DeleteJobModels;

	private float mWait;

	private bool mDisplayJobModel;

	private int mModeYesNo;

	private int mYesNo;

	private UniTask mTask;

	public int m_CharacterPage { get; private set; }

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

	public void Close()
	{
	}

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__50))]
	public UniTask Initialize(CUIButtonExplanation btnExplanation)
	{
		return default;
	}

	public void Resume()
	{
	}

	public void Start_LocalSlot(CSaveData.GAMEDATA gameData)
	{
	}

	public void Start_OnlineSlot(CSaveData.NET netType, CSaveData.GAMEDATA gameData = null)
	{
	}

	public void Start_Continue()
	{
	}

	private void Initialize(GameController.PADNUM padNum)
	{
	}

	public void SelectMessage()
	{
	}

	private void Show_DefButton(GameController.PADNUM padNum)
	{
	}

	private void Update_DefButton()
	{
	}

	public bool IsExec()
	{
		return false;
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

	private bool IsOnline_ErrorOrLeave()
	{
		return false;
	}

	private void Update()
	{
	}

	private void Show_BlueMan()
	{
	}

	private void Cb_SelectCancel()
	{
	}

	private void Cb_Cancel()
	{
	}

	private void Cb_Decision(int n)
	{
	}

	private void Cb_ConvCancel()
	{
	}

	private void Cb_ConvDecision(int n)
	{
	}

	private void Open_YesNo(int n, CSaveData.GAMEDATA saveData, bool displayJobModel = false)
	{
	}

	public void Only_YesNo(int n)
	{
	}

	public void Close_YesNo()
	{
	}

	public bool IsActive_YesNo()
	{
		return false;
	}

	public int YesNo(GamePad pad, GamePad mouse, GameController.PADNUM padNum = GameController.PADNUM.None)
	{
		return 0;
	}

	private void Cb_YN_Cancel()
	{
	}

	private void Cb_YN_Decision(int n)
	{
	}

	private void UnloadJobModels(bool force = false)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckSaveData_003Ed__90))]
	private UniTask CheckSaveData(CancellationToken token)
	{
		return default;
	}

	private void UpdateList(bool cursorReset = true)
	{
	}

	private void Extraction_Offline()
	{
	}

	private void Extraction_Net(NetworkType type)
	{
	}

	public void OpenCharacterSaveDetail(int i_PieceIndex)
	{
	}

	public JsonNode GetSelectedSaveData()
	{
		return null;
	}
}
