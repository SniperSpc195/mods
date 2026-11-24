using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CCardReinforcementView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_SetUI_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CCardReinforcementView _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			private Texture _003CfromMain_003E5__2;

			private Texture _003CtoMain_003E5__3;

			private UniTask<Texture>.Awaiter _003C_003Eu__1;

			private RawImage _003C_003E7__wrap3;

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

		private const string CardReinforcementSE = "SE_0340";

		[SerializeField]
		private CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		private RawImage m_From;

		[SerializeField]
		private RawImage m_To;

		[SerializeField]
		private Animator m_ToAnimator;

		[SerializeField]
		private Animator m_MainAnimator;

		[SerializeField]
		private AssetReferenceGameObject m_ReinforceEffectPrefab;

		[SerializeField]
		private AssetReferenceTexture2D m_CardReveseFaceTexture;

		private CMaster_SkillCardData m_SkillCardData;

		private CMaster_SkillCardData m_ReinforcementCardData;

		private CancellationTokenSource m_CancellationTokenSource;

		public CUIGenericOpenClose OpenClose => null;

		private void OnDestroy()
		{
		}

		public bool IsOpenCloseExecute()
		{
			return false;
		}

		public bool IsReinforcementExecute(CFieldPlayer i_Player)
		{
			return false;
		}

		public void Active(bool i_Active, string i_CardID = null, int i_DelayMillsecond = 0)
		{
		}

		private void SetUI()
		{
		}

		[AsyncStateMachine(typeof(_003C_SetUI_003Ed__18))]
		private UniTask _SetUI(CancellationToken i_CancellationToken)
		{
			return default;
		}

		public void Execute()
		{
		}

		public void OnChangeCard()
		{
		}

		public void OnEffectActivate()
		{
		}
	}
}
