using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using net;

public class CSetting_Host : CSetting_Online
{
	[Serializable]
	public class SETTING_HOST
	{
		public string mNickName;

		public string mStageID;

		public CMaster_MapStageData mStageData;

		public string mTimeSavingID;

		public CMaster_MapTimeSavingData mTimeSavingData;

		public NUM_PLAYERS mNumPlayers;

		public bool mUsePassword;

		public string mPassword;

		public ENTRY_PERMIT mEntryPermit;

		public bool mVoiceChat;

		public int mSteamBuildID;

		public bool mEditor;

		public bool IsPermitAll()
		{
			return false;
		}

		public bool IsPermitFriend()
		{
			return false;
		}

		public SETTING_HOST(string name)
		{
		}

		public SETTING_HOST(SETTING_HOST backup)
		{
		}

		public SETTING_HOST(JsonNode json)
		{
		}

		public SETTING_HOST(string name, string stage, NUM_PLAYERS num, bool pass, ENTRY_PERMIT entry, bool vc)
		{
		}

		public Dictionary<string, object> MakeDictionary()
		{
			return null;
		}

		public void SetStage(string id, TextMeshProUGUI tmPro = null)
		{
		}

		public void SetStage(CMaster_MapStageData data, TextMeshProUGUI tmPro = null)
		{
		}

		public string GetStageName()
		{
			return null;
		}

		public void SetNumPlayers(NUM_PLAYERS n)
		{
		}

		public bool IsGuest()
		{
			return false;
		}

		public int GetMaxPlayers()
		{
			return 0;
		}

		public bool IsValidPassword()
		{
			return false;
		}
	}

	private enum MODE
	{
		None = 0,
		Select_Start = 1,
		Select = 2,
		Password = 3,
		Complete = 4
	}

	private const float MIN_Distance = 0.5f;

	private const float MAX_Distance = 15f;

	public static float mDistanceChat;

	[SerializeField]
	private TextMeshProUGUI mTextDistanceChat;

	[SerializeField]
	[ReadOnly]
	private SETTING_HOST mSetting;

	private bool mOldUsePassword;

	private static SETTING_HOST mBackupSetting;

	private MODE mMode;

	private string[] TextContents;

	public SETTING_HOST GetSettingHost()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void GoMenu()
	{
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool IsComplete()
	{
		return false;
	}

	public void Update()
	{
	}

	private void Set_GMMessage(int i)
	{
	}

	private void Cb_Cancel()
	{
	}

	private void Cb_ItemDecision(int n)
	{
	}

	private void Cb_ButtonDecision(CUIGenericFocus focus)
	{
	}

	private void Change_Contents(int i, int n)
	{
	}

	private void Update_Switch(int i)
	{
	}

	public CreateRoomReq CreateRoomData()
	{
		return default;
	}
}
