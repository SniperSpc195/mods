using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using StUtility;

public static class CDebugDataCheck
{
	private class OrdinalIgnoreCaseComparer : IEqualityComparer<string>
	{
		public bool Equals(string a, string b)
		{
			return false;
		}

		public int GetHashCode(string str)
		{
			return 0;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDebugEffectTest_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Dictionary<string, HashSet<string>>> _003C_003Et__builder;

		private HashSet<string> _003CskillScripts_003E5__2;

		private HashSet<string> _003CcharaScripts_003E5__3;

		private CPack _003CpackSkill_003E5__4;

		private CPack _003CpackChara_003E5__5;

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

	[AsyncStateMachine(typeof(_003CDebugEffectTest_003Ed__0))]
	public static UniTask<Dictionary<string, HashSet<string>>> DebugEffectTest()
	{
		return default;
	}

	private static void GrabStringTable(Dictionary<string, HashSet<string>> stringTable, CPack pack, HashSet<string> actionTable)
	{
	}

	private static bool ValidUTF8Sequence(ReadOnlySpan<byte> data)
	{
		return false;
	}
}
