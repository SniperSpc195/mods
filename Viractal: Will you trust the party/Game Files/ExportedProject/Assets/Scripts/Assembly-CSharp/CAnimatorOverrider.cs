using UnityEngine;

[AddComponentMenu("Debug/AnimatorOverrider")]
[RequireComponent(typeof(Animator))]
[DefaultExecutionOrder(100)]
[ExecuteAlways]
public class CAnimatorOverrider : MonoBehaviour
{
	public int m_Layer;

	public string State;

	public float Time;

	private string state;

	private float time;

	private Animator _animator;

	private string[] m_States;

	public Animator Animator => null;

	public string[] States => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnValidate()
	{
	}
}
