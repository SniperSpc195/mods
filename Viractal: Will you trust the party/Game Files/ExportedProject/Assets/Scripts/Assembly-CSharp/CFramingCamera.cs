using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class CFramingCamera : CBaseFieldCamera
{
	private enum CROSS
	{
		None = 0,
		Start_1 = 1,
		Start_2 = 2,
		Start_3 = 3,
		Continue = 4
	}

	[Serializable]
	public class FOLLOW
	{
		public Vector3 pos;

		public Vector3 offset;

		public bool set;

		public bool checkCrossFade;

		public FOLLOW(Vector3 _pos, bool _set, bool _checkCrossFade)
		{
		}

		public FOLLOW(Vector3 _pos, Vector3 _offset, bool _set, bool _checkCrossFade)
		{
		}

		public Vector3 GetPosition()
		{
			return default;
		}
	}

	private enum MOVE
	{
		None = 0,
		On = 1,
		OneFrame = 2
	}

	[Serializable]
	private struct CAM_XangDist
	{
		public Vector3 v;

		public float speed;

		public float mouseDragSpeed;

		public float shadowDistance;

		public float farClipPlane;
	}

	[Serializable]
	private class PARAM_DOF
	{
		public float m_Start;

		public float m_End;

		public float m_MaxRadius;

		public PARAM_DOF(PARAM_DOF a)
		{
		}

		public Vector3 Lerp(PARAM_DOF target, float t)
		{
			return default;
		}

		public void Set(PARAM_DOF target, float t)
		{
		}
	}

	public class Backup
	{
		public Vector3 mDeadzone;

		public Vector3 mDamping;

		public Vector3 mFollowPosition;

		public int mDistI;

		public Vector3 mDistTarget;
	}

	private const float CAM_FADESPD = 1f / 14f;

	[SerializeField]
	private Transform mVCamFollow;

	private Vector3 ReserveVCamFollow;

	[SerializeField]
	private Vector3 mScreenPos;

	[SerializeField]
	private CLookatCamera mLookAtCam;

	[SerializeField]
	private Camera mMainCamera;

	[SerializeField]
	private RawImage mCrossFadeImage;

	private RenderTexture mRenderTexture;

	private float mCrossFadeAlpha;

	[SerializeField]
	[ReadOnly]
	private CROSS mCrossMode;

	private FOLLOW mFollow;

	[SerializeField]
	private FOLLOW m_FollowBackup;

	[SerializeField]
	[ReadOnly]
	private MOVE mMove;

	[SerializeField]
	private CAM_XangDist[] mCamDistData;

	[SerializeField]
	[ReadOnly]
	private int mCamDistI;

	[SerializeField]
	private float mTopView_XAngle;

	[SerializeField]
	private bool mTopView;

	private const float DEF_FARCLIP = 500f;

	private float[] mLerpFar;

	private float mTargetFarClip;

	private float mBaseFarClip;

	private bool mEnableZoomFarClip;

	private Vector3 mCamDistNow;

	[SerializeField]
	private Vector3 mCamDistTarget;

	private Vector3 mVelocity;

	[SerializeField]
	private Vector3 mCalcLookAtPosition;

	[SerializeField]
	private float mCamDistTime;

	[SerializeField]
	private Vector3 mDamping;

	[SerializeField]
	[ReadOnly]
	private CRangebasedChromaVolume mRangebasedChromaVolume;

	[SerializeField]
	private CParamRangebasedChroma[] mParamRangebasedChroma;

	private CParamRangebasedChroma mOldRangebasedChroma;

	[SerializeField]
	[ReadOnly]
	private int mRangebasedChromaI;

	[SerializeField]
	[ReadOnly]
	private float mRangebasedChromaT;

	[SerializeField]
	[ReadOnly]
	private float mCamDistF;

	private Vector3 mOldCameraPosition;

	[SerializeField]
	[ReadOnly]
	private float mCamMoveDistance;

	[SerializeField]
	[ReadOnly]
	private DepthOfField mDOF;

	[SerializeField]
	private PARAM_DOF[] mParamDOF;

	private PARAM_DOF mOldDOF;

	private float mShadowDistance;

	public float ShadowDistance => 0f;

	public bool IsNowCrossFade()
	{
		return false;
	}

	public float GetCrossFadeAlpha()
	{
		return 0f;
	}

	public void ChangeTopView()
	{
	}

	public void ResetTopView()
	{
	}

	public float GetFarClipPlane()
	{
		return 0f;
	}

	public void SetFarClipPlane(float a)
	{
	}

	public void EnableZoomFarClip(bool a)
	{
	}

	public float GetCamDistSpeed()
	{
		return 0f;
	}

	public float GetCamDistMouseSpeed()
	{
		return 0f;
	}

	public float GetCameraMoveDistance()
	{
		return 0f;
	}

	public Backup MakeBackup()
	{
		return null;
	}

	public void WriteBack(Backup bk)
	{
	}

	private void Awake()
	{
	}

	public void SetGlovalVolume(GameObject g)
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public FOLLOW SetFollowPosition(Vector3 p, bool set = false, bool checkCrossFade = true)
	{
		return null;
	}

	public FOLLOW SetFollowPosition(Vector3 p, Vector3 offset, bool set = false, bool checkCrossFade = true)
	{
		return null;
	}

	public void SetFollowPosition(FOLLOW f)
	{
	}

	public Vector3 GetFollowPosition()
	{
		return default;
	}

	public float GetFollowDistance()
	{
		return 0f;
	}

	public Vector3 GetDamping()
	{
		return default;
	}

	public void SetDamping(float a)
	{
	}

	public void SetDamping(Vector3 a)
	{
	}

	public void SetDeafultDamping()
	{
	}

	public Vector3 GetDeadZone()
	{
		return default;
	}

	public void SetDeadZone(Vector3 v)
	{
	}

	public void SetDefaultDeadZone()
	{
	}

	public void SetOneFrame()
	{
	}

	public int GetCamDistI()
	{
		return 0;
	}

	public bool GetTopView()
	{
		return false;
	}

	public void SetCamDist(int i, bool topView)
	{
	}

	public bool IsCamDistMin()
	{
		return false;
	}

	public bool IsCamDistMax()
	{
		return false;
	}

	public int ZoomIn()
	{
		return 0;
	}

	public int ZoomOut()
	{
		return 0;
	}

	public void SetZoom(int i)
	{
	}

	public void SetZoom(Vector3 v)
	{
	}

	public Vector3 GetZoom()
	{
		return default;
	}

	public void SetLookatPosition(Vector3 p, Vector3 offset)
	{
	}

	public void DefaultLookat()
	{
	}

	private void SetupFollow()
	{
	}

	private void SetCrossFade(Vector3 p)
	{
	}

	public void UpdateCamera()
	{
	}

	public void Setup(CGroupCamera gc)
	{
	}

	private void SetPosteffectAutorange()
	{
	}
}
