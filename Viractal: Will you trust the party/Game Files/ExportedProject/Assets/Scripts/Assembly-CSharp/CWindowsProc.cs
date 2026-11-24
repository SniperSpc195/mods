using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AOT;
using Steamworks;
using UnityEngine;

public class CWindowsProc : SingletonMonoBehaviour<CWindowsProc>
{
	private struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	private struct MONITORINFO
	{
		public uint cbSize;

		public RECT rcMonitor;

		public RECT rcWork;

		public uint dwFlags;
	}

	private delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

	private enum WMsg
	{
		WM_MOVE = 3,
		WM_SIZE = 5,
		SIZE_MINIMIZED = 2,
		WM_MOUSEMOVE = 512,
		WM_SIZING = 532,
		WM_MOVING = 534,
		WMSZ_LEFT = 1,
		WMSZ_RIGHT = SIZE_MINIMIZED,
		WMSZ_TOP = WM_MOVE,
		WMSZ_BOTTOM = 6,
		WMSZ_LEFT_TOP = 4,
		WMSZ_LEFT_BOTTOM = 7,
		WMSZ_RIGHT_TOP = WM_SIZE,
		WMSZ_RIGHT_BOTTOM = 8,
		WM_KEYDOWN = 256,
		WM_SYSKEYDOWN = 260,
		WM_CLOSE = 16,
		WM_QUIT = 18,
		WM_DESTROY = SIZE_MINIMIZED
	}

	private enum WStyles : uint
	{
		WS_OVERLAPPED = 0u,
		WS_POPUP = 2147483648u,
		WS_CHILD = 1073741824u,
		WS_MINIMIZE = 536870912u,
		WS_VISIBLE = 268435456u,
		WS_DISABLED = 134217728u,
		WS_CLIPSIBLINGS = 67108864u,
		WS_CLIPCHILDREN = 33554432u,
		WS_MAXIMIZE = 16777216u,
		WS_CAPTION = 12582912u,
		WS_BORDER = 8388608u,
		WS_DLGFRAME = 4194304u,
		WS_VSCROLL = 2097152u,
		WS_HSCROLL = 1048576u,
		WS_SYSMENU = 524288u,
		WS_THICKFRAME = 262144u,
		WS_GROUP = 131072u,
		WS_TABSTOP = 65536u,
		WS_MINIMIZEBOX = WS_GROUP,
		WS_MAXIMIZEBOX = WS_TABSTOP,
		WS_TILED = WS_OVERLAPPED,
		WS_ICONIC = WS_MINIMIZE,
		WS_SIZEBOX = WS_THICKFRAME,
		WS_TILEDWINDOW = 13565952u,
		WS_OVERLAPPEDWINDOW = WS_TILEDWINDOW,
		WS_POPUPWINDOW = 2156396544u,
		WS_CHILDWINDOW = WS_CHILD
	}

	private enum Monitor
	{
		MONITOR_DEFAULTTONULL = 0,
		MONITOR_DEFAULTTOPRIMARY = 1,
		MONITOR_DEFAULTTONEAREST = 2
	}

	private enum VK
	{
		VK_RETURN = 13,
		VK_F11 = 122
	}

	[CompilerGenerated]
	private sealed class _003CDoScreenShot_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CWindowsProc _003C_003E4__this;

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
		public _003CDoScreenShot_003Ed__69(int _003C_003E1__state)
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

	private const int WINDOW_TITLE_HEIGHT = 33;

	private const int WINDOW_FRAME_HEIGHT = 1;

	private const int WINDOW_FRAME_WIDTH = 1;

	private const int MIN_WINDOW_WIDTH = 480;

	private const int MIN_WINDOW_HEIGHT = 270;

	private static bool m_Enabled;

	private static bool m_FullScreen;

	private static float m_AspectRatio;

	private static Vector2Int m_MinWindowSize;

	private static Vector2Int m_MonitorResolution;

	private static Vector2Int m_FullScreenResolution;

	private static Vector2Int m_WindowPosition;

	private static Vector2Int m_WindowSize;

	private static IntPtr m_WindowHandle;

	private static IntPtr m_OldWndProcPtr;

	private static IntPtr m_NewWndProcPtr;

	private static WndProcDelegate m_WndProcDelegate;

	private static int m_WindowStytle;

	private static Mutex mMutex;

	private bool m_FixFullScreen;

	private bool m_FixWindowScreen;

	private bool m_FixAspectRatio;

	private bool m_RecoveryStyle;

	private bool m_SetPosition;

	private Vector2Int m_TmpPosition;

	private Vector2Int chkAspectPos;

	private Vector2Int chkAspectSize;

	private float[] m_CheckTimer;

	private Callback<ScreenshotRequested_t> m_ScreenshotRequested;

	private bool m_ExecCapture;

	private Texture2D m_CaptureTexture;

	private byte[] m_CaptureImage;

	private Vector2Int m_CaptureSize;

	private const int GWLP_WNDPROC = -4;

	private const int GWL_STYLE = -16;

	private const int HWND_TOP = 0;

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	private const int SWP_NOACTIVATE = 16;

	private const int SWP_FRAMECHANGED = 32;

	private const int SWP_SHOWWINDOW = 64;

	[PreserveSig]
	private static extern IntPtr GetTopWindow(IntPtr hWnd);

	[PreserveSig]
	private static extern IntPtr GetWindow(IntPtr hWnd, uint wCmd);

	[PreserveSig]
	public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	[PreserveSig]
	private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

	[PreserveSig]
	private static extern IntPtr FindWindow(string className, string windowName);

	[PreserveSig]
	private static extern IntPtr SetWindowLong32(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

	[PreserveSig]
	private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

	[PreserveSig]
	private static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[PreserveSig]
	private static extern bool GetWindowRect(IntPtr hwnd, ref RECT lpRect);

	[PreserveSig]
	private static extern bool GetClientRect(IntPtr hWnd, ref RECT lpRect);

	[PreserveSig]
	private static extern int SetWindowPos(IntPtr hwnd, int hwndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

	[PreserveSig]
	private static extern IntPtr MonitorFromRect(ref RECT lprc, uint dwFlags);

	[PreserveSig]
	private static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	public static void OnBeforeSplashScreen()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private static IntPtr GetSelfWindowHandle()
	{
		return (IntPtr)0;
	}

	private static IntPtr GetMonitorHandle()
	{
		return (IntPtr)0;
	}

	private static Vector2Int GetDisplayResolution(bool log = false)
	{
		return default;
	}

	public static Vector2Int GetWorkResolution()
	{
		return default;
	}

	public static Vector2Int GetDefaultWindowSize()
	{
		return default;
	}

	public void SetWindowCenter_Height()
	{
	}

	public void SetWindowPosition(Vector2Int a)
	{
	}

	private static Vector2Int MakeFullScreenResolution(Vector2Int displayRes)
	{
		return default;
	}

	private static void GetWindowsPositionSize(ref Vector2Int pos, ref Vector2Int size)
	{
	}

	private void CheckAspect()
	{
	}

	public IntPtr Get()
	{
		return (IntPtr)0;
	}

	public static IntPtr SetWindowLong(int nIndex, IntPtr dwNewLong)
	{
		return (IntPtr)0;
	}

	[MonoPInvokeCallback(typeof(WndProcDelegate))]
	private static IntPtr WindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	public static void SetWindowedScreenSize(int width, int height)
	{
	}

	public static Vector2Int GetWindowedScreenSize()
	{
		return default;
	}

	private void ScreenshotRequested(ScreenshotRequested_t pCallBack)
	{
	}

	[IteratorStateMachine(typeof(_003CDoScreenShot_003Ed__69))]
	private IEnumerator DoScreenShot()
	{
		return null;
	}
}
