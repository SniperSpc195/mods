using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using net;

public class CSetting_Client : CSetting_Online
{
	[Serializable]
	public class SETTING_CLIENT
	{
		public string mStageID;

		public CMaster_MapStageData mStageData;

		public NUM_PLAYERS mNumPlayers;

		public int mIndexNumPlayers;

		public bool mUsePassword;

		public ENTRY_PERMIT mFriend;

		public CHAT mVoiceChat;

		public SETTING_CLIENT(SETTING_CLIENT backup)
		{
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

		public bool IsFriendOnly()
		{
			return false;
		}

		public bool IsIncludeVoiceChat()
		{
			return false;
		}
	}

	private enum MODE
	{
		None = 0,
		Select_Start = 1,
		Select = 2,
		Complete = 3
	}

	[SerializeField]
	[ReadOnly]
	private SETTING_CLIENT mSetting;

	private static SETTING_CLIENT mBackupSetting;

	private List<string> mStageIDs;

	private NUM_PLAYERS[] NumPlayers;

	private MODE mMode;

	private string[] TextContents;

	public SETTING_CLIENT GetSettingClient()
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

	public SearchRoomCondition CreateSearchRoomCondition()
	{
		return default;
	}

	public List<ROOM_RESULT> Sorting(CSetting_Host settingHost, List<IRoomInfo> list)
	{
		return null;
	}
}
