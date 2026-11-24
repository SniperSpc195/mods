using System;
using UnityEngine;

[Serializable]
public class TransformOffset
{
	public LerpVec3 mPosition;

	public LerpVec3 mAngle;

	public LerpVec3 mScale;

	public bool EqualsTarget(TransformOffset off)
	{
		return false;
	}

	public void Reset(float ts)
	{
	}

	public void Update()
	{
	}

	public Vector3 GetPosition()
	{
		return default;
	}

	public Vector3 GetAngle()
	{
		return default;
	}

	public Vector3 GetScale()
	{
		return default;
	}
}
