using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/HandCard")]
	public class CUIHandCard : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public CSkillCardData card;

			internal bool _003CDrawCard_003Eb__3(CSkillCardData x)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDrawCard_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIHandCard _003C_003E4__this;

			public IList<CSkillCardData> i_OldCards;

			public int i_DeckRemain;

			public Action<int> i_OnDraw;

			public IList<CSkillCardData> i_NewCards;

			private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

			public int i_DeckCount;

			private CancellationToken _003CcancellationToken_003E5__2;

			private List<CSkillCardData> _003Ccurrent_003E5__3;

			private int _003CcurrentRemain_003E5__4;

			private int _003CcurrentHandCount_003E5__5;

			private bool _003Cfirst_003E5__6;

			private UniTask.Awaiter _003C_003Eu__1;

			private IEnumerator<CSkillCardData> _003C_003E7__wrap6;

			private UniTask<Texture>.Awaiter _003C_003Eu__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDropCard_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IList<CSkillCardData> i_NewCards;

			public IList<CSkillCardData> i_OldCards;

			public CUIHandCard _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			private DropCard _003Cdc_003E5__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRefill_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Action<int> i_OnDraw;

			public CUIHandCard _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			public int i_CardCount;

			private int _003Ci_003E5__2;

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

		private static readonly string SEDrawCard;

		[SerializeField]
		private Animator m_Animator;

		[SerializeField]
		private Renderer m_FlyingCardRenderer;

		[SerializeField]
		private ParentConstraint m_CardFocusConstraint;

		private MaterialPropertyBlock m_Property;

		private CInOutPattern m_InOut;

		private Transform m_Root;

		public float m_RadianScaler;

		private int m_CardCount;

		private static readonly int OpenParamID;

		private CancellationTokenSource m_CancellationTokenSource;

		private bool m_IsInAnimationTask;

		private bool? m_ShowAnimationEnd;

		public CUICharacterStatus m_StatusUI;

		private bool m_IsFocus;

		private float m_AnimatorBaseSpeed;

		private float m_GameSpeed;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetStatusUI(CUICharacterStatus i_StatusUI)
		{
		}

		public void SetValues(IList<CSkillCardData> i_Cards)
		{
		}

		private void Update()
		{
		}

		public void SetFocus(bool i_IsFocus)
		{
		}

		private void LateUpdate()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void UpdateAngles()
		{
		}

		[AsyncStateMachine(typeof(_003CDrawCard_003Ed__27))]
		public UniTask DrawCard(IList<CSkillCardData> i_OldCards, IList<CSkillCardData> i_NewCards, int i_DeckCount, int i_DeckRemain, Action<int> i_OnDraw)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CRefill_003Ed__28))]
		private UniTask Refill(int i_CardCount, Action<int> i_OnDraw, CancellationToken i_CancellationToken)
		{
			return default;
		}

		public void CancelDrawCards()
		{
		}

		public void SetTimeSavingMode(bool i_Enabled)
		{
		}

		[AsyncStateMachine(typeof(_003CDropCard_003Ed__31))]
		public UniTask DropCard(IList<CSkillCardData> i_OldCards, IList<CSkillCardData> i_NewCards, CancellationToken i_CancellationToken)
		{
			return default;
		}
	}
}
