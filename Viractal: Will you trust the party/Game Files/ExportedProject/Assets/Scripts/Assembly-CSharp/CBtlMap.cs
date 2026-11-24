using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class CBtlMap : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadMapEffect_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlMap _003C_003E4__this;

		public string i_EffectPath;

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

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private Collider m_Collider;

	private static readonly int _HashIn;

	private static readonly int _HashOut;

	private static readonly int _HashInIdle;

	private static readonly int _HashOutIdle;

	private GameObject m_MapEffect;

	public string m_MapName;

	public string m_EffectName;

	public Animator GetAnimator => null;

	public Collider Collider => null;

	public Transform m_LookAt { get; private set; }

	public Transform m_CameraFollow { get; private set; }

	private void Awake()
	{
	}

	public void PlayIn()
	{
	}

	public void PlayInIdle()
	{
	}

	public void PlayOut()
	{
	}

	public void PlayOutIdle()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CLoadMapEffect_003Ed__27))]
	public UniTask LoadMapEffect(string i_EffectPath)
	{
		return default;
	}

	public void DeleteMapEffect()
	{
	}
}
