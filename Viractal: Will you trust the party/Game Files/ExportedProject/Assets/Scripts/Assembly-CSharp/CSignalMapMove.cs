using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CSignalMapMove : CSignalCallback
{
	[CompilerGenerated]
	private sealed class _003C_Move_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CSignalMapMove _003C_003E4__this;

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
		public _003C_Move_003Ed__6(int _003C_003E1__state)
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

	private CBtlMap m_BtlMap;

	private Vector3 m_Src;

	private Vector3 m_Dest;

	private float m_Time;

	public void Setup(CBtlMap i_BtlMap, Vector3 i_Src, Vector3 i_Dest)
	{
	}

	private void Move()
	{
	}

	[IteratorStateMachine(typeof(_003C_Move_003Ed__6))]
	private IEnumerator _Move()
	{
		return null;
	}
}
