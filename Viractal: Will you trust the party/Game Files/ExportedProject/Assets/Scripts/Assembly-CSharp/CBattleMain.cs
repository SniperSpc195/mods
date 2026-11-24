using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Timeline;

public class CBattleMain : LwSingleton<CBattleMain>
{
	public enum RESULT
	{
		None = 0,
		Lose = 1,
		Win = 2,
		Escape = 3
	}

	private struct SaveTransform
	{
		public GameObject go { get; private set; }

		public Vector3 position { get; private set; }

		public SaveTransform(GameObject go)
		{
			this.go = null;
			position = default;
		}

		public void Resume()
		{
		}
	}

	private enum MODE
	{
		None = 0,
		Start = 1,
		TurnDecisionPhase = 2,
		PlayerStartPhase = 3,
		SelectCardPhase = 4,
		ActionPhase = 5,
		ActionPhase_WillCharge = 6,
		ActionPhaseEnd = 7,
		GetWillToken = 8,
		AdditionalActCard = 9,
		TurnEndPhase = 10,
		SelectCardPhaseOther = 11,
		ExecuteEnemyRoutine = 12,
		ResultEscape = 13,
		ResultWin = 14,
		ResultLose = 15,
		Resume_Start = 16,
		Resume_Wait = 17,
		End = 18,
		ConnectionError = 19,
		DebugMenu = 20
	}

	private enum InputButton
	{
		IsPressPlusMinus = 0
	}

	private enum InputLoseMenu
	{
		IsContinue = 0,
		IsGameOver = 1
	}

	private struct PopDirection
	{
		public float time;

		public bool landing;
	}

	private struct WillEffect
	{
		public Vector3 start;

		public Vector3 end;

		public CEffectHandle handle;
	}

	private struct StolenPlayerItem
	{
		public CParamPlayer owner;

		public CMaster_ItemData item;

		public int index;

		public CParamCondition condition;
	}

	private struct ReturnApplyAbility
	{
		public bool changedRepeat;
	}

	public enum BattleTime
	{
		Start = 0,
		Total = 1,
		Operate = 2
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public UniTask<GameObject>.Awaiter awaiter;

		internal bool _003CLoadMap_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass180_0
	{
		public CFieldPlayer player;

		internal bool _003CTransitionNormalBattleStart_003Eb__0(CBattlePlayer x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass183_0
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003CTransitionBattleEnd_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass183_0 _003C_003E4__this;

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
		private struct _003C_003CTransitionBattleEnd_003Eb__1_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass183_0 _003C_003E4__this;

			private Vector3[] _003C_scale_003E5__2;

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

		public CBattleMain _003C_003E4__this;

		public float chrTime;

		public CBtlMap coMap;

		[AsyncStateMachine(typeof(_003C_003CTransitionBattleEnd_003Eb__0_003Ed))]
		internal UniTask _003CTransitionBattleEnd_003Eb__0()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_003CTransitionBattleEnd_003Eb__1_003Ed))]
		internal UniTask _003CTransitionBattleEnd_003Eb__1()
		{
			return default;
		}

		internal bool _003CTransitionBattleEnd_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public CParamDef param;

		public CBattleMain _003C_003E4__this;

		internal bool _003CTurnDecisionPhase_003Eb__0(CBattlePlayer x)
		{
			return false;
		}

		internal bool _003CTurnDecisionPhase_003Eb__1()
		{
			return false;
		}

		internal bool _003CTurnDecisionPhase_003Eb__2(CBattleEnemy x)
		{
			return false;
		}

		internal bool _003CTurnDecisionPhase_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public CFieldMenu_NewUseItem itemmenu;

		internal bool _003CUseItemEnd_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass194_0
	{
		public CBattleMain _003C_003E4__this;

		public CParamDef param;

		internal bool _003CNextPersonalPhase_003Eb__3()
		{
			return false;
		}

		internal bool _003CNextPersonalPhase_003Eb__1(CBattlePlayer x)
		{
			return false;
		}

		internal bool _003CNextPersonalPhase_003Eb__4()
		{
			return false;
		}

		internal bool _003CNextPersonalPhase_003Eb__2(CBattleEnemy x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass202_0
	{
		public CBattleMain _003C_003E4__this;

		public int consume;

		internal bool _003C_Lose_003Eb__0()
		{
			return false;
		}

		internal UniTask _003C_Lose_003Eb__2()
		{
			return default;
		}

		internal bool _003C_Lose_003Eb__3()
		{
			return false;
		}

		internal bool _003C_Lose_003Eb__4()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass203_0
	{
		public CUITurn turnUI;

		internal bool _003C_ReduceRemainingTurns_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass204_0
	{
		public CEventScript evscript;

		internal bool _003CToGameOver_003Eb__4()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass210_0
	{
		public CBattleMain _003C_003E4__this;

		public Vector3 prevPos;

		internal bool _003CActiveFieldCamera_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass212_0
	{
		public CBattlePlayer _bp;

		public CBattleMain _003C_003E4__this;

		internal bool _003CToSelectCardPhase_003Eb__0(CFieldPlayer x)
		{
			return false;
		}

		internal bool _003CToSelectCardPhase_003Eb__1()
		{
			return false;
		}

		internal bool _003CToSelectCardPhase_003Eb__5()
		{
			return false;
		}

		internal bool _003CToSelectCardPhase_003Eb__6(CSkillCardData x)
		{
			return false;
		}

		internal bool _003CToSelectCardPhase_003Eb__7()
		{
			return false;
		}

		internal bool _003CToSelectCardPhase_003Eb__3(CFieldPlayer x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CActionEnd_003Ed__193 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		public bool i_TurnEnd;

		private bool _003Cadditional_003E5__2;

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
		public _003CActionEnd_003Ed__193(int _003C_003E1__state)
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
	private struct _003CActiveBattleCamera_003Ed__209 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

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
	private struct _003CActiveFieldCamera_003Ed__210 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass210_0 _003C_003E8__1;

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
	private struct _003CApplyAbility_003Ed__253 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<ReturnApplyAbility> _003C_003Et__builder;

		public CSkillEffect i_SkillEffect;

		public CBattleMain _003C_003E4__this;

		public CancellationToken i_Cancel;

		private ReturnApplyAbility _003Cret_003E5__2;

		private IEnumerator<CSkillEffect.TargetContext> _003C_003E7__wrap2;

		private CSkillEffect.TargetContext _003Ctarget_003E5__4;

		private CFieldPlayer _003Cfp_003E5__5;

		private List<CMaster_SkillAbilityData>.Enumerator _003C_003E7__wrap5;

		private CMaster_SkillAbilityData _003Cability_003E5__7;

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
	private struct _003CApplyUIRank_003Ed__250 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CSkill i_Skill;

		public CBattleMain _003C_003E4__this;

		private IEnumerator<CSkillEffect.TargetContext> _003C_003E7__wrap1;

		private CUICharacterStatus _003Cui_003E5__3;

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
	private struct _003CDiscardInHand_003Ed__248 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CSkill i_Skill;

		public CBattleMain _003C_003E4__this;

		public CancellationToken i_Cancel;

		private PooledObject<List<CParamPlayer>> _003C_003E7__wrap1;

		private PooledObject<List<UniTask>> _003C_003E7__wrap2;

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
	private struct _003CLoadMap_003Ed__170 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		public string i_Path;

		private _003C_003Ec__DisplayClass170_0 _003C_003E8__1;

		public Transform i_Parent;

		public string i_EffectPath;

		private GameObject _003CprefabMap_003E5__2;

		private int _003CpreLayer_003E5__3;

		private GameObject _003Cgo_003E5__4;

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
	private struct _003CLoadMapEffect_003Ed__171 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_EffectPath;

		public CBattleMain _003C_003E4__this;

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
	private struct _003CLoadModel_003Ed__169 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private string[] _003CenemyIds_003E5__2;

		private int _003Ci_003E5__3;

		private CMaster_EnemyData _003Cenemy_003E5__4;

		private GameObject _003Cgo_003E5__5;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private CMaster_CharJobData _003Cjob_003E5__6;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CMoveCameraOffset_003Ed__205 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private float _003Cstart_003E5__2;

		private float _003Ctime_003E5__3;

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
	private sealed class _003CNextPersonalPhase_003Ed__194 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass194_0 _003C_003E8__1;

		private CBattleEnemy _003CactorEnemy_003E5__2;

		private float _003Cwait_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CNextPersonalPhase_003Ed__194(int _003C_003E1__state)
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
	private struct _003CObtainEnemyWilllToken_003Ed__249 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private CSkillCard _003Cskillcard_003E5__2;

		private bool _003Calign_003E5__3;

		private CBattleCharDef _003Cbtlchr_003E5__4;

		private List<Vector3> _003ClocalPositions_003E5__5;

		private PooledObject<List<Vector3>> _003C_003E7__wrap5;

		private int _003Coffset_003E5__7;

		private int _003Ci_003E5__8;

		private UniTask<Vector3?>.Awaiter _003C_003Eu__1;

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
	private struct _003COpenSkillResultWindow_003Ed__251 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CSkill i_Skill;

		public CBattleMain _003C_003E4__this;

		public CancellationToken i_Cancel;

		private CSkillCard _003Ccard_003E5__2;

		private CItem _003Citem_003E5__3;

		private bool _003CresortTimeline_003E5__4;

		private UniTask.Awaiter _003C_003Eu__1;

		private List<CSkillEffect>.Enumerator _003C_003E7__wrap4;

		private UniTask<ReturnApplyAbility>.Awaiter _003C_003Eu__2;

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
	private sealed class _003CPassiveEffectBossBattle_003Ed__240 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

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
		public _003CPassiveEffectBossBattle_003Ed__240(int _003C_003E1__state)
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
	private sealed class _003CProcAutoResurrection_003Ed__241 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		private PooledObject<List<CBattlePlayer>> _003C_003E7__wrap1;

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
		public _003CProcAutoResurrection_003Ed__241(int _003C_003E1__state)
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
	private sealed class _003CProgressCondition_003Ed__211 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

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
		public _003CProgressCondition_003Ed__211(int _003C_003E1__state)
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
	private struct _003CShowStealMessage_003Ed__237 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private float _003CwaitSteal_003E5__2;

		private List<string>.Enumerator _003C_003E7__wrap2;

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
	private struct _003CStart_003Ed__168 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private List<CBattleEnemy>.Enumerator _003C_003E7__wrap1;

		private CBattleEnemy _003Cbe_003E5__3;

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
	private struct _003CSyncParamPlayer_003Ed__224 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

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

	[CompilerGenerated]
	private sealed class _003CToGameOver_003Ed__204 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass204_0 _003C_003E8__1;

		private CMaster_MapBattleData _003CmapBattle_003E5__2;

		private AsyncOperationHandle<GameObject> _003ChndGameOver_003E5__3;

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
		public _003CToGameOver_003Ed__204(int _003C_003E1__state)
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
	private sealed class _003CToSelectCardPhase_003Ed__212 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		public bool i_UsedItemAfter;

		private _003C_003Ec__DisplayClass212_0 _003C_003E8__1;

		private Coroutine _003ChandTurnStart_003E5__2;

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
		public _003CToSelectCardPhase_003Ed__212(int _003C_003E1__state)
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
	private struct _003CTransitionBattleEnd_003Ed__183 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass183_0 _003C_003E8__1;

		private UniTask _003CactiveFieldCamera_003E5__2;

		private CinemachineBlendDefinition _003CprevBlend_003E5__3;

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
	private struct _003CTransitionBattleRush_003Ed__182 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private List<CBattleEnemy>.Enumerator _003C_003E7__wrap1;

		private CBattleEnemy _003Cbe_003E5__3;

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
	private struct _003CTransitionBattleStart_003Ed__179 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private List<UniTask> _003Ctask_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

		private PooledObject<List<UniTask>> _003C_003E7__wrap2;

		private int _003Ci_003E5__4;

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
	private struct _003CTransitionBossBattleStart_003Ed__181 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private CMaster_MapBattleData _003CmasterMap_003E5__2;

		private UniTask _003CloadMap_003E5__3;

		private CinemachineBlendDefinition _003CprevCameraBlend_003E5__4;

		private UniTask _003Cpoptask_003E5__5;

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
	private struct _003CTransitionNormalBattleStart_003Ed__180 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass180_0 _003C_003E8__1;

		private CMaster_MapBattleData _003CmasterMap_003E5__2;

		private CHexPosition _003ChexPos_003E5__3;

		private UniTask _003CloadMap_003E5__4;

		private UniTask.Awaiter _003C_003Eu__1;

		private CinemachineBlendDefinition _003CprevCameraBlend_003E5__5;

		private UniTask _003Cpoptask_003E5__6;

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
	private struct _003CTurnDecisionPhase_003Ed__189 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass189_0 _003C_003E8__1;

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
	private sealed class _003CUseItemEnd_003Ed__192 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass192_0 _003C_003E8__1;

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
		public _003CUseItemEnd_003Ed__192(int _003C_003E1__state)
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
	private sealed class _003C_ConsumeWillCost_003Ed__191 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		private List<WillEffect> _003CtokenEffect_003E5__2;

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
		public _003C_ConsumeWillCost_003Ed__191(int _003C_003E1__state)
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
	private sealed class _003C_Escape_003Ed__207 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		private List<Coroutine>.Enumerator _003C_003E7__wrap1;

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
		public _003C_Escape_003Ed__207(int _003C_003E1__state)
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
	private sealed class _003C_Lose_003Ed__202 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		private _003C_003Ec__DisplayClass202_0 _003C_003E8__1;

		private CFieldPlayer _003Cactor_003E5__2;

		private int _003Cmode_003E5__3;

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
		public _003C_Lose_003Ed__202(int _003C_003E1__state)
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
	private struct _003C_ReduceRemainingTurns_003Ed__203 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public int i_TurnNumber;

		private _003C_003Ec__DisplayClass203_0 _003C_003E8__1;

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
	private sealed class _003C_ShowMessageAndChoice_003Ed__227 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

		public string i_Message;

		public string i_Choice;

		public int i_CursorPosition;

		public string[] i_ChoiceSubText;

		public float i_ChoicePositionY;

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
		public _003C_ShowMessageAndChoice_003Ed__227(int _003C_003E1__state)
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
	private sealed class _003C_Win_003Ed__200 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleMain _003C_003E4__this;

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
		public _003C_Win_003Ed__200(int _003C_003E1__state)
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

	private static bool m1stBattle;

	private static string mRushBattle;

	private static string[] mEnemyGroup;

	private static int mEnemyGroupIndex;

	private static int mFirstActEnemy;

	private static bool mIsFirstAwake;

	private static RESULT mResult;

	[SerializeField]
	private GameObject m_CameraRoot;

	[SerializeField]
	private CBtlCamera m_BtlCamera;

	[SerializeField]
	private Camera m_ModelUICamera;

	private GameObject m_FieldCameraRoot;

	[SerializeField]
	private Volume m_Volume;

	[SerializeField]
	private Volume m_MotionBlurVolume;

	[SerializeField]
	private CinemachineBlendDefinition m_ToBattleBlendDefinition;

	[SerializeField]
	private CinemachineBlendDefinition m_ToFieldBlendDefinition;

	[SerializeField]
	private SignalSourceAsset m_SignalSourceAsset;

	[SerializeField]
	private Canvas m_Canvas;

	[SerializeField]
	private Canvas m_CanvasDebug;

	[SerializeField]
	private RectTransform m_UIRootTimeline;

	[SerializeField]
	private RectTransform m_UIRootHand;

	[SerializeField]
	private CBtlCardDetail m_BtlCardDetail;

	[SerializeField]
	private RectTransform m_UIRootTurnMenu;

	[SerializeField]
	private RectTransform m_UIRootCharaInfo;

	[SerializeField]
	private CanvasGroup m_CharacterInfoCanvaGroup;

	[SerializeField]
	private CChoiceMenu m_MessageMenu;

	[SerializeField]
	private CEventMessage m_GameMasterEventMessage;

	[SerializeField]
	private CBtlGmMessage m_GameMasterBattleMessage;

	private Coroutine m_MessageAndChoiceCoroutine;

	[SerializeField]
	private CInOutBehaviour m_ChoiceInOut;

	[SerializeField]
	private SpeechBubbleRenderer m_SpeechBubbleRenderer;

	[SerializeField]
	private CItemWindow m_ItemWindow;

	[SerializeField]
	private CUIButtonExplanation m_ButtonExplanation;

	private bool m_IsControl;

	private double m_Time;

	private List<double> m_OperateTime;

	[SerializeField]
	private bool m_EnableForceVector;

	[SerializeField]
	private Vector3 m_ForceVector;

	[SerializeField]
	private bool m_EnableForce;

	[SerializeField]
	private int m_Force;

	[SerializeField]
	private bool m_EnableTorqueVector;

	[SerializeField]
	private Vector3 m_TorqueVector;

	[SerializeField]
	private bool m_EnableTorque;

	[SerializeField]
	private int m_Torque;

	[SerializeField]
	private Transform m3DRoot;

	[SerializeField]
	private Transform m_3DBattleTestRoot;

	[SerializeField]
	private Transform mMapRoot;

	[SerializeField]
	private Transform m_TreasureBoxRoot;

	[SerializeField]
	private Transform m_ActionScript;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private bool m_Started;

	private float m_SaveShadowDistance;

	private bool[] m_InputButton;

	private SaveTransform m_SaveHex;

	private SaveTransform m_SaveDodai;

	private SaveTransform m_SaveField;

	private int mBattleCount;

	private CFieldPlayer[] mFieldPlayer;

	private List<CBattlePlayer> mBattlePlayer;

	private List<CBattleEnemy> mBattleEnemy;

	private CFieldEnemy m_FieldEnemy;

	private bool m_FirstTurnDecisionPhase;

	private bool m_ActorConditionDeath;

	private bool m_EnableNotActionEffect;

	public bool m_EnableWaitUsingAction;

	private Vector3 m_CenterPosition;

	private Vector3 m_PlayerBasePosition;

	private Vector3 m_EnemyBasePosition;

	private float m_PopMapTime;

	private float m_PopCharacterTime;

	private PopDirection[] m_PopPlayer;

	private PopDirection[] m_PopEnemy;

	private Coroutine m_ConsumeWillCost;

	private UniTask m_TransitionBattleEnd;

	private List<string> m_StealMessagePool;

	private List<StolenPlayerItem> m_StolenPlayerItems;

	private UniTask m_ChangedRankUI;

	private UniTask m_ObtainEnemyWilllToken;

	private PreUIFadeController m_PreUIFadeController;

	private List<GroupTrack> m_SaveGroupTrack;

	[SerializeField]
	private float m_PossesionDistance2;

	[SerializeField]
	private float m_PossesionDistance3;

	[SerializeField]
	private float m_PossesionAngle2;

	[SerializeField]
	private float m_PossesionAngle3;

	private static bool _EnableEscape { get; set; }

	public static bool mEnableEscape
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public static bool mEventBattle { get; private set; }

	public CBtlCamera BtlCamera => null;

	public Camera ModelUICamera => null;

	public Volume Volume => null;

	public SignalSourceAsset SignalSourceAsset => null;

	public CBtlCardDetail BtlCardDetail => null;

	public CChoiceMenu MessageMenu => null;

	public CEventMessage GameMasterEventMessage => null;

	public CBtlGmMessage GameMasterBattleMessage => null;

	public SpeechBubbleRenderer SpeechBubbleRenderer => null;

	public CItemWindow ItemWindow => null;

	public Transform TreasureBoxRoot => null;

	public Transform ActionScript => null;

	public CBattleShareParam m_BattleShareParam { get; private set; }

	public CBtlMap m_Map { get; private set; }

	public CBattleCharDef mActor { get; private set; }

	public CSkill mActSkill { get; private set; }

	public CSkillCard mPrevPlayerUsedSkill { get; private set; }

	public List<CBattleCharDef> mPrevPlayerUsedSkillTarget { get; private set; }

	public List<CBattleCharDef> m_EscapeCharacters { get; private set; }

	public List<CBattleCharDef> m_WillChargePlayers { get; private set; }

	public static string GetRushBattleID()
	{
		return null;
	}

	public static string GetEnemyGroup(int i_RushIndex = 0)
	{
		return null;
	}

	public static void SetEnemyGroup(string groupID, int firstActorIndex = -1)
	{
	}

	public static void SetEnableEscape(bool a)
	{
	}

	public static void SetEventBattle(bool a)
	{
	}

	public static bool IsInBattle()
	{
		return false;
	}

	public static bool IsWin()
	{
		return false;
	}

	public static bool IsLose()
	{
		return false;
	}

	public static bool IsEscape()
	{
		return false;
	}

	public static void SetBattleResult(RESULT res)
	{
	}

	public CUIButtonExplanation ButtonExplanation()
	{
		return null;
	}

	private void SetModeNone()
	{
	}

	private void Awake()
	{
	}

	private new void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__168))]
	private UniTask Start()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadModel_003Ed__169))]
	private UniTask LoadModel()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadMap_003Ed__170))]
	private UniTask LoadMap(string i_Path, string i_EffectPath, Transform i_Parent)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadMapEffect_003Ed__171))]
	private UniTask LoadMapEffect(string i_EffectPath, Transform i_Parent)
	{
		return default;
	}

	public Vector3 GetPlayerPosition(int count, int index)
	{
		return default;
	}

	private void OnValidate()
	{
	}

	public Vector3 GetEnemyPosition(int count, int index)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CTransitionBattleStart_003Ed__179))]
	private UniTask TransitionBattleStart()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CTransitionNormalBattleStart_003Ed__180))]
	private UniTask TransitionNormalBattleStart()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CTransitionBossBattleStart_003Ed__181))]
	private UniTask TransitionBossBattleStart()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CTransitionBattleRush_003Ed__182))]
	private UniTask TransitionBattleRush()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CTransitionBattleEnd_003Ed__183))]
	private UniTask TransitionBattleEnd()
	{
		return default;
	}

	private void TransitionMap(float time, Vector3 center)
	{
	}

	private void TransitionCharacter(float time)
	{
	}

	private void TransitionPlayer(int index, float time, float jump)
	{
	}

	private void TransitionEnemy(int index, float time, float jump)
	{
	}

	private void Update()
	{
	}

	[AsyncStateMachine(typeof(_003CTurnDecisionPhase_003Ed__189))]
	private UniTask TurnDecisionPhase()
	{
		return default;
	}

	private void ConsumeWillCost()
	{
	}

	[IteratorStateMachine(typeof(_003C_ConsumeWillCost_003Ed__191))]
	private IEnumerator _ConsumeWillCost()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUseItemEnd_003Ed__192))]
	private IEnumerator UseItemEnd()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CActionEnd_003Ed__193))]
	public IEnumerator ActionEnd(bool i_TurnEnd)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CNextPersonalPhase_003Ed__194))]
	public IEnumerator NextPersonalPhase()
	{
		return null;
	}

	public List<CBattlePlayer> GetBattlePlayerList()
	{
		return null;
	}

	public List<CBattlePlayer> GetBattlePlayerList_SortPositionX()
	{
		return null;
	}

	public List<CBattleEnemy> GetBattleEnemyList()
	{
		return null;
	}

	public void SetModeActionPhase(CSkill skill, bool i_OnlyCharge = false)
	{
	}

	public void Win()
	{
	}

	[IteratorStateMachine(typeof(_003C_Win_003Ed__200))]
	private IEnumerator _Win()
	{
		return null;
	}

	public void Lose()
	{
	}

	[IteratorStateMachine(typeof(_003C_Lose_003Ed__202))]
	private IEnumerator _Lose()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003C_ReduceRemainingTurns_003Ed__203))]
	private UniTask _ReduceRemainingTurns(int i_TurnNumber)
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CToGameOver_003Ed__204))]
	private IEnumerator ToGameOver()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CMoveCameraOffset_003Ed__205))]
	private UniTask MoveCameraOffset()
	{
		return default;
	}

	public bool Escape()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003C_Escape_003Ed__207))]
	private IEnumerator _Escape()
	{
		return null;
	}

	public void EscapeFailed()
	{
	}

	[AsyncStateMachine(typeof(_003CActiveBattleCamera_003Ed__209))]
	public UniTask ActiveBattleCamera()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CActiveFieldCamera_003Ed__210))]
	public UniTask ActiveFieldCamera()
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CProgressCondition_003Ed__211))]
	private IEnumerator ProgressCondition()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CToSelectCardPhase_003Ed__212))]
	private IEnumerator ToSelectCardPhase(bool i_UsedItemAfter)
	{
		return null;
	}

	public CBattlePlayer GetPlayer(CParamDef param)
	{
		return null;
	}

	public CBattlePlayer GetPlayerToIndex(int index)
	{
		return null;
	}

	public CBattleEnemy GetEnemy(CParamDef param)
	{
		return null;
	}

	private CMaster_MapBattleData GetBattleData()
	{
		return null;
	}

	private CHexPosition GetFieldHexPosition()
	{
		return null;
	}

	private void OnReceived()
	{
	}

	public List<Dictionary<string, object>> CreateParamPlayerMe()
	{
		return null;
	}

	public List<Dictionary<string, object>> CreateParamPlayerAll()
	{
		return null;
	}

	public void SetParamPlayerAll(JsonNode array)
	{
	}

	public List<Dictionary<string, object>> CreateParamEnemyAll()
	{
		return null;
	}

	public void SetParamEnemyAll(JsonNode array)
	{
	}

	[AsyncStateMachine(typeof(_003CSyncParamPlayer_003Ed__224))]
	private UniTask SyncParamPlayer(CancellationToken cancel)
	{
		return default;
	}

	public Vector3 GetIncenter(Vector3 a, Vector3 b, Vector3 c)
	{
		return default;
	}

	public void ShowMessageAndChoice(string i_Message, string i_Choice, int i_CursorPosition = 0, float i_ChoicePositionY = -480f, string[] i_ChoiceSubText = null)
	{
	}

	[IteratorStateMachine(typeof(_003C_ShowMessageAndChoice_003Ed__227))]
	private IEnumerator _ShowMessageAndChoice(string i_Message, string i_Choice, int i_CursorPosition = 0, float i_ChoicePositionY = -480f, string[] i_ChoiceSubText = null)
	{
		return null;
	}

	public bool IsShowCompleteMessageAndChoice()
	{
		return false;
	}

	public void ShowMessage(string i_Message, GameController.PADNUM i_PadNum, bool i_IsControl)
	{
	}

	public void ShowMessageFixed(string i_Message)
	{
	}

	public void SetMessage(string i_Message)
	{
	}

	public void HideMessage()
	{
	}

	public bool IsShowMessage()
	{
		return false;
	}

	public void ReserveStealMessage(string i_Message)
	{
	}

	public CMaster_ItemData StealPlayerItem(CBattlePlayer i_Player, CParamCondition i_Condition)
	{
		return null;
	}

	public void ReturnStolenPlayerItems()
	{
	}

	[AsyncStateMachine(typeof(_003CShowStealMessage_003Ed__237))]
	public UniTask ShowStealMessage()
	{
		return default;
	}

	public bool IsBossBattle()
	{
		return false;
	}

	public void SetHandCardFilter(bool i_Show, bool i_Immediate = false)
	{
	}

	[IteratorStateMachine(typeof(_003CPassiveEffectBossBattle_003Ed__240))]
	private IEnumerator PassiveEffectBossBattle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcAutoResurrection_003Ed__241))]
	private IEnumerator ProcAutoResurrection()
	{
		return null;
	}

	public CMaster_EnemyGroupData GetEnemyGroup()
	{
		return null;
	}

	public void ExecuteEnemyRoutine(CBattleEnemy i_Enemy, bool i_ActionBefore = false)
	{
	}

	private void ChangeBattleCamera(out CinemachineBlendDefinition o_PrevCameraBlend)
	{
		o_PrevCameraBlend = default;
	}

	private void ResetBattleCamera()
	{
	}

	private bool AbilityResurrectionHp(CMaster_SkillAbilityData i_Data, ref int i_Rate, int i_DefaultValue)
	{
		return false;
	}

	private void _DiscardInHand(CParamPlayer i_ParamTarget)
	{
	}

	[AsyncStateMachine(typeof(_003CDiscardInHand_003Ed__248))]
	public UniTask DiscardInHand(CSkill i_Skill, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CObtainEnemyWilllToken_003Ed__249))]
	public UniTask ObtainEnemyWilllToken(CancellationToken cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CApplyUIRank_003Ed__250))]
	public UniTask ApplyUIRank(CSkill i_Skill, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003COpenSkillResultWindow_003Ed__251))]
	public UniTask OpenSkillResultWindow(CSkill i_Skill, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CApplyAbility_003Ed__253))]
	private UniTask<ReturnApplyAbility> ApplyAbility(CSkillEffect i_SkillEffect, CancellationToken i_Cancel)
	{
		return default;
	}

	public void SetControl(bool i_IsControl)
	{
	}

	public bool IsControl()
	{
		return false;
	}

	public bool IsMeOnlineCommandSender()
	{
		return false;
	}

	private void CancelLookAtCamera()
	{
	}

	public void EnableEndlessAction()
	{
	}

	public void DisableEndlessAction()
	{
	}

	public string GetBossDeadCameraName()
	{
		return null;
	}

	private void PlayBattleBgm()
	{
	}

	public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
	{
		return default;
	}

	[Conditional("UNITY_DEBUG")]
	public void OutputTimeLog(BattleTime i_Type)
	{
	}

	[Conditional("UNITY_DEBUG")]
	public void OutputOperateItemTimeLog(CItem i_Item)
	{
	}
}
