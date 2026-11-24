using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUICharacterStatusVoicechatIcon : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_VCErrorFade_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CUICharacterStatusVoicechatIcon _003C_003E4__this;

			private double _003CstartTime_003E5__2;

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
			public _003C_VCErrorFade_003Ed__15(int _003C_003E1__state)
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
		private Transform m_VoiceIcon;

		[SerializeField]
		private GameObject m_NgIcon;

		[SerializeField]
		private SpriteRenderer m_GuideIcon;

		[SerializeField]
		private CUICharacterStatus m_Parent;

		private Animator m_FaceAnimator;

		[SerializeField]
		private TMP_Text m_ErrorText;

		[SerializeField]
		private GameObject m_RestrictedIcon;

		private const float m_ThreshouldRMSMin = -96f;

		private const float m_ThreshouldRMSMax = -24f;

		private Coroutine m_VCErrorEffectCoroutine;

		public void SetFaceAnimator(Animator i_Animator)
		{
		}

		public void UpdateButtonGuide(CCharDef i_GamepadHolder)
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Inactive()
		{
		}

		[IteratorStateMachine(typeof(_003C_VCErrorFade_003Ed__15))]
		private IEnumerator _VCErrorFade()
		{
			return null;
		}
	}
}
