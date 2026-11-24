using System.Collections.Generic;
using UnityEngine;

public class CFieldDice : CCharRigidbody
{
	public class ForcePower
	{
		public Quaternion mRotation;

		public Vector3 mForce;

		public Vector3 mTorque;
	}

	private Vector3 mPosition;

	private float mScaleUpPositionY;

	private Vector3 mScale;

	private int mScaleUp;

	private int mNum;

	private List<GameObject> mHitGameObject;

	private static int mHit;

	private static float mHitTime;

	private ForcePower mForcePower;

	private const float mMaxDicePower = 5f;

	private static float mDicePower;

	private void Awake()
	{
	}

	public void Active(bool a)
	{
	}

	public void ResetNum()
	{
	}

	public void SetScalePause(float s)
	{
	}

	public void SetScaleUp()
	{
	}

	public void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}

	public Vector3 GetFollowPosition()
	{
		return default;
	}

	public static void ClearPower()
	{
	}

	public static bool AddPower()
	{
		return false;
	}

	public static float GetPower()
	{
		return 0f;
	}

	public static ForcePower MakeForcePower(float pow = 0f)
	{
		return null;
	}

	public static List<ForcePower> MakeForcePowerN(int n, float pow = 0f)
	{
		return null;
	}

	public Vector3 ResetPosition(Vector3Int hex)
	{
		return default;
	}

	public void SetPosition(Vector3 pos, bool localSet = true)
	{
	}

	public void SetForcePower(ForcePower fp, bool active = true)
	{
	}

	public static void HitSeReset()
	{
	}

	public static void HitSeRequest()
	{
	}

	public bool IsStop()
	{
		return false;
	}

	public int ConfirmNum()
	{
		return 0;
	}

	public void SetNum(int a)
	{
	}

	public int GetNum()
	{
		return 0;
	}

	public void SetUIPosition(int max, int index)
	{
	}

	public void SetNumRotation(int num)
	{
	}
}
