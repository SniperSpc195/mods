using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerDiceNum : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Start_Anime = 1,
		Spline = 2,
		Following = 3,
		Countdown = 4,
		Hide = 5
	}

	[SerializeField]
	private Text mNumText;

	[SerializeField]
	private RectTransform mMoveTransform;

	[SerializeField]
	private Vector3 mOffsetPlayerNum;

	private Vector3 mTargetOffset;

	[SerializeField]
	[ReadOnly]
	private Transform mTarget;

	[SerializeField]
	[ReadOnly]
	private Vector2 mUIPosition;

	[SerializeField]
	private float mSplineCreateStep;

	[SerializeField]
	private float mSplineMoveStep;

	[SerializeField]
	[ReadOnly]
	private List<Vector2> mSplineData;

	[SerializeField]
	[ReadOnly]
	private float mSplineIndex;

	private CAnimePlayer mAnimePlayer;

	private int mNum;

	[SerializeField]
	[ReadOnly]
	private bool mScreenOverflow;

	private MODE mMode;

	private Color mColor;

	private float mAlpha;

	private float[] m3DPanelX;

	private float[] m3DPanelY;

	public RectTransform GetNumParent()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Show()
	{
	}

	public void Hide(bool countdown = false)
	{
	}

	public int GetNum()
	{
		return 0;
	}

	public void SetNum(int n, int add = 0)
	{
	}

	public Vector2 MakeUIPosition(Camera camera, Vector3 pos)
	{
		return default;
	}

	public Vector3 MakePosition(Vector3 pos)
	{
		return default;
	}

	public void SetSpline(Vector2 sPos, Transform target)
	{
	}

	public void SetSplineEnd(int num, int add, Transform target)
	{
	}

	public void SetSpline(Vector2 sPos, Transform target, Vector3 offset)
	{
	}

	public bool IsFollowing()
	{
		return false;
	}

	private void LateUpdate()
	{
	}
}
