using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CFieldLight
{
	[SerializeField]
	[ReadOnly]
	private Light mLight;

	[SerializeField]
	[ReadOnly]
	private Color mOrgColor;

	public Color mBaseColor;

	public Color mTargetColor;

	public Color mNowColor;

	public float[] mLerpColor;

	[SerializeField]
	[ReadOnly]
	private float mOrgIntensity;

	public float mBaseIntensity;

	public float mTargetIntensity;

	public float mNowIntensity;

	public float[] mLerpIntensity;

	public CFieldLight(Light light)
	{
	}

	public void SetOrgIntensity(float a)
	{
	}

	public bool IsFade()
	{
		return false;
	}

	public void FadeStart(Color tColor, float tIntensity, float time)
	{
	}

	public void FadeColor(Color tColor, float time)
	{
	}

	public void FadeColor(float time)
	{
	}

	public void FadeIntensity(float tIntensity, float time)
	{
	}

	public void Update()
	{
	}

	public void SyncLight()
	{
	}

	public void Load(JsonNode json)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	private float[] SaveColor(Color c)
	{
		return null;
	}
}
