using UnityEngine;

public class CCharMeshFade : MonoBehaviour
{
	private LODGroup _LODGroup;

	[SerializeField]
	[ReadOnly]
	private Collider _Collider;

	[SerializeField]
	[ReadOnly]
	private Transform _Camera;

	[SerializeField]
	[ReadOnly]
	private bool _AutomaticMode;

	[SerializeField]
	[ReadOnly]
	private Transform _Target;

	public bool _IsVisible;

	public bool _EnableCameraDistance;

	public float _CameraDistance;

	private Vector3 m_Offset;

	public void SetCollider(Collider c)
	{
	}

	private void Awake()
	{
	}

	public static void SetMeshFadeDulation(float i_Seconds)
	{
	}

	public void UpdateVisibility()
	{
	}

	public void SetVisible(bool i_Visible)
	{
	}

	public void SetAutomaticFade(bool i_IsActive, Transform i_Camera = null, Transform i_Target = null, Vector3? i_Offset = null)
	{
	}

	public void SetFadeMode(LODFadeMode i_Mode)
	{
	}

	public void SetCameraDistance(bool a, float d = 0f)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private bool IsInCollider(Vector3 i_Position)
	{
		return false;
	}
}
