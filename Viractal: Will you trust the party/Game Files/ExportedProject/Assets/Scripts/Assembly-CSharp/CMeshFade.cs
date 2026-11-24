using UnityEngine;

public class CMeshFade : MonoBehaviour
{
	private LODGroup _LODGroup;

	private Collider _Collider;

	private Transform _Camera;

	private bool _AutomaticMode;

	private Transform _Target;

	public bool _IsVisible;

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

	public void SetAutomaticFade(bool i_IsActive, Transform i_Camera = null, Transform i_Target = null)
	{
	}

	public void SetFadeMode(LODFadeMode i_Mode)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}
}
