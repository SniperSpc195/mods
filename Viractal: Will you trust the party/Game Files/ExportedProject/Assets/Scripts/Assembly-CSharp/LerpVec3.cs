using System;
using UnityEngine;

[Serializable]
public class LerpVec3
{
	public enum EASING
	{
		Linear = 0,
		SineOut = 1,
		CubicOut = 2,
		QuintOut = 3,
		CubicIn = 4,
		QuintIn = 5
	}

	public Vector3[] mVec;

	public float mT;

	public float mTs;

	private EASING mEasing;

	public LerpVec3(Vector3 a)
	{
	}

	public bool EqualTarget(Vector3 a)
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsExec()
	{
		return false;
	}

	public void Update()
	{
	}

	public Vector3 GetNow()
	{
		return default;
	}

	public Vector3 GetTarget()
	{
		return default;
	}

	public Vector3 Set(Vector3 a)
	{
		return default;
	}

	public Vector3 Start(Vector3 n, Vector3 t, float nt = 0f, float ts = 0.1f, EASING es = EASING.Linear)
	{
		return default;
	}
}
