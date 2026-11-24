using System;
using System.Collections.Generic;
using UnityEngine;

public class CFieldHand : CCharDef
{
	private class ORG_PARENT
	{
		public Transform himself;

		public Transform parent;

		public int index;

		public ORG_PARENT(Transform t)
		{
		}

		public void ComebackParent()
		{
		}

		public void ComebackIndex()
		{
		}
	}

	private enum MODE
	{
		None = 0,
		MoveStart = 1,
		Move = 2,
		Shake = 3,
		Roll = 4,
		To_The_Stratosphere = 5,
		RollWait = 6,
		Online_Received = 7,
		Stop = 8,
		End = 9
	}

	private static GameController.PADNUM mPadNum;

	[SerializeField]
	private Transform mDiceCollider;

	[SerializeField]
	private Vector3 mPosition;

	[SerializeField]
	private float[] mYShake;

	[SerializeField]
	private float mShakeRadius;

	private float[] mEasingTime;

	private CFramingCamera mFramingCamera;

	private CGroupCamera mGroupCamera;

	private Transform[] mDiceTemp;

	private List<CFieldDice> mDice;

	private List<CFieldDice> mUIDice;

	private CFramingCamera.FOLLOW mFollowPosition;

	private Vector3 mCameraZoom;

	private float mWait;

	private int mDiceNum;

	private int mRestDiceNum;

	private Vector3[] mDiceOffset;

	private DateTime mShakeTime;

	private ORG_PARENT[] mOrgParent;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private bool mIsControl;

	private CFieldPlayer mPlayer;

	private static Vector3 mPos_DiceY;

	private static Vector3[][] mPos_Dice3;

	private static Vector3[][] mPos_Dice2;

	private static Vector3[][] mPos_Dice1;

	public static void SetPadNum(GameController.PADNUM a)
	{
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public void Setup(CFramingCamera _fc, CGroupCamera _gc)
	{
	}

	public void SetDice(List<CFieldDice> _dice, List<CFieldDice> _uidice)
	{
	}

	public int GetRestDiceNum()
	{
		return 0;
	}

	public void MakeDiceParent()
	{
	}

	public void MoveDiceParent(Transform parent)
	{
	}

	public void ReturnDiceParent()
	{
	}

	public void ReturnDiceIndex()
	{
	}

	public bool IsRoll()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public void RollTheDice(bool isControl, CFieldPlayer player, Vector3 center, int num)
	{
	}

	public void RollTheDice(Vector3 center, int num)
	{
	}

	private void Update()
	{
	}
}
