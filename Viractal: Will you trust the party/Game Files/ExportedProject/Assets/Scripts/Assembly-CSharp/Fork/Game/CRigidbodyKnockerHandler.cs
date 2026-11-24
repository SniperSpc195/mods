using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CRigidbodyKnockerHandler
	{
		private struct LocalMatrix
		{
			public Vector3 m_Position;

			public Quaternion m_Rotation;

			public LocalMatrix(Transform t)
			{
				m_Position = default;
				m_Rotation = default;
			}

			public void Apply(Transform t)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnIrregularPosition_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CRigidbodyKnockerHandler _003C_003E4__this;

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

		private CInOutPattern m_InOut;

		private Rigidbody[] m_AllRigidbodies;

		private Dictionary<int, LocalMatrix> m_StoredRigidbodyMatrix;

		private bool m_OnIrregularPosition;

		public CRigidbodyKnockerHandler(CRigidbodyKnocker i_Knocker, CInOutPattern i_InOutPattern, Rigidbody[] i_ChainBody)
		{
		}

		public void Clear()
		{
		}

		private void OnRequestFixPositions()
		{
		}

		public void LateUpdate()
		{
		}

		[AsyncStateMachine(typeof(_003COnIrregularPosition_003Ed__9))]
		private UniTask OnIrregularPosition()
		{
			return default;
		}
	}
}
