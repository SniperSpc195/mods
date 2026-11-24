using Cinemachine;
using UnityEngine;

public class CGroupCamera : CBaseFieldCamera
{
	[SerializeField]
	private CinemachineTargetGroup mTargetGroup;

	private void Awake()
	{
	}

	public CinemachineFramingTransposer GetFramingTransposer()
	{
		return null;
	}

	public void SetFollowTarget(Transform[] t)
	{
	}

	public void SetFollowTarget(CinemachineTargetGroup.Target[] t)
	{
	}

	public CinemachineTargetGroup.Target[] GetFollowTarget()
	{
		return null;
	}
}
