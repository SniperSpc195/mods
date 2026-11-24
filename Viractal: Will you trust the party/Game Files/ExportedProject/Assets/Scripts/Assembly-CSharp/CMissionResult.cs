using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CMissionResult : MonoBehaviour
{
	private enum AFTER
	{
		None = 0,
		Item = 1,
		Ability = 2
	}

	public class RewardsAfter
	{
		public List<string> mItem;

		public List<string> mAbility;

		public void Clear()
		{
		}
	}

	private enum MODE
	{
		End = 0,
		Open = 1,
		Open_Wait = 2,
		Counter = 3,
		Clear_0 = 4,
		Open_Reward = 5,
		BtnWait = 6,
		Close = 7,
		Loop_Organization = 8,
		Wait_Organization = 9,
		Item_Organization = 10,
		Ability_Organization = 11
	}

	[SerializeField]
	private CUIGenericOpenClose mInfoOpenClose;

	[SerializeField]
	private CMissionInfo mMissionInfo;

	[SerializeField]
	private CUIGenericMenu mButtonNext;

	[SerializeField]
	private GameObject mClearParent;

	[SerializeField]
	private CanvasGroup mClearCG;

	[SerializeField]
	private CUIGenericOpenClose mRewardOpenClose;

	[SerializeField]
	private TextMeshProUGUI mRewardItem;

	private bool mBattle;

	private CFieldPlayer mPlayer;

	private List<CFieldPlayer> mPlayerList;

	private int mPlayerIndex;

	private AFTER mAfter;

	private List<CParamMission> mMission;

	private int mMissionIndex;

	private CParamMission mNowMission;

	private List<string> mAddIDs;

	private int mAddIndex;

	private CUIGenericOpenClose mCloseWindow;

	private const float WAIT_CLEAR = 60f;

	private float mClearAlpha;

	private List<RewardsAfter> mRewardsAfter;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private float mWait;

	public void Active(bool a)
	{
	}

	private void Initialize()
	{
	}

	public void Go(CParamMission mission, CFieldPlayer player)
	{
	}

	public void Go(List<CParamMission> missions, CFieldPlayer player)
	{
	}

	public void Go(List<CParamMission> missions, List<string> addIDs)
	{
	}

	private void Open()
	{
	}

	public bool IsExecute()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public void Update()
	{
	}

	private void StartClear()
	{
	}

	private void WriteReward()
	{
	}

	private void EarnRewards()
	{
	}
}
