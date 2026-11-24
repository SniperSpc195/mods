using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.ModelButtons;
using UnityEngine;
using UnityEngine.Pool;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/ConditionHolder")]
	public class CUICharacterStatusConditionHolder : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public CUiCharacterStatusCondition latestComponent;

			internal bool _003C_SetValuesAnimate_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_SetValuesAnimate_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatusConditionHolder _003C_003E4__this;

			private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

			public List<CParamCondition> i_Conditions;

			public CancellationToken i_CancellationToken;

			private int _003Cindex_003E5__2;

			private PooledObject<List<GameObject>> _003Clp_003E5__3;

			private List<GameObject> _003CgoPool_003E5__4;

			private int _003Ci_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;

			private YieldAwaitable.Awaiter _003C_003Eu__2;

			private List<CParamCondition>.Enumerator _003C_003E7__wrap5;

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
		private Transform m_Root;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		private CUICharacterStatusGroup m_Parent;

		private CUICharacterStatus m_Status;

		private CancellationTokenSource m_CancellationTokenSource;

		private bool m_TooltipBottomMode;

		private int m_MaxButtonCount;

		private void Awake()
		{
		}

		public void SetParent(CUICharacterStatusGroup i_Parent, CUICharacterStatus i_Character)
		{
		}

		private void OnDestroy()
		{
		}

		public void SetTooltipForEnemy()
		{
		}

		public void SetValues(List<CParamCondition> i_Conditions)
		{
		}

		public void SetValuesAnimate(List<CParamCondition> i_Conditions)
		{
		}

		[AsyncStateMachine(typeof(_003C_SetValuesAnimate_003Ed__13))]
		private UniTask _SetValuesAnimate(List<CParamCondition> i_Conditions, CancellationToken i_CancellationToken)
		{
			return default;
		}

		public CUiCharacterStatusCondition GetConditionByInedex(int i_Index)
		{
			return null;
		}
	}
}
