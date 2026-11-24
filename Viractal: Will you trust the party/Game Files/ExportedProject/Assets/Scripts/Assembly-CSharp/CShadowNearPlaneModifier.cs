using UnityEngine;

[RequireComponent(typeof(Light))]
public class CShadowNearPlaneModifier : MonoBehaviour
{
	[SerializeField]
	private float m_ModifiedNearClipPlane;

	private Light _light;

	private Light m_Light => null;

	private void Start()
	{
	}
}
