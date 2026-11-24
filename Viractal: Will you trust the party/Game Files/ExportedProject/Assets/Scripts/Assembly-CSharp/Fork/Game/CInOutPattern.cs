using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CInOutPattern
	{
		public enum State
		{
			In = 0,
			Out = 1,
			Stay = 2,
			Hide = 3
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CKeepPlaying_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CInOutPattern _003C_003E4__this;

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

		public static readonly int ImmediateShowKey;

		public static readonly int ImmediateHideKey;

		public static readonly int InKey;

		public static readonly int OutKey;

		public static readonly int StayKey;

		public static readonly int HideKey;

		protected Animator m_Animator;

		protected bool m_ForcePlaying;

		public static CInOutPattern MakeInOutPattern(GameObject g)
		{
			return null;
		}

		public CInOutPattern(Animator i_Animator)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void ImmediateShow()
		{
		}

		public void ImmediateHide()
		{
		}

		public bool IsIn()
		{
			return false;
		}

		public bool IsOut()
		{
			return false;
		}

		public bool IsPlaying()
		{
			return false;
		}

		public State GetState()
		{
			return State.In;
		}

		[AsyncStateMachine(typeof(_003CKeepPlaying_003Ed__19))]
		private UniTask KeepPlaying()
		{
			return default;
		}

		public void SetTrigger(int hash)
		{
		}

		public bool IsShow()
		{
			return false;
		}

		public void SetFastSpeedMode()
		{
		}
	}
}
