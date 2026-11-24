using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CGameRoom : LwSingleton<CGameRoom>
{
	public enum ROOM_POS
	{
		None = -1,
		Refine = 0,
		GameMaster = 1,
		Shelf = 2,
		GameTable = 3,
		ShelfBook = 4,
		Memo = 5,
		Door = 6,
		Achievement = 7
	}

	private enum MODE
	{
		None = 0,
		Wait_CompleteRoom = 1,
		Tutorial_HELP_0200 = 2,
		Enter_FadeWait = 3,
		Enter_Room = 4,
		Enter_Save = 5,
		InitCursor = 6,
		MoveCursor = 7,
		Forward_DollyCamera = 8,
		Wait_DollyCamera = 9,
		Facility_Before = 10,
		Stop_DollyCamera = 11,
		Facility_After = 12,
		AutoSave = 13,
		Back_DollyCamera = 14,
		EndBack_DollyCamera = 15,
		Talk_GameMaster = 16,
		GameTable = 17,
		Online = 18,
		Shelf = 19,
		Refine = 20,
		Memo = 21,
		OptionMenu = 22,
		Tutorial = 23,
		StaffRole = 24,
		End_Ending = 25,
		ClearBoard = 26,
		To_Title_Save = 27,
		To_Title = 28
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public CGameRoom _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CUnloadSceneLater_003Ed__103 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom _003C_003E4__this;

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

	[CompilerGenerated]
	private sealed class _003C_HideSoulPoint_003Ed__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CGameRoom _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_HideSoulPoint_003Ed__120(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private bool mLoadingCompleteRoom;

	private static bool mInGame;

	private static CSaveData.GAMEDATA mOnline_ResumeData;

	[SerializeField]
	private CDebugMenu mDebugMenu;

	[SerializeField]
	private Camera mThisSceneCamera;

	[SerializeField]
	private CinemachineVirtualCamera mDollyCamera;

	[SerializeField]
	private CinemachineVirtualCamera mLookAtCamera;

	[SerializeField]
	[ReadOnly]
	private CinemachineTrackedDolly mTrackedDolly;

	[SerializeField]
	[ReadOnly]
	private CinemachineBasicMultiChannelPerlin[] mNoise;

	[SerializeField]
	private float mAmplitudeGain;

	[SerializeField]
	private float mFrequencyGain;

	[SerializeField]
	[ReadOnly]
	private bool mNoiseOn;

	[SerializeField]
	private CinemachineSmoothPath[] mSmoothPath;

	private CinemachineSmoothPath mPlaySmoothPath;

	private Vector3[] mEndDollyPosition;

	private Vector3[] mPathPosition;

	private Vector3 mDefPathPosition;

	private float mLerpPathPosition;

	[SerializeField]
	private float mPathSpeed;

	[SerializeField]
	[ReadOnly]
	private CMouseCtrl.FACILITY mSelectFacility;

	[SerializeField]
	[ReadOnly]
	private Vector3 mCameraLookAt;

	[SerializeField]
	private Vector3 mCameraPosition;

	[SerializeField]
	private Vector3 mCamraAngle;

	[SerializeField]
	private float mCameraFov;

	[SerializeField]
	private Transform mDefaultLookAt;

	[SerializeField]
	private Transform mStartLookAt;

	private Vector3 mStartPosition;

	private float[] mBackMoveLeap;

	[SerializeField]
	private CUIGenericCrossFade mCrossFade;

	[SerializeField]
	private RectTransform m3DToUI;

	[SerializeField]
	private CMouseCtrl mMouseCtrl;

	[SerializeField]
	private GameObject m2DRoot;

	[SerializeField]
	private GameObject mDebugPlaceCircle;

	[SerializeField]
	private TextMeshProUGUI mDebugTextRoomPosition;

	[SerializeField]
	private GameObject mParentRoomPosition;

	[SerializeField]
	private CRoomPosition[] mRoomPosition;

	[SerializeField]
	private GameObject mParentPlaceInfo;

	[SerializeField]
	private CEventScript mEventScript;

	[SerializeField]
	private CUIFade mFade;

	[SerializeField]
	private CEventMessage mGMMessage;

	private string mTextGM_RoomInfo;

	[SerializeField]
	private CUIButtonExplanation mButtonExp;

	[SerializeField]
	private CUIGenericMenu mMenu_YesNo;

	[SerializeField]
	private CGameRoom_Table mMenu_GameTable;

	[SerializeField]
	private CGameRoom_Shelf mMenu_Shelf;

	[SerializeField]
	private CGameRoom_Transmutation mMenu_Transmutation;

	[SerializeField]
	private CItemWindow mItemWindow;

	[SerializeField]
	private Transform mParentJobModel;

	[SerializeField]
	private float mScaleJobModel;

	[SerializeField]
	[ReadOnly]
	private CBlueMan[] mBlueMans;

	[SerializeField]
	private CUIStaffroll mStaffroll;

	[SerializeField]
	private CUIStaffrollEnding mStaffrollEnding;

	private CAnimePlayer mAnimeDoor;

	[SerializeField]
	private CMenuClearBoard mMenuClearBoard;

	private float mWait;

	private bool mDebugDreaw;

	private static bool mFirstLLaunch;

	private GameObject mBoardAchievement;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private Action mAfterTutorial;

	private bool mBeforeStartPosition;

	private RaycastHit[] m_CachedHitList;

	public CMouseCtrl MouseCtrl => null;

	public CUIFade Fade => null;

	public CEventMessage GMMessage => null;

	public CGameRoom_Shelf MenuShelf => null;

	public CGameRoom_Transmutation MenuTransmutation => null;

	public CItemWindow ItemWindow => null;

	public CUIStaffroll Staffroll => null;

	public CUIStaffrollEnding StaffrollEnding => null;

	public CAnimePlayer AnimeDoor => null;

	private new void OnDestroy()
	{
	}

	public static void SetOnline_Resume(CSaveData.GAMEDATA gameData)
	{
	}

	public Camera GetMainCamera()
	{
		return null;
	}

	public CinemachineVirtualCamera GetDollyCamera()
	{
		return null;
	}

	public CinemachineVirtualCamera GetLookAtCamera()
	{
		return null;
	}

	public CinemachineTrackedDolly GetCinemachineTrackedDolly()
	{
		return null;
	}

	public CinemachineSmoothPath GetCinemachineSmoothPath(ROOM_POS n)
	{
		return null;
	}

	public Vector3 GetEndDollyPosition(ROOM_POS pos)
	{
		return default;
	}

	public float GetPathSpeed()
	{
		return 0f;
	}

	public CMouseCtrl.FACILITY GetSelectFacility()
	{
		return CMouseCtrl.FACILITY.Refine;
	}

	public Vector3 GetStartLookAtPosition()
	{
		return default;
	}

	public CUIGenericCrossFade GetCrossFade()
	{
		return null;
	}

	public CRoomPosition GetCRoomPosition(ROOM_POS n)
	{
		return null;
	}

	public CEventScript GetCEventScript()
	{
		return null;
	}

	public CGameRoom_Table GetGameRoom_Table()
	{
		return null;
	}

	public CBlueMan[] GetBlueMans()
	{
		return null;
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__93))]
	private UniTaskVoid Start()
	{
		return default;
	}

	private void PlaceActive()
	{
	}

	public void Active_BoardAchievement(bool a)
	{
	}

	private void CB_LoadingCompleteRoom(Scene scene)
	{
	}

	private void Update()
	{
	}

	[AsyncStateMachine(typeof(_003CUnloadSceneLater_003Ed__103))]
	private UniTask UnloadSceneLater()
	{
		return default;
	}

	private void HideCanvases()
	{
	}

	private void DeactivateCamera()
	{
	}

	private void ReturnStartPosition()
	{
	}

	private GameObject CheckRay()
	{
		return null;
	}

	private void SetCameraNoise(bool a)
	{
	}

	public void ShowGmMessage(string i_Text)
	{
	}

	public static CBlueMan[] GetRoomBlueMans()
	{
		return null;
	}

	public static CBlueMan GetBlueMan(COnline.PlayerInfo info)
	{
		return null;
	}

	public void ShowBlueMan(int num, bool effect = false)
	{
	}

	public void Reset_BlueMan(bool immediate = false)
	{
	}

	public void Reset_Effect_BlueMan(bool immediate = false)
	{
	}

	public void ShowSoulPoint(int a)
	{
	}

	public void ShowSoulPoint()
	{
	}

	public void ShowBonusSoulPoint()
	{
	}

	public void HideSoulPoint()
	{
	}

	[IteratorStateMachine(typeof(_003C_HideSoulPoint_003Ed__120))]
	private IEnumerator _HideSoulPoint()
	{
		return null;
	}

	private bool BootContine()
	{
		return false;
	}
}
