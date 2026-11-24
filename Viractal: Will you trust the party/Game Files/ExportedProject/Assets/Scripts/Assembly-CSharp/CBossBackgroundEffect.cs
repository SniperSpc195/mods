using System;
using UnityEngine;

public class CBossBackgroundEffect : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public Gradient m_Gradient;

		public Vector2 m_TimeScaleMinMax;

		public Vector2 m_DistortionMinMax;

		public float m_LoopTime;

		public void ReadValue(float i_Time, out Color o_Color, out float o_TimeSlace, out float o_Distortion)
		{
			o_Color = default;
			o_TimeSlace = default;
			o_Distortion = default;
		}
	}

	public static CBossBackgroundEffect Instance;

	[SerializeField]
	private Settings m_Low;

	[SerializeField]
	private Settings m_High;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_Progress;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_Weight;

	[SerializeField]
	private Renderer m_Renderer;

	private double m_DamageTime;

	private float m_LowTime;

	private float m_HighTime;

	private MaterialPropertyBlock m_Props;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void SetProgress(float i_Progress)
	{
	}

	public void SetWeight(float i_Weight)
	{
	}

	public void OnDamage()
	{
	}
}
