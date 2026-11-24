using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;

public class CTurnStartMessenger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_PlayIn_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string playername;

		public CTurnStartMessenger _003C_003E4__this;

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
		public _003C_PlayIn_003Ed__10(int _003C_003E1__state)
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
	private sealed class _003C_PlayIn_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CFieldPlayer fp;

		public CTurnStartMessenger _003C_003E4__this;

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
		public _003C_PlayIn_003Ed__12(int _003C_003E1__state)
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
	private TextMeshProUGUI m_TextPlayerName;

	[SerializeField]
	private TextMeshProUGUI m_TextStartMessage;

	[SerializeField]
	private Animator m_Animator;

	private Coroutine m_InCoroutine;

	public CInOutPattern m_InOut { get; private set; }

	private void Awake()
	{
	}

	public void Play(string playername)
	{
	}

	[IteratorStateMachine(typeof(_003C_PlayIn_003Ed__10))]
	private IEnumerator _PlayIn(string playername)
	{
		return null;
	}

	public void Play(CFieldPlayer fp)
	{
	}

	[IteratorStateMachine(typeof(_003C_PlayIn_003Ed__12))]
	private IEnumerator _PlayIn(CFieldPlayer fp)
	{
		return null;
	}

	public void Hide()
	{
	}
}
