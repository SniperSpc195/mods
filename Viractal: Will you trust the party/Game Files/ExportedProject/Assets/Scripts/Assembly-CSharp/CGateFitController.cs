using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CGateFitController : MonoBehaviour
{
	[SerializeField]
	private float m_VerticalFocalLength;

	[SerializeField]
	private float m_HorizontalFocalLength;

	[SerializeField]
	private Vector2 m_ReferenceScreenRatio;

	private Camera _camera;

	private Vector2Int? m_ScreenSize;

	private Camera m_Camera => null;

	private void Update()
	{
	}

	private void UpdateGateFit(Vector2Int screenSize)
	{
	}
}
