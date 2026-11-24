using System;

[Serializable]
public class RotationY
{
	private float mNow;

	private float mTarget;

	private float mSpeed;

	public RotationY(float now, float target, int frame)
	{
	}

	public float Update()
	{
		return 0f;
	}

	public bool IsEnd()
	{
		return false;
	}
}
