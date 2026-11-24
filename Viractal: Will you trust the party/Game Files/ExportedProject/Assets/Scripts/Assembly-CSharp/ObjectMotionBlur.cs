using System;
using UnityEngine.Rendering;

[Serializable]
[VolumeComponentMenu("Custom/Object Motion Blur")]
public class ObjectMotionBlur : VolumeComponent
{
	public ClampedFloatParameter shutterAngle;

	public ClampedIntParameter sampleCount;

	public bool IsActive()
	{
		return false;
	}
}
