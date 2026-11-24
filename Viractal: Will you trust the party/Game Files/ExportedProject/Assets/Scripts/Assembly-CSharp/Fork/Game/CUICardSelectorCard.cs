using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUICardSelectorCard : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_PlayDeleteEffect_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float i_Second;

			public CUICardSelectorCard _003C_003E4__this;

			private float _003Cerapsed_003E5__2;

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
			public _003C_PlayDeleteEffect_003Ed__32(int _003C_003E1__state)
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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Setup_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string i_CardID;

			public CancellationToken i_CancellationToken;

			public CUICardSelectorCard _003C_003E4__this;

			public bool i_SetRandomParam;

			private UniTask<Texture>.Awaiter _003C_003Eu__1;

			private RawImage _003C_003E7__wrap1;

			private UniTask<Material>.Awaiter _003C_003Eu__2;

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
		private RawImage m_CardImage;

		[SerializeField]
		private RawImage m_DeleteEffectMask;

		private Animator _animator;

		private CancellationTokenSource m_CardLoadCancellationTokenSource;

		private Coroutine m_CardDeleteCoroutine;

		private bool m_DeleteMode;

		public string ID { get; private set; }

		private Animator m_Animator => null;

		public bool m_UpgradeMode { get; private set; }

		private void OnDestroy()
		{
		}

		public void Active(bool i_Switch, bool i_Immediate = false)
		{
		}

		public void SetCard(string i_CardID)
		{
		}

		public void Setup(string i_CardID, bool i_SetRandomParam = true)
		{
		}

		[AsyncStateMachine(typeof(_003C_Setup_003Ed__21))]
		private UniTask _Setup(string i_CardID, CancellationToken i_CancellationToken, bool i_SetRandomParam = true)
		{
			return default;
		}

		public void ChangeBase()
		{
		}

		public bool ChangeUpgrade()
		{
			return false;
		}

		public void EnterDeleteMode()
		{
		}

		public void LeaveDeleteMode()
		{
		}

		public void OnEnable()
		{
		}

		public void SetUpgradable()
		{
		}

		public void SetDark()
		{
		}

		public void SetLight()
		{
		}

		public bool IsUpgradable()
		{
			return false;
		}

		public void PlayDeleteEffect(float i_Second)
		{
		}

		[IteratorStateMachine(typeof(_003C_PlayDeleteEffect_003Ed__32))]
		private IEnumerator _PlayDeleteEffect(float i_Second)
		{
			return null;
		}
	}
}
