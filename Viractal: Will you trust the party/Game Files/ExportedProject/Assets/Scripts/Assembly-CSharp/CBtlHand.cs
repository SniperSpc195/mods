using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Pool;

public class CBtlHand : LwSingleton<CBtlHand>
{
	private enum ButtonType
	{
		ViewAbilities = 0,
		ChangeCharacter = 1,
		Exit = 2
	}

	[Serializable]
	private class Card
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDrawAnimation_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Card _003C_003E4__this;

			public float i_Duration;

			private float _003Ctime_003E5__2;

			private AnimationCurve _003Ccurve_003E5__3;

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

		public Transform root;

		public MeshRenderer mesh;

		public TextMeshPro atkBuff;

		public TextMeshPro atkDebuff;

		public TextMeshPro defBuff;

		public TextMeshPro defDebuff;

		public Transform willConfuse;

		[ReadOnly]
		public Quaternion rotation;

		[ReadOnly]
		public bool decide;

		[ReadOnly]
		public string cardID;

		[ReadOnly]
		public Vector3 notSelectPosition;

		[ReadOnly]
		public bool draw;

		[ReadOnly]
		public bool frozen;

		[ReadOnly]
		public ParticleSystem frozenParticleSystem;

		[ReadOnly]
		public GameObject frozenEffectRoot;

		[ReadOnly]
		public bool curse;

		[ReadOnly]
		public ParticleSystem curseParticleSystem;

		[ReadOnly]
		public GameObject curseEffectRoot;

		[ReadOnly]
		public bool prohibit;

		[ReadOnly]
		public ParticleSystem prohibitParticleSystem;

		[ReadOnly]
		public GameObject prohibitEffectRoot;

		[AsyncStateMachine(typeof(_003CDrawAnimation_003Ed__21))]
		public UniTask DrawAnimation(float i_Duration)
		{
			return default;
		}
	}

	private struct WillEffect
	{
		public CardRenderTextureSpriteRenderer.ManaKind kind;

		public CEffectHandle line;

		public Vector3 startPosition;

		public Vector3 endPosition;

		public Vector3 localPosition;

		public Vector3 speed;
	}

	private enum Seq
	{
		None = 0,
		TurnStart = 1,
		SelectCard = 2,
		DicideCardAnime = 3,
		PlayConfirm = 4,
		CheckCost = 5,
		SelectTarget = 6,
		SelectEnemyUI0 = 7,
		SelectEnemyUI1 = 8,
		SelectEnemyUI2 = 9,
		SelectPlayerUI0 = 10,
		SelectPlayerUI1 = 11,
		SelectPlayerUI2 = 12,
		DebugSelectCard = 13
	}

	private enum InputSelectCard
	{
		IsOk = 0,
		IsCancel = 1,
		IsPressLeft = 2,
		IsRepLeft = 3,
		IsPressRight = 4,
		IsRepRight = 5,
		IsPress_R3 = 6,
		IsPress_L3 = 7,
		IsPressUp = 8,
		IsPressDown = 9,
		IsSelectEnemy0 = 10,
		IsSelectEnemy1 = 11,
		IsSelectEnemy2 = 12,
		IsSelectPlayer0 = 13,
		IsSelectPlayer1 = 14,
		IsSelectPlayer2 = 15
	}

	private enum InputCheckCost
	{
		IsItemOk = 0,
		IsCancel = 1
	}

	private enum InputCheckTarget
	{
		IsOk = 0,
		IsCancel = 1
	}

	private enum InputSelectTarget
	{
		IsCancel = 0
	}

	private struct PickupCard
	{
		public int srcIndex;

		public GameObject card;
	}

	public enum HandState
	{
		Hide = 0,
		Move = 1,
		Opened = 2
	}

	private struct DecideCardDirectionParam
	{
		public Vector3 position;

		public Quaternion rotation;
	}

	private struct UseRandomCardParam
	{
		public int m_SelectedCardIdx;

		public bool isProhibitCard;

		public bool isLackCost;

		public bool isProhibitEscape;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass131_0
	{
		public CBtlHand _003C_003E4__this;

		public List<CMaster_SkillCardData> drawCard;

		public CUICharacterStatus characterStatus;

		internal UniTask _003CTurnStart_003Eb__3()
		{
			return default;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass143_0
	{
		public float time;

		public AnimationCurve curve;

		public MeshRenderer mesh;

		public Vector3 meshScale;

		public CBtlHand _003C_003E4__this;

		internal bool _003CDecideCardDirection_003Eb__0()
		{
			return false;
		}

		internal bool _003CDecideCardDirection_003Eb__1()
		{
			return false;
		}

		internal bool _003CDecideCardDirection_003Eb__2()
		{
			return false;
		}

		internal bool _003CDecideCardDirection_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass145_0
	{
		public CBtlHand _003C_003E4__this;

		public float time;

		public Transform mesh;

		public Vector3 srcScale;

		public AnimationCurve curve;

		internal bool _003CDestroyDecisionCard_003Eb__0()
		{
			return false;
		}

		internal bool _003CDestroyDecisionCard_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass146_0
	{
		public CUICharacterStatus characterStatus;

		internal UniTask _003CProcessReDrawHandCards_003Eb__0()
		{
			return default;
		}

		internal UniTask _003CProcessReDrawHandCards_003Eb__2()
		{
			return default;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass174_0
	{
		public CBtlHand _003C_003E4__this;

		public CSkillCardData card;

		public CUICharacterStatus characterStatus;

		internal UniTask _003C_UseTopofDeck_003Eb__0()
		{
			return default;
		}

		internal bool _003C_UseTopofDeck_003Eb__1(CSkillCardData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCancelCardDirection_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		private bool _003Cresume_003E5__2;

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
		public _003CCancelCardDirection_003Ed__144(int _003C_003E1__state)
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
	private sealed class _003CDecideCardDirection_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		public bool i_FromDeck;

		private _003C_003Ec__DisplayClass143_0 _003C_003E8__1;

		private CMaster_SkillCardData _003Cdata_003E5__2;

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
		public _003CDecideCardDirection_003Ed__143(int _003C_003E1__state)
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
	private sealed class _003CDestroyDecisionCard_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		private _003C_003Ec__DisplayClass145_0 _003C_003E8__1;

		public bool i_OnlyCharge;

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
		public _003CDestroyDecisionCard_003Ed__145(int _003C_003E1__state)
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
	private sealed class _003CHandInOutAnime_003Ed__172 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		public bool inverse;

		private Vector3[] _003CstartPos_003E5__2;

		private Vector3[] _003CgoalPos_003E5__3;

		private int _003Corder_003E5__4;

		private Func<bool, int, int> _003CfuncDecisionCardClose_003E5__5;

		private List<int> _003CdrawIndex_003E5__6;

		private PooledObject<List<int>> _003C_003E7__wrap6;

		private int _003Ci_003E5__8;

		private float _003Ctime_003E5__9;

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
		public _003CHandInOutAnime_003Ed__172(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadCardIllust_003Ed__130 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlHand _003C_003E4__this;

		public MeshRenderer i_MeshRenderer;

		public string i_ID;

		private MaterialPropertyBlock _003Cpropertyblock_003E5__2;

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
	private sealed class _003CLoadWillEffect_003Ed__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

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
		public _003CLoadWillEffect_003Ed__147(int _003C_003E1__state)
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
	private sealed class _003CPlayWillEffect_003Ed__149 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer i_ChargePlayer;

		public CBtlHand _003C_003E4__this;

		public bool i_OnlyCharge;

		private AnimationCurve _003Ccurve_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CPlayWillEffect_003Ed__149(int _003C_003E1__state)
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
	private sealed class _003CProcessReDrawHandCards_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		private _003C_003Ec__DisplayClass146_0 _003C_003E8__1;

		private CParamPlayer _003Cparam_003E5__2;

		private CConfigData.SortHandCard _003Csort_003E5__3;

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
		public _003CProcessReDrawHandCards_003Ed__146(int _003C_003E1__state)
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
	private sealed class _003CProcessTargetSelector_003Ed__158 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		public bool i_EnableCancel;

		private bool _003CchoiceSolo_003E5__2;

		private Dictionary<CBtlCursorManager.TargetGroup, CBattleCharDef> _003CtmpSoloTarget_003E5__3;

		private PooledObject<Dictionary<CBtlCursorManager.TargetGroup, CBattleCharDef>> _003C_003E7__wrap3;

		private int _003Cj_003E5__5;

		private CSkillEffect _003Cskleff_003E5__6;

		private CBtlCursorManager.TargetGroup _003Cgroup_003E5__7;

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
		public _003CProcessTargetSelector_003Ed__158(int _003C_003E1__state)
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
	private sealed class _003CRefleshHand_003Ed__134 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

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
		public _003CRefleshHand_003Ed__134(int _003C_003E1__state)
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
	private sealed class _003CSetRandomTarget_003Ed__159 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		private int _003Ci_003E5__2;

		private CSkillEffect _003Cskleff_003E5__3;

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
		public _003CSetRandomTarget_003Ed__159(int _003C_003E1__state)
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
	private struct _003CStart_003Ed__120 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlHand _003C_003E4__this;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
	private sealed class _003CStartSelectCard_003Ed__132 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

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
		public _003CStartSelectCard_003Ed__132(int _003C_003E1__state)
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
	private sealed class _003CSyncHandCardsParam_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

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
		public _003CSyncHandCardsParam_003Ed__133(int _003C_003E1__state)
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
	private sealed class _003CTurnStart_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		private _003C_003Ec__DisplayClass131_0 _003C_003E8__1;

		private int _003Ccount_003E5__2;

		private bool _003CisOpenhand_003E5__3;

		private CParamPlayer _003Cparam_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CTurnStart_003Ed__131(int _003C_003E1__state)
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
	private sealed class _003CUseRandomCard_003Ed__183 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		private bool _003CisProhibitCard_003E5__2;

		private bool _003CisLackCost_003E5__3;

		private bool _003CisProhibitEscape_003E5__4;

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
		public _003CUseRandomCard_003Ed__183(int _003C_003E1__state)
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
	private sealed class _003CYieldUniTaskAwaiter_003Ed__167 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UniTask.Awaiter i_Awaiter;

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
		public _003CYieldUniTaskAwaiter_003Ed__167(int _003C_003E1__state)
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
	private sealed class _003C_HandIn_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		public bool enableSelect;

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
		public _003C_HandIn_003Ed__136(int _003C_003E1__state)
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
	private sealed class _003C_HandOut_003Ed__138 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		public bool camera;

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
		public _003C_HandOut_003Ed__138(int _003C_003E1__state)
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
	private sealed class _003C_UseTopofDeck_003Ed__174 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlHand _003C_003E4__this;

		private _003C_003Ec__DisplayClass174_0 _003C_003E8__1;

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
		public _003C_UseTopofDeck_003Ed__174(int _003C_003E1__state)
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

	private RaycastHit[] m_RaycastHits;

	[SerializeField]
	private CinemachineVirtualCamera m_EnemyLookAtCamera;

	[SerializeField]
	private CinemachineVirtualCamera m_BossEnemyLookAtCamera;

	[SerializeField]
	private CinemachineVirtualCamera m_CharacterLookAtCamera;

	[SerializeField]
	private CEnemyDescription m_EnemyDescription;

	[SerializeField]
	private Animator m_CharacterStatusNaviAnimator;

	[SerializeField]
	private CBtlTurnMenu.Button[] m_CharacterStatusNaviButtons;

	[SerializeField]
	private CanvasGroup m_CharacterStatusNaviCanvasGroup;

	private int m_ActiveCharacterIndex;

	private int m_ActiveConditionIndex;

	private bool m_BossMode;

	private bool m_AbilityViewMode;

	private float? m_BackupCameraDistance;

	private float? _descriptionDistance;

	private CUIEnemyStatus m_ActiveEnemyStatus;

	private bool IsEnableCallback;

	private bool IsInvokeOnEndTop;

	public static readonly int TokenKey;

	[SerializeField]
	private RectTransform m_HandRect;

	[SerializeField]
	private Transform m_RootCard;

	[SerializeField]
	private Card m_CardOrigin;

	[SerializeField]
	private List<Card> m_Card;

	[SerializeField]
	[Header("カードの中心")]
	[Range(0f, 30f)]
	private float m_CardCenter;

	[SerializeField]
	[Header("手札の基準角度")]
	[Range(0f, 90f)]
	private float m_Angle0;

	[SerializeField]
	[Header("カード同士の間隔（角度）")]
	[Range(0f, 40f)]
	private float m_Angle1;

	[SerializeField]
	[Header("楕円長軸の長さ")]
	[Range(0.1f, 6f)]
	private float m_MajorAxis;

	[SerializeField]
	[Header("楕円短軸の長さ")]
	[Range(0.1f, 6f)]
	private float m_MinorAxis;

	[SerializeField]
	[Header("手札１枚毎の表示間隔")]
	private float m_HandInDuration;

	[SerializeField]
	[Header("手札の表示速度")]
	private float m_HandInSpeed;

	[SerializeField]
	[Header("ドロー１枚毎の表示間隔(Frame)")]
	private float m_DrawTime;

	[SerializeField]
	[Header("次のドローの待ち時間(Frame)")]
	private float m_DrawWait;

	[SerializeField]
	[Header("手札の放物線アニメーションの高さ")]
	private float m_HandInArcHeight;

	private GameObject m_SelectFrontEffect;

	private GameObject m_SelectBackEffect;

	private GameObject m_FrozenEffect;

	private GameObject m_CurseEffect;

	private GameObject m_SkillProhibitEffect;

	private CSelectableInOutPattern m_InOutFront;

	private CInOutPattern m_InOutBack;

	private List<WillEffect> m_WillEffect;

	private float m_WillTrajectoryTime;

	private Seq m_Seq;

	private float[] m_HandInOutUniqueTime;

	private float m_HandInOutCommonTime;

	private Coroutine m_HandInOutCoroutine;

	private float m_FixedAngle0;

	private float m_FixedAngle1;

	private bool[] m_InputButton;

	private int m_SelectedCardIdx;

	private int m_DecidedCardIdx;

	private PickupCard m_PickupCard;

	private readonly Vector3 PickupPositionOffset;

	private List<MaterialPropertyBlock> m_CardMaterialPropertyBlock;

	private float m_NonresponseTime;

	private bool m_ShowingLeaveMessage;

	private bool m_ConditionDetailMode;

	private float m_GameSpeed;

	private DecideCardDirectionParam m_DecideCardDirectionParam;

	private bool m_ShowedOnceDisableHealDialog;

	private UseRandomCardParam? m_UseRandomCardParam;

	private float DescriptionDistance => 0f;

	public Coroutine m_HandInCoroutine { get; private set; }

	public Coroutine m_HandOutCoroutine { get; private set; }

	public bool m_ProcessingDestroyDecisionCard { get; private set; }

	public CBattlePlayer m_BattlePlayer { get; private set; }

	public CSkillCard m_DecidedSkillCard { get; private set; }

	public HandState m_HandState { get; private set; }

	private int CheckRaycast(CUICharacterStatusGroup statusGroup, GamePad mouse)
	{
		return 0;
	}

	private static bool IsPressUp(GamePad pad)
	{
		return false;
	}

	private static bool IsPressDown(GamePad pad)
	{
		return false;
	}

	private int IsEnemyStatusClicked(bool isControl, GamePad mouse)
	{
		return 0;
	}

	private int AutoSelectEnemy(bool isControl, GamePad pad)
	{
		return 0;
	}

	private int IsPlayerStatusClicked(bool isControl, GamePad mouse, out int o_ConditionIndex)
	{
		o_ConditionIndex = default;
		return 0;
	}

	private int AutoSelectPlayer(bool isControl, GamePad pad)
	{
		return 0;
	}

	public void BeginSelectCharacterCondition(int i_CharacterIndex, int i_ConditionIndex)
	{
	}

	private bool UpdateEnemyUI()
	{
		return false;
	}

	private bool oldUpdatePlayerUI()
	{
		return false;
	}

	private bool UpdatePlayerUI()
	{
		return false;
	}

	private void UpdateAbilityView(bool isControl, GamePad i_Pad, GamePad i_Mouse)
	{
	}

	private void OnFocusEnemy(int i_Index)
	{
	}

	private void oldOnFocusCharacterCondition(int i_CharacterIndex, int i_ConditionIndex)
	{
	}

	private void OnFocusCharacterCondition(int i_CharacterIndex, int unused = -1)
	{
	}

	private void UpdateCharacterStatusNaviUI()
	{
	}

	private void SetAbilityViewNavi(bool i_IsAbilityViewMode)
	{
	}

	private void OnEndTop()
	{
	}

	private void BeginOnTopCallbackIfNessesory()
	{
	}

	private void EndOnTopCallback()
	{
	}

	public static bool IsContainLargeEnemy()
	{
		return false;
	}

	public static float GetColliderSize(Collider i_Collider)
	{
		return 0f;
	}

	public static float _GetCapsuleSize(CapsuleCollider i_Capsule)
	{
		return 0f;
	}

	public static float _GetBoxSize(BoxCollider i_Box)
	{
		return 0f;
	}

	public static float _GetSphereSize(SphereCollider i_Sphere)
	{
		return 0f;
	}

	public static void Setup(CBattlePlayer player)
	{
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__120))]
	private UniTask Start()
	{
		return default;
	}

	private new void OnDestroy()
	{
	}

	public bool IsEnableOtherButton()
	{
		return false;
	}

	private void Update()
	{
	}

	public void FocusCard()
	{
	}

	private void LateUpdate()
	{
	}

	public void Close()
	{
	}

	public void AddCard(params CSkillCardData[] cards)
	{
	}

	private void ApplySkillCard()
	{
	}

	public void ApplyBuffDebuff()
	{
	}

	[AsyncStateMachine(typeof(_003CLoadCardIllust_003Ed__130))]
	private UniTask LoadCardIllust(MeshRenderer i_MeshRenderer, string i_ID)
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CTurnStart_003Ed__131))]
	public IEnumerator TurnStart()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartSelectCard_003Ed__132))]
	public IEnumerator StartSelectCard()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSyncHandCardsParam_003Ed__133))]
	private IEnumerator SyncHandCardsParam()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRefleshHand_003Ed__134))]
	public IEnumerator RefleshHand()
	{
		return null;
	}

	public void HandIn(bool enableSelect)
	{
	}

	[IteratorStateMachine(typeof(_003C_HandIn_003Ed__136))]
	private IEnumerator _HandIn(bool enableSelect)
	{
		return null;
	}

	public void HandOut(bool camera = false)
	{
	}

	[IteratorStateMachine(typeof(_003C_HandOut_003Ed__138))]
	private IEnumerator _HandOut(bool camera = false)
	{
		return null;
	}

	public bool IsHandOut()
	{
		return false;
	}

	private void StartCoroutineDecideCardDirection(bool i_FromDeck = false)
	{
	}

	[IteratorStateMachine(typeof(_003CDecideCardDirection_003Ed__143))]
	private IEnumerator DecideCardDirection(bool i_FromDeck = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCancelCardDirection_003Ed__144))]
	private IEnumerator CancelCardDirection()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDestroyDecisionCard_003Ed__145))]
	public IEnumerator DestroyDecisionCard(bool i_OnlyCharge)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessReDrawHandCards_003Ed__146))]
	public IEnumerator ProcessReDrawHandCards()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadWillEffect_003Ed__147))]
	private IEnumerator LoadWillEffect()
	{
		return null;
	}

	private void ObtainWillToken(CardRenderTextureSpriteRenderer.ManaKind i_Kind, int i_AddCount, ref int i_CurrentCount, Vector3 i_EffectPosition)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayWillEffect_003Ed__149))]
	private IEnumerator PlayWillEffect(bool i_OnlyCharge, CBattlePlayer i_ChargePlayer)
	{
		return null;
	}

	private float ApplyAngle1()
	{
		return 0f;
	}

	private Vector3 GetCardPosition(float degree)
	{
		return default;
	}

	private void SetCardPosition()
	{
	}

	public bool IsDecideCardInprocessing()
	{
		return false;
	}

	private bool ToActionPhase(bool i_OnlyCharge)
	{
		return false;
	}

	private void ToCostCheck()
	{
	}

	private void CheckChargeOnly(out bool isProhibitCard, out bool isLackCost, out bool isProhibitEscape)
	{
		isProhibitCard = default;
		isLackCost = default;
		isProhibitEscape = default;
	}

	[IteratorStateMachine(typeof(_003CProcessTargetSelector_003Ed__158))]
	private IEnumerator ProcessTargetSelector(bool i_EnableCancel = true)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetRandomTarget_003Ed__159))]
	private IEnumerator SetRandomTarget()
	{
		return null;
	}

	private bool TryOpenDisableHealDialog(int i_EffectIndex, CBattleCharDef i_Target)
	{
		return false;
	}

	private bool UpdateHealNgMessage()
	{
		return false;
	}

	private void ReturnHandCardsSelect()
	{
	}

	private void PrepareSkill(bool i_OnlyCharge)
	{
	}

	public Vector2 GetDecideCardScreenPosition()
	{
		return default;
	}

	private void PredictionCost()
	{
	}

	private void OnValidate()
	{
	}

	[IteratorStateMachine(typeof(_003CYieldUniTaskAwaiter_003Ed__167))]
	private IEnumerator YieldUniTaskAwaiter(UniTask.Awaiter i_Awaiter)
	{
		return null;
	}

	private Coroutine HandInAnime()
	{
		return null;
	}

	private IEnumerator _HandInAnime()
	{
		return null;
	}

	private Coroutine HandOutAnime()
	{
		return null;
	}

	private IEnumerator _HandOutAnime()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHandInOutAnime_003Ed__172))]
	private IEnumerator HandInOutAnime(bool inverse = false)
	{
		return null;
	}

	public void UseTopofDeck()
	{
	}

	[IteratorStateMachine(typeof(_003C_UseTopofDeck_003Ed__174))]
	private IEnumerator _UseTopofDeck()
	{
		return null;
	}

	public IOrderedEnumerable<KeyValuePair<CardRenderTextureSpriteRenderer.ManaKind, int>> GetCostList(CMaster_SkillCardData i_Data)
	{
		return null;
	}

	private void SetBuffDebuffText(CMaster_SkillCardData i_SkillCard, TextMeshPro i_AtkBuffText, TextMeshPro i_AtkDebuffText, TextMeshPro i_DefBuffText, TextMeshPro i_DefDebuffText, Transform i_ChargeWillParent)
	{
	}

	private int AtkBonus(CMaster_SkillCardData i_SkillCard)
	{
		return 0;
	}

	private int DefBonus(CMaster_SkillCardData i_SkillCard)
	{
		return 0;
	}

	public bool IsTurnStartProcess()
	{
		return false;
	}

	public bool IsSelecting()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CUseRandomCard_003Ed__183))]
	private IEnumerator UseRandomCard()
	{
		return null;
	}
}
