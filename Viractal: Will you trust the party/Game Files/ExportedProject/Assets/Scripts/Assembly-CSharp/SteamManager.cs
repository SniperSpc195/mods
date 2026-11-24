using System.Text;
using AOT;
using Steamworks;
using UnityEngine;

public class SteamManager : SingletonMonoBehaviour<SteamManager>
{
	public static uint APPID;

	protected static bool s_EverInitialized;

	private string mNickName;

	private string mLang;

	[SerializeField]
	[ReadOnly]
	private int mSteamBuildID;

	private bool mRunningOnSteamDeck;

	private Callback<GameOverlayActivated_t> m_CbOverlay;

	private static bool m_bInitialized;

	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	private bool m_ActiveOverlay;

	public static bool Initialized => false;

	public static string GetNickName(int length = 0)
	{
		return null;
	}

	public static string GetNickName(CSteamID id, int length = 0)
	{
		return null;
	}

	public static string GetLang()
	{
		return null;
	}

	public int GetSteamBuildID()
	{
		return 0;
	}

	public string GetSteamBuildID_String()
	{
		return null;
	}

	public static bool GetRunningOnSteamDeck()
	{
		return false;
	}

	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitOnPlayMode()
	{
	}

	private void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Update()
	{
	}

	private void OverlayRequested(GameOverlayActivated_t ptr)
	{
	}

	public bool IsActiveOverlay()
	{
		return false;
	}
}
