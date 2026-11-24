using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUIStaffroll : MonoBehaviour
	{
		protected enum State
		{
			Prepare = 0,
			Execute = 1,
			Ended = 2
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateUnit_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CMaster_StaffrollData i_Data;

			public CUIStaffroll _003C_003E4__this;

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
		private struct _003C_Prepare_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUIStaffroll _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			private CMaster_StaffrollData[] _003Calldata_003E5__2;

			private int _003Ci_003E5__3;

			private int _003Cfirst_003E5__4;

			private UniTask.Awaiter _003C_003Eu__1;

			private YieldAwaitable.Awaiter _003C_003Eu__2;

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
		protected GameObject m_HeadlinePrefab;

		[SerializeField]
		protected GameObject m_SpacePrefab;

		[SerializeField]
		protected GameObject m_ImagePrefab;

		[SerializeField]
		protected GameObject m_StaffPrefab;

		[SerializeField]
		protected RectTransform m_StaffrollRoot;

		[SerializeField]
		protected RectTransform m_StaffrollViewport;

		[SerializeField]
		protected float m_Speed;

		[SerializeField]
		protected CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		protected CUIGenericButtonGuide m_ButtonGuide;

		[SerializeField]
		protected RawImage m_FadeMask;

		private float m_CurrentSpeed;

		private double m_StartTimeSeconds;

		protected State m_State;

		protected List<StaffrollComponent> m_WaitingComponents;

		protected CancellationTokenSource m_CancellationTokenSource;

		public static CUIStaffroll Instance { get; private set; }

		public List<AsyncOperationHandle<Texture2D>> m_LoadedTextures { get; private set; }

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		private void CloseImmediate()
		{
		}

		public bool IsEnd()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CCreateUnit_003Ed__30))]
		private UniTask CreateUnit(CMaster_StaffrollData i_Data)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_Prepare_003Ed__31))]
		private UniTask _Prepare(CancellationToken i_CancellationToken)
		{
			return default;
		}

		public bool IsVisible(RectTransform i_Child, out float o_AbsoluteY)
		{
			o_AbsoluteY = default;
			return false;
		}

		public bool HasEnoughContents()
		{
			return false;
		}

		private void Update()
		{
		}
	}
}
