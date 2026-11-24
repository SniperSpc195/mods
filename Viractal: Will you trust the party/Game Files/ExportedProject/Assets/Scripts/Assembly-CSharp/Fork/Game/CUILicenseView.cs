using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUILicenseView : MonoBehaviour
	{
		private enum State
		{
			None = 0,
			Open = 1,
			View = 2,
			Close = 3
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPrepare_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUILicenseView _003C_003E4__this;

			public CancellationToken i_CancellationToken;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShow_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUILicenseView _003C_003E4__this;

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
		private Licenses m_Licenses;

		[SerializeField]
		private CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		private RectTransform m_ContentRoot;

		[SerializeField]
		private ScrollRect m_ScrollRect;

		[SerializeField]
		private TMP_Text m_HeaderText;

		[SerializeField]
		private CanvasGroup m_CanvasGroup;

		private bool m_Prepared;

		private State m_State;

		private float m_Tick;

		private float m_Page;

		private float m_NormalizedMin;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CPrepare_003Ed__14))]
		private UniTask Prepare(CancellationToken i_CancellationToken = default(CancellationToken))
		{
			return default;
		}

		public bool IsPrepared()
		{
			return false;
		}

		public bool IsActive()
		{
			return false;
		}

		public void Active()
		{
		}

		public void Close()
		{
		}

		[AsyncStateMachine(typeof(_003CShow_003Ed__19))]
		public UniTask Show()
		{
			return default;
		}

		private void Update()
		{
		}

		private void UpdateView()
		{
		}
	}
}
