using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CBtlCharacterInfo : MonoBehaviour
{
	private enum Seq
	{
		Wait = 0,
		ChangeOut = 1,
		ChangeIn = 2
	}

	[SerializeField]
	private TextMeshProUGUI m_TextHpCurrent;

	[SerializeField]
	private TextMeshProUGUI m_TextHpMax;

	[SerializeField]
	private Image m_BarHp;

	[SerializeField]
	private Image m_BarBarrier;

	[SerializeField]
	private Image[] m_ConditionIcons;

	[SerializeField]
	private CanvasGroup m_ConditionCanvaGroup;

	[SerializeField]
	private Animator m_ConditionAnimator;

	[SerializeField]
	private TextMeshProUGUI m_ActorSymbol;

	[SerializeField]
	private TextMeshProUGUI m_Label;

	private CBattleCharDef m_Char;

	private CParamDef m_Param;

	private Camera m_Camera;

	private float m_ConditionTimer;

	private const float ChangeTime = 120f;

	private int m_ShowConditionPage;

	private CInOutPattern m_InOut;

	private Seq m_Seq;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void Setup(CBattleCharDef chr, CParamDef param)
	{
	}

	public void ApplyHp()
	{
	}

	public void ApplyCondition()
	{
	}

	public void ShowActorSymbol()
	{
	}

	public void HideActorSymbol()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
