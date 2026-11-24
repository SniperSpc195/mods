using System;
using UnityEngine;
using UnityEngine.InputSystem;

[Serializable]
public class GamePad
{
	public enum TYPE
	{
		NONE = -1,
		GAMEPAD = 0,
		KEYBOARD = 1,
		MOUSE = 2
	}

	private static bool mUseXInput;

	public const uint D_U = 1u;

	public const uint D_D = 2u;

	public const uint D_L = 4u;

	public const uint D_R = 8u;

	public const uint DIGIT_LEFT = 15u;

	public const uint AL_U = 16u;

	public const uint AL_D = 32u;

	public const uint AL_L = 64u;

	public const uint AL_R = 128u;

	public const uint STICK_LEFT = 240u;

	public const uint AR_U = 256u;

	public const uint AR_D = 512u;

	public const uint AR_L = 1024u;

	public const uint AR_R = 2048u;

	public const uint STICK_RIGHT = 3840u;

	public const float StickSafeValue = 0.3f;

	public const uint KEY_Enter = 4096u;

	public const uint KEY_Escape = 8192u;

	public const uint BTN_WHEEL = 16384u;

	public const uint BTN_UP = 65536u;

	public const uint BTN_DOWN = 131072u;

	public const uint BTN_LEFT = 262144u;

	public const uint BTN_RIGHT = 524288u;

	public const uint BTN_X = 65536u;

	public const uint BTN_B = 131072u;

	public const uint BTN_Y = 262144u;

	public const uint BTN_A = 524288u;

	public const uint BTN_ABXY = 983040u;

	public const uint BTN_L1 = 1048576u;

	public const uint BTN_R1 = 2097152u;

	public const uint BTN_L2 = 4194304u;

	public const uint BTN_R2 = 8388608u;

	public const uint EVENT_SKIP = 2097152u;

	public const uint BTN_MINUS = 16777216u;

	public const uint BTN_PLUS = 33554432u;

	public const uint BTN_BACK = 16777216u;

	public const uint BTN_START = 33554432u;

	public const uint BTN_L3 = 67108864u;

	public const uint BTN_R3 = 134217728u;

	public const uint UP = 17u;

	public const uint DOWN = 34u;

	public const uint LEFT = 68u;

	public const uint RIGHT = 136u;

	public const uint UD = 51u;

	public const uint LR = 204u;

	public const uint MOVE = 255u;

	private bool mConnected;

	private float mInvalidWait;

	[SerializeField]
	[ReadOnly]
	private TYPE mType;

	private static uint[] mInputList;

	private static string[] mNameList;

	[SerializeField]
	[ReadOnly]
	private GameController.PADNUM mPadNum;

	private bool mReaction;

	private uint mOn;

	private uint mPress;

	private uint mRepeat;

	private uint mRepeatA;

	private float[] mWaitRep;

	private float[][] mWaitRepA;

	private Vector2[] mOrgStickV;

	private Vector2[] mStick2D;

	private Vector3[] mStick3D;

	private Vector2 mMouseOldPosition;

	private const float MOUSE_SCROLL_DELTA = -120f;

	private const float MOUSE_SCROLL_SUB = 1f;

	public static float REPEAT_STANDARD;

	public static float REPEAT_START;

	public static float REPEAT_NEXT;

	public static float REPEAT_COM;

	public static bool UseXInput => false;

	public static void SetXInput(bool a)
	{
	}

	public bool IsConnected()
	{
		return false;
	}

	public static TYPE GetType(GameController.PADNUM padNum)
	{
		return TYPE.GAMEPAD;
	}

	public bool IsGamePad()
	{
		return false;
	}

	public bool IsKeyboard()
	{
		return false;
	}

	public bool IsMouse()
	{
		return false;
	}

	public uint GetOn()
	{
		return 0u;
	}

	public uint GetPress()
	{
		return 0u;
	}

	public uint GetRepeat()
	{
		return 0u;
	}

	public uint GetRepeatA()
	{
		return 0u;
	}

	public bool IsOk()
	{
		return false;
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool IsCancelAll(GameController.PADNUM padNum = GameController.PADNUM.All)
	{
		return false;
	}

	public bool IsPressBtnX()
	{
		return false;
	}

	public bool IsPressBtnB()
	{
		return false;
	}

	public bool IsPressBtnY()
	{
		return false;
	}

	public bool IsPressBtnA()
	{
		return false;
	}

	public bool IsPressBtnUp()
	{
		return false;
	}

	public bool IsPressBtnDown()
	{
		return false;
	}

	public bool IsPressBtnLeft()
	{
		return false;
	}

	public bool IsPressBtnRight()
	{
		return false;
	}

	public bool IsPressUp()
	{
		return false;
	}

	public bool IsPressDown()
	{
		return false;
	}

	public bool IsPressLeft()
	{
		return false;
	}

	public bool IsPressRight()
	{
		return false;
	}

	public bool IsRepUp()
	{
		return false;
	}

	public bool IsRepDown()
	{
		return false;
	}

	public bool IsRepLeft()
	{
		return false;
	}

	public bool IsRepRight()
	{
		return false;
	}

	public bool IsRepAUp()
	{
		return false;
	}

	public bool IsRepADown()
	{
		return false;
	}

	public bool IsRepALeft()
	{
		return false;
	}

	public bool IsRepARight()
	{
		return false;
	}

	public bool IsOn(uint a = 0u)
	{
		return false;
	}

	public bool IsPress(uint a = 0u)
	{
		return false;
	}

	public bool IsRepeat(uint a = 0u)
	{
		return false;
	}

	public bool IsRepeatA(uint a = 0u)
	{
		return false;
	}

	public bool IsDegit()
	{
		return false;
	}

	public bool IsLeftMove()
	{
		return false;
	}

	public bool IsLeftStickMove()
	{
		return false;
	}

	public bool IsRightMove()
	{
		return false;
	}

	public Vector2 GetLeftVec2()
	{
		return default;
	}

	public Vector3 GetLeftVec3()
	{
		return default;
	}

	public Vector2 GetRightVec2()
	{
		return default;
	}

	public Vector3 GetRightVec3()
	{
		return default;
	}

	public Vector2 GetOrgStickV(int n)
	{
		return default;
	}

	public bool IsMouseIn()
	{
		return false;
	}

	public Vector2 GetMousePosition2D()
	{
		return default;
	}

	public Vector3 GetMousePosition3D()
	{
		return default;
	}

	public float GetMouseScroll()
	{
		return 0f;
	}

	public bool IsMouseScrollUp()
	{
		return false;
	}

	public bool IsMouseScrollDown()
	{
		return false;
	}

	public GameController.PADNUM GetPadNum()
	{
		return GameController.PADNUM.PAD0;
	}

	public GamePad(GameController.PADNUM padNum)
	{
	}

	public void Clear()
	{
	}

	public void ClearBtn()
	{
	}

	public void Copy(GamePad dst)
	{
	}

	public void UpdatePad(Gamepad pad, bool makeTxt = false)
	{
	}

	private void Update_Default(bool swap, Gamepad pad)
	{
	}

	private void Update_Stick(int n, Vector2 v, GameController.BUTTON bLeft, GameController.BUTTON bRight, GameController.BUTTON bUp, GameController.BUTTON bDown)
	{
	}

	public void UpdateKeyboard(Keyboard kb, bool makeTxt = false)
	{
	}

	public void UpdateMouse(bool makeTxt = false)
	{
	}

	public bool IsMouseReaction()
	{
		return false;
	}

	private void CreateDigitToStick()
	{
	}

	private void CreateRepeat()
	{
	}
}
