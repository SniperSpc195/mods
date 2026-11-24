using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/TestCameraData", fileName = "testCameraData.asset")]
public class TestCameraData : ScriptableObject
{
	[SerializeField]
	[Range(1f, 179f)]
	public float m_FOV;

	[SerializeField]
	public bool m_UsePhysicalProperties;

	[SerializeField]
	public float m_FocalLength;

	[SerializeField]
	public Vector2 m_LensShift;

	[SerializeField]
	public Vector2 m_SensorSize;

	[SerializeField]
	public float m_Longitude;

	[SerializeField]
	public float m_Latitude;

	[SerializeField]
	public float m_Distance;

	[SerializeField]
	[ReadOnly]
	public string m_Target;

	[SerializeField]
	public Vector3 m_Offset;

	private Transform _target;

	public Transform Target => null;

	private void OnValidate()
	{
	}

	public void Invalidate()
	{
	}
}
