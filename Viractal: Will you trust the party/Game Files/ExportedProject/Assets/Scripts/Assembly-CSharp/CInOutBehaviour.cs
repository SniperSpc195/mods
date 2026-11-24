using Fork.Game;
using UnityEngine;

public class CInOutBehaviour : MonoBehaviour
{
	private CInOutPattern mInOutPattern;

	public static bool IsAnimatorInclude(GameObject g)
	{
		return false;
	}

	private void Awake()
	{
	}

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	public virtual void ImmediateShow()
	{
	}

	public virtual void ImmediateHide()
	{
	}

	public virtual bool IsIn()
	{
		return false;
	}

	public virtual bool IsOut()
	{
		return false;
	}

	public virtual bool IsPlaying()
	{
		return false;
	}

	public virtual bool IsShow()
	{
		return false;
	}

	public virtual CInOutPattern.State GetState()
	{
		return CInOutPattern.State.In;
	}

	public virtual bool IsHide()
	{
		return false;
	}

	public void SetFastSpeedMode()
	{
	}
}
