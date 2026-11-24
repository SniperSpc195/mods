using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUIAbilityViewAbility : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetIcon_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CMaster_SkillAbilityData i_Ability;

			public CUIAbilityViewAbility _003C_003E4__this;

			private UniTask<RenderTexture>.Awaiter _003C_003Eu__1;

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
		private GameObject m_ContentRoot;

		[SerializeField]
		private TMP_Text m_NameText;

		[SerializeField]
		private TMP_Text m_DescriptionText;

		[SerializeField]
		private RawImage m_IconImage;

		private RenderTexture m_IconTexture;

		private void OnDestroy()
		{
		}

		public void SetAbility(CMaster_SkillAbilityData i_Ability)
		{
		}

		[AsyncStateMachine(typeof(_003CSetIcon_003Ed__7))]
		private UniTask SetIcon(CMaster_SkillAbilityData i_Ability)
		{
			return default;
		}
	}
}
