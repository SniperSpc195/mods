using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CMission_NewResult : MonoBehaviour
{
	private enum MODE
	{
		Notice_Open = 0,
		Notice_Wait = 1,
		Notice_Close = 2,
		Reward_Start = 3,
		Reward_Loop = 4,
		Reward_SelectCard = 5,
		Reward_SelectPlayer = 6,
		Reward_ItemMenu = 7,
		Reward_DecisionPlayer = 8,
		Reward_Get = 9,
		Reward_LoopOverflow = 10,
		Reward_Overflow = 11,
		Reward_End = 12,
		Reward_Item = 13,
		Reward_Money = 14,
		Reward_Ability = 15,
		Reward_Card = 16,
		Reward_Soul = 17,
		Event = 18,
		Close = 19,
		End = 20
	}

	private class Overflow
	{
		private enum MODE
		{
			None = 0,
			Item = 1,
			Ability = 2,
			End = 3
		}

		public int mIndex;

		public List<string> mItem;

		public List<string> mAbility;

		private MODE mMode;

		public Overflow(int i)
		{
		}

		public void Clear()
		{
		}

		public void AddItem(string id)
		{
		}

		public void AddAbility(string id)
		{
		}

		public bool IsOverflow()
		{
			return false;
		}

		public bool Update()
		{
			return false;
		}
	}

	[SerializeField]
	[ReadOnly]
	private string mName_Notice;

	[SerializeField]
	private CUIGenericOpenClose mNotice_OpenClose;

	[SerializeField]
	private Sprite[] mNotice_Icons;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private TextMeshProUGUI[] mNotice_Text;

	[SerializeField]
	private float mNotice_FontSize;

	[SerializeField]
	private Image[] mNotice_Mark;

	[SerializeField]
	private CChoiceMenu[] mChoices;

	[SerializeField]
	private CChoiceMenu mChoiceMenu;

	private CItemWindow mItemWindow;

	private CEventMessage mEventMessage;

	private List<CParamMission> mMissionList;

	private int mMissionIndex;

	private CParamMission mMission;

	private List<CParamMission.Reward> mRewardList;

	private int mReardIndex;

	private CParamMission.Reward mReward;

	private List<CFieldPlayer> mReceivePlayers;

	private List<Overflow> mOverflows;

	private int mPlayerIndex;

	private bool[] m_InputButton;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private MODE mReturnMode;

	private double mTime;

	private double mSpeedUp;

	private GameController.PADNUM mControlPadNum;

	private bool mBtnWait;

	private bool mSetPossessionNum;

	private CUIButtonExplanation.DATA[] m_Button_ItemMenu;

	private CUIButtonExplanation.DATA[] m_Button_Decision;

	public void Active(bool a)
	{
	}

	private void SetupReceivePlayer()
	{
	}

	private void Awake()
	{
	}

	public void Go(CParamMission data)
	{
	}

	public void Go(List<CParamMission> data)
	{
	}

	private void Initialize()
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

	private void Update()
	{
	}

	private void Update_NoticeIcon()
	{
	}

	private void SetupRewardWindow(CFieldMain fMain, MODE mode)
	{
	}

	private bool SetupSelectPlayer()
	{
		return false;
	}

	private void CbDecision_SelectPlayer(int cur)
	{
	}

	private bool AddReward(CFieldPlayer player)
	{
		return false;
	}
}
