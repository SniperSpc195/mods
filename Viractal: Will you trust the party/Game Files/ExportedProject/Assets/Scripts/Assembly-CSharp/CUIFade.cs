using UnityEngine;
using UnityEngine.UI;

public class CUIFade : MonoBehaviour
{
	private enum MODE
	{
		Stop = 0,
		Alpha = 1,
		Color = 2
	}

	[SerializeField]
	private Image mImage;

	[SerializeField]
	private Color mNowColor;

	[SerializeField]
	private Color mTargetColor;

	[SerializeField]
	private float mNowTime;

	[SerializeField]
	[ReadOnly]
	private float mSpeed;

	[SerializeField]
	private CanvasGroup[] mCanvasGroup;

	[SerializeField]
	private MODE mMode;

	public void Active(bool a)
	{
	}

	public void SetNowColor(Color c)
	{
	}

	public void SetTargetColor(Color c)
	{
	}

	public float GetTime()
	{
		return 0f;
	}

	public void FadeIn(float t)
	{
	}

	public void FadeOut(float t)
	{
	}

	public void Fade_NowTarget(float t)
	{
	}

	public void Fade_TargetNow(float t)
	{
	}

	public bool IsFade()
	{
		return false;
	}

	public bool IsStop()
	{
		return false;
	}

	public bool IsDisplay()
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	private void SyncAlpha(float a)
	{
	}
}
