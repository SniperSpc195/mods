using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Fork.Game
{
	public class CUIStaffrollEnding : CUIStaffroll
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateUnit_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CMaster_StaffrollData i_Data;

			public CUIStaffrollEnding _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Prepare_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIStaffrollEnding _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			private CMaster_StaffrollData[] _003Calldata_003E5__2;

			private int _003Ci_003E5__3;

			private int _003Cfirst_003E5__4;

			private UniTask.Awaiter _003C_003Eu__1;

			private YieldAwaitable.Awaiter _003C_003Eu__2;

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

		private double m_EndingTime;

		private double m_CurrentTime;

		private double m_StartTime;

		private double m_PrepareTime;

		public static CUIStaffrollEnding Instance2 { get; private set; }

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Open(double i_Duration)
		{
		}

		public override void Close()
		{
		}

		public void SetCurrentTime(double i_Time, double i_Duration)
		{
		}

		private void CloseImmediate()
		{
		}

		[AsyncStateMachine(typeof(_003CCreateUnit_003Ed__14))]
		private UniTask CreateUnit(CMaster_StaffrollData i_Data)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_Prepare_003Ed__15))]
		private UniTask _Prepare(CancellationToken i_CancellationToken)
		{
			return default;
		}

		private void Update()
		{
		}
	}
}
