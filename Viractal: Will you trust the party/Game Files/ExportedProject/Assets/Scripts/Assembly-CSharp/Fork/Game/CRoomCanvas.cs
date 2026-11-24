using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CRoomCanvas : SingletonMonoBehaviour<CRoomCanvas>
	{
		[CompilerGenerated]
		private sealed class _003C_ActiveBlurCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool i_Switch;

			public CRoomCanvas _003C_003E4__this;

			private float _003Ccurrent_003E5__2;

			private float _003Cstep_003E5__3;

			private bool _003Cend_003E5__4;

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
			public _003C_ActiveBlurCoroutine_003Ed__19(int _003C_003E1__state)
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
		private COutgameOptionMenu m_OptionMenu;

		[SerializeField]
		private CUIGenericOpenClose m_ExplainButton;

		[SerializeField]
		private CUIGenericFocus m_OptionButtonFocus;

		[SerializeField]
		private CUIGenericButtonGuide m_ButtonGuide;

		[SerializeField]
		private CEventMessage m_GMMessage;

		[SerializeField]
		private CanvasGroup m_RoomBlur;

		private bool m_MayBlurActive;

		private Coroutine m_BlurCoroutine;

		private bool m_Ready;

		public bool IsStartDone()
		{
			return false;
		}

		public static COutgameOptionMenu GetOptionMenu()
		{
			return null;
		}

		public static CUIGenericButtonGuide GetButtonGuide()
		{
			return null;
		}

		public static bool IsOptionButtonDown()
		{
			return false;
		}

		public static void ShowGMMessage(string i_Text)
		{
		}

		public static void HideGMMessage()
		{
		}

		public static void ActiveBlur(bool i_Switch)
		{
		}

		public void ActiveExplainButton(bool i_Switch)
		{
		}

		private void Awake()
		{
		}

		private void _ActiveBlur(bool i_Switch)
		{
		}

		[IteratorStateMachine(typeof(_003C_ActiveBlurCoroutine_003Ed__19))]
		private IEnumerator _ActiveBlurCoroutine(bool i_Switch)
		{
			return null;
		}
	}
}
