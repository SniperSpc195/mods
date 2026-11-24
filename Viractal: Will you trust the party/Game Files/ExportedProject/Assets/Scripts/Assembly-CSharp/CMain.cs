using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UTPN;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class CMain : LwSingleton<CMain>
{
	public enum RND
	{
		System = 0,
		Battle = 1,
		Event = 2,
		MapAutoGen = 3,
		Effect = 4,
		Save = 5,
		Max = 6
	}

	public class SCENE_HANDLE
	{
		public string mName;

		public string mAddress;

		public AsyncOperationHandle<SceneInstance> mAddressables;

		public AsyncOperation mSceneManager;

		private bool mDone;

		private bool mUnload;

		private Action<Scene> mCb_LoadEnd;

		public List<string> mChildSceneName;

		public void Add_CbLoadEnd(Action<Scene> a)
		{
		}

		public void Add_ChildSceneName(string name)
		{
		}

		public SCENE_HANDLE(string sceneName)
		{
		}

		public void Set(AsyncOperationHandle<SceneInstance> a)
		{
		}

		public void Set(AsyncOperation a)
		{
		}

		public bool IsDone()
		{
			return false;
		}

		public void SetDone()
		{
		}

		public void Unload()
		{
		}
	}

	private enum MODE
	{
		None = 0,
		Inisialize_1 = 1,
		Inisialize_2 = 2,
		Load_SystemSaveData_1 = 3,
		Load_SystemSaveData_2 = 4,
		Load_SystemSaveData_Loop = 5,
		Load_SystemSaveData_Error = 6,
		Load_SystemSaveData_End = 7,
		CheckAddScene = 8,
		LoadSceneAddressables_Start = 9,
		LoadSceneAddressables_Wait = 10,
		LoadScene_Start = 11,
		LoadScene_Wait = 12,
		EndScene_Start = 13,
		EndScene_Wait = 14
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInisialize_1_003Ed__133 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMain _003C_003E4__this;

		private TaskAwaiter<IResourceLocator> _003C_003Eu__1;

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
	private struct _003CInisialize_2_003Ed__134 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMain _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private CSound _003Csound_003E5__2;

		private UniTask<long>.Awaiter _003C_003Eu__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__3;

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
	private struct _003CPrepareShaders_003Ed__175 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private int _003CprogressCount_003E5__2;

		private ShaderVariantCollection _003CshaderVariantCollection_003E5__3;

		private UniTask<ShaderVariantCollection>.Awaiter _003C_003Eu__1;

		private YieldAwaitable.Awaiter _003C_003Eu__2;

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

	private static bool m_OnRequestQuit;

	[SerializeField]
	private Camera mMainCamera;

	[SerializeField]
	private GameObject mGlobalPostEffect;

	[SerializeField]
	private CUIGenericDialog mDialog;

	[SerializeField]
	private Transform mDebugMode_Parent;

	private string mBuildDate;

	private GameController mGameController;

	private UnityEvent _onFullscreenChanged;

	private bool? fullScreen;

	private string mGUID;

	[SerializeField]
	private Calc.FAST mGameFast;

	[SerializeField]
	private TextMeshProUGUI mUISpeed;

	private long mTimeUISpeed;

	public bool mEnableBinauralAisac;

	private static List<UtpnRandom> mRandom;

	public CDefine.GameFlag mSystemFlag;

	public CDefine.GameWork mSystemWork;

	public CDefine.GameWork mTmpWork;

	public CDefine.GameFlag mTutorialFlag;

	public CDefine.GameFlag mPossessionItem;

	public CDefine.GameFlag mPossessionCard;

	public CDefine.GameFlag mPossessionEObject;

	public CDefine.GameFlag mPossessionStage;

	public CDefine.GameFlag mUnlockTransmutation;

	public CDefine.GameFlag mUnlockMemo;

	public CDefine.CryptInt mActivatedMemo;

	public CDefine.GameFlag mAppearTransmutation;

	[SerializeField]
	[ReadOnly]
	private CDefine.DictionaryCount mPossessionJob;

	[SerializeField]
	[ReadOnly]
	private CDefine.CryptInt mSoulPoint;

	[SerializeField]
	[ReadOnly]
	private CDefine.CryptInt mTotalSoulPoint;

	public CDefine.DictionaryCount mPlayStage;

	public CDefine.DictionaryCount mClearStage;

	public CDefine.DictionaryCount mAnnihilationStage;

	public CDefine.DictionaryCount mPlayJob;

	public CDefine.DictionaryCount mClearJob;

	public CDefine.DictionaryCount mAnnihilationJob;

	public CDefine.DictionaryCount mAchievement;

	private List<string> mClearedGUID;

	private List<string> mGameOverGUID;

	private List<string> mSoulGUID;

	private string mPossessionRestoreID;

	public List<string> mInputNames;

	public bool mIsShelfFavoriteMode;

	public string[] mShelfFavorite;

	private double mRecordedTime;

	[SerializeField]
	[ReadOnly]
	private CDefine.CryptInt mTotalPlayingTime;

	private string[] mDeadPlayerNames;

	public CConfigData mConfigData;

	public CDefine.GameFlag mLocalFlag;

	public CDefine.GameWork mLocalWork;

	[SerializeField]
	private CNowLoading mNowLoading;

	[SerializeField]
	private CUIFade mFadeFrontmost;

	[SerializeField]
	private float mLangTimeChar;

	[SerializeField]
	private float mLangTimeLine;

	[SerializeField]
	[ReadOnly]
	private CFieldSound[] mFieldBGM;

	[SerializeField]
	[ReadOnly]
	private List<CFieldSound> mFieldSE;

	[SerializeField]
	[ReadOnly]
	private CFieldSound mFieldVoice;

	private string[] SoundEffectName;

	private float[] SoundEffectValue;

	private int SoundEffectSelect;

	private UniTask m_IniTask;

	private MODE mMode;

	private uint mTime;

	private List<CSaveData.READDATA> mLoadSystemData;

	private int mLoadSystemIndex;

	private static List<SCENE_HANDLE> mLoadSceneHandle;

	private static List<string> mEndSceneName;

	private static Dictionary<string, SCENE_HANDLE> mLoadedScene;

	private AsyncOperation m_UnloadUnusedAssetsOp;

	public UnityEvent onFullScreenChanged => null;

	public Calc.FAST GameFast => Calc.FAST.Normal;

	public static void RequestQuit()
	{
	}

	public CUIGenericDialog GetDialog()
	{
		return null;
	}

	public string GetBuildDate()
	{
		return null;
	}

	public string GetGUID()
	{
		return null;
	}

	public bool SetGameFast(Calc.FAST a)
	{
		return false;
	}

	public static UtpnRandom GetRandom(RND r)
	{
		return null;
	}

	public static UtpnRandom GetRandom_Battle()
	{
		return null;
	}

	public void SetInputNames(int numPlayer, CGameRoom_Table.PLAYER_SETTING[] setting)
	{
	}

	public void RemoveInputNames(string a)
	{
	}

	public string Make_PlayGUID()
	{
		return null;
	}

	public bool AddCleared(string guid)
	{
		return false;
	}

	public bool AddGameOver(string guid)
	{
		return false;
	}

	public string Make_SoulGUID()
	{
		return null;
	}

	public int UpdatePlayingTime()
	{
		return 0;
	}

	public void SetDeadPlayers(List<CFieldPlayer> list)
	{
	}

	public string GetDeadPlayerName(int i)
	{
		return null;
	}

	public int GetSoulPoint()
	{
		return 0;
	}

	public int SetSoulPoint(int a)
	{
		return 0;
	}

	public int GetTotalSoulPoint()
	{
		return 0;
	}

	public int AddSoulPoint(string guid, int n)
	{
		return 0;
	}

	public int AddSoulPoint(int n)
	{
		return 0;
	}

	public void SetPossessionJob(string jobID)
	{
	}

	public void DelPossessionJob(string jobID)
	{
	}

	public bool IsPossessionJob(string i_ID, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionJob(CMaster_CharJobData i_Data, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionItem(string i_ID, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionItem(CMaster_ItemData i_Data, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionEventObject(string i_ID, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionEventObject(CMaster_EventObjectData i_Data, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionStage(string i_ID, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionStage(CMaster_MapStageData i_Data, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionCard(string i_ID, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsPossessionCard(CMaster_SkillCardData i_Data, bool i_CheckUsable = true)
	{
		return false;
	}

	public bool IsUnlockTransmutation(string i_ID)
	{
		return false;
	}

	public bool IsUnlockTransmutation(CMaster_UnlockData i_Data)
	{
		return false;
	}

	public bool IsAppearTransmutation(string i_ID)
	{
		return false;
	}

	public bool IsAppearTransmutation(CMaster_UnlockData i_Data)
	{
		return false;
	}

	public void RestorePossessionData(bool i_Force = false)
	{
	}

	private void RestorePossessionData_Trial()
	{
	}

	private void RestorePossessionData_v0_3_0()
	{
	}

	public void LogPossesion()
	{
	}

	public bool IsActiveMemo()
	{
		return false;
	}

	public string GetActivatedMemo()
	{
		return null;
	}

	public bool IsUnlockMemo(string id)
	{
		return false;
	}

	public void UnlockMemo()
	{
	}

	public void ClearLocal()
	{
	}

	public void SaveSystem(ref Dictionary<string, object> top, bool includePlayingTime = true)
	{
	}

	public void LoadSystem(JsonNode json)
	{
	}

	public Dictionary<string, object> SaveLocal()
	{
		return null;
	}

	public void LoadLocal(JsonNode save)
	{
	}

	public float GetLangWait(int numChar, int line)
	{
		return 0f;
	}

	public float GetLangWaitLines(int line)
	{
		return 0f;
	}

	public string GetSoundEffectName()
	{
		return null;
	}

	public float GetSoundEffectValue()
	{
		return 0f;
	}

	public void SetSoundEffectValue(float a)
	{
	}

	public int GetSoundEffectSelect()
	{
		return 0;
	}

	public int GetSoundEffectMax()
	{
		return 0;
	}

	public void SetSoundEffectSelect(int a)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitializeSetCulture()
	{
	}

	private void BootInitialize()
	{
	}

	private void EastAddressableExceptionHandler(AsyncOperationHandle i_Handle, Exception e)
	{
	}

	private new void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void CreateGUID()
	{
	}

	private void Start_TimeMeasurement(string t, int n = 0)
	{
	}

	private void End_TimeMeasurement(int n = 0)
	{
	}

	[AsyncStateMachine(typeof(_003CInisialize_1_003Ed__133))]
	private UniTask Inisialize_1()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CInisialize_2_003Ed__134))]
	private UniTask Inisialize_2()
	{
		return default;
	}

	public static SCENE_HANDLE GetLoadSceneHandle(string name)
	{
		return null;
	}

	private void Update()
	{
	}

	public static SCENE_HANDLE AddScene(string name)
	{
		return null;
	}

	public static void UnloadScene(string name)
	{
	}

	private void SceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void SceneUnloaded(Scene scene)
	{
	}

	public static bool IsExistScene(string name)
	{
		return false;
	}

	public static GameObject GetSceneAsGameObject(string sceneName, string objectName)
	{
		return null;
	}

	public static GameObject GetSceneAsGameObject(Scene scene, string objectName)
	{
		return null;
	}

	public static T[] GetComponentsInScene<T>(Scene scene, bool includeInactive = true)
	{
		return null;
	}

	public static T[] GetComponentsInGameObject<T>(GameObject root, bool includeInactive = true)
	{
		return null;
	}

	public static string CreateTransformName(Transform t)
	{
		return null;
	}

	public CNowLoading GetNowLoading()
	{
		return null;
	}

	public CUIFade GetFade()
	{
		return null;
	}

	public void SetPostEffect(bool a)
	{
	}

	public void SetText_DebugMode(string text)
	{
	}

	private void CheckSound()
	{
	}

	public CFieldSound GetFieldSoundBGM(int ch)
	{
		return null;
	}

	public CFieldSound ReqBGM(int ch, string req)
	{
		return null;
	}

	public void ResumeBGM(int ch)
	{
	}

	public void FadeoutPauseBGM(int ch, ushort msec = 2000)
	{
	}

	public void FadeoutStopBGM(int ch, ushort msec = 2000)
	{
	}

	public void FadeToBGM(int ch, float vol, ushort msec = 2000)
	{
	}

	public void StopBGM(int ch)
	{
	}

	public CFieldSound ReqSE(string req)
	{
		return null;
	}

	public void StopSE(string req)
	{
	}

	public void FadeOutSE(string req, float time)
	{
	}

	public void ReqVoice(string req)
	{
	}

	public void StopVoice()
	{
	}

	public bool IsPlayVoice()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CPrepareShaders_003Ed__175))]
	private UniTask PrepareShaders()
	{
		return default;
	}

	public int GetShelfFavoriteIndex(string i_ID)
	{
		return 0;
	}

	public string GetShelfFavorite(int i_Index)
	{
		return null;
	}

	public void SetShelfFavorite(int i_Index, string i_ID)
	{
	}
}
