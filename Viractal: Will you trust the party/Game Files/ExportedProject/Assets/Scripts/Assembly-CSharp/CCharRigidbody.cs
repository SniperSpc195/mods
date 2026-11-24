using System;
using UnityEngine;

public class CCharRigidbody : MonoBehaviour
{
	public enum STAT
	{
		Move = 0,
		Stop_Sleep = 1,
		Stop_TimeOver = 2,
		Stop_FrameOver = 3
	}

	protected Rigidbody mRigidbody;

	protected bool mFirstCollision;

	private DateTime mTimeFirstCollision;

	protected Vector3 mOldPosition;

	protected Vector3 mOldRotation;

	protected int mALittleFrame;

	private const float STOP_POS = 1f;

	private const float STOP_ANG = 0.5f;

	private const int STOP_FRAME = 8;

	protected STAT mStat;

	public Rigidbody GetRigidbody()
	{
		return null;
	}

	public void ResetFirstCollision()
	{
	}

	public void SetFirstCollision()
	{
	}

	public STAT IsStop(float seconds, bool aLittle = false)
	{
		return STAT.Move;
	}
}
