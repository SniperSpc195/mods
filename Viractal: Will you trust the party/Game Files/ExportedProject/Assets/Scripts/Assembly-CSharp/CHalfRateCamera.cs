using UnityEngine;

[AddComponentMenu("Model/HalfRateCamera")]
[RequireComponent(typeof(Camera))]
[DefaultExecutionOrder(-1)]
public class CHalfRateCamera : MonoBehaviour
{
	private Camera? _camera;

	private int m_FlipCounter;

	[SerializeField]
	private int m_Rate;

	private Camera? Camera => null;

	public void SetRate(int i_Rate)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
