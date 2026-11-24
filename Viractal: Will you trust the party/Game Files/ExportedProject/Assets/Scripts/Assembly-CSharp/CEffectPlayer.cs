using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Playables;

public class CEffectPlayer : MonoBehaviour
{
	private struct LightParam
	{
		public Light light;

		public float range;

		public float intensity;

		public float scale;
	}

	[Serializable]
	private class LoopMonitor
	{
		[SerializeField]
		[ReadOnly]
		private ParticleSystem mPs;

		[SerializeField]
		[ReadOnly]
		private int mCount;

		[SerializeField]
		[ReadOnly]
		private float mTime;

		private int mCheckCount;

		public LoopMonitor(ParticleSystem ps)
		{
		}

		public void Check()
		{
		}

		public int GetCount()
		{
			return 0;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStopNaturally_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CEffectPlayer _003C_003E4__this;

		public CancellationToken i_Cancel;

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

	[SerializeField]
	[ReadOnly]
	private ParticleSystem[] mAllParticle;

	private ParticleSystem mParticle;

	[SerializeField]
	[ReadOnly]
	private List<ParticleSystem> mLoopParticle;

	[SerializeField]
	[ReadOnly]
	private PlayableDirector mPlayableDirector;

	[SerializeField]
	[ReadOnly]
	private CEffectState.STAT mStatTimeline;

	private LightParam[] m_Lights;

	[SerializeField]
	private LoopMonitor mLoopMonitor;

	[SerializeField]
	[ReadOnly]
	private CEffectState mState;

	private CEffectHandle mEffectHandle;

	private long mZeroParticleTime;

	public PositionConstraint mPositionConstraint { get; private set; }

	public ScaleConstraint mScaleConstraint { get; private set; }

	public RotationConstraint mRotationConstraint { get; private set; }

	public CEffectPartcilePosition mPartcilePosition { get; private set; }

	public bool IsTimeline()
	{
		return false;
	}

	public void SetState(CEffectState s)
	{
	}

	public void SetEffectHandle(CEffectHandle h)
	{
	}

	public bool IsLoop()
	{
		return false;
	}

	public bool IsPlay()
	{
		return false;
	}

	public bool IsStop()
	{
		return false;
	}

	public bool IsPause()
	{
		return false;
	}

	public bool IsParticleZero()
	{
		return false;
	}

	public float GetTime()
	{
		return 0f;
	}

	public int GetParticleCount()
	{
		return 0;
	}

	public int GetLoopCount()
	{
		return 0;
	}

	public void mLoopOff()
	{
	}

	private void Awake()
	{
	}

	private void DisableLoop(ParticleSystem[] particles)
	{
	}

	private void GetLoopParticle()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void Play()
	{
	}

	public void Play(CEffectState s)
	{
	}

	private void Stop_Particle()
	{
	}

	private void Stop_Timeline()
	{
	}

	public void Stop()
	{
	}

	[AsyncStateMachine(typeof(_003CStopNaturally_003Ed__50))]
	public UniTask StopNaturally(CancellationToken i_Cancel)
	{
		return default;
	}

	public void Pause()
	{
	}

	private void SetSpeed_Particle()
	{
	}

	private void SetSpeed_Timeline()
	{
	}

	public void AddComponentPositionConstraint(Transform source)
	{
	}

	public void AddComponentScaleConstraint(Transform source)
	{
	}

	public void AddComponentRotationConstraint(Transform source)
	{
	}

	public void EnableForceFiled(UnityAction<Vector3, CSkill> hitEvent, CSkill skill, ParticleSystemForceField influenceForceField, LayerMask influenceLayerMask, params Collider[] colliders)
	{
	}

	private void _EnableForceFiled(ParticleSystem ps, ParticleSystem.ExternalForcesModule ef, UnityAction<Vector3, CSkill> hitEvent, CSkill skill, ParticleSystemForceField influenceForceField, LayerMask influenceLayerMask, params Collider[] colliders)
	{
	}

	public void SetTriggerCallback(UnityAction<Vector3, CSkill> hitEvent, CSkill skill, params Collider[] colliders)
	{
	}
}
