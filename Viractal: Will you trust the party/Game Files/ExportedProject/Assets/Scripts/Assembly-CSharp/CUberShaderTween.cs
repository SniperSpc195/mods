using System;
using UnityEngine;

[AddComponentMenu("Effects/UberShaderTween")]
[RequireComponent(typeof(Renderer))]
public class CUberShaderTween : MonoBehaviour
{
	[Serializable]
	public struct Property<T>
	{
		public bool m_Enabled;

		public T m_Start;

		public T m_End;
	}

	private static readonly int _ColorScalerKey;

	private static readonly int _HighColorKey;

	private static readonly int _MidColorKey;

	private static readonly int _LowColorKey;

	[SerializeField]
	public float m_DurationSeconds;

	[SerializeField]
	public bool m_UseUnscaledTime;

	[SerializeField]
	public Property<float> m_ColorScaler;

	[SerializeField]
	public Property<Color> m_HighColor;

	[SerializeField]
	public Property<Color> m_MidColor;

	[SerializeField]
	public Property<Color> m_LowColor;

	private MaterialPropertyBlock m_Property;

	private Renderer _renderer;

	private Renderer m_Renderer => null;

	private void Update()
	{
	}

	private float GetInterpolateParam()
	{
		return 0f;
	}

	public void UpdateProperties()
	{
	}
}
