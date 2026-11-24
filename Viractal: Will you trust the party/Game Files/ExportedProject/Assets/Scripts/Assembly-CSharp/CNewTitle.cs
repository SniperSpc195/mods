using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CNewTitle : LwSingleton<CNewTitle>
{
	private enum MODE
	{
		None = 0,
		Wait_Room = 1,
		Loop_Logo = 2,
		Open_Logo = 3,
		Close_Logo = 4,
		Init_Title = 5,
		Open_Title = 6,
		Push_AnyButton = 7,
		Close_Title = 8,
		View_License = 9,
		Load_GameRoom = 10,
		Enter_GameRoom = 11
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public CNewTitle _003C_003E4__this;

		private TitleLogoSet _003CassetGroup_003E5__2;

		private Image _003C_003E7__wrap2;

		private UniTask<Sprite>.Awaiter _003C_003Eu__1;

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
	private TitleLogoSet m_TitleLogoJP;

	[SerializeField]
	private TitleLogoSet m_TitleLogoUS;

	[SerializeField]
	private TitleLogoSet m_TitleLogoJP_DEMO;

	[SerializeField]
	private TitleLogoSet m_TitleLogoUS_DEMO;

	[SerializeField]
	private TitleLogoSet m_TitleLogoCS;

	[SerializeField]
	private TitleLogoSet m_TitleLogoCT;

	[SerializeField]
	private TitleLogoSet m_TitleLogoKO;

	[SerializeField]
	private TitleLogoSet m_TitleLogoCS_DEMO;

	[SerializeField]
	private TitleLogoSet m_TitleLogoCT_DEMO;

	[SerializeField]
	private TitleLogoSet m_TitleLogoKO_DEMO;

	[SerializeField]
	private Image m_TitleLogoImage;

	[SerializeField]
	private CChoiceMenu m_DemoChoice;

	[SerializeField]
	private Camera mThisSceneCamera;

	[SerializeField]
	private Vector3 mDefaultCameraPosition;

	[SerializeField]
	private Vector3 mDefaultLookAt;

	[SerializeField]
	private GameObject mParentCompanyLogo;

	[SerializeField]
	private CUIFade[] mCompanyLogo;

	private int mCLogoIndex;

	[SerializeField]
	private GameObject mLogoTITLEGroup;

	[SerializeField]
	private CanvasGroup mLogoTITLECanvasGroup;

	[SerializeField]
	private Image mPressAnyButton;

	[SerializeField]
	private RawImage mTitlebackImage;

	[SerializeField]
	private TMP_Text mVersionsText;

	[SerializeField]
	private GameObject mClearEffectRoot;

	[SerializeField]
	private ParticleSystem[] mClearEffectParticles;

	[SerializeField]
	private TMP_Text mClearStarText;

	private float mPingPongSpeed;

	[SerializeField]
	private Transform mCanvasDebug;

	private static bool mFirstBoot;

	private GameObject mRoom;

	private Camera mRoomCamera;

	private long mBgmRequestHandle;

	private bool mLoadingCompleteRoom;

	private int mWaitFrame;

	private float mTime;

	private const float mWaitCompanyLogo = 120f;

	private const float mTitleLogoTime = 1.5f;

	private const float mWaitPushAnyButton = 0.5f;

	private const float mFadeoutTime = 3f;

	private GameObject mBoardAchievement;

	private bool mUnloadScene;

	private MODE mMode;

	private new void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	public static string Load_GameRoomLight()
	{
		return null;
	}

	public static void UnloadScene_GameRoomLight()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__43))]
	private UniTaskVoid Start()
	{
		return default;
	}

	public void Active_BoardAchievement(bool a)
	{
	}

	private void CB_LoadingComplete_Room(Scene scene)
	{
	}

	public void SceneEnd()
	{
	}

	private void Update()
	{
	}

	private void PingPong()
	{
	}
}
