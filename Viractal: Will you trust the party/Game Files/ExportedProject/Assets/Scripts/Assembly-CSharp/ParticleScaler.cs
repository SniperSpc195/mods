using UnityEngine;

public class ParticleScaler : MonoBehaviour
{
	private ParticleSystem[] particleSystems;

	private Light[] lights;

	private Transform parentTransform;

	private float lastScale;

	private ParticleSystem.MinMaxCurve[] initialNoiseStrength;

	private ParticleSystem.MinMaxCurve[] initialNoiseScrollSpeed;

	private float[] initialLightRange;

	private float[] initialLightIntensity;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateScaleAdjustments()
	{
	}

	private ParticleSystem.MinMaxCurve ScaleMinMaxCurve(ParticleSystem.MinMaxCurve original, float scaleFactor)
	{
		return default;
	}
}
