using System;
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
using UnityEngine.ResourceManagement.AsyncOperations;

public class CGameRoom_Job : SingletonMonoBehaviour<CGameRoom_Job>
{
	[Serializable]
	public class Layout
	{
		public float mScaleModel;

		public Vector3 mJobName;

		public Vector3 mSpace;

		public Vector3 mLookAt;

		public Vector3 mCamera;
	}

	[Serializable]
	public class MODEL
	{
		public struct NewtonianMechanics
		{
			public float m_Speed;

			private float m_InitailSpeed;

			private float m_InitialPosition;

			public float m_Accel;

			public float m_Position;

			public float m_BouncingFloor;

			public float m_BouncingRatio;

			public double m_Time;

			public int m_BounceCount;

			public float m_Multiplier;

			public NewtonianMechanics(float position, float initialSpeed, float accel, float bouncingFloor = 0f, float bouncingRatio = 0.6f)
			{
				m_Speed = 0f;
				m_InitailSpeed = 0f;
				m_InitialPosition = 0f;
				m_Accel = 0f;
				m_Position = 0f;
				m_BouncingFloor = 0f;
				m_BouncingRatio = 0f;
				m_Time = 0.0;
				m_BounceCount = 0;
				m_Multiplier = 0f;
			}

			public bool Update()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Drop_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public MODEL _003C_003E4__this;

			public float i_Floor;

			private float _003Cinitialspeed_003E5__2;

			private float _003CfirstPosition_003E5__3;

			private bool _003Cbounce_003E5__4;

			private double _003CstartTime_003E5__5;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003C_FixUnitPosition_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int i_RandomFrame;

			public MODEL _003C_003E4__this;

			public Action i_OnEnd;

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
		private struct _003C_Jump_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Vector3 i_StartPosition;

			public Vector3 i_EndPosition;

			public MODEL _003C_003E4__this;

			private Vector3 _003CstartPosition_003E5__2;

			private Vector3 _003CendPosition_003E5__3;

			private float _003Cvolume_003E5__4;

			private NewtonianMechanics _003Cnewton_003E5__5;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003C_Shake_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public MODEL _003C_003E4__this;

			private int _003Ccount_003E5__2;

			private Vector3 _003Cpos_003E5__3;

			private double _003CstartTime_003E5__4;

			private float _003Clength_003E5__5;

			private CancellationToken _003Ctoken_003E5__6;

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

		private static readonly string SELandingHard;

		private static readonly string SELandingSoft;

		private static readonly string SEJump;

		public CMaster_CharJobData mJob;

		public CGameRoom_JobModel mModel;

		public CGameRoom_JobBase mJobBase;

		public int mPlayerLv;

		public CCharMeshFade mMeshFade;

		public TextMeshProUGUI mTmPro;

		public bool mSelected;

		private Action mDropCallback;

		private CancellationTokenSource mCancellationTokenSource;

		public CGameRoom_Table.ONLINE_PLAYER mOnline;

		public bool IsEqual(CGameRoom_Table.ONLINE_PLAYER a)
		{
			return false;
		}

		public MODEL(CMaster_CharJobData job, GameObject g, float scale, TextMeshProUGUI tmPro, CGameRoom_Table.ONLINE_PLAYER online = null)
		{
		}

		public void Destroy()
		{
		}

		public void CancelShakeTask()
		{
		}

		public void Active(bool a)
		{
		}

		public void SetPosition(Vector3 p)
		{
		}

		public Vector3 GetPosition()
		{
			return default;
		}

		public void SetIdle()
		{
		}

		public void SetBaseColor(int i)
		{
		}

		public void SetJobName()
		{
		}

		public void SetText(string text)
		{
		}

		public void CalcNamePosition(bool disp, Camera camera, TextMeshProUGUI tmPro, Vector3 offset, float alpha = 1f)
		{
		}

		public void SetDropCallback(Action i_OnDrop)
		{
		}

		public void Drop()
		{
		}

		[AsyncStateMachine(typeof(_003C_Drop_003Ed__27))]
		private UniTask _Drop(float i_Floor)
		{
			return default;
		}

		public void Shake()
		{
		}

		[AsyncStateMachine(typeof(_003C_Shake_003Ed__29))]
		private UniTask _Shake()
		{
			return default;
		}

		public void Jump(WaitingPoint i_Destination, Action i_OnEnd, int i_RandomFrame)
		{
		}

		[AsyncStateMachine(typeof(_003C_FixUnitPosition_003Ed__32))]
		private UniTask _FixUnitPosition(Action i_OnEnd, int i_RandomFrame)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_Jump_003Ed__33))]
		private UniTask _Jump(Vector3 i_StartPosition, Vector3 i_EndPosition, Quaternion i_StartRotation, Quaternion i_EndRotation)
		{
			return default;
		}
	}

	public class MOVE_LOOKAT
	{
		private Transform[] mTransform;

		private Vector3[] mStart;

		private Vector3[] mTarget;

		private Vector3[] mNow;

		private float mTime;

		public MOVE_LOOKAT(Transform lookAt, Transform camera)
		{
		}

		public void Start(Vector3 lookAt, Vector3 camera)
		{
		}

		public void Set(Vector3 lookAt, Vector3 camera)
		{
		}

		public float Update(float s)
		{
			return 0f;
		}
	}

	private enum MODE
	{
		None = 0,
		Cancel = 1,
		Selected = 2,
		Start_Local = 3,
		Select_Local = 4,
		Details_Initialize = 5,
		Details = 6,
		Details_Back = 7,
		LocalLobby_Start = 8,
		LocalLobby_Wait = 9,
		LocalLobby_End = 10,
		ContinueLobby_Default = 11,
		OnlineLobby_Start = 12,
		OnlineLobby_Comp = 13,
		OnlineLobby_Return = 14,
		OnlineLobby_End = 15
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoad_JobModels_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Job _003C_003E4__this;

		public List<CGameRoom_Table.PLAYER_SETTING> setting;

		public Transform parent;

		public List<MODEL> dstList;

		private float _003Csx_003E5__2;

		private int _003Ci_003E5__3;

		private CMaster_CharJobData _003CjobData_003E5__4;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__5;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
	private struct _003CLoad_JobModels_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Job _003C_003E4__this;

		public JsonNode players;

		public Transform parent;

		public List<MODEL> dstList;

		private float _003Csx_003E5__2;

		private int _003Ci_003E5__3;

		private JsonNode _003Cprm_003E5__4;

		private CMaster_CharJobData _003CjobData_003E5__5;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__6;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
	private struct _003CLoad_JobModels_003Ed__95 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Job _003C_003E4__this;

		public CGameRoom_Table.ONLINE_PLAYER[] players;

		public List<MODEL> dstList;

		public Transform parent;

		public JsonNode playerSaveData;

		private float _003Csx_003E5__2;

		private int _003Ci_003E5__3;

		private CMaster_CharJobData _003CjobData_003E5__4;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__5;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
	private struct _003CStart_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public CGameRoom_Job _003C_003E4__this;

		private int _003Ci_003E5__2;

		private int _003Cmax_003E5__3;

		private int _003Cj_003E5__4;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__5;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private CMaster_CharJobData[] _003C_003E7__wrap5;

		private CMaster_CharJobData _003Cjob_003E5__7;

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
	private CUIButtonExplanation mButtonExplanation;

	private static CUIButtonExplanation.DATA[] mKEYASSIGN_Data;

	[SerializeField]
	private CEventMessage mGMMessage;

	private string mTextGM;

	[SerializeField]
	private Transform mParentBase;

	[SerializeField]
	private Transform mParentModel;

	[SerializeField]
	private Transform mParentLocal;

	[SerializeField]
	private Layout mLocalLayout;

	[SerializeField]
	private Layout mLocalLobbyLayout;

	[SerializeField]
	private Layout mOnlineLayout;

	[SerializeField]
	private Transform mParentJobName;

	[SerializeField]
	private float mModelSelectSpeed;

	[SerializeField]
	private CUIFade mModelMask;

	[SerializeField]
	private CUIGenericFocus[] mFocusArea;

	[SerializeField]
	private CUIGenericOpenClose mKeyAssignDetail;

	private Vector2 mSize_KeyAssignDetail;

	[SerializeField]
	private Vector2 mLensShift;

	[SerializeField]
	private Vector2 mModelMaskPos;

	private float mTimeLensShift;

	[SerializeField]
	private Camera mThisSceneCamera;

	[SerializeField]
	private CinemachineVirtualCamera mDollyCamera;

	[SerializeField]
	private CinemachineVirtualCamera mLookAtCamera;

	[SerializeField]
	private Transform mLookAtTarget;

	[SerializeField]
	private CInOutBehaviour mJobFocusLight;

	[SerializeField]
	private CInOutBehaviour[] mOnlineSpotlights;

	[SerializeField]
	private Animator m_ArrowLeft;

	[SerializeField]
	private Animator m_ArrowRight;

	private bool m_FirstTimePlay;

	private WaitingPoint[] mWaitingPoints;

	[SerializeField]
	private GameObject m_EnterEffectPrefab;

	[SerializeField]
	private CCharacterDetail m_CharacterDetail;

	private CinemachineBasicMultiChannelPerlin m_NoiseComponent;

	private CanvasGroup mArrowCanvasGroup;

	private List<MODEL> mModels;

	private MOVE_LOOKAT mMoveLookAt;

	private int firstEnd;

	private List<List<MODEL>> mUnSelectedJob;

	private int mMaxUnSelectedJob;

	private int mModelIndex;

	private const int JOB_COLUM_MAX = 5;

	private CUIGenericOpenClose mParent_UIOnlinePlayerInfo;

	private bool mLocalSelect;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private MODE mModeBackup;

	private bool mLocalLobby;

	private List<MODEL> mLobbyModel;

	private UniTask mTask;

	private Vector3 mDollyCameraPosition;

	private CGameRoom_Table.ONLINE_PLAYER[] mOnlinePlayer;

	private CinemachineBasicMultiChannelPerlin NoiseComponent => null;

	private void Awake()
	{
	}

	public CMaster_CharJobData GetDefaultPossettionJob()
	{
		return null;
	}

	public void JumpUnits()
	{
	}

	public bool IsBoxEnterEnd()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__46))]
	private UniTaskVoid Start()
	{
		return default;
	}

	public void ClearSelected_All()
	{
	}

	public void ClearSelected(string id)
	{
	}

	public void GoLocalSelect(CUIGenericOpenClose onlineUI, string gmMes, int baseIndex, string selectedJobID, bool dupOk = false, bool isFirstTime = false)
	{
	}

	public void EndLocalSelect()
	{
	}

	private void FocusModel_Set(Layout layout, MODEL model)
	{
	}

	private void FocusModel_Move(Layout layout, MODEL model)
	{
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool IsSelected()
	{
		return false;
	}

	public string GetLocalJobID()
	{
		return null;
	}

	public void SelectJob_ChangeBaseColor(int color)
	{
	}

	public void SelectJob(GamePad pad, GamePad mouse)
	{
	}

	public void LocalDispJobName(float alpha)
	{
	}

	private bool LocalSelect(GamePad pad)
	{
		return false;
	}

	private bool SelectUpdate(int old, int line, int index, int max)
	{
		return false;
	}

	private void KnockArrow(bool left = false, bool right = false)
	{
	}

	private bool SelectLeft()
	{
		return false;
	}

	private bool SelectRight()
	{
		return false;
	}

	private int NextLineNearIndex(int line, int index, int nextLine)
	{
		return 0;
	}

	public void GoLocalLobby(List<CGameRoom_Table.PLAYER_SETTING> setting)
	{
	}

	public void EndLocalLobby()
	{
	}

	[AsyncStateMachine(typeof(_003CLoad_JobModels_003Ed__77))]
	public UniTask Load_JobModels(List<MODEL> dstList, Transform parent, List<CGameRoom_Table.PLAYER_SETTING> setting)
	{
		return default;
	}

	public bool IsComplete_LocalLobby()
	{
		return false;
	}

	public void LocalLobby()
	{
	}

	public void GoContinueLobby(JsonNode json)
	{
	}

	public void SetNames(string[] names)
	{
	}

	public void GoContinueLobby_Camera()
	{
	}

	public void GoContinueLobby_Default(Vector3 startPosition)
	{
	}

	[AsyncStateMachine(typeof(_003CLoad_JobModels_003Ed__87))]
	public UniTask Load_JobModels(List<MODEL> dstList, Transform parent, JsonNode players)
	{
		return default;
	}

	public bool IsComplete_ContinueLobby()
	{
		return false;
	}

	public void ContinueLobby()
	{
	}

	public void GoOnlineLobby(CGameRoom_Table.ONLINE_PLAYER[] list, JsonNode playerSaveData = null)
	{
	}

	public void ReturnOnlineLobby()
	{
	}

	public void UpdateOnlineLobby(CGameRoom_Table.ONLINE_PLAYER[] players, JsonNode playerSaveData = null)
	{
	}

	public bool IsComplete_OnlineLobby()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CLoad_JobModels_003Ed__95))]
	public UniTask Load_JobModels(List<MODEL> dstList, Transform parent, CGameRoom_Table.ONLINE_PLAYER[] players, JsonNode playerSaveData = null)
	{
		return default;
	}

	public bool OnlineLobby()
	{
		return false;
	}

	public void HideCanvases()
	{
	}

	public void ShowArrow(bool i_Switch)
	{
	}

	public void SetSaveDetailMode()
	{
	}

	public void DelSaveDetailMode()
	{
	}

	public Vector3 GetLobbyModelPosition(int i_Index)
	{
		return default;
	}
}
