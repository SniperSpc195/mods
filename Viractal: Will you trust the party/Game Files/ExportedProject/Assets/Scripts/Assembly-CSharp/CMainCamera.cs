using UnityEngine;

public class CMainCamera : SingletonMonoBehaviour<CMainCamera>
{
	public enum MODE
	{
		SIMPLE = 0,
		PARALLEL = 1,
		BATTLE = 2,
		FREEMOVE = 3
	}

	public const float DEFAULT_FOV = 26f;

	public CameraSimple mSimple;

	public CameraFreeMove mFreeMove;

	public MODE mMode;

	private Camera mCamera;

	public bool Active(bool a)
	{
		return false;
	}

	public void SetMode(MODE mode)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
