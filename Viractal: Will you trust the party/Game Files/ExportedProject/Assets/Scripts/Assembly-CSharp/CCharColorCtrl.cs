using System;
using System.Collections.Generic;
using UnityEngine;

public class CCharColorCtrl : MonoBehaviour
{
	[Serializable]
	public class LerpParam
	{
		public enum MODE
		{
			Linear = 0,
			PingPong = 1
		}

		public float mParam;

		private float mNow;

		private float mTarget;

		private float mLerp;

		public float mSec;

		public Vector2 mPingPong;

		private float mLerpPingPong;

		public MODE mMode;

		[SerializeField]
		[ReadOnly]
		private float mDefault;

		[SerializeField]
		[ReadOnly]
		private Vector2 mMinMax;

		private bool mExec;

		public bool IsExec()
		{
			return false;
		}

		public bool IsEnd()
		{
			return false;
		}

		public bool IsPingPong()
		{
			return false;
		}

		public void SetExec()
		{
		}

		public LerpParam(float def, float min, float max)
		{
		}

		public bool IsValidParam(float a)
		{
			return false;
		}

		public bool IsValidParam(float a, float b)
		{
			return false;
		}

		public float GetParam()
		{
			return 0f;
		}

		public void Reset(float sec = 0f)
		{
		}

		public void SetTarget(float target, float sec)
		{
		}

		public void SetMin(float sec)
		{
		}

		public void SetMax(float sec)
		{
		}

		public void SetPingPong(float min, float max, float sec)
		{
		}

		public void StartPingPong()
		{
		}

		public float Update()
		{
			return 0f;
		}
	}

	[Serializable]
	public class ShaderParam
	{
		public enum SHADER
		{
			_Contrast = 0,
			_Hue = 1,
			_Saturation = 2,
			_Max = 3
		}

		[SerializeField]
		[ReadOnly]
		private Renderer mRenderer;

		[SerializeField]
		[ReadOnly]
		private Material mMaterial;

		[SerializeField]
		[ReadOnly]
		private int mMatIndex;

		[SerializeField]
		[ReadOnly]
		private string mShaderName;

		private MaterialPropertyBlock mMaterialPropertyBlock;

		private static int[] mPropertyNum;

		public ShaderParam(Renderer render, Material mat, int matIndex, string name)
		{
		}

		public void Set(float contrast, float hue, float saturation)
		{
		}
	}

	public LerpParam mContrast;

	public LerpParam mHue;

	public LerpParam mSaturation;

	public List<ShaderParam> mShaderParams;

	private string[] ShaderNames;

	public bool IsValid()
	{
		return false;
	}

	public void Linear(float _contrast, float _hue, float _saturation, float _sec)
	{
	}

	public void PingPong(float _c0, float _c1, float _h0, float _h1, float _s0, float _s1, float _sec)
	{
	}

	public void ResetAll(float _sec)
	{
	}

	public bool IsExec()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
