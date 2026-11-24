using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class FinalCameraDestroyer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Update_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public FinalCameraDestroyer _003C_003E4__this;

			private CancellationToken _003Ctoken_003E5__2;

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

		public static bool DestroyImmediateFlag;

		private Camera m_FieldCamera;

		private double m_StartTime;

		private void Awake()
		{
		}

		public void SetFieldCamera(Camera i_Camera)
		{
		}

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003C_Update_003Ed__6))]
		private UniTask _Update()
		{
			return default;
		}

		private void OnDestroy()
		{
		}
	}
}
