using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(ReflectionProbe))]
public class ReadbackReflectionProbe : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Render_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReflectionProbe i_ReflectionProbe;

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
		public _003C_Render_003Ed__1(int _003C_003E1__state)
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

	public void Render()
	{
	}

	[IteratorStateMachine(typeof(_003C_Render_003Ed__1))]
	private IEnumerator _Render(ReflectionProbe i_ReflectionProbe)
	{
		return null;
	}

	private void WriteHeader(BinaryWriter i_Writer, int i_Width, int i_Height)
	{
	}
}
