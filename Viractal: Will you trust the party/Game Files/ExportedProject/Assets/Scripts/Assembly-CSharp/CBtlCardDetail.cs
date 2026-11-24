using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CBtlCardDetail : MonoBehaviour
{
	private struct Detail
	{
		public CUITooltip tooltip;

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
	private struct _003CCreateConditionDetail_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlCardDetail _003C_003E4__this;

		public CancellationToken i_Cancel;

		public CMaster_SkillCardData i_CardData;

		public Vector2 i_Position;

		public UnityAction i_OnComplete;

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
	private CUITooltip m_TooltipLeft;

	[SerializeField]
	private bool m_IsTooltipFlip;

	[SerializeField]
	private CUITooltip m_TooltipTop;

	[SerializeField]
	private ScrollRect m_ScrollRect;

	[SerializeField]
	private RectTransform m_ScrollRectTransform;

	[SerializeField]
	private RectTransform m_ScrollContain;

	[SerializeField]
	private CanvasGroup m_ScrollBarCanvasGroup;

	private Vector2? m_Position;

	private List<CUITooltip> m_CacheTooltipLeft;

	private List<CUITooltip> m_CacheTooltipTop;

	private int m_ShowTooltipLeftCount;

	private int m_ShowTooltipTopCount;

	private List<CMaster_SkillConditionData> m_DisplayCondition;

	private List<CMaster_SkillAbilityData> m_DisplayAbility;

	private List<CMaster_SkillCardData> m_DisplayCard;

	private List<Detail> m_ShowDetails;

	private int m_Indent;

	[SerializeField]
	private bool m_RequireHoverForScroll;

	private CFieldPlayer m_Player;

	private bool[] m_InputButton;

	private CancellationTokenSource m_CancellationTokenSource;

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void CreateConditionDetail(CMaster_SkillCardData i_CardData, Vector2 i_Position, UnityAction i_OnComplete = null)
	{
	}

	[AsyncStateMachine(typeof(_003CCreateConditionDetail_003Ed__26))]
	private UniTask CreateConditionDetail(CancellationToken i_Cancel, CMaster_SkillCardData i_CardData, Vector2 i_Position, UnityAction i_OnComplete = null)
	{
		return default;
	}

	public void SetPosition(Vector2 i_ScreenPosition)
	{
	}

	public void Show(CFieldPlayer i_Player = null)
	{
	}

	public void Hide()
	{
	}

	public bool IsShow()
	{
		return false;
	}

	public int Count()
	{
		return 0;
	}

	public void Destroy()
	{
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
}
