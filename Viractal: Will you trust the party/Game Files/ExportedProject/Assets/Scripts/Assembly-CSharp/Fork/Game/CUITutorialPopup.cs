using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	[DefaultExecutionOrder(1)]
	public class CUITutorialPopup : SingletonMonoBehaviour<CUITutorialPopup>
	{
		private enum State
		{
			Open = 0,
			Select = 1,
			Close = 2,
			None = 3
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COpenAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUITutorialPopup _003C_003E4__this;

			public GameController.PADNUM i_PadNum;

			public string[] i_HelpIDTable;

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
		private CInOutBehaviour m_InOut;

		[SerializeField]
		private CUIHelpDetail m_HelpDetail;

		[SerializeField]
		private TMP_Text m_TitleText;

		private State m_State;

		private List<string> m_Helps;

		private GameController.PADNUM m_PadNum;

		public static bool HaveSeen(string i_HelpID)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003COpenAsync_003Ed__1))]
		public UniTask OpenAsync(GameController.PADNUM i_PadNum, params string[] i_HelpIDTable)
		{
			return default;
		}

		private void Awake()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		[Obsolete("void Open( GameController.PADNUM i_PadNum, params string[] i_HelpIDTable ) を使用してください", true)]
		public void Open(params string[] i_HelpIDTable)
		{
		}

		public void Open(GameController.PADNUM i_PadNum, params string[] i_HelpIDTable)
		{
		}

		private void OpenFirst()
		{
		}

		private void Update()
		{
		}
	}
}
