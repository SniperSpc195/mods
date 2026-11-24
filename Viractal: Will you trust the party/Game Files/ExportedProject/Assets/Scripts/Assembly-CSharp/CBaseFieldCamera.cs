using Cinemachine;
using UnityEngine;

public class CBaseFieldCamera : MonoBehaviour
{
	[SerializeField]
	protected CinemachineVirtualCamera mVCam;

	protected CinemachineFramingTransposer mFramingTransposer;

	protected LensSettings mLensSettings;

	[SerializeField]
	protected Vector3 mOrgDamping;

	[SerializeField]
	protected Vector3 mOrgDeadZone;

	public void Select(bool a)
	{
	}
}
