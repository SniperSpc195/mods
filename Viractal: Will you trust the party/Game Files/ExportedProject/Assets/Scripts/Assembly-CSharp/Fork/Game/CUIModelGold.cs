using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.ModelButtons;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/Gold")]
	public class CUIModelGold : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_MoveGold_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public float i_Time;

			public CUIModelGold _003C_003E4__this;

			public int i_Start;

			public int i_Value;

			public CancellationToken i_CancellationToken;

			private int _003Ci_003E5__2;

			private double _003CstartTime_003E5__3;

			private float _003Cip_003E5__4;

			private float _003CstartValue_003E5__5;

			private float _003CendValue_003E5__6;

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
		private CUIModelGoldColumn[] m_Columns;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIModelButton m_Button;

		private CancellationTokenSource m_CancellationTokenSource;

		private CUICharacterStatus m_Parent;

		private int m_Gold;

		private int[] m_BufferStart;

		private int[] m_BufferEnd;

		private void Awake()
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void SetParent(CUICharacterStatus i_Parent)
		{
		}

		public void SetValue(int i_Gold, float i_Time = 0f)
		{
		}

		private static float Nonliear(float i_Value)
		{
			return 0f;
		}

		private void SetValue(int i_Value)
		{
		}

		private void FillBuffer(int[] i_Buffer, int i_Value)
		{
		}

		[AsyncStateMachine(typeof(_003C_MoveGold_003Ed__15))]
		private UniTask _MoveGold(int i_Value, int i_Start, float i_Time, CancellationToken i_CancellationToken)
		{
			return default;
		}
	}
}
