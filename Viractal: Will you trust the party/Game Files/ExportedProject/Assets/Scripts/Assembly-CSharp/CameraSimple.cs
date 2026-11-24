using System;
using UnityEngine;

[Serializable]
public class CameraSimple
{
	public float mFov;

	public Vector3 mLookAt;

	public Vector3 mPosition;

	public Vector3 mUpVector;

	public CameraSimple(Vector3 lookat, Vector3 position, Vector3? up = null)
	{
	}

	public CameraSimple(CameraSimple a)
	{
	}

	public void Update(Transform transform, Vector3 vib)
	{
	}

	public Vector2 DebugPrint(Transform parent, Vector2 pos)
	{
		return default;
	}
}
