using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CGameBox : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_PlaySE_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CGameBox _003C_003E4__this;

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

		private static CGameBox Instance;

		private static readonly int FloorOffsetKey;

		private static readonly int BaseScaleKey;

		private static readonly string SEOpenBox;

		private static readonly string SEBoardFlash;

		private static readonly string SEBoxShake;

		[SerializeField]
		private Animator m_Animator;

		private int? m_BackupState;

		private CancellationTokenSource m_BoardOpenCanecellationTokenSource;

		private long m_BoardFlashSEHandle;

		private long m_BoardShakeSEHandle;

		private static bool mForceOpen;

		private Animator m_FloorAnimator;

		private Transform m_BaseTransform;

		private Action m_OnHide;

		public static void SetForceOpen(bool a)
		{
		}

		public static void SetStayMode()
		{
		}

		public static void SetJobSelectMode()
		{
		}

		public static void SetShake()
		{
		}

		public static void SetShakeFirst()
		{
		}

		public static void OpenBox()
		{
		}

		[AsyncStateMachine(typeof(_003C_PlaySE_003Ed__18))]
		private UniTask _PlaySE()
		{
			return default;
		}

		public static void CancelBoardFlashSE()
		{
		}

		private void _CancelBoardFlashSE()
		{
		}

		public static bool IsOpen()
		{
			return false;
		}

		public static void Terminate()
		{
		}

		public static float GetFloorOffset()
		{
			return 0f;
		}

		public static float GetBaseScale()
		{
			return 0f;
		}

		public static void SetBase(Transform i_Transform)
		{
		}

		public static void SetFloorAnimator(Animator i_Animator)
		{
		}

		public static void ReturnToBox(Action onHide = null)
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnReturnToBox()
		{
		}
	}
}
