using System;
using System.Collections.Generic;
using UnityEngine;

public class CEventCoin : CCharRigidbody
{
	private enum MODE
	{
		None = 0,
		Scaling = 1
	}

	private List<GameObject> mHitGameObject;

	private DateTime mRollTime;

	private bool mSetTime;

	private static int mHit;

	private static float mHitTime;

	public Vector3 mPosition;

	public Quaternion mRotation;

	private MODE mMode;

	private float mScale;

	public static void HitSeReset()
	{
	}

	public static void HitSeRequest()
	{
	}

	private void Awake()
	{
	}

	public void UpdateTransform()
	{
	}

	public void EnablePhysics()
	{
	}

	public void Scaling()
	{
	}

	public bool IsStop()
	{
		return false;
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}
}
