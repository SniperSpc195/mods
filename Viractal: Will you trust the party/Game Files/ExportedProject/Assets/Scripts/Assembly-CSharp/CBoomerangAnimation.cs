using System;
using UnityEngine;

public class CBoomerangAnimation : MonoBehaviour
{
	[Serializable]
	private struct Context
	{
		[Header("投擲アニメーション名")]
		public string animation;

		[Header("アニメーションハッシュ（設定不要）")]
		public int hash;

		[Header("本体のアニメータ")]
		public Animator animator;

		[Header("投擲パーツ")]
		public GameObject gameObject;

		[Header("投擲開始位置")]
		public Vector3 near;

		[Header("投擲最長位置")]
		public Vector3 far;

		[Header("投擲距離")]
		public float distance;

		[Header("投擲開始フレーム")]
		public float startFrame;

		[Header("投擲終了フレーム")]
		public float endFrame;
	}

	[SerializeField]
	private Context[] m_Data;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetDistance(string animation, float distance)
	{
	}

	public void Play(string animation)
	{
	}
}
