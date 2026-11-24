using System.Collections.Generic;
using UnityEngine;

public class CNewDice : CCharRigidbody
{
	public enum TYPE
	{
		Default = 0,
		Move = 1
	}

	public class THROW
	{
		public Vector3 mRotation;

		public Vector3 mTorque;

		public Vector3 mForce;

		public THROW()
		{
		}

		public THROW(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		public THROW(THROW org)
		{
		}

		public Dictionary<string, object> Save()
		{
			return null;
		}

		public void Load(JsonNode json)
		{
		}
	}

	private enum MODE
	{
		None = 0,
		Roll = 1,
		Throw = 2,
		Stop = 3
	}

	private const float STOP_TIME = 10f;

	private const uint SEREQ_FRAME = 10u;

	private const float SE_VELOCITY_SCALER = 0.1f;

	[SerializeField]
	private CPlayerDiceNum mDiceNum;

	[SerializeField]
	private TYPE mType;

	[SerializeField]
	private Vector3 mResetPosition;

	[SerializeField]
	private Vector3 mResetRotation;

	[SerializeField]
	private Vector3 mRoleSpeed;

	[SerializeField]
	[ReadOnly]
	private Vector3 mAddRotation;

	[SerializeField]
	[ReadOnly]
	private Vector3 mRotation;

	[SerializeField]
	private Vector3 mTorque;

	[SerializeField]
	private Vector3 mForce;

	[SerializeField]
	[ReadOnly]
	private int mNum;

	private THROW mParamThrow;

	public int mRecommend;

	private THROW mPriorityThrow;

	private MODE mMode;

	private bool mCollisionEnter;

	private long mHitTime;

	private const float HV_angle = 15f;

	private int[] mIndexThrow;

	private static THROW[] ThrowResult_1;

	private static THROW[] ThrowResult_2;

	private static THROW[] ThrowResult_3;

	private static THROW[] ThrowResult_4;

	private static THROW[] ThrowResult_5;

	private static THROW[] ThrowResult_6;

	public CPlayerDiceNum DiceNum => null;

	public CAnimePlayer AnimePlayer => null;

	public void Active(bool a)
	{
	}

	public void SetResetPosition(Vector3[] position, int index)
	{
	}

	public bool IsDefault()
	{
		return false;
	}

	public bool IsMove()
	{
		return false;
	}

	public int GetNum()
	{
		return 0;
	}

	public void SetRoutelle()
	{
	}

	public void SetPriorityNum(int n)
	{
	}

	public void Reset(bool reqSe = true)
	{
	}

	public Dictionary<string, object> Throw(bool IsOnline)
	{
		return null;
	}

	public void Replay()
	{
	}

	public void Throw(JsonNode json)
	{
	}

	private THROW SetupThrow()
	{
		return null;
	}

	public bool IsStop()
	{
		return false;
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Stop()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}

	public Transform GetUpperTransform()
	{
		return null;
	}

	public int ConfirmNum()
	{
		return 0;
	}

	public Dictionary<string, object> MakeConditions()
	{
		return null;
	}

	public void SetConditions(JsonNode json)
	{
	}

	public static bool CheckAngle(Vector3 v)
	{
		return false;
	}

	public static bool CheckAngle(float f)
	{
		return false;
	}
}
