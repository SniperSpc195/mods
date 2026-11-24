using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CCardDetail : MonoBehaviour
	{
		private struct Detail
		{
			public GameObject tooltip;

			public int indent;
		}

		private enum InputButton
		{
			RightStickUp = 0,
			RightStickDown = 1,
			MouseWheelUp = 2,
			MouseWheelDown = 3,
			_Max = 4
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Setup_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string i_CardID;

			public CancellationToken i_CancellationToken;

			public CCardDetail _003C_003E4__this;

			public bool i_SetRandomParam;

			private UniTask<Texture>.Awaiter _003C_003Eu__1;

			private RawImage _003C_003E7__wrap1;

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

		[SerializeField]
		private RawImage m_CardImage;

		[SerializeField]
		private CanvasGroup m_CanvasGroup;

		[SerializeField]
		private RectTransform m_ExplainRoot;

		[SerializeField]
		private ScrollRect m_ExplainScrollRect;

		[SerializeField]
		private GameObject m_TooltipLeft;

		[SerializeField]
		private GameObject m_TooltipTop;

		[SerializeField]
		private bool m_FlipIndent;

		private RectTransform m_ScrollRectTransform;

		private List<GameObject> m_CacheTooltipLeft;

		private List<GameObject> m_CacheTooltipTop;

		private int m_ShowTooltipLeftCount;

		private int m_ShowTooltipTopCount;

		private CancellationTokenSource m_CardLoadCancellationTokenSource;

		private string m_CardId;

		private bool m_UpdageMode;

		private List<CMaster_SkillConditionData> m_DisplayCondition;

		private List<CMaster_SkillAbilityData> m_DisplayAbility;

		private List<CMaster_SkillCardData> m_DisplayCard;

		private List<Detail> m_ShowDetails;

		private int m_Indent;

		private bool[] m_InputButton;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void Show(string i_CardID, bool i_DeleteMode = false, bool i_UpgradeMode = false, bool i_SetRandomParam = true)
		{
		}

		private void Setup(string i_CardID, bool i_DeleteMode = false, bool i_SetRandomParam = true)
		{
		}

		[AsyncStateMachine(typeof(_003C_Setup_003Ed__28))]
		private UniTask _Setup(string i_CardID, CancellationToken i_CancellationToken, bool i_SetRandomParam = true)
		{
			return default;
		}

		public bool IsShow()
		{
			return false;
		}

		private void SetExplains(CMaster_SkillCardData i_Card)
		{
		}

		private void AddExplainCondition(IEnumerable<CMaster_SkillCardData.CEffectIdTable> i_EffectIds, ref int i_StartIndex)
		{
		}

		private void AddExplainCondition(CMaster_SkillAbilityData i_Ability, ref int i_StartIndex)
		{
		}

		private void AddExplainCondition(CMaster_SkillConditionData i_Condition, ref int i_StartIndex)
		{
		}

		private bool AddExplain(CMaster_SkillConditionData i_Condition, ref int i_StartIndex)
		{
			return false;
		}

		private void AddExplainAbility(IEnumerable<CMaster_SkillCardData.CEffectIdTable> i_EffectIds, ref int i_StartIndex)
		{
		}

		private void AddExplainCard(IEnumerable<CMaster_SkillCardData.CEffectIdTable> i_EffectIds, ref int i_StartIndex)
		{
		}

		public void Hide()
		{
		}

		public void ToggleCardUpgrade()
		{
		}
	}
}
