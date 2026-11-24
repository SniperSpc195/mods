using System;
using UnityEngine;

public class CWallClock : SingletonMonoBehaviour<CWallClock>
{
	private Transform mHandsHour;

	private Vector3 mAngHour;

	private Transform mHandsMinute;

	private Vector3 mAngMinute;

	private int mHour;

	private int mMinute;

	private int mSecond;

	private DateTime mPreviousRing;

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void SetClock(int hour, int minute, int second)
	{
	}
}
