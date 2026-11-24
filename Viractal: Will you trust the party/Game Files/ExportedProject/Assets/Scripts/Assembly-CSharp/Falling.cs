using System;
using UnityEngine;

[Serializable]
public class Falling
{
	private enum MODE
	{
		Fall = 0,
		Jump_Up = 1,
		Jump_Down = 2,
		Landing = 3,
		End = 4
	}

	public Vector3 mPosition;

	public Vector3 mAddPosition;

	public Vector3 mAngle;

	public Vector3[] mShake;

	private float mT;

	private float mLoopCount;

	private bool mSingle;

	private MODE mMode;

	public Falling(Vector3 v, bool single = false)
	{
	}

	public bool Update()
	{
		return false;
	}

	private bool ExecOne()
	{
		return false;
	}
}
