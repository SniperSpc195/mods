using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GameController : SingletonMonoBehaviour<GameController>
{
	public enum PADNUM
	{
		None = -1,
		PAD0 = 0,
		PAD1 = 1,
		PAD2 = 2,
		HANDHELD = 3,
		KEYBOARD = 4,
		MOUSE = 5,
		Max = 6,
		All = 7
	}

	public enum BUTTON
	{
		Cross = 0,
		Cross_Up = 1,
		Cross_Down = 2,
		Cross_Left = 3,
		Cross_Right = 4,
		LeftStick = 5,
		LeftStick_Up = 6,
		LeftStick_Down = 7,
		LeftStick_Left = 8,
		LeftStick_Right = 9,
		RightStick = 10,
		RightStick_Up = 11,
		RightStick_Down = 12,
		RightStick_Left = 13,
		RightStick_Right = 14,
		Button_Up = 15,
		Button_Down = 16,
		Button_Left = 17,
		Button_Right = 18,
		Button_L1 = 19,
		Button_R1 = 20,
		Button_L2 = 21,
		Button_R2 = 22,
		Button_Minus = 23,
		Button_Plus = 24,
		Button_L3 = 25,
		Button_R3 = 26,
		Max = 27
	}

	private class BUTTON_DATA
	{
		public uint mBit;

		public Sprite mIcon;

		public BUTTON_DATA(uint a)
		{
		}

		public BUTTON_DATA(uint a, Sprite s)
		{
		}
	}

	public class SPRITE_ICONS
	{
		public AsyncOperationHandle<IList<Sprite>> mHandle;

		public Dictionary<string, Sprite> mSprites;

		public SPRITE_ICONS(AsyncOperationHandle<IList<Sprite>> handle)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public GameController _003C_003E4__this;

		private AsyncOperationHandle<IList<Sprite>> _003Chandle_003E5__2;

		private UniTask<IList<Sprite>>.Awaiter _003C_003Eu__1;

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
	private CVoiceChat_VolumeSetting mVCVS;

	[SerializeField]
	private CExitGameDialog mExitGameDialog;

	private bool mSpeedSwitch;

	private int mWaitSS;

	private CFieldMain mFieldMain;

	private static BUTTON_DATA[] mButtonMap;

	private static SPRITE_ICONS mButtonSprites;

	private static bool mInitialized;

	private static bool mSwapButton;

	private bool mChangeFullScreen;

	private float mStandByFullScreen;

	public const int GAMEPAD_MAX = 6;

	[SerializeField]
	[ReadOnly]
	private List<GamePad> mGamePad;

	private GamePad[] mExcludeClear;

	private bool mUse_ExcludeClear;

	private bool mDrawInfo;

	private PADNUM[] PadNumList;

	private static Dictionary<uint, BUTTON> mPadToBUTTON;

	public static bool IsMouseUse(PADNUM num)
	{
		return false;
	}

	public static Dictionary<string, Sprite> GetButtonIconSprites()
	{
		return null;
	}

	public static bool IsInitialized()
	{
		return false;
	}

	public static bool IsSwapButton()
	{
		return false;
	}

	public static void SetSwapButton(bool a)
	{
	}

	public bool IsChangeFullScreen()
	{
		return false;
	}

	public void ResetChangeFullScreen()
	{
	}

	public bool IsDrawInfo()
	{
		return false;
	}

	public void SetDrawInfo(bool a)
	{
	}

	public void ClearBtn()
	{
	}

	public PADNUM GetConnectedPadNum()
	{
		return PADNUM.PAD0;
	}

	public GamePad GetForceGamePad(PADNUM num)
	{
		return null;
	}

	public GamePad GetGamePad(PADNUM num)
	{
		return null;
	}

	public GamePad GetGamePad(bool returnNull = false, bool mouse = false)
	{
		return null;
	}

	public GamePad GetMouse()
	{
		return null;
	}

	public bool GetMousePosition(out Vector2 pos)
	{
		pos = default;
		return false;
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__38))]
	public UniTask Initialize()
	{
		return default;
	}

	public static void SetupButtonUI(Transform parent, PADNUM padNum, bool child = true)
	{
	}

	public static BUTTON GetPadToBUTTON(uint pad_bit, bool pcSwap = true)
	{
		return BUTTON.Cross;
	}

	public static Key GetPadToKeyboard(uint pad)
	{
		return Key.None;
	}

	public static Sprite GetPadToIcon(uint pad_bit, bool pcSwap = true, PADNUM padNum = PADNUM.None)
	{
		return null;
	}

	private void Update()
	{
	}

	public void EnableSpeedSwitch(bool a, CFieldMain field = null)
	{
	}

	private bool SpeedSwitch()
	{
		return false;
	}

	public static uint GetButtonBit(BUTTON b)
	{
		return 0u;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnDeviceChange(InputDevice i_InputDevice, InputDeviceChange i_InputDeviceChange)
	{
	}
}
