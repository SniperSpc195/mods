using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CBtlTimelineUnit : MonoBehaviour
{
	public enum Size
	{
		L = 0,
		M = 1
	}

	public enum AnimationType
	{
		Up = 0,
		In = 1,
		Out = 2,
		Hide = 3,
		Keep = 4
	}

	[SerializeField]
	private Size m_Size;

	[SerializeField]
	private RectTransform m_RectTransform;

	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private TextMeshProUGUI m_LabelDebug;

	[SerializeField]
	private Image m_UnitIllust;

	[SerializeField]
	private Image m_UnitBlloon;

	[SerializeField]
	private Image m_AddBlloon;

	private LerpVec3 m_Position;

	private CInOutPattern m_InOut;

	public CParamDef m_Param { get; private set; }

	public int m_Order { get; private set; }

	public AnimationType m_AnimationType { get; private set; }

	public bool m_Started { get; private set; }

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void Initialize(CParamDef param, int index)
	{
	}

	public void ApplyLabel()
	{
	}

	public void MoveUp()
	{
	}

	public void Erase(bool immediate)
	{
	}

	public void ResetOrder(int i_Order)
	{
	}

	public void PlayAnime(AnimationType type)
	{
	}

	private bool IsAnimePlaying()
	{
		return false;
	}

	private float GetPositionY()
	{
		return 0f;
	}

	public void StartBlink()
	{
	}

	public void StopBlink()
	{
	}
}
