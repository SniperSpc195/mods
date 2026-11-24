using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	[RequireComponent(typeof(Animator))]
	public class CTurnIndependentAnimatorStep : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_SetEnd_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CTurnIndependentAnimatorStep _003C_003E4__this;

			private float _003Cstart_003E5__2;

			private float _003Cremain_003E5__3;

			private double _003CstartTime_003E5__4;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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

		private Animator m_Animator;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetEnd()
		{
		}

		[AsyncStateMachine(typeof(_003C_SetEnd_003Ed__4))]
		private UniTask _SetEnd()
		{
			return default;
		}
	}
}
