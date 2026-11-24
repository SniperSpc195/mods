using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.ModelButtons;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/Face")]
	public class CUICharacterStatusFace : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_UpdateFace_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string i_ModelID;

			public CancellationToken i_CancellationToken;

			public CUICharacterStatusFace _003C_003E4__this;

			private string _003Caddress_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private AsyncOperationHandle<Texture2D> _003Chandle_003E5__3;

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

		[SerializeField]
		private MeshRenderer m_Renderer;

		[SerializeField]
		private int m_MaterialIndex;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIModelButton m_Button;

		private CancellationTokenSource m_CancellationTokenSourceResource;

		private AsyncOperationHandle<Texture2D> m_FaceTexture;

		private MaterialPropertyBlock m_Property;

		private string m_ModelID;

		private ColoredUnit m_Color;

		private bool m_IsDead;

		private CInOutPattern m_InOut;

		private CParamDef m_Character;

		public Animator m_Animator { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void SetupResource(ColoredUnit i_Color, ColoredUnitResource i_Resource)
		{
		}

		public void SetupRenderer(Transform parent)
		{
		}

		public void UpdateFace(CParamDef i_Parameter)
		{
		}

		public void SetFaceDirection(CParamDef i_Parameter, bool i_Animate)
		{
		}

		[AsyncStateMachine(typeof(_003C_UpdateFace_003Ed__23))]
		private UniTask _UpdateFace(string i_ModelID, CancellationToken i_CancellationToken)
		{
			return default;
		}
	}
}
