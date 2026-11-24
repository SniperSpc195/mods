using System;
using UnityEngine;

[Serializable]
public class CEffectState
{
	public enum STAT
	{
		Stop = 0,
		Load = 1,
		Start = 2,
		Play = 3
	}

	[SerializeField]
	[ReadOnly]
	public Vector3 mPosition;

	[SerializeField]
	[ReadOnly]
	public Vector3 mOffsetPos;

	[SerializeField]
	[ReadOnly]
	public Vector3 mAngle;

	[SerializeField]
	[ReadOnly]
	public Vector3 mScale;

	public bool mLoopOff;

	public STAT mStat;

	public bool IsLoad()
	{
		return false;
	}

	public bool IsPlay()
	{
		return false;
	}

	public bool IsStop()
	{
		return false;
	}

	public void SeReq(float t)
	{
	}
}
