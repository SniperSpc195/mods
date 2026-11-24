using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUIStaffrollPicture : StaffrollComponent
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPrepare_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIStaffrollPicture _003C_003E4__this;

			private CancellationToken _003Ctoken_003E5__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_SetValue_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIStaffrollPicture _003C_003E4__this;

			public string i_ImageAddress;

			private CancellationToken _003Ctoken_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private AsyncOperationHandle<Texture2D> _003Ctexture_003E5__3;

			private UniTask<Texture2D>.Awaiter _003C_003Eu__2;

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
		private RawImage m_Picture;

		private bool m_Prepared;

		public bool Prepared => false;

		[AsyncStateMachine(typeof(_003CPrepare_003Ed__4))]
		public UniTask Prepare()
		{
			return default;
		}

		public override void SetValue(CMaster_StaffrollData i_Data, CUIStaffroll i_Parent)
		{
		}

		[AsyncStateMachine(typeof(_003C_SetValue_003Ed__6))]
		private UniTask _SetValue(string i_ImageAddress)
		{
			return default;
		}
	}
}
