using System;
using UnityEngine;
using UnityEngine.Rendering;

[Serializable]
[VolumeComponentMenu("Sting/RangebasedChroma")]
public class CRangebasedChromaVolume : VolumeComponent
{
	public ClampedFloatParameter m_Weight;

	public FloatRangeParameter m_U_Weight;

	public FloatRangeParameter m_U_Range;

	public FloatRangeParameter m_V_Weight;

	public FloatRangeParameter m_V_Range;

	public ColorParameter m_Color;

	public Vector4 ParamU => default;

	public Vector4 ParamV => default;

	public bool IsActive()
	{
		return false;
	}

	public void SetWeight(float a)
	{
	}

	public void SetU_Weight(Vector2 a)
	{
	}

	public void SetU_Range(Vector2 a)
	{
	}

	public void SetV_Weight(Vector2 a)
	{
	}

	public void SetV_Range(Vector2 a)
	{
	}

	public void SetColor(Color a)
	{
	}
}
