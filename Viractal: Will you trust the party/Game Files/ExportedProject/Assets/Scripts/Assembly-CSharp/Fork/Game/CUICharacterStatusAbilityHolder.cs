using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.ModelButtons;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/AbilityHolder")]
	public class CUICharacterStatusAbilityHolder : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_SetValuesAnimate_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public List<CSkillAbilityData> i_Abilities;

			public CUICharacterStatusAbilityHolder _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			private int _003Cindex_003E5__2;

			private List<CSkillAbilityData>.Enumerator _003C_003E7__wrap2;

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

		[SerializeField]
		private Transform m_Root;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private GameObject m_AdditionalInfoUI;

		[SerializeField]
		private bool m_BattleOnly;

		private CUICharacterStatusGroup m_Parent;

		private CUICharacterStatus m_Status;

		private CancellationTokenSource m_CancellationTokenSource;

		private List<CSkillAbilityData> m_Abilities;

		private CUIModelButtonGroup _backupTop;

		private CUIModelButtonGroup _backupBotton;

		private CUIModelButtonGroup _backupLeft;

		private CUIModelButtonGroup _backupRight;

		public CUIModelButtonGroup ButtonGroup => null;

		public bool IsEmpty => false;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetParent(CUICharacterStatusGroup i_Parent, CUICharacterStatus i_Character)
		{
		}

		public void SetValues(List<CSkillAbilityData> i_Abilities, bool i_Animate)
		{
		}

		private void _SetValuesImmediate(List<CSkillAbilityData> i_Abilities)
		{
		}

		[AsyncStateMachine(typeof(_003C_SetValuesAnimate_003Ed__17))]
		private UniTask _SetValuesAnimate(List<CSkillAbilityData> i_Abilities, CancellationToken i_CancellationToken)
		{
			return default;
		}

		public void Clear()
		{
		}

		public void StartOnlySelectionMode(Camera i_Camera, CUICharacterStatusAbilityHolder i_TemporaryHolder, CCharDef i_GamepadHolder)
		{
		}

		public void EndOnlySelectionMode()
		{
		}

		public CUiCharacterStatusAbility GetIcon(int i_Index)
		{
			return null;
		}

		public Transform GetIconRoot(int i_Index)
		{
			return null;
		}

		public CUIModelButtonGroup GetButtonGroup()
		{
			return null;
		}

		public void PlayActivateEffect(string i_ID)
		{
		}
	}
}
