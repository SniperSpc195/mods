using System;
using UnityEngine;

[Serializable]
public class HexDupPosition
{
	[Serializable]
	public class INIT_DATA
	{
		public Vector3 position;

		public Vector3 scale;

		public INIT_DATA(Vector3 p, float s)
		{
		}
	}

	private INIT_DATA mData;

	public TransformOffset mOffset;

	public bool mSingleGrid;

	public INIT_DATA GetData()
	{
		return null;
	}

	public INIT_DATA Start(INIT_DATA data, float ts)
	{
		return null;
	}

	public void Update()
	{
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public Vector3 GetPosition()
	{
		return default;
	}

	public Vector3 GetAngle()
	{
		return default;
	}

	public Vector3 GetScale()
	{
		return default;
	}
}
