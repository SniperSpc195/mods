using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Fork.ModelButtons
{
	[AddComponentMenu("Fork/ModelButtonGroup")]
	public class CUIModelButtonGroup : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSelectLater_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIModelButton i_PrevButton;

			public CUIModelButtonGroup _003C_003E4__this;

			public Camera i_Camera;

			public CCharDef i_GamepadHolder;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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

		public static bool IsEnable;

		[SerializeField]
		private Vector2Int m_Size;

		[SerializeField]
		private bool m_HorizontalRepeat;

		[SerializeField]
		private bool m_VerticalRepeat;

		[SerializeField]
		private bool m_VerticalFlip;

		[SerializeField]
		public CUIModelButtonGroup m_TopConnection;

		[SerializeField]
		public CUIModelButtonGroup m_BottomConnection;

		[SerializeField]
		public CUIModelButtonGroup m_LeftConnection;

		[SerializeField]
		public CUIModelButtonGroup m_RightConnection;

		private Vector2Int m_Index;

		private CCharDef m_GamepadHolder;

		private Camera m_Camera;

		private Func<GamePad, bool> m_ControllCallback;

		public bool m_IgnoreFindNearest { get; set; }

		public List<CUIModelButton> m_Buttons { get; private set; }

		public bool ForceUpdateSelection { get; set; }

		public bool IsActive => false;

		public UnityEvent onEndOfTop { get; private set; }

		public int ButtonIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public CUIModelButton CurrentButton => null;

		public Vector2Int ViewSize => default;

		public void AddControlCallback(Func<GamePad, bool> i_ControllCallback)
		{
		}

		public static bool ControlInactive(GamePad i_GamePad)
		{
			return false;
		}

		public void Select(Camera i_Camera, CCharDef i_GamepadHolder, CUIModelButton i_PrevButton = null)
		{
		}

		[AsyncStateMachine(typeof(_003CSelectLater_003Ed__41))]
		private UniTask SelectLater(Camera i_Camera, CCharDef i_GamepadHolder, CUIModelButton i_PrevButton)
		{
			return default;
		}

		private void FindNearestIndex(Vector3 i_PrevPosition)
		{
		}

		public void Deselect()
		{
		}

		private void Update()
		{
		}

		private void DrawFingerCursor()
		{
		}

		public void UpdateDirection(GameController.BUTTON? i_Button = null)
		{
		}
	}
}
