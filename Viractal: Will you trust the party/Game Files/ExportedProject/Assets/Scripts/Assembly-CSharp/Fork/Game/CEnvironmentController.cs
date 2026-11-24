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
	public class CEnvironmentController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Wakeup_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Func<bool> i_Condition;

			public CancellationToken i_CancellationToken;

			public float i_WakeupTimeSeconds;

			public CEnvironmentController _003C_003E4__this;

			private double _003CstartTime_003E5__2;

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

		[SerializeField]
		private ReflectionProbe m_RefrectionProbe;

		[SerializeField]
		private Light[] m_Lights;

		private float m_BackupReflectionProbeIntensity;

		private float[] m_BackupLightIntensities;

		private void Awake()
		{
		}

		public void SetLightIntensity(Light i_Light, float i_Intensity)
		{
		}

		public void Wakeup(Func<bool> i_Condition, float i_WakeupTimeSeconds)
		{
		}

		[AsyncStateMachine(typeof(_003C_Wakeup_003Ed__7))]
		private UniTask _Wakeup(Func<bool> i_Condition, float i_WakeupTimeSeconds, CancellationToken i_CancellationToken)
		{
			return default;
		}
	}
}
