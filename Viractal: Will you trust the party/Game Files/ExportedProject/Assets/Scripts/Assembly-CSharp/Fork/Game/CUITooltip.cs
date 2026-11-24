using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cysharp.Text;
using Sting.UIComponents;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUITooltip : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_SetPivotLater_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CUITooltip _003C_003E4__this;

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
			public _003C_SetPivotLater_003Ed__42(int _003C_003E1__state)
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
		protected TMP_Text m_TextArea;

		[SerializeField]
		private VariableBaloon m_Pivot;

		[SerializeField]
		public float m_MinWidth;

		[SerializeField]
		public float m_MaxWidth;

		[SerializeField]
		private LayoutElement m_LayoutElement;

		private Vector2 m_BackupWidth;

		private LayoutElement m_LayoutElementText;

		private VariableBaloon[] m_VariableBaloons;

		public CInOutPattern m_InOut { get; private set; }

		public UnityEvent onDecide { get; private set; }

		public UnityEvent onCancel { get; private set; }

		public bool m_SelifFlip
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float m_BallonPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		public virtual void SetFixedWidth(float i_Width)
		{
		}

		public virtual void SetText(string i_Text)
		{
		}

		public virtual void SetTextSize(float i_TextSize)
		{
		}

		public virtual void SetText(Utf16ValueStringBuilder i_StringBuilder)
		{
		}

		public string GetText()
		{
			return null;
		}

		public void RemoveAllListeners()
		{
		}

		public virtual void OnReturnToPool()
		{
		}

		private void PreparePreferredWidth()
		{
		}

		private void SetPreferredWidth()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void SetPivot()
		{
		}

		private void SetPivotLater()
		{
		}

		[IteratorStateMachine(typeof(_003C_SetPivotLater_003Ed__42))]
		private IEnumerator _SetPivotLater()
		{
			return null;
		}
	}
}
