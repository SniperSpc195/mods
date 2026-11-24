using System.Collections.Generic;
using Fork.Game;
using TMPro;
using UnityEngine;
using net;

public class CVoiceChat_VolumeSetting : SingletonMonoBehaviour<CVoiceChat_VolumeSetting>
{
	private enum TYPE
	{
		Mute = 0,
		Mic = 1,
		Other = 2,
		Master = 3,
		BGM = 4,
		SE = 5,
		Max = 6
	}

	public enum MODE
	{
		None = 0,
		Open = 1,
		Select = 2,
		Close = 3,
		Error_Dialog = 4,
		Error_Connection = 5
	}

	[SerializeField]
	private CUIGenericDialog mDialog;

	[SerializeField]
	private CUIGenericOpenClose mTop;

	[SerializeField]
	private CUIGenericMenu[] mMenus;

	[SerializeField]
	private CUIGenericMenu mMenu;

	private Transform[] mContents;

	private CUISettingsSlider[] mSettingsSlider;

	[SerializeField]
	[ReadOnly]
	private int[] mVolume;

	[SerializeField]
	private TextMeshProUGUI mTextExplanation;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private Transform mParentMicLv;

	[SerializeField]
	private TextMeshProUGUI mTextMicLv;

	[SerializeField]
	private TextMeshProUGUI mNumMicLv;

	[SerializeField]
	[ReadOnly]
	private COnline.PlayerInfo[] mPlayerInfo;

	[SerializeField]
	[ReadOnly]
	private int mOwnIndex;

	private static bool mOwnMute;

	private const float VOLUME_SCALE = 10f;

	private static float mOtherVolume;

	[SerializeField]
	private bool mEnableSetting;

	[SerializeField]
	[ReadOnly]
	private MatchingError mVCErrorID;

	[SerializeField]
	private MatchingError mDebug_SetVCErr;

	[SerializeField]
	[ReadOnly]
	private COnline.VCHAT mStateVChat;

	[SerializeField]
	private Color[] mAcvtiveColor;

	private List<RtChat.AudioInputDeviceInfo> mMicInfo;

	[SerializeField]
	[ReadOnly]
	private int mSelectMic;

	[SerializeField]
	[ReadOnly]
	private string mSelectMicUID;

	private long mTimeMic;

	private double mNowTime;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	[SerializeField]
	private float[] LvOn_dB;

	public static bool OwnMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static float OtherVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private bool IsVCError()
	{
		return false;
	}

	public void ClearVCError()
	{
	}

	public void EnableSetting(bool a)
	{
	}

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	private void GoMenu()
	{
	}

	private void Init_Mute()
	{
	}

	private void Init_Error()
	{
	}

	private void Init_MicDevice()
	{
	}

	private void Update_MicDevice()
	{
	}

	private int GetMicDeviceInfo()
	{
		return 0;
	}

	private bool IsChangeMic()
	{
		return false;
	}

	private void ChangeMic(int i)
	{
	}

	public void GoError()
	{
	}

	private void Stop()
	{
	}

	private GamePad GetPlayerPad()
	{
		return null;
	}

	private void OpenDialog(string a, bool btn = false, bool getTextLang = true)
	{
	}

	private bool ElapsedTime(float t = 0.5f)
	{
		return false;
	}

	public static bool IsExec()
	{
		return false;
	}

	public bool UI_Update()
	{
		return false;
	}

	private void Cb_ButtonDecision(CUIGenericFocus focus)
	{
	}

	private void SelectedMenu(Transform parent, bool a)
	{
	}

	protected void Write_SettingText(Transform parent, string text)
	{
	}

	protected void On_Arrow(Transform parent)
	{
	}

	protected void Off_Arrow(Transform parent)
	{
	}

	protected void Sw_Arrow(Transform parent, bool left, bool right)
	{
	}

	protected void DisplayOn_Arrow(Transform parent)
	{
	}

	protected void DisplayOff_Arrow(Transform parent)
	{
	}

	private void Change_Contents(int i, int n)
	{
	}

	private void Update_Switch(int i)
	{
	}

	private void Update_MicLevel()
	{
	}
}
