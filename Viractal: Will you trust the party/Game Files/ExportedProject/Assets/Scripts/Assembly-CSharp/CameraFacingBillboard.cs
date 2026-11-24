using UnityEngine;

public class CameraFacingBillboard : MonoBehaviour, IBillboard
{
	public enum Axis
	{
		up = 0,
		down = 1,
		left = 2,
		right = 3,
		forward = 4,
		back = 5,
		none = 6
	}

	[SerializeField]
	private Camera referenceCamera;

	public bool reverseFace;

	public Axis axis;

	private Camera settingCamera;

	private Camera _referenceCamera => null;

	public Vector3 GetAxis(Axis refAxis)
	{
		return default;
	}

	public void SetReferenceCamera(Camera i_Camera)
	{
	}

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetFace()
	{
	}
}
