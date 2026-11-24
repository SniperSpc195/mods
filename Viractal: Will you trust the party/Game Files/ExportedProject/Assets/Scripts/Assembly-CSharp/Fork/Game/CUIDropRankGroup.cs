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
	[AddComponentMenu("Fork/CharacterStatus/DropRankGroup")]
	public class CUIDropRankGroup : MonoBehaviour
	{
		public enum Type
		{
			Skill = 0,
			Item = 1,
			Tag = 2,
			Gold = 3,
			Count = 4
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public CUIDropRankGroup _003C_003E4__this;

			public int i_Skill;

			public float i_Time;

			public CancellationToken i_CancellationToken;

			public int i_Item;

			public int i_Tag;

			public int i_Gold;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_SetValue_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIDropRankGroup _003C_003E4__this;

			public int i_Skill;

			public float i_Time;

			public CancellationToken i_CancellationToken;

			public int i_Item;

			public int i_Tag;

			public int i_Gold;

			private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

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
		private struct _003C_SetValue_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int i_Value;

			public float i_Time;

			public CUIDropRankGroup _003C_003E4__this;

			public bool i_IsUp;

			public CUIModelDroprankColumn i_Column;

			public CancellationToken i_CancellationToken;

			private float _003Cstart_003E5__2;

			private float _003Cend_003E5__3;

			private double _003Ct_003E5__4;

			private float _003Cip_003E5__5;

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

		private static readonly string SEDropRankUp;

		private static readonly string SEDropRankDown;

		[SerializeField]
		private CUIModelDroprankColumn[] m_Columns;

		[SerializeField]
		private MeshRenderer[] m_HighlightRenderers;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		private CancellationTokenSource m_CancellationTokenSource;

		private int[] m_ColumnValue;

		private CUICharacterStatus m_Parent;

		private void Awake()
		{
		}

		public void SetParent(CUICharacterStatus i_Parent)
		{
		}

		public void SetValues(int i_Skill, int i_Item, int i_Tag, int i_Gold, float i_Time = 0f)
		{
		}

		[AsyncStateMachine(typeof(_003C_SetValue_003Ed__12))]
		private UniTask _SetValue(int i_Skill, int i_Item, int i_Tag, int i_Gold, float i_Time, CancellationToken i_CancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_SetValue_003Ed__13))]
		private UniTask _SetValue(bool i_IsUp, CUIModelDroprankColumn i_Column, int i_Value, float i_Time, CancellationToken i_CancellationToken)
		{
			return default;
		}
	}
}
