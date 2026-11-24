using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUIIngameStamp : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Play_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIIngameStamp _003C_003E4__this;

			public CancellationToken token;

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
		private RawImage m_StampImage;

		[SerializeField]
		private Animator m_Animator;

		private CInOutPattern m_InOut;

		private CancellationTokenSource m_CancellationTokenSource;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetImage(Texture2D i_StampImage)
		{
		}

		public void Terminate()
		{
		}

		[AsyncStateMachine(typeof(_003C_Play_003Ed__8))]
		private UniTask _Play(CancellationToken token)
		{
			return default;
		}
	}
}
