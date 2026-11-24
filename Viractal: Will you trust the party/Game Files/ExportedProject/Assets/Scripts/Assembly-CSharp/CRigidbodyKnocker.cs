using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CRigidbodyKnocker : MonoBehaviour
{
	[SerializeField]
	private Vector3 m_ReferenceLocalPosition;

	[SerializeField]
	private Quaternion m_ReferenceLocalRotation;

	[SerializeField]
	private float m_SquareThreshould;

	[SerializeField]
	private int m_SleepFrameCount;

	private Collider _Collider;

	private int m_WaitFrame;

	public float m_DegreeThreshould;

	private float m_AngleThreshould;

	public Action m_Callback { get; set; }

	public Rigidbody m_Rigidbody { get; private set; }

	public Collider Collider => null;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private bool IsInvalidPosition()
	{
		return false;
	}
}
