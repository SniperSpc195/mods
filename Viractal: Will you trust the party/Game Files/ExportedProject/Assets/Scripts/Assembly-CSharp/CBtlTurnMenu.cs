using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CBtlTurnMenu : SingletonMonoBehaviour<CBtlTurnMenu>
{
	[Serializable]
	public struct Button
	{
		public Image m_ButtonIcon;

		public TextMeshProUGUI m_Text;

		public TextMeshProUGUI m_Cost;
	}

	private enum ButtonType
	{
		Item = 0,
		ReDraw = 1,
		Escape = 2
	}

	private enum InputSelectMenu
	{
		IsPressY = 0,
		IsPressL = 1,
		IsPressR = 2
	}

	private enum InputDpCommand
	{
		Escape = 0,
		ReDraw = 1,
		IsCancel = 2
	}

	private enum Seq
	{
		None = 0,
		SelectMenu = 1,
		ItemNgMessage = 2,
		ProcessItemMenu = 3,
		ProcessEscape = 4,
		ProcessReDraw = 5,
		ConfirmEscape = 6,
		ConfirmReDraw = 7
	}

	[CompilerGenerated]
	private sealed class _003CProcessItemMenu_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlTurnMenu _003C_003E4__this;

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
		public _003CProcessItemMenu_003Ed__26(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CProcessReDrawHandCards_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlTurnMenu _003C_003E4__this;

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
		public _003CProcessReDrawHandCards_003Ed__23(int _003C_003E1__state)
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
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private Button[] m_Button;

	[SerializeField]
	private Animator m_Animator;

	private CBattlePlayer m_BattlePlayer;

	private CInOutPattern m_InOut;

	private UnityAction m_OnStartShow;

	private int m_UsedCount;

	private CItem m_DecidedItem;

	private bool[] m_InputButton;

	private Seq m_Seq;

	private Coroutine m_ItemMenuCoroutine;

	public static void Setup(CBattlePlayer player)
	{
	}

	public static void Show()
	{
	}

	public static void Hide()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ToReDrawHandCards()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessReDrawHandCards_003Ed__23))]
	private IEnumerator ProcessReDrawHandCards()
	{
		return null;
	}

	public bool ToItemMenu()
	{
		return false;
	}

	private void StopItemMenuProcess()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessItemMenu_003Ed__26))]
	private IEnumerator ProcessItemMenu()
	{
		return null;
	}

	public bool IsInprocessDpCommand()
	{
		return false;
	}

	public bool IsInprocessItemMenu()
	{
		return false;
	}

	public void EnableItemMenu()
	{
	}

	public void DisableItemMenu()
	{
	}

	public void AddUsedCount()
	{
	}

	private bool IsUsableItem()
	{
		return false;
	}

	private void ResumeButtonColor()
	{
	}

	private int GetEscapeCost()
	{
		return 0;
	}

	private int GetRedrawCost()
	{
		return 0;
	}

	private bool IsRedraw()
	{
		return false;
	}

	private bool EmptyDeck()
	{
		return false;
	}

	public void SetupButtonUI()
	{
	}
}
