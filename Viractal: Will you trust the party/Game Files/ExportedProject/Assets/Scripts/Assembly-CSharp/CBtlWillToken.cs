using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;

public class CBtlWillToken : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CHide_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlWillToken _003C_003E4__this;

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
	private Animator m_Animator;

	private CInOutPattern m_InOutPattern;

	private CEffectHandle m_SelectingEffect;

	private float m_GameSpeed;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Show()
	{
	}

	[AsyncStateMachine(typeof(_003CHide_003Ed__7))]
	public UniTask Hide(CancellationToken i_Cancel)
	{
		return default;
	}

	public void PlaySelecting()
	{
	}

	public void StopSelecting()
	{
	}
}
