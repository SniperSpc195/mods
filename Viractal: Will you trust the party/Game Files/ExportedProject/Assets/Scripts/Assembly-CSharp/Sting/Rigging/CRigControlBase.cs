using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace Sting.Rigging
{
	[AddComponentMenu(null)]
	public class CRigControlBase : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetRigWeight_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CRigControlBase _003C_003E4__this;

			public float i_Weight;

			public CancellationToken i_Token;

			public float i_Time;

			private float _003Cstart_003E5__2;

			private double _003CstartTime_003E5__3;

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

		private CancellationTokenSource m_Cancel;

		public Rig m_Rig { get; private set; }

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public void SetRigActive(bool i_Active, float i_Time = 0f)
		{
		}

		[AsyncStateMachine(typeof(_003CSetRigWeight_003Ed__8))]
		private UniTask SetRigWeight(float i_Weight, float i_Time, CancellationToken i_Token)
		{
			return default;
		}
	}
}
