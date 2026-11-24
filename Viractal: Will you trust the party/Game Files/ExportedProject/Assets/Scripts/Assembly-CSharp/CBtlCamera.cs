using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class CBtlCamera : LwSingleton<CBtlCamera>
{
	private struct MoveParam
	{
		private int timeTotal;

		private float timeCurrent;

		private float start;

		private float end;

		private ActionWork.AnimationCurve curveType;

		private AnimationCurve curve;

		public void Move(float i_Now, float i_End, int i_Time, ActionWork.AnimationCurve i_Curve)
		{
		}

		public float GetNow()
		{
			return 0f;
		}

		public bool IsEnd()
		{
			return false;
		}

		public bool Update()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadBossDeadCamera_003Ed__106 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlCamera _003C_003E4__this;

		public string i_Name;

		private Utf16ValueStringBuilder _003Csb_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadEncountCamera_003Ed__105 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlCamera _003C_003E4__this;

		public string i_Name;

		private Utf16ValueStringBuilder _003Csb_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_Quake_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBtlCamera _003C_003E4__this;

		public float i_Amplitude;

		public float i_AttackTime;

		public float i_Time;

		public float i_DecayTime;

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
		public _003C_Quake_003Ed__83(int _003C_003E1__state)
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

	[SerializeField]
	private CBtlEncountCamera m_BtlEncountCamera;

	[SerializeField]
	private CinemachineVirtualCamera m_VCamInput;

	[SerializeField]
	private CinemachineVirtualCamera m_VCamBattleClose;

	[SerializeField]
	private CinemachineVirtualCamera m_VCamGameMaster;

	private Coroutine m_Quake;

	[SerializeField]
	private float m_AngleX;

	private float m_AngleXInitialValue;

	private bool m_AngleXUnlimited;

	[SerializeField]
	private float m_AngleY;

	private float m_AngleYInitialValue;

	private bool m_AngleYUnlimited;

	[SerializeField]
	private float m_Distance;

	private float m_DistanceInitialValue;

	public float? m_DistanceSave;

	[SerializeField]
	private Vector3 m_PosOffset;

	private Vector3 m_PosYOffsetInitialValue;

	public Vector3? m_PosYOffsetSave;

	[SerializeField]
	private Vector3 m_LookOffset;

	private Vector3 m_LookYOffsetInitialValue;

	public Vector3? m_LookYOffsetSave;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_ScreenX;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_ScreenY;

	private MoveParam m_MoveDistance;

	private MoveParam m_MovePositionY;

	private MoveParam m_MoveLookAtY;

	private MoveParam m_MoveAngleX;

	private MoveParam m_MoveAngleY;

	public CBtlEncountCamera EncountCamera => null;

	public CinemachineVirtualCamera VirtualCamera => null;

	public CinemachineVirtualCamera VirtualCameraBattleClose => null;

	public CinemachineBasicMultiChannelPerlin m_MultiChannelPerlin { get; private set; }

	public Camera m_Camera { get; private set; }

	public CinemachineBrain m_Brain { get; private set; }

	public float AngleX => 0f;

	public float AngleY => 0f;

	public float Distance => 0f;

	public Vector3 PosOffset => default;

	public Vector3 LookOffset => default;

	public Transform m_Follow { get; private set; }

	public Transform m_LookAt { get; private set; }

	public float ScreenX
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float ScreenY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool m_EnableInputAngle { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void InputRotation()
	{
	}

	private void InputTranslation()
	{
	}

	public void SetCamera(CinemachineBrain camera, float i_LookAtYOffset, float i_PositionYOffset, float i_AngleX, float i_AngleY, float i_Distance)
	{
	}

	public void ResetPosition()
	{
	}

	public void ResetAll()
	{
	}

	public void StartQuake(float i_Amplitude, float i_Time, float i_AttackTime, float i_DecayTime)
	{
	}

	[IteratorStateMachine(typeof(_003C_Quake_003Ed__83))]
	private IEnumerator _Quake(float i_Amplitude, float i_Time, float i_AttackTime, float i_DecayTime)
	{
		return null;
	}

	public void StopCameraQuake()
	{
	}

	public void MuteQuake()
	{
	}

	public bool IsShake()
	{
		return false;
	}

	public void SetPositionY(float i_Height)
	{
	}

	public void SetPosition(Vector3 i_Position)
	{
	}

	public void MovePositionY(float i_Height, int i_Time, ActionWork.AnimationCurve i_Curve)
	{
	}

	public void RestorePositionY(int i_Time, ActionWork.AnimationCurve i_Curve)
	{
	}

	public void SetLookAtY(float i_Height)
	{
	}

	public void SetLookAt(Vector3 i_Offset)
	{
	}

	public void MoveLookAtY(float i_Height, int i_Time, ActionWork.AnimationCurve i_Curve)
	{
	}

	public void RestoreLookAtY(int i_Time, ActionWork.AnimationCurve i_Curve)
	{
	}

	public void SetDistance(float distance)
	{
	}

	public void MoveDistance(float distance, int time, ActionWork.AnimationCurve curve)
	{
	}

	public void RestoreDistance(int time, ActionWork.AnimationCurve curve)
	{
	}

	public void SetRotation(float i_AngleX, float i_AngleY)
	{
	}

	public void UpdatePosition()
	{
	}

	public void LookAt(Transform i_LookAt, Transform i_Follow)
	{
	}

	public void SetPitchUnlimited(bool flag)
	{
	}

	public void SetYawUnlimited(bool flag)
	{
	}

	public bool IsMovingAndgleX()
	{
		return false;
	}

	public bool IsMovingAndgleY()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CLoadEncountCamera_003Ed__105))]
	public UniTask LoadEncountCamera(string i_Name)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadBossDeadCamera_003Ed__106))]
	public UniTask LoadBossDeadCamera(string i_Name)
	{
		return default;
	}

	public void DestroyEncountCamera()
	{
	}

	public void EnableGMCamera()
	{
	}

	public void DisableGMCamera()
	{
	}

	public void DisableListenerAutoMove()
	{
	}

	public void SetBlendTime(float i_Time)
	{
	}

	public void SetBlend(CinemachineBlendDefinition i_Blend)
	{
	}
}
