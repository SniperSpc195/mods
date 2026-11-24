using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;
using net;

public class CTitle : SingletonMonoBehaviour<CTitle>
{
	private enum JOINTYYE
	{
		Host = 0,
		Client = 1,
		Guest = 2
	}

	private enum MODE
	{
		None = 0,
		Start = 1,
		SelectTop = 2,
		Init_Continue = 3,
		Make_Continue = 4,
		Continue = 5,
		OnlineConnect = 6,
		LoadFriend = 7,
		LoadBlock = 8,
		SelectHostClient = 9,
		Host_InputPass = 10,
		Make_CreateRoom = 11,
		CreateRoom = 12,
		Lobby_Host = 13,
		SearchRoom = 14,
		EmptyRoom = 15,
		SelectRoom = 16,
		SelectRoom_InputPass = 17,
		EnterRoom = 18,
		LeaveRoom = 19,
		Failed_EnterRoom = 20,
		Lobby_Client = 21,
		Continue_Online_Start = 22,
		Continue_SearchRoom = 23,
		Continue_EmptyRoom = 24,
		Continue_CreateRoom = 25,
		Continue_EnterRoom = 26,
		Continue_Failed_EnterRoom = 27,
		OnlineError = 28,
		End = 29
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CTitle _003C_003E4__this;

		private AsyncOperationHandle<GameObject> _003CaHandle_003E5__2;

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

	private GameObject mModelClock;

	private const uint ONLINE_GAMEMODE_NEW = 0u;

	private CreateRoomReq mCreateReq;

	private bool mEnablePass;

	private static string mRoomName;

	private static string mPassCreate;

	private static string mPassEnter;

	private string mPassword;

	private bool mEndInput;

	private List<IRoomInfo> mRoomResultList;

	private IRoomInfo mEnterRoom;

	private CUIGenericDialog mDialog;

	private double mNowTime;

	[SerializeField]
	private CUIGenericMenu mSelectOfflineOnline;

	[SerializeField]
	private CUIGenericMenu mSelectHostClient;

	[SerializeField]
	private CUIGenericMenu mMenuRoomResult;

	[SerializeField]
	private GameObject mParentInputField;

	[SerializeField]
	private TMP_InputField mInputField;

	[SerializeField]
	private CUIGenericMenu mMenuSaveList;

	[SerializeField]
	private GameObject mUIRetrySearch;

	[SerializeField]
	private COnlineLobby mOnlineLobby;

	[SerializeField]
	private Transform mCanvasDebug;

	[SerializeField]
	private TextMeshProUGUI mOwnRoomName;

	private CUIGenericMenu mCurrentMenu;

	private List<CSaveData.GAMEDATA> mSaveData;

	private static JsonNode mOnline_AutoContinue;

	private static bool mOnline;

	private JOINTYYE mSelectType;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private JsonNode mContinueSavedata;

	private JsonNode mContinueField;

	private string mContinueString;

	private uint mContinueGameMode;

	private CreateRoomReq mContinue_CreateRoomReq;

	private SearchRoomCondition mSearchRoomCondition;

	private void OnDestroy()
	{
	}

	public static void SetOnline_AutoContinue(JsonNode save)
	{
	}

	public static bool IsOnline_AutoContinue()
	{
		return false;
	}

	public static bool IsOnline()
	{
		return false;
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__34))]
	private UniTask Start()
	{
		return default;
	}

	private void CB_LoadingCompleteRoom(Scene scene)
	{
	}

	private bool ElapsedTime(float t = 0.5f)
	{
		return false;
	}

	private void OpenDialog(string a, bool btn = false)
	{
	}

	private bool IsOnlineError()
	{
		return false;
	}

	private bool IsNewGame()
	{
		return false;
	}

	private bool IsContinue()
	{
		return false;
	}

	private void Update()
	{
	}

	private void ClearContinue(bool errContinue = false)
	{
	}

	private void OnEndInputText(string text)
	{
	}

	private void InitInputField(string t)
	{
	}

	private bool IsInputCancel(GamePad pad)
	{
		return false;
	}

	private void SetupRoomResult(List<IRoomInfo> list)
	{
	}

	private bool IsSearchTheRooms()
	{
		return false;
	}

	private void SetupContinue_Online(JsonNode save)
	{
	}

	private bool IsContinueRoom(IRoomInfo room)
	{
		return false;
	}
}
