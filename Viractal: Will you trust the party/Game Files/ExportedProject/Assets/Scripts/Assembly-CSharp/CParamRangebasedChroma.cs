using System;
using UnityEngine;
using UnityEngine.Rendering;

[Serializable]
public class CParamRangebasedChroma
{
	public ClampedFloatParameter m_Weight;

	public FloatRangeParameter m_U_Weight;

	public FloatRangeParameter m_U_Range;

	public FloatRangeParameter m_V_Weight;

	public FloatRangeParameter m_V_Range;

	public ColorParameter m_Color;

	public float GetWeight(CParamRangebasedChroma p, float t)
	{
		return 0f;
	}

	public Vector2 GetU_Weight(CParamRangebasedChroma p, float t)
	{
		return default;
	}

	public Vector2 GetU_Range(CParamRangebasedChroma p, float t)
	{
		return default;
	}

	public Vector2 GetV_Weight(CParamRangebasedChroma p, float t)
	{
		return default;
	}

	public Vector2 GetV_Range(CParamRangebasedChroma p, float t)
	{
		return default;
	}

	public Color GetColor(CParamRangebasedChroma p, float t)
	{
		return default;
	}

	public void Set(CParamRangebasedChroma p)
	{
	}

	public void Set(CParamRangebasedChroma p, float t)
	{
	}
}
