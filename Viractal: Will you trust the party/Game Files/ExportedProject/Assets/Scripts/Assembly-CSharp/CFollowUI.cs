using UnityEngine;

public class CFollowUI : MonoBehaviour
{
	[SerializeField]
	private Canvas m_Canvas;

	[SerializeField]
	private bool m_LockX;

	[SerializeField]
	private bool m_LockY;

	public Transform m_Target { get; set; }

	public Vector3 m_Offset { get; set; }

	public Camera m_Camera { get; set; }

	private void LateUpdate()
	{
	}
}
