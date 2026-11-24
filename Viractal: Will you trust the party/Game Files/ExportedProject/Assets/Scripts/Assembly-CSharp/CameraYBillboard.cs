using UnityEngine;

public class CameraYBillboard : MonoBehaviour, IBillboard
{
	[SerializeField]
	private Camera referenceCamera;

	private Camera settingCamera;

	private Camera _referenceCamera => null;

	public void SetReferenceCamera(Camera i_Camera)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetFace()
	{
	}
}
