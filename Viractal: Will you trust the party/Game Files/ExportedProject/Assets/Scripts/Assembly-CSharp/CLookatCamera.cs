using Cinemachine;
using UnityEngine;

public class CLookatCamera : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		ToTarget = 1,
		Stop = 2,
		ToStart = 3,
		End = 4
	}

	[SerializeField]
	private Camera mMainCamera;

	[SerializeField]
	private CinemachineBrain mVCam;

	[SerializeField]
	[ReadOnly]
	private Vector3 mStartPosition;

	[SerializeField]
	[ReadOnly]
	private Vector3 mTargetPosition;

	[SerializeField]
	[ReadOnly]
	private float mLerp;

	[SerializeField]
	private float mSpeed;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	public bool IsExec()
	{
		return false;
	}

	public bool IsStop()
	{
		return false;
	}

	public void ToTarget(Vector3 start, Vector3 target)
	{
	}

	public void ToStart()
	{
	}

	private void Update()
	{
	}
}
