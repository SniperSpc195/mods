using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CGameRoom_UIOnlinePlayerInfo : MonoBehaviour
{
	private enum VMODE
	{
		None = 0,
		Up = 1,
		Down = 2
	}

	private const double TIME_STAMP = 5.0;

	[SerializeField]
	private TextMeshProUGUI mPlayerName;

	[SerializeField]
	private TextMeshProUGUI mCompStatus;

	[SerializeField]
	private TextMeshProUGUI mLevel;

	[SerializeField]
	private GameObject mIconVoice;

	[SerializeField]
	private GameObject mIconMute;

	[SerializeField]
	private GameObject mIconRestricted;

	[SerializeField]
	private TextMeshProUGUI mTextError;

	[SerializeField]
	private RectTransform mIconLoading;

	[SerializeField]
	private Image mPlayerFace;

	[SerializeField]
	private CUIGenericOpenClose[] mStamps;

	[SerializeField]
	[ReadOnly]
	private int mStamp;

	private double mTimeStamp;

	[SerializeField]
	private Color[] m_PingPongColor;

	public static float m_PingPongSpeed;

	private double m_PingPongTime;

	public static double m_PingPongTimeMax;

	private float m_PingPongMax;

	private float m_PingPongResult;

	private CGameRoom_Table.ONLINE_PLAYER mOnlinePlayer;

	private Vector3 mAngle;

	private const float ROT_SPEED = -0.5f;

	private const float VOICE_SCALE = 0.05f;

	private const float VOICE_ZOOM = 1.4f;

	public const float MIN_RMS = -96f;

	public const float MAX_RMS = 0f;

	private float mVoiceScale;

	private float mVoiceTalk;

	private VMODE mVMode;

	[SerializeField]
	[ReadOnly]
	private bool mMute;

	private static Vector2[] mStampSize;

	private static float m_Stamp_PingPongPeriod;

	public void Active(bool a)
	{
	}

	public void Clear()
	{
	}

	private void VCIcon_Active(bool top, bool mute = false, bool error = false)
	{
	}

	private void VCError_Active(bool a)
	{
	}

	public void WriteInfo(CGameRoom_Table.ONLINE_PLAYER op, JsonNode contPlayer)
	{
	}

	private void SetName(string name, bool exist = true)
	{
	}

	private void SetLevel(int lv, bool exist = true)
	{
	}

	private void SetFace(string id, bool exist = true)
	{
	}

	private void ResetVoice()
	{
	}

	private bool IsUseVoiceChat()
	{
		return false;
	}

	private bool MuteUpdate()
	{
		return false;
	}

	private void VoiceUpdate()
	{
	}

	private void Update()
	{
	}

	public void HideStamp()
	{
	}
}
