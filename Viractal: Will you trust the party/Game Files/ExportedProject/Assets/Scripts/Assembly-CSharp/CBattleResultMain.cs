using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CBattleResultMain : LwSingleton<CBattleResultMain>
{
	private struct PlayerContext
	{
		public CBattlePlayer battle;

		public int levelPrev;

		public int levelNext;

		public int obtainGoldBase;

		public int obtainGoldBonus;
	}

	private enum Seq
	{
		None = 0,
		VictoryMotion = 1,
		RewardSoulPoint = 2,
		RewardExp = 3,
		LevelUp = 4,
		SkillSelector = 5,
		ResumeCameraLevelUp = 6,
		RewardItem = 7,
		RewardGold = 8,
		ProgressMission = 9,
		ClearBossBattle = 10
	}

	private struct TreasureBox
	{
		public GameObject root;

		public GameObject gameObject;

		public Animator animator;

		public CBattleEnemy enemy;

		public CMaster_TreasureTableData data;
	}

	private enum InputButton
	{
		Ok = 0,
		MenuItem = 1,
		DebugMenu = 2
	}

	public enum BattleTime
	{
		Start = 0,
		Total = 1,
		Open = 2,
		Obtain = 3
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public CFieldPlayer fp;

		public bool isControl;

		public CBattlePlayer openPlayer;

		public List<CBattlePlayer> choicePlayer;

		public CBattleResultMain _003C_003E4__this;

		public bool isOnline;

		internal bool _003CRewardItem_003Eb__1()
		{
			return false;
		}

		internal bool _003CRewardItem_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_1
	{
		public int i;

		public _003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals1;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_2
	{
		public CCardSelector cardSelector;

		public bool isCard;

		public TreasureBox box;

		public string message;

		public _003C_003Ec__DisplayClass29_1 CS_0024_003C_003E8__locals2;

		internal bool _003CRewardItem_003Eb__8()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_3
	{
		public bool waitToOpen;

		public CFieldMenu_NewUseItem menuItem;

		public CBattlePlayer obtainPlayer;

		public CFieldMenu_NewUseItem.RESULT_STAT resStat;

		public string choiceList;

		public string[] subText;

		public _003C_003Ec__DisplayClass29_2 CS_0024_003C_003E8__locals3;

		internal bool _003CRewardItem_003Eb__5()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_4
	{
		public UniTask<CCardSelector>.Awaiter awaiter;

		internal bool _003CRewardItem_003Eb__7()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public CBattlePlayer opener;

		internal bool _003CTickOpener_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public AsyncOperationHandle<GameObject> task;

		internal bool _003CLevelUpDirection_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public AsyncOperationHandle<GameObject> handle;

		internal bool _003CShowTreasureBox_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CLevelUpDirection_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

		private CBattlePlayer _003Cplayer_003E5__2;

		private GameController.PADNUM _003Cpadnum_003E5__3;

		private string _003Cname_003E5__4;

		private Transform _003Ct_003E5__5;

		private CPedestal _003Cpedestal_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLevelUpDirection_003Ed__32(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadScene_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken cancel;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadSkillSelector_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleResultMain _003C_003E4__this;

		private UniTask<CCardSelector>.Awaiter _003C_003Eu__1;

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

	[CompilerGenerated]
	private sealed class _003CLotteryTreasureBox_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		public int i_Buff;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLotteryTreasureBox_003Ed__36(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLotteryTreasureBoxContent_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer i_Opener;

		public CBattleResultMain _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLotteryTreasureBoxContent_003Ed__39(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CProccessBossBattle_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CProccessBossBattle_003Ed__34(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CResumeCamera_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		private CBtlCamera _003Ccamera_003E5__2;

		private float _003CangleX_003E5__3;

		private float _003CangleY_003E5__4;

		private float _003CscreenX_003E5__5;

		private float _003CscreenY_003E5__6;

		private float _003Cdistance_003E5__7;

		private float _003Ctime_003E5__8;

		private AnimationCurve _003Ccurve_003E5__9;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CResumeCamera_003Ed__50(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRewardGold_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		private List<CBattlePlayer> _003CalivePlayer_003E5__2;

		private bool _003CexistBonus_003E5__3;

		private CFieldPlayer _003CturnPlayer_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRewardGold_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRewardItem_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass29_1 _003C_003E8__2;

		private _003C_003Ec__DisplayClass29_3 _003C_003E8__3;

		private _003C_003Ec__DisplayClass29_4 _003C_003E8__4;

		private float _003CfloorY_003E5__2;

		private float _003Cscale_003E5__3;

		private Coroutine _003CopenerCoroutine_003E5__4;

		private int _003Ci_003E5__5;

		private float _003CprevAngle_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRewardItem_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShowTreasureBox_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass38_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

		private TreasureBox _003CdropItem_003E5__3;

		private GameObject _003Cparent_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CShowTreasureBox_003Ed__38(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleResultMain _003C_003E4__this;

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

	[CompilerGenerated]
	private sealed class _003CTickOpener_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer opener;

		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		public bool back;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CTickOpener_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CVictoryMotion_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		private List<CBattlePlayer>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CVictoryMotion_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CZoomInLevelUpCharacter_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleResultMain _003C_003E4__this;

		private CBtlCamera _003Ccamera_003E5__2;

		private float _003CangleX_003E5__3;

		private float _003CangleY_003E5__4;

		private float _003CscreenX_003E5__5;

		private float _003CscreenY_003E5__6;

		private float _003Cdistance_003E5__7;

		private float _003Ctime_003E5__8;

		private AnimationCurve _003Ccurve_003E5__9;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CZoomInLevelUpCharacter_003Ed__49(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private Canvas m_Canvas;

	[SerializeField]
	private CItemWindow m_ItemWindow;

	[SerializeField]
	private CDebugMenu m_DebugMenu;

	private int m_ExecPlayerIndex;

	private List<PlayerContext> m_Players;

	private CCardSelector m_CardSelector;

	private Seq m_Seq;

	private Seq m_PreSeq;

	private float m_PrevAngleY;

	private int m_DropNo;

	private int m_RewardExp;

	private int m_RewardGold;

	private int m_RewardSoulPoint;

	private List<TreasureBox> m_DropItems;

	private bool[] m_InputButton;

	private float m_Time;

	private float m_OperateTime;

	private float m_BackupCameraAngleX;

	private float m_BackupCameraAngleY;

	private float m_BackupCameraScreenX;

	private float m_BackupCameraScreenY;

	private float m_BackupCameraDistance;

	private Transform m_BackupLookAt;

	private Transform m_BackupFollow;

	[AsyncStateMachine(typeof(_003CLoadScene_003Ed__21))]
	public static UniTask LoadScene(bool fromDebug = false, CancellationToken cancel = default(CancellationToken))
	{
		return default;
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__23))]
	private UniTask Start()
	{
		return default;
	}

	private void Update()
	{
	}

	[AsyncStateMachine(typeof(_003CLoadSkillSelector_003Ed__25))]
	private UniTask LoadSkillSelector()
	{
		return default;
	}

	private CParamPlayer GetChrParam(int index)
	{
		return null;
	}

	private void NextSequence()
	{
	}

	[IteratorStateMachine(typeof(_003CVictoryMotion_003Ed__28))]
	private IEnumerator VictoryMotion()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRewardItem_003Ed__29))]
	private IEnumerator RewardItem()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTickOpener_003Ed__30))]
	private IEnumerator TickOpener(CBattlePlayer opener, bool back)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRewardGold_003Ed__31))]
	private IEnumerator RewardGold()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLevelUpDirection_003Ed__32))]
	private IEnumerator LevelUpDirection()
	{
		return null;
	}

	private void TransitionMission()
	{
	}

	[IteratorStateMachine(typeof(_003CProccessBossBattle_003Ed__34))]
	private IEnumerator ProccessBossBattle()
	{
		return null;
	}

	private void Close()
	{
	}

	[IteratorStateMachine(typeof(_003CLotteryTreasureBox_003Ed__36))]
	private IEnumerator LotteryTreasureBox(int i_Buff)
	{
		return null;
	}

	private void _LotteryTreassureBox(int i_Buff)
	{
	}

	[IteratorStateMachine(typeof(_003CShowTreasureBox_003Ed__38))]
	private IEnumerator ShowTreasureBox()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLotteryTreasureBoxContent_003Ed__39))]
	private IEnumerator LotteryTreasureBoxContent(CBattlePlayer i_Opener)
	{
		return null;
	}

	private void _LotteryTreasureBoxContent(int i_Rank)
	{
	}

	private void SaveCamera()
	{
	}

	[IteratorStateMachine(typeof(_003CZoomInLevelUpCharacter_003Ed__49))]
	private IEnumerator ZoomInLevelUpCharacter()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResumeCamera_003Ed__50))]
	private IEnumerator ResumeCamera()
	{
		return null;
	}

	private float GetExpBonus(CBattlePlayer i_BattlePlayer, string i_AbilityID)
	{
		return 0f;
	}

	[Conditional("UNITY_DEBUG")]
	public void OutputTimeLog(BattleTime i_Type)
	{
	}
}
