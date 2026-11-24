using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;

public class CEventGrant
{
	public enum TYPE
	{
		Grant_Item = 0,
		Erase_Item = 1,
		Grant_Card = 2,
		Erase_Card = 3,
		Grant_Ability = 4,
		Erase_Ability = 5,
		Grant_Condition = 6,
		Erase_Condition = 7,
		Param = 8,
		Money = 9,
		HP_Num = 10,
		HP_Per = 11,
		MaxHP = 12,
		Reset_MaxHP = 13,
		Speed = 14,
		Reset_Speed = 15,
		Dp = 16,
		NoText_Dp = 17,
		Exp = 18,
		DropRank_Skill = 19,
		DropRank_Item = 20,
		DropRank_Ability = 21,
		DropRank_Money = 22,
		DropRank = 23
	}

	private enum MODE
	{
		End = 0,
		Open = 1,
		Wait_ItemWindow = 2,
		Wait_Card = 3,
		Write_Message = 4,
		Wait_Message = 5,
		Wait_DroprankChange = 6,
		Close = 7,
		Selection = 8,
		SwapDP = 9,
		Wait_SwapDP = 10,
		Before_End = 11,
		Receive_Droprank = 12,
		Start_Droprank = 13
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_ChangeDroprank_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CEventGrant _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private TYPE mType;

	private CEventMessage mMessageWindow;

	private string mWriteText;

	private List<PairStrInt> mPairList;

	private List<string> mIDs;

	private List<string> mSwapDP;

	private int mSwapIndex;

	private int mAdd;

	private int mBonusGold;

	private CFieldPlayer mExecPlayer;

	private CFieldPlayer mTargetPlayer;

	private CEventEnum.EVID mTargetEVID;

	private List<string> mFullItems;

	private CUIButtonExplanation mButtonExplanation;

	private CItemWindow mItemWindow;

	private int mListIndex;

	private List<string> mDroprankName;

	private List<int> mDroprankNum;

	private string[] KeysDroprank;

	private MODE mMode;

	public CEventGrant(CEventMessage win)
	{
	}

	public bool SetGrantTarget(CEventEnum.EVID evid = CEventEnum.EVID._EXEC_PLAYER)
	{
		return false;
	}

	public CFieldPlayer GetTargetPlayer()
	{
		return null;
	}

	public void Start(TYPE type, List<PairStrInt> list)
	{
	}

	public void Start(TYPE type, List<string> list)
	{
	}

	public void Start(TYPE type, int add, int bonus = 0)
	{
	}

	public void StartDroprank(List<string> names, List<int> nums)
	{
	}

	public bool IsExec()
	{
		return false;
	}

	public void Stop()
	{
	}

	public void Execute()
	{
	}

	private int GetTupleNum()
	{
		return 0;
	}

	private void MakeTupleFullItems()
	{
	}

	private void MakeTupleText(string text)
	{
	}

	private void MakeIDsText(string text)
	{
	}

	private void MakeSwapDPText(int i)
	{
	}

	[AsyncStateMachine(typeof(_003C_ChangeDroprank_003Ed__37))]
	private UniTask _ChangeDroprank()
	{
		return default;
	}
}
