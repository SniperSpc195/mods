using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/ModelStatus/Turn")]
	public class CUITurn : CInOutBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDelayHide_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken token;

			public CUITurn _003C_003E4__this;

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
		private struct _003CDelayShow_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken token;

			public CUITurn _003C_003E4__this;

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

		private static readonly string SETurnChange;

		[SerializeField]
		private Animator m_BodyAnimator;

		[SerializeField]
		private Animator m_PhisicsAnimator;

		[SerializeField]
		private CRigidbodyKnocker m_RigidbodyKnocker;

		[SerializeField]
		private MeshRenderer m_MaxTurnRenderer;

		[SerializeField]
		private CUIModelGoldColumn[] m_Columns;

		[SerializeField]
		private CUICharacterStatusGroup m_CharacterStatusGroup;

		private int m_Turn;

		private int m_LimitTurn;

		private int[] m_BufferStart;

		private int[] m_BufferEnd;

		private CInOutPattern m_BodyInOut;

		private CInOutPattern m_PhisicsInOut;

		private MaterialPropertyBlock m_Properties;

		private static Color m_FadeColor;

		private CRigidbodyKnockerHandler m_RigidbodyFixer;

		private CancellationTokenSource m_CancellationTokenSource;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void Show()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayShow_003Ed__20))]
		private UniTask DelayShow(CancellationToken token)
		{
			return default;
		}

		public override void Hide()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayHide_003Ed__22))]
		private UniTask DelayHide(CancellationToken token)
		{
			return default;
		}

		public override void ImmediateShow()
		{
		}

		public override void ImmediateHide()
		{
		}

		public override bool IsIn()
		{
			return false;
		}

		public override bool IsOut()
		{
			return false;
		}

		public override bool IsPlaying()
		{
			return false;
		}

		public override bool IsShow()
		{
			return false;
		}

		public override CInOutPattern.State GetState()
		{
			return CInOutPattern.State.In;
		}

		public void UpdateValue(int i_Turn)
		{
		}

		public void SetMaxTurn(int i_MaxTurn)
		{
		}

		public void SetLimitTurn(int i_LimitTurn)
		{
		}

		private void SetValue(int i_Value)
		{
		}

		private void FillBuffer(int[] i_Buffer, int i_Value)
		{
		}

		private static void WarningOn(MaterialPropertyBlock i_Porps)
		{
		}

		private static void WarningOff(MaterialPropertyBlock i_Porps)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
