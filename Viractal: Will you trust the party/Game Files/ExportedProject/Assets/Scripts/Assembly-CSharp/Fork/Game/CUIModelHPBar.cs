using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.ModelButtons;
using Sting.ModelComponents;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/HPBar")]
	public class CUIModelHPBar : MonoBehaviour
	{
		private struct ColorRatio
		{
			public Color color;

			public float ratio;

			public ColorRatio(string const_define)
			{
				color = default;
				ratio = 0f;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_MoveText_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int i_Old;

			public int i_New;

			public TMP_Text i_TextComponent;

			public CancellationToken i_CancellationToken;

			private int _003Cframes_003E5__2;

			private int _003Ci_003E5__3;

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
		private struct _003C_MoveValue_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIModelHPBar _003C_003E4__this;

			public int i_OldBlock;

			public CancellationToken i_CancellationToken;

			public int i_OldValue;

			public float i_Time;

			private SizableRoundCube _003C_moveTarget_003E5__2;

			private Vector3 _003CstartSize_003E5__3;

			private Vector3 _003CendSize_003E5__4;

			private double _003CstartTime_003E5__5;

			private float _003Cip_003E5__6;

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

		private const float NormalMetallic = 0.12f;

		private const float NormalSmoothness = 0.76f;

		private const float ShieldMetallic = 1f;

		private const float ShieldSmoothness = 1f;

		[SerializeField]
		private SizableRoundCube m_InnerBlue;

		[SerializeField]
		private SizableRoundCube m_OuterRed;

		[SerializeField]
		private Vector3 m_MaxSize;

		[SerializeField]
		private Vector3 m_MinSize;

		[SerializeField]
		private TMP_Text m_HPText;

		[SerializeField]
		private CInOutBehaviour m_BlockInOut;

		[SerializeField]
		private TMP_Text m_BlockNumberText;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIModelButton m_Button;

		private CancellationTokenSource m_CancellationTokenSource;

		private Color m_InnerColor;

		private Color m_OuterColor;

		private CUICharacterStatus m_Parent;

		private static List<ColorRatio> _colorRarioTable;

		public int m_MaxValue { get; private set; }

		public int m_Value { get; private set; }

		public int m_Block { get; private set; }

		private static List<ColorRatio> ColorRatioTable => null;

		private void Awake()
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void SetParent(CUICharacterStatus i_Parent)
		{
		}

		private void SetBlockImmediate(int i_Block)
		{
		}

		public void SetColor(Color i_InnerColor, Color? i_OuterColor = null)
		{
		}

		public void Initialize(int i_Value, int i_Block, int i_MaxValue)
		{
		}

		public void SetMaxValue(int i_MaxValue)
		{
		}

		public void SetValue(int i_Value, int i_Block, float i_Time = 0f)
		{
		}

		private void SetText(float i_Value, float i_MaxValue)
		{
		}

		[AsyncStateMachine(typeof(_003C_MoveValue_003Ed__38))]
		private UniTask _MoveValue(int i_OldValue, int i_OldBlock, float i_Time, CancellationToken i_CancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_MoveText_003Ed__39))]
		private UniTask _MoveText(int i_Old, int i_New, TMP_Text i_TextComponent, CancellationToken i_CancellationToken)
		{
			return default;
		}

		private void CheckColor()
		{
		}
	}
}
