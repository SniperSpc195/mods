using System.Collections.Generic;
using UnityEngine;

public class CHexCloud : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Open = 1
	}

	public class ScaleUp
	{
		private const float Speed = 0.04f;

		private float mEasing;

		public float Update()
		{
			return 0f;
		}

		public bool IsEnd()
		{
			return false;
		}
	}

	public CHexPosition mCHexPosition;

	private float mScale;

	private float mOpenWait;

	private MODE mMode;

	private const float OpenTime = 15f;

	private const float ScaleDown = 0.06f;

	private List<CHexCloud> mCompList;

	public void Initialize(CHexPosition hex, float scale)
	{
	}

	public Vector3 GetPopupOffset()
	{
		return default;
	}

	public void ClearingClouds(List<CHexCloud> list, int mostNear, Vector3Int playerPosition)
	{
	}

	public void Clearing(bool reqSe = true)
	{
	}

	private void Update()
	{
	}
}
