using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUIHelpDetail : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public CUIArrow i_Arrow;

			internal bool _003CArrowDeactivateLater_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CArrowDeactivateLater_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIArrow i_Arrow;

			public CancellationToken i_CancellationToken;

			private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

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
		private struct _003C_SetHelp_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIHelpDetail _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			private CMaster_TutorialData.Page _003Cpage_003E5__2;

			private string _003CassetName_003E5__3;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private AsyncOperationHandle<Texture2D> _003Ctexture_003E5__4;

			private UniTask<Texture2D>.Awaiter _003C_003Eu__2;

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

		private static readonly Vector2 _SmallSize;

		private static readonly Vector2 _LargeSize;

		[SerializeField]
		private RawImage m_Image;

		[SerializeField]
		private TMP_Text m_DetailsText;

		[SerializeField]
		private TMP_Text m_HelpText;

		[SerializeField]
		private CUIArrow m_LeftArrow;

		[SerializeField]
		private CUIArrow m_RightArrow;

		[SerializeField]
		private TMP_Text m_L1Text;

		[SerializeField]
		private TMP_Text m_R1Text;

		[SerializeField]
		private TMP_Text m_CloseText;

		[SerializeField]
		private LayoutElement m_TextLayoutElement;

		private CHelp m_CurrentHelp;

		private int m_CurrentIndex;

		private int m_ShowFlag;

		private CancellationTokenSource m_CancellationTokenSource;

		private GameController.PADNUM m_PadNum;

		private AsyncOperationHandle<Texture2D> m_LoadedTexture;

		private CancellationTokenSource m_ArrowCTS;

		public bool m_PopupMode { get; set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetController(GameController.PADNUM padNum)
		{
		}

		public void InvalidateList()
		{
		}

		public bool IsShowAllAndLastPage()
		{
			return false;
		}

		public bool MoveCursor(GameController.PADNUM padNum, GamePad pad, bool isPopup = false)
		{
			return false;
		}

		private void UpdateArrow()
		{
		}

		[AsyncStateMachine(typeof(_003CArrowDeactivateLater_003Ed__29))]
		private UniTask ArrowDeactivateLater(CUIArrow i_Arrow, CancellationToken i_CancellationToken)
		{
			return default;
		}

		public void SetHelp(CHelp i_Help, int i_Index = 0)
		{
		}

		private void SetHelp()
		{
		}

		[AsyncStateMachine(typeof(_003C_SetHelp_003Ed__32))]
		private UniTask _SetHelp(CancellationToken i_CancellationToken)
		{
			return default;
		}

		private void SetDetailsText(CMaster_TutorialData.Page i_HelpPage)
		{
		}

		public void UpdateGuide()
		{
		}

		public bool IsMouseCursorOnButton()
		{
			return false;
		}
	}
}
