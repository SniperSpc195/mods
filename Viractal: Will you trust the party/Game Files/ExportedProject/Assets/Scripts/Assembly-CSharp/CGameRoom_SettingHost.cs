using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using net;

public class CGameRoom_SettingHost : CGameRoom_SettingOnline
{
	[Serializable]
	public class SETTING_HOST
	{
		public string mNickName;

		public string mStageID;

		public CMaster_MapStageData mStageData;

		public NUM_PLAYERS mNumPlayers;

		public bool mUsePassword;

		public string mPassword;

		public ENTRY_PERMIT mEntryPermit;

		public int mSteamBuildID;

		public bool mEditor;

		public SETTING_HOST()
		{
		}

		public SETTING_HOST(SETTING_HOST backup)
		{
		}

		public SETTING_HOST(JsonNode json)
		{
		}

		public SETTING_HOST(string name, string stage, NUM_PLAYERS num, bool pass, ENTRY_PERMIT entry)
		{
		}

		public Dictionary<string, object> MakeDictionary()
		{
			return null;
		}

		public void SetStage(string id, TextMeshProUGUI tmPro)
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

		public bool FlipPassword(CheckMark[] check)
		{
			return false;
		}

		public void FlipEntry(CheckMark[] check)
		{
		}

		public void UpdatePassword(CheckMark[] check)
		{
		}

		public void UpdateEntry(CheckMark[] check)
		{
		}
	}

	private enum MODE
	{
		None = 0,
		Select = 1,
		Top_Selection = 2,
		Stage_Selection = 3,
		NumPlayers_Selection = 4,
		Input_Password = 5,
		Input_End = 6,
		Complete = 7
	}

	[SerializeField]
	private TMP_InputField mInputField;

	[SerializeField]
	private TextMeshProUGUI mTmStage;

	[SerializeField]
	private TextMeshProUGUI mTmNumPlayers;

	[SerializeField]
	private CheckMark[] mCheckPassword;

	[SerializeField]
	private CheckMark[] mEntryPermit;

	[SerializeField]
	[ReadOnly]
	private SETTING_HOST mSetting;

	private bool mOldUsePassword;

	private static SETTING_HOST mBackupSetting;

	private List<string> mTmpList;

	private NUM_PLAYERS[] mTmpListNP;

	private bool mInitialize;

	private MODE mMode;

	public SETTING_HOST GetSettingHost()
	{
		return null;
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

	private void Update()
	{
	}

	private void Setup_InputPass()
	{
	}

	private bool IsInputCancel(GamePad pad, GamePad mouse)
	{
		return false;
	}

	public void OnPassComplete(string a)
	{
	}

	public CreateRoomReq CreatRoomData()
	{
		return default;
	}
}
