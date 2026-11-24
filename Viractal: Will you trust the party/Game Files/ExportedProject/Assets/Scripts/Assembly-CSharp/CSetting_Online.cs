using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using net;

public class CSetting_Online : MonoBehaviour
{
	public enum NUM_PLAYERS
	{
		_3P = 0,
		_2P = 1,
		_2P_Guest = 2,
		_3_or_less = 3,
		Max = 4
	}

	public enum ENTRY_PERMIT
	{
		All = 0,
		Friend = 1
	}

	public enum CHAT
	{
		None = 0,
		All = 1
	}

	public class ROOM_RESULT
	{
		public int mPoint;

		public IRoomInfo mRoomInfo;

		public CSetting_Host.SETTING_HOST mHost;

		public string mPassword;

		public bool IsDummy()
		{
			return false;
		}

		public ROOM_RESULT(IRoomInfo info, CSetting_Host.SETTING_HOST host = null)
		{
		}

		public CMaster_MapStageData GetStageData()
		{
			return null;
		}

		public string GetNickName()
		{
			return null;
		}

		public bool IsFriend()
		{
			return false;
		}

		public bool IsPermitFriend()
		{
			return false;
		}

		public bool IsRestrictedByPassword()
		{
			return false;
		}

		public bool IsUseVoiceChat()
		{
			return false;
		}

		public bool CheckSteamBuildID(int id)
		{
			return false;
		}
	}

	protected enum YESNO
	{
		None = -1,
		Yes = 0,
		No = 1
	}

	[SerializeField]
	protected CEventMessage mGMMessage;

	[SerializeField]
	protected CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	protected TextMeshProUGUI mText_MenuTitle;

	[SerializeField]
	protected Image mStageImage;

	[SerializeField]
	protected TextMeshProUGUI[] mStageText;

	[SerializeField]
	protected CUIGenericMenu mMenu;

	protected int[] mSaveCursor;

	protected int mSaveCursorIndex;

	[SerializeField]
	protected Transform mParentPassword;

	[SerializeField]
	protected CUIGenericInputText mInputPassword;

	[SerializeField]
	protected Sprite[] mSettingIcons;

	[SerializeField]
	private CChoiceMenu mChoiceMenu;

	protected const uint ONLINE_GAMEMODE_NEW = 0u;

	protected const string ALL_STAGE_ID = "All";

	protected CUIButtonExplanation.DATA[] ButtonData;

	protected List<CMaster_MapStageData> mUnlockedStages;

	protected int mIndexStage;

	private const int PASSWORD_MAX = 10;

	protected YESNO mYesNo;

	private int mModeYesNo;

	public static string GetTextNumPlayers(NUM_PLAYERS n)
	{
		return null;
	}

	public void Active(bool a)
	{
	}

	protected void Make_UnlockedStages()
	{
	}

	protected void Write_Stage(CMaster_MapStageData data)
	{
	}

	protected void Write_Stage(string stageID)
	{
	}

	protected void Write_SettingTitle(Transform parent, string text)
	{
	}

	protected void Write_SettingIcon(Transform parent, Sprite icon)
	{
	}

	protected void Selected_Setting(Transform parent, bool a)
	{
	}

	protected void Write_Setting(Transform parent, CMaster_MapStageData data)
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

	protected void Open_Password(string pass, string title)
	{
	}

	protected void End_Password()
	{
	}

	protected void Open_YesNo(int n)
	{
	}

	protected YESNO YesNo(GamePad pad, GamePad mouse)
	{
		return YESNO.Yes;
	}

	protected void Cb_YN_Cancel()
	{
	}

	protected void Cb_YN_Decision(int n)
	{
	}
}
