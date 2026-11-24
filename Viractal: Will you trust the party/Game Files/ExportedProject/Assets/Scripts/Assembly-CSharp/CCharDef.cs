using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sting.Rigging;
using UnityEngine;
using UnityEngine.Animations;

public class CCharDef : MonoBehaviour
{
	protected struct PositionSE
	{
		public long handle;

		public string se;

		public PositionSE(long h, string req)
		{
			handle = 0L;
			se = null;
		}
	}

	public enum APPEARANCE
	{
		None = 0,
		Default = 1,
		Fall = 2
	}

	[CompilerGenerated]
	private sealed class _003CUpdateFlashColor_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float i_TimeFI;

		public Color i_Color;

		public CCharDef _003C_003E4__this;

		public float i_TimeDuration;

		public float i_TimeFO;

		public bool i_Loop;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateFlashColor_003Ed__107(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_StartShake_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CCharDef _003C_003E4__this;

		public float i_Time;

		public float i_Velocity;

		public Vector3 i_Magnitude;

		private Vector3 _003CbasePosition_003E5__2;

		private double _003CstartTime_003E5__3;

		private float _003CstartX_003E5__4;

		private float _003CstartY_003E5__5;

		private float _003CstartZ_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_StartShake_003Ed__98(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const float DUP_SCALE_DEF = 0.75f;

	public const float DUP_SCALE_BUILDING = 0.25f;

	public const float DUP_SCALE_EVOBJECT = 0.55f;

	public const float DUP_SCALE_TRESURE = 1f;

	public CCharMeshFade mMeshFade;

	public CCharColorCtrl mColorCtrl;

	protected MaterialPropertyBlock[] mBaseMaterialPropertyBlock;

	[SerializeField]
	[ReadOnly]
	protected CDefine.BaseColor mBaseColor;

	public CEventEnum.EVID mEVID;

	public Vector3Int mHexPosition;

	public CHexDef.DIR mDir;

	public float mPieceAngle;

	public Vector3 mWorldPosition;

	public Vector3 mAngle;

	public Vector3 mScale;

	private RotationY mRotationY;

	public TransformOffset mOffset;

	public HexDupPosition mDupPosition;

	public int mDupPriority;

	public CAnimePlayer mAnimePlayer;

	public CLookAtRig mLookAtRig;

	private Dictionary<string, GameObject> mNode;

	[NonSerialized]
	private CapsuleCollider[] _CapsuleCollider;

	[NonSerialized]
	private CHitNode _Hit;

	[NonSerialized]
	private CPedestal _Pedestal;

	protected string m_EnvironmentSE;

	protected long m_EnvironmentSEHandle;

	protected string m_EffectName;

	protected CEffectHandle m_EffectHandle;

	protected List<PositionSE> m_PositionSE;

	private CHexCloud.ScaleUp mScaleUp;

	private const float OFF_SCREEN_RIGHT = 16f;

	private const float OFF_SCREEN_UP = 10f;

	private const float OFF_SCREEN_DOWN = -10f;

	private const float APP_SPD = 0.05f;

	protected APPEARANCE mAppearanceState;

	public Falling mFalling;

	protected Rigidbody[] m_RigidBody;

	private ParentConstraint[] m_ParentConstraint;

	[SerializeField]
	[ColorUsage(true, true)]
	private Color m_LerpColor;

	private Renderer[] m_Renderer;

	private MaterialPropertyBlock mpb;

	private Coroutine m_FlashColor;

	public ParticleSystemForceField m_ParticleSystemForceField { get; protected set; }

	public CapsuleCollider[] m_CapsuleCollider => null;

	public CHitNode HitNode => null;

	public CPedestal Pedestal => null;

	public CSkill m_UsingSkill { get; private set; }

	public virtual Rigidbody[] RigidBody => null;

	public ParentConstraint[] ParentConstraint => null;

	public bool IsValidColorCtrl()
	{
		return false;
	}

	public void SetBaseColor(CDefine.BaseColor bc)
	{
	}

	public void SetPedestal(CPedestal i_Component)
	{
	}

	protected void OnDestroy()
	{
	}

	protected virtual void Awake()
	{
	}

	public virtual string ID()
	{
		return null;
	}

	public virtual string Name()
	{
		return null;
	}

	public void Active(bool a)
	{
	}

	public void Initialize()
	{
	}

	public HexDupPosition.INIT_DATA SetDupPosition(HexDupPosition.INIT_DATA data, float ts)
	{
		return null;
	}

	public void SetGameObjectName()
	{
	}

	public bool IsCloud()
	{
		return false;
	}

	public bool HidingClouds()
	{
		return false;
	}

	public void ReturnClouds()
	{
	}

	public Vector3 GetNowPosition()
	{
		return default;
	}

	public Transform GetTransformCursor()
	{
		return null;
	}

	public void SetTargetRig(Transform t = null)
	{
	}

	public void CancelRig()
	{
	}

	public void InitAnimePlayer(bool useFace = false)
	{
	}

	public bool IsCorrectHex()
	{
		return false;
	}

	public void SetAutoMMeshfade(bool _set, Transform _camera, Transform _target, Vector3? _offset = null)
	{
	}

	public void ShowBase(bool a)
	{
	}

	public void AddBase(Transform parent)
	{
	}

	public void ChangeBaseColor(CDefine.BaseColor bc)
	{
	}

	public void SetHexPosition(Vector3Int hex, CHexDef.DIR dir, CHexDef.DIR dispDir = CHexDef.DIR.None)
	{
	}

	public void RotationY(float target, int frame)
	{
	}

	public bool IsRotationY()
	{
		return false;
	}

	protected virtual void LateUpdate()
	{
	}

	public virtual GameController.PADNUM GetPadNum()
	{
		return GameController.PADNUM.PAD0;
	}

	public void TransformUpdate()
	{
	}

	public bool IsAppearanceFall()
	{
		return false;
	}

	public bool IsAppearance()
	{
		return false;
	}

	public void EvtAppearance(float dist, string ptn)
	{
	}

	public void EvtExit(string ptn)
	{
	}

	public virtual void ResetRigidBody()
	{
	}

	public virtual void PlayBtlIdle()
	{
	}

	public virtual void PlayDeadAnime(Vector3? vecForce = null)
	{
	}

	public virtual void ResetKinect(string motion)
	{
	}

	public void StartShake(float i_Time, float i_Velocity, Vector3 i_Magnitude)
	{
	}

	[IteratorStateMachine(typeof(_003C_StartShake_003Ed__98))]
	private IEnumerator _StartShake(float i_Time, float i_Velocity, Vector3 i_Magnitude)
	{
		return null;
	}

	public void SetLerpColor(Color color)
	{
	}

	public void ResetRenderer()
	{
	}

	public void StartFlash(Color i_Color, float i_TimeFI, ActionWork.AnimationCurve i_InterpolationFI, float i_TimeDuration, float i_TimeFO, ActionWork.AnimationCurve i_InterpolationFO, bool i_Loop = false)
	{
	}

	public void StartFlash(Color i_Color, float i_TimeDuration, bool i_Loop = false)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateFlashColor_003Ed__107))]
	protected IEnumerator UpdateFlashColor(Color i_Color, float i_TimeFI, ActionWork.AnimationCurve i_InterpolationFI, float i_TimeDuration, float i_TimeFO, ActionWork.AnimationCurve i_InterpolationFO, bool i_Loop = false)
	{
		return null;
	}

	public void StopFlash()
	{
	}

	public bool IsFlash()
	{
		return false;
	}

	protected virtual void OnValidate()
	{
	}

	protected void CreateNodeList()
	{
	}

	private void _CreateNodeList(Transform i_Parent)
	{
	}

	public GameObject GetGameObject(string i_Name)
	{
		return null;
	}

	public void PlayEnvironmentSE()
	{
	}

	public void StopEnvironmentSE(int msec = 0)
	{
	}

	public void PlayEffect()
	{
	}

	public void StopEffect()
	{
	}

	public void PlayTransformSe(string req)
	{
	}

	public void StopTransformSe(string req, int msec = 0)
	{
	}

	public void SetUsingSkill(CSkillCard i_Skill, bool i_OnlyCharge)
	{
	}

	public void SetUsingItem(CItem i_Item)
	{
	}

	public virtual void DelUsingSkill()
	{
	}
}
