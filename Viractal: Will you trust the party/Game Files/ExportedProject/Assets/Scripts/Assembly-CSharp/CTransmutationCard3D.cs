using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class CTransmutationCard3D : MonoBehaviour
{
	public enum Kind
	{
		Fast = 0,
		Finish = 1
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetup_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CTransmutationCard3D _003C_003E4__this;

		public CTransmutationCard i_CardUI;

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
	private Kind m_Kind;

	[SerializeField]
	private MeshRenderer m_CardImage;

	[SerializeField]
	private SpriteRenderer m_IconImage;

	private MaterialPropertyBlock m_CardMaterialPropertyBlock;

	[AsyncStateMachine(typeof(_003CSetup_003Ed__5))]
	public UniTask Setup(CTransmutationCard i_CardUI)
	{
		return default;
	}
}
