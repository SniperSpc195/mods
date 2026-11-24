using System.Collections.Generic;
using UnityEngine;

public class CItemIcon_Obtained : MonoBehaviour
{
	private enum MODE
	{
		Active = 0,
		End = 1
	}

	private List<Vector2> mSplineData;

	private float mSplineIndex;

	private const float mSplineCreateStep = 0.03f;

	private const float mSplineMoveStep = 1f;

	private MODE mMode;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetTarget(int n, Vector2 target)
	{
	}

	public bool IsExec()
	{
		return false;
	}

	private void Update()
	{
	}
}
