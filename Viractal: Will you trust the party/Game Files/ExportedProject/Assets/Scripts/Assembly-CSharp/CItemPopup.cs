using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fork.Game;
using UnityEngine;

public class CItemPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Play_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CItemPopup _003C_003E4__this;

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
		public _003C_Play_003Ed__9(int _003C_003E1__state)
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
	private Animator m_Animator;

	[SerializeField]
	private SpriteRenderer m_Icon;

	[SerializeField]
	private Transform m_Billboard;

	private Camera m_Camera;

	private CInOutPattern m_InOut;

	private float m_GameSpeed;

	public CInOutPattern InOut => null;

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003C_Play_003Ed__9))]
	private IEnumerator _Play()
	{
		return null;
	}

	public void Play()
	{
	}

	public void Play(Sprite icon)
	{
	}
}
