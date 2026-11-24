using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CBattlePlayer : CBattleCharDef
{
	public enum ResurrectionSeq
	{
		Main = 0,
		WhiteOut = 1,
		Position = 2,
		Angle = 3,
		_Max = 4
	}

	public enum DeadSeq
	{
		Main = 0,
		WhiteOut = 1,
		ScaleHalf = 2,
		ColorResume = 3,
		_Max = 4
	}

	[CompilerGenerated]
	private sealed class _003CDeadSeqColorResume_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private int _003Cmax_003E5__2;

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
		public _003CDeadSeqColorResume_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CDeadSeqScaleHalf_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private int _003Cmax_003E5__2;

		private AnimationCurve _003Ccurve_003E5__3;

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
		public _003CDeadSeqScaleHalf_003Ed__61(int _003C_003E1__state)
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
	private sealed class _003CDeadSeqWhiteOut_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private int _003Cmax_003E5__2;

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
		public _003CDeadSeqWhiteOut_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CPlayResurrectionAnime_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private float _003Cvtime_003E5__2;

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
		public _003CPlayResurrectionAnime_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CResurrectionSeqAngle_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

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
		public _003CResurrectionSeqAngle_003Ed__48(int _003C_003E1__state)
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
	private sealed class _003CResurrectionSeqColorResume_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private int _003Cmax_003E5__2;

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
		public _003CResurrectionSeqColorResume_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CResurrectionSeqLanding_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

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
		public _003CResurrectionSeqLanding_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CResurrectionSeqPosition_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private Vector3 _003Cstart_003E5__2;

		private Vector3 _003Cgoal_003E5__3;

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
		public _003CResurrectionSeqPosition_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CResurrectionSeqScale_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private int _003Cmax_003E5__2;

		private Vector3 _003Cpre_003E5__3;

		private AnimationCurve _003Ccurve_003E5__4;

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
		public _003CResurrectionSeqScale_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CResurrectionSeqWhiteOut_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

		private int _003Cmax_003E5__2;

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
		public _003CResurrectionSeqWhiteOut_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003C_PlayDeadAnime_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool i_Immediate;

		public CBattlePlayer _003C_003E4__this;

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
		public _003C_PlayDeadAnime_003Ed__58(int _003C_003E1__state)
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
	private sealed class _003C_StartLookCamera_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattlePlayer _003C_003E4__this;

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
		public _003C_StartLookCamera_003Ed__69(int _003C_003E1__state)
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

	public const float DeadScale = 0.25f;

	public GameController.PADNUM mPadNum;

	public CMaster_CharJobData mJob;

	public CParamPlayer mParam;

	public Rigidbody m_Rigidbody;

	public CConfigData.SortHandCard? m_SortHandCard;

	public int m_NextDrawCount;

	private GameObject mExecArrow;

	public List<uint> m_FrozenCardUIDs;

	public List<uint> m_CurseCardUIDs;

	public List<uint> m_ProhibitCardUIDs;

	public bool m_IsDamagedEvenOnce;

	public bool m_IsUsedItemEvenOnce;

	private int m_ResurrectionSeq;

	private int m_VibTime;

	private float m_VibPow;

	private Vector3[] m_ResurrectionStartPosition;

	private Vector3[] m_ResurrectionGoalPosition;

	private Vector3[] m_ResurrectionStartAngle;

	private Vector3[] m_ResurrectionGoalAngle;

	private float m_ResurrectionTime;

	private float m_DeadTime;

	private Coroutine m_StartLookCamera;

	public Coroutine[] m_ResurrectionCoroutine { get; private set; }

	public Coroutine[] m_DeadCoroutine { get; private set; }

	public override CParamDef GetParam()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	public override string ID()
	{
		return null;
	}

	public override string Name()
	{
		return null;
	}

	public void SetParam(CParamPlayer i_Param, Rigidbody i_Rigidbody)
	{
	}

	public void Setup(CFieldPlayer fp)
	{
	}

	public void Setup(CMaster_CharJobData job)
	{
	}

	public override void ReloadActionScript()
	{
	}

	private void Start()
	{
	}

	public void SetActiveArrow(bool a)
	{
	}

	protected override void LateUpdate()
	{
	}

	public override Vector3 GetPedestalHeight(bool scale)
	{
		return default;
	}

	public override void SetWorldPosition(Vector3 position)
	{
	}

	public override GameController.PADNUM GetPadNum()
	{
		return GameController.PADNUM.PAD0;
	}

	public void Resurrection(int hp)
	{
	}

	public bool IsPlayingResurrection()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CPlayResurrectionAnime_003Ed__42))]
	private IEnumerator PlayResurrectionAnime()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResurrectionSeqWhiteOut_003Ed__43))]
	private IEnumerator ResurrectionSeqWhiteOut()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResurrectionSeqScale_003Ed__44))]
	private IEnumerator ResurrectionSeqScale()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResurrectionSeqColorResume_003Ed__45))]
	private IEnumerator ResurrectionSeqColorResume()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResurrectionSeqLanding_003Ed__46))]
	private IEnumerator ResurrectionSeqLanding()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResurrectionSeqPosition_003Ed__47))]
	private IEnumerator ResurrectionSeqPosition()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResurrectionSeqAngle_003Ed__48))]
	private IEnumerator ResurrectionSeqAngle()
	{
		return null;
	}

	public override void PlayDeadAnime(Vector3? vecForce = null)
	{
	}

	public void PlayDeadAnimeImmediate()
	{
	}

	public bool IsPlayingDeadAnime()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003C_PlayDeadAnime_003Ed__58))]
	private IEnumerator _PlayDeadAnime(bool i_Immediate)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDeadSeqWhiteOut_003Ed__59))]
	private IEnumerator DeadSeqWhiteOut()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDeadSeqColorResume_003Ed__60))]
	private IEnumerator DeadSeqColorResume()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDeadSeqScaleHalf_003Ed__61))]
	private IEnumerator DeadSeqScaleHalf()
	{
		return null;
	}

	public override void ResetKinect(string name)
	{
	}

	public override void ResetRigidBody()
	{
	}

	public override void PlayBtlIdle()
	{
	}

	public void LookCamera()
	{
	}

	public void StartLookCamera()
	{
	}

	public void StopLookCamera()
	{
	}

	[IteratorStateMachine(typeof(_003C_StartLookCamera_003Ed__69))]
	private IEnumerator _StartLookCamera()
	{
		return null;
	}

	public void ActHandCardsEffectTurnStart()
	{
	}

	public void SendParam()
	{
	}

	public bool ReceiveParam()
	{
		return false;
	}

	public override Dictionary<string, object> Save(Dictionary<string, object> i_Dict)
	{
		return null;
	}

	public override void Load(JsonNode i_JsonNode)
	{
	}
}
