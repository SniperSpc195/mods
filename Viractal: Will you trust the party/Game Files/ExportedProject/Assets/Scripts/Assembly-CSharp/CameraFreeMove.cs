using System;
using UnityEngine;

[Serializable]
public class CameraFreeMove
{
	public float mFov;

	public Vector3 mAngle;

	public Vector3 mLookAt;

	public Vector3 mPosition;

	public float mMoveSpeed;

	public float mRotSpeed;

	private Vector3 mCurrentAt;

	public bool mMoveOk;

	public Vector3 At => default;

	public CameraFreeMove(Vector3 position, Vector3 angle)
	{
	}

	public CameraFreeMove(CameraFreeMove a)
	{
	}

	public void Update(Transform transform)
	{
	}

	public Vector2 DebugPrint(Transform parent, Vector2 pos)
	{
		return default;
	}
}
