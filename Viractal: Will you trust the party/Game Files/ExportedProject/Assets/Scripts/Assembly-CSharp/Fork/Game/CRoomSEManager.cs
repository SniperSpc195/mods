using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CRoomSEManager : MonoBehaviour
	{
		[Serializable]
		public class CRoomSE
		{
			public string m_Name;

			public Transform m_Position;
		}

		private enum State
		{
			Play = 0,
			Stop = 1
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CRoomSEManager _003C_003E4__this;

			private int _003Ci_003E5__2;

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
		private CRoomSE[] m_RoomSETable;

		private State m_State;

		private CancellationTokenSource m_CancellationTokenSource;

		private long[] m_SeHandleTable;

		public static CRoomSEManager Instance { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void PlaySE()
		{
		}

		public static void StopSE()
		{
		}

		private void _PlaySE()
		{
		}

		[AsyncStateMachine(typeof(_003CPlayAsync_003Ed__15))]
		private UniTask PlayAsync(CancellationToken cancellationToken)
		{
			return default;
		}

		public void _StopSE()
		{
		}
	}
}
