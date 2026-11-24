using Fork.Game;
using UnityEngine;

[AddComponentMenu("Fork/PreUIFadeController")]
public class PreUIFadeController : CInOutBehaviour
{
	public enum Style
	{
		BattleHand = 0,
		FieldStatus = 1
	}

	[SerializeField]
	private Camera m_FadeRendering2DCamera;

	public float m_Alpha;

	public float m_Speed;

	public Style m_Style;

	private float m_Accel;

	private void Update()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void ImmediateShow()
	{
	}

	public override void ImmediateHide()
	{
	}

	public override bool IsIn()
	{
		return false;
	}

	public override bool IsOut()
	{
		return false;
	}

	public override bool IsPlaying()
	{
		return false;
	}

	public override bool IsShow()
	{
		return false;
	}

	public override CInOutPattern.State GetState()
	{
		return CInOutPattern.State.In;
	}
}
