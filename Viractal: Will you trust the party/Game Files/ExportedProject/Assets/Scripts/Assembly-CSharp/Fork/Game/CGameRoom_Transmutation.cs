using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Fork.Game
{
	public class CGameRoom_Transmutation : LwSingleton<CGameRoom_Transmutation>
	{
		private enum Seq
		{
			None = 0,
			Tutorial = 1,
			SelectCard = 2,
			InputChoice = 3,
			Execute = 4,
			DebugMenu = 5,
			DebugSave = 6
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass56_0
		{
			[StructLayout((LayoutKind)3)]
			private struct _003C_003CPlayTransmutateAnime_003Eb__0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				public _003C_003Ec__DisplayClass56_0 _003C_003E4__this;

				private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
			private struct _003C_003CPlayTransmutateAnime_003Eb__2_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				public _003C_003Ec__DisplayClass56_0 _003C_003E4__this;

				private CMaster_CharJobData _003CdataChr_003E5__2;

				private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
			private struct _003C_003CPlayTransmutateAnime_003Eb__3_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				public _003C_003Ec__DisplayClass56_0 _003C_003E4__this;

				private CMaster_EventObjectData _003CdataObject_003E5__2;

				private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
			private struct _003C_003CPlayTransmutateAnime_003Eb__4_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				public _003C_003Ec__DisplayClass56_0 _003C_003E4__this;

				private CMaster_MapStageData _003Cdata_003E5__2;

				private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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

			public CTransmutationCard i_TransmutationCard;

			public CGameRoom_Transmutation _003C_003E4__this;

			public PlayableDirector pd;

			[AsyncStateMachine(typeof(_003C_003CPlayTransmutateAnime_003Eb__2_003Ed))]
			internal UniTask _003CPlayTransmutateAnime_003Eb__2()
			{
				return default;
			}

			[AsyncStateMachine(typeof(_003C_003CPlayTransmutateAnime_003Eb__3_003Ed))]
			internal UniTask _003CPlayTransmutateAnime_003Eb__3()
			{
				return default;
			}

			[AsyncStateMachine(typeof(_003C_003CPlayTransmutateAnime_003Eb__4_003Ed))]
			internal UniTask _003CPlayTransmutateAnime_003Eb__4()
			{
				return default;
			}

			[AsyncStateMachine(typeof(_003C_003CPlayTransmutateAnime_003Eb__0_003Ed))]
			internal UniTask _003CPlayTransmutateAnime_003Eb__0()
			{
				return default;
			}

			internal bool _003CPlayTransmutateAnime_003Eb__1()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			public PlayableDirector pdClose;

			internal bool _003CDestroyDirection_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDestroyDirection_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CGameRoom_Transmutation _003C_003E4__this;

			public CTransmutationCard i_TransmutationCard;

			private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

			private CinemachineBrain _003Ccambrain_003E5__2;

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
			public _003CDestroyDirection_003Ed__57(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CExecuteTransmutation_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CGameRoom_Transmutation _003C_003E4__this;

			private int _003Ccursor_003E5__2;

			private string _003Cid_003E5__3;

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
			public _003CExecuteTransmutation_003Ed__54(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPlayTransmutateAnime_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CTransmutationCard i_TransmutationCard;

			public CGameRoom_Transmutation _003C_003E4__this;

			private _003C_003Ec__DisplayClass56_0 _003C_003E8__1;

			private List<UniTask> _003Ctask_003E5__2;

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
			public _003CPlayTransmutateAnime_003Ed__56(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CShowChoiceMessage_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string i_Message;

			public string i_Choice;

			public CGameRoom_Transmutation _003C_003E4__this;

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
			public _003CShowChoiceMessage_003Ed__52(int _003C_003E1__state)
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
		private CDebugMenu m_DebugMenu;

		[SerializeField]
		private CanvasGroup m_WindowCanvasGroup;

		[SerializeField]
		private CMouseCtrl m_MouseCtrl;

		[SerializeField]
		private CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		private CUIGenericMenu m_Menu;

		[SerializeField]
		private CCardDetail m_CardDetailRight;

		[SerializeField]
		private CCardDetail m_CardDetailLeft;

		[SerializeField]
		private TMP_Text m_TitleText;

		[SerializeField]
		private TMP_Text m_NumberText;

		[SerializeField]
		private CanvasGroup m_Cursor;

		[SerializeField]
		private CUITooltip m_TooltipRight;

		[SerializeField]
		private CUITooltip m_TooltipLeft;

		[SerializeField]
		private List<TextMeshProUGUI> m_RightLowerText;

		[SerializeField]
		private CChoiceMenu m_ChoiceMenu;

		private int? m_PrevFocusIndex;

		private List<CTransmutationCard> m_Cards;

		private List<CMaster_UnlockData> m_List;

		private List<GroupTrack> m_SaveGroupTrack;

		private string m_TutorialID;

		private bool m_DetailMode;

		private Coroutine m_ExecuteTransmutationCoroutine;

		private Seq m_Seq;

		private bool m_Reopen;

		private CTransmutationNode m_TransmutationNode;

		private GameObject m_PieceModel;

		private GameObject m_Direction;

		public CUIGenericMenu Menu => null;

		public CUIGenericOpenClose OpenClose => null;

		private void Awake()
		{
		}

		private new void OnDestroy()
		{
		}

		private void Active(bool i_IsActive)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void Initialize()
		{
		}

		private void _Initialize(List<CMaster_UnlockData> i_List)
		{
		}

		private void SetCardIllust(bool i_LockMask)
		{
		}

		private void SetCardIllust(int i_Index, bool i_LockMask)
		{
		}

		private void Update()
		{
		}

		public bool MoveCursor(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
		{
			return false;
		}

		public void ShowCardView(bool i_Reverse)
		{
		}

		public void HideCardView()
		{
		}

		public bool IsMouseFocus()
		{
			return false;
		}

		private void ShowDetail()
		{
		}

		private void ToggleAppear()
		{
		}

		private void ShowGMMessage()
		{
		}

		private void GetCardCondition(CMaster_UnlockData i_Data, out bool o_Unlock, out bool o_Have)
		{
			o_Unlock = default;
			o_Have = default;
		}

		public void ApplySoulPoint()
		{
		}

		[IteratorStateMachine(typeof(_003CShowChoiceMessage_003Ed__52))]
		private IEnumerator ShowChoiceMessage(string i_Message, string i_Choice = "")
		{
			return null;
		}

		private bool IsShowCompleteChoiceMessage()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CExecuteTransmutation_003Ed__54))]
		private IEnumerator ExecuteTransmutation()
		{
			return null;
		}

		public void SetReopenFlag()
		{
		}

		[IteratorStateMachine(typeof(_003CPlayTransmutateAnime_003Ed__56))]
		private IEnumerator PlayTransmutateAnime(CTransmutationCard i_TransmutationCard)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDestroyDirection_003Ed__57))]
		private IEnumerator DestroyDirection(CTransmutationCard i_TransmutationCard)
		{
			return null;
		}

		private void ShowNavi()
		{
		}

		private void ObtainAchievement()
		{
		}

		public static void RefleshLockState()
		{
		}
	}
}
