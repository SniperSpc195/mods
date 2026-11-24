using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fork.Game;
using Sting.Script.Engine;
using UnityEngine;
using UnityEngine.Events;

public abstract class CBattleCharDef : CCharDef
{
	public enum ActionScriptLabel
	{
		None = 0,
		Damage = 1,
		Dead = 2,
		Dodge = 3,
		ReflectStart = 4,
		ReflectDamage = 5,
		ReflectDead = 6,
		BarrierStart = 7,
		Endure = 8,
		CmnApproachTarget = 9,
		CmnLeave = 10,
		OnlyCharge = 11
	}

	public enum GuardTrigger
	{
		None = 0,
		EnemyAll = 1
	}

	private struct GuardParam
	{
		public GuardTrigger trigger;

		public int value;

		public CBattleCharDef initiator;

		public CSkill skill;

		public CEffectHandle effect;

		public void Init()
		{
		}
	}

	public struct BackParameter
	{
		public bool start;

		public int frame;

		public ActionWork.AnimationCurve curve;

		public bool keepAngle;
	}

	private enum SeqAction
	{
		None = 0,
		Action = 1
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public CEffectHandle effhnd;

		internal bool _003C_PlayEscapeAnime_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_ApproachTarget_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleCharDef target;

		public CBattleCharDef _003C_003E4__this;

		public ActionWork.AnimationCurve curveType;

		public float distance;

		public int approachFrame;

		private AnimationCurve _003Ccurve_003E5__2;

		private Vector3 _003Cstart_003E5__3;

		private Vector3 _003Cgoal_003E5__4;

		private float _003Ctime_003E5__5;

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
		public _003C_ApproachTarget_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003C_CheckAction_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleCharDef _003C_003E4__this;

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
		public _003C_CheckAction_003Ed__63(int _003C_003E1__state)
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
	private sealed class _003C_Move2Node_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActionWork.MapNode node;

		public CBattleCharDef _003C_003E4__this;

		public ActionWork.AnimationCurve curveType;

		public float distance;

		public int approachFrame;

		private AnimationCurve _003Ccurve_003E5__2;

		private Vector3 _003Cstart_003E5__3;

		private Vector3 _003Cgoal_003E5__4;

		private float _003Ctime_003E5__5;

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
		public _003C_Move2Node_003Ed__83(int _003C_003E1__state)
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
	private sealed class _003C_PlayEscapeAnime_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleCharDef _003C_003E4__this;

		private _003C_003Ec__DisplayClass102_0 _003C_003E8__1;

		private float _003Ctime_003E5__2;

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
		public _003C_PlayEscapeAnime_003Ed__102(int _003C_003E1__state)
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
	private sealed class _003C_PlayStartupEffect_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleCharDef _003C_003E4__this;

		public Transform parent;

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
		public _003C_PlayStartupEffect_003Ed__98(int _003C_003E1__state)
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
	private sealed class _003C_TurnToward_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform i_Target;

		public CBattleCharDef _003C_003E4__this;

		public int i_Time;

		private float _003Ctime_003E5__2;

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
		public _003C_TurnToward_003Ed__77(int _003C_003E1__state)
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

	public static readonly float EffectScale;

	public int mIndex;

	private GuardParam m_Guard;

	public bool m_StartReflectDead;

	public Vector3? mInitWorldPosition;

	public Vector3? mInitAngle;

	public Vector3? mInitScale;

	private Coroutine m_Approach;

	private IEnumerator m_CheckAction;

	public CActionSeq m_LastChangedAngle;

	private CBlurEnabler _BlurEnabler;

	public float m_GameSpeed;

	private Coroutine m_TurnTowardCoroutine;

	public AnimationCurve m_Curve;

	private SeqAction m_SeqAction;

	public Color color;

	public CActionSeq m_ActionScript { get; protected set; }

	public CSkillManager m_SkillManager { get; protected set; }

	public int m_Block { get; private set; }

	public int m_LocalTurnCount { get; private set; }

	public int m_GlobalTurnCount { get; private set; }

	public int m_ActTurnCount { get; private set; }

	public CActionRoutine m_ActionRoutine { get; protected set; }

	public BackParameter? m_Back { get; set; }

	public CBlurEnabler m_BlurEnabler => null;

	public UnityEvent<CBattleCharDef> OnStart { get; private set; }

	public bool IsValidGuard()
	{
		return false;
	}

	public CBattleCharDef GetGuardInitiator()
	{
		return null;
	}

	public int GetGuardValue()
	{
		return 0;
	}

	public GuardTrigger GetGuardTrigger()
	{
		return GuardTrigger.None;
	}

	public CSkill GetGuardSkill()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	protected void LoadActionScript(string name)
	{
	}

	public abstract void ReloadActionScript();

	[IteratorStateMachine(typeof(_003C_CheckAction_003Ed__63))]
	private IEnumerator _CheckAction()
	{
		return null;
	}

	public void TrigActionScript(ActionScriptLabel label)
	{
	}

	public abstract CParamDef GetParam();

	public void StartGurad(CBattleCharDef initiator, int value, GuardTrigger trigger, CSkill skill)
	{
	}

	public void EndGurad()
	{
	}

	public void SetBlock(int value)
	{
	}

	public void AddBlock(int value)
	{
	}

	public void ResetBlock()
	{
	}

	public void ResetSkillEffect()
	{
	}

	public bool ExecuteSkill(string i_SkillID)
	{
		return false;
	}

	public void ActConditionPrepareSkill(CMaster_SkillCardData i_SkillData)
	{
	}

	private void PrepareSkillHost(CSkillCard skill, List<object> sendWhisperTarget)
	{
	}

	public void TurnToward(Transform i_Target, int i_Time)
	{
	}

	[IteratorStateMachine(typeof(_003C_TurnToward_003Ed__77))]
	private IEnumerator _TurnToward(Transform i_Target, int i_Time)
	{
		return null;
	}

	public void ApproachTarget(CBattleCharDef target, float distance, int approachFrame, ActionWork.AnimationCurve curveType)
	{
	}

	[IteratorStateMachine(typeof(_003C_ApproachTarget_003Ed__80))]
	private IEnumerator _ApproachTarget(CBattleCharDef target, float distance, int approachFrame, ActionWork.AnimationCurve curveType)
	{
		return null;
	}

	private Vector3 GetApproachPosition(Vector3 i_Start, float i_Distance, CBattleCharDef i_Target)
	{
		return default;
	}

	public void Move2Node(ActionWork.MapNode node, float distance, int approachFrame, ActionWork.AnimationCurve curveType)
	{
	}

	[IteratorStateMachine(typeof(_003C_Move2Node_003Ed__83))]
	private IEnumerator _Move2Node(ActionWork.MapNode node, float distance, int approachFrame, ActionWork.AnimationCurve curveType)
	{
		return null;
	}

	public void ChangeForward(ActionWork.MapNode node, int frame)
	{
	}

	public void ReturnForward(int frame)
	{
	}

	public void LookHomePosition(int frame = 5)
	{
	}

	private void Update()
	{
	}

	public void SetAction()
	{
	}

	public bool IsActionEnd()
	{
		return false;
	}

	public override void DelUsingSkill()
	{
	}

	private void UpdateAction()
	{
	}

	public virtual Vector3 GetPedestalHeight(bool scale)
	{
		return default;
	}

	public virtual void SetWorldPosition(Vector3 position)
	{
	}

	protected void AddParticleForceField()
	{
	}

	public void PlayStartupEffect(Transform parent)
	{
	}

	[IteratorStateMachine(typeof(_003C_PlayStartupEffect_003Ed__98))]
	protected virtual IEnumerator _PlayStartupEffect(Transform parent)
	{
		return null;
	}

	public CEffectHandle PlayEffect(string path, Transform parent, Vector3 position, bool async = false, bool autoDeath = true, bool autoPlay = true)
	{
		return null;
	}

	public override void PlayBtlIdle()
	{
	}

	public Coroutine PlayEscapeAnime()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003C_PlayEscapeAnime_003Ed__102))]
	private IEnumerator _PlayEscapeAnime()
	{
		return null;
	}

	public void AddLocalTurnCount()
	{
	}

	public void AddActTurnCount()
	{
	}

	public void ResetLocalTurnCount()
	{
	}

	public bool IsLastLocalTrun()
	{
		return false;
	}

	public void ActAbilityHpLE()
	{
	}

	protected override void OnValidate()
	{
	}

	public virtual Dictionary<string, object> Save(Dictionary<string, object> i_Dict)
	{
		return null;
	}

	public virtual void Load(JsonNode i_JsonNode)
	{
	}
}
