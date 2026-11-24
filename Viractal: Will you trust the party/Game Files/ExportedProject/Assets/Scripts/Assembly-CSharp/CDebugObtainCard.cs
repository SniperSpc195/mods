using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;

public class CDebugObtainCard : SingletonMonoBehaviour<CDebugObtainCard>
{
	private enum InputButton
	{
		Ok = 0,
		Cancel = 1
	}

	private enum Seq
	{
		CreatePlayerSelector = 0,
		SelectPlayer = 1,
		CreateCardSelector = 2,
		WaitCreateCardSelector = 3,
		SelectCard = 4,
		ObtainCard = 5,
		Proc = 6
	}

	public enum Mode
	{
		None = 0,
		ObtainToDeck = 1,
		ObtainToHand = 2
	}

	private enum ObtainToDeckMenu
	{
		ObtainSave = 0
	}

	private enum ObtainToHandMenu
	{
		ObtainTemp = 0
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003CObtainCard_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass22_0 _003C_003E4__this;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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

		public CDebugObtainCard _003C_003E4__this;

		public CUICharacterStatus ui;

		[AsyncStateMachine(typeof(_003C_003CObtainCard_003Eb__0_003Ed))]
		internal UniTask _003CObtainCard_003Eb__0()
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAddScene_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CDebugObtainCard> _003C_003Et__builder;

		public Mode i_Mode;

		public CancellationToken i_Cancel;

		public CFieldPlayer i_Operator;

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

	[CompilerGenerated]
	private sealed class _003CObtainCard_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CDebugObtainCard _003C_003E4__this;

		public string i_CardId;

		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		private Utf16ValueStringBuilder _003Csb_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CObtainCard_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_ShowMessageInOut_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CDebugObtainCard _003C_003E4__this;

		public Utf16ValueStringBuilder i_Message;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_ShowMessageInOut_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private CScrollMenu m_PlayerSelectorMenu;

	[SerializeField]
	private CanvasGroup m_MessageCanvasGroup;

	[SerializeField]
	private TextMeshProUGUI m_Message;

	private CFieldPlayer m_Operator;

	private CFieldPlayer m_Obtainer;

	private bool[] m_InputButton;

	private bool m_ObtainCardTemp;

	private bool m_ObtainCardSave;

	private Seq m_Seq;

	private Mode m_Mode;

	private Dictionary<ObtainToDeckMenu, string> ObtainToDeckMenuName;

	private Dictionary<ObtainToHandMenu, string> ObtainToHandMenuName;

	private Coroutine m_ShowMessageCoroutine;

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	[AsyncStateMachine(typeof(_003CAddScene_003Ed__19))]
	public static UniTask<CDebugObtainCard> AddScene(CFieldPlayer i_Operator, Mode i_Mode, CancellationToken i_Cancel)
	{
		return default;
	}

	private void Setup(CFieldPlayer i_Operator, Mode i_Mode)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CObtainCard_003Ed__22))]
	private IEnumerator ObtainCard(string i_CardId)
	{
		return null;
	}

	private void Close()
	{
	}

	private void ShowMessage(string i_Message)
	{
	}

	private void ShowMessage(Utf16ValueStringBuilder i_Message)
	{
	}

	public void ShowMessageInOut(Utf16ValueStringBuilder i_Message)
	{
	}

	public bool IsShowMessage()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003C_ShowMessageInOut_003Ed__29))]
	private IEnumerator _ShowMessageInOut(Utf16ValueStringBuilder i_Message)
	{
		return null;
	}

	private void HideMessage()
	{
	}
}
