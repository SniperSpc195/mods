using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using net;

public class CGameRoom_SettingClient : CGameRoom_SettingOnline
{
	[Serializable]
	public class SETTING_CLIENT
	{
		public string mStageID;

		public CMaster_MapStageData mStageData;

		public NUM_PLAYERS mNumPlayers;

		public bool mUsePassword;

		public ENTRY_PERMIT mFriend;

		public SETTING_CLIENT(SETTING_CLIENT backup)
		{
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

		public bool FlipPassword(CheckMark[] check)
		{
			return false;
		}

		public void FlipFriend(CheckMark[] check)
		{
		}

		public void UpdatePassword(CheckMark[] check)
		{
		}

		public void UpdateFriend(CheckMark[] check)
		{
		}

		public bool IsFriendOnly()
		{
			return false;
		}
	}

	private enum MODE
	{
		None = 0,
		Select = 1,
		Top_Selection = 2,
		Stage_Selection = 3,
		NumPlayers_Selection = 4,
		Complete = 5
	}

	[SerializeField]
	private TextMeshProUGUI mTmStage;

	[SerializeField]
	private TextMeshProUGUI mTmNumPlayers;

	[SerializeField]
	private CheckMark[] mCheckPassword;

	[SerializeField]
	private CheckMark[] mCheckFriends;

	[SerializeField]
	[ReadOnly]
	private SETTING_CLIENT mSetting;

	private static SETTING_CLIENT mBackupSetting;

	private List<string> mTmpList;

	private NUM_PLAYERS[] mTmpListNP;

	private bool mInitialize;

	private MODE mMode;

	private string[] TopGMMessage;

	public SETTING_CLIENT GetSettingClient()
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

	public SearchRoomCondition CreateSearchRoomCondition()
	{
		return default;
	}
}
