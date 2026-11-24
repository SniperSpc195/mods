using UnityEngine;

public class CHitNode : MonoBehaviour
{
	[SerializeField]
	private Transform m_Hit;

	[SerializeField]
	private Transform m_Effect1;

	[SerializeField]
	private Transform m_Cursor;

	[SerializeField]
	private Collider m_Collider;

	[SerializeField]
	private Collider m_OuterCollider;

	[SerializeField]
	private Transform m_Parts;

	public Transform Hit => null;

	public Transform Effect1 => null;

	public Transform Cursor => null;

	public Collider Collider => null;

	public Collider OuterCollider => null;

	public Transform Parts => null;
}
