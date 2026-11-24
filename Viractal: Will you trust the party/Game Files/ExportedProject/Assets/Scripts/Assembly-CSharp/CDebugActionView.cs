using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Sting.Script.Engine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CDebugActionView : LwSingleton<CDebugActionView>
{
	private enum Menu
	{
		Main = 0,
		Actor = 1,
		Target = 2,
		Script = 3,
		DeadEditor = 4,
		ReloadActionScript = 5
	}

	private enum DeadEdit
	{
		Play = 0,
		Idle = 1,
		Reset = 2,
		ForceVectorX = 3,
		ForceVectorY = 4,
		ForceVectorZ = 5,
		Force = 6,
		TorqueX = 7,
		TorqueY = 8,
		TorqueZ = 9,
		Torque = 10
	}

	private enum ActorTab
	{
		Character = 0,
		Enemy = 1,
		_Max = 2
	}

	private enum ScriptTab
	{
		Common = 0,
		Skill = 1,
		_Max = 2
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadActorModel_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMaster_CharJobData job;

		public CDebugActionView _003C_003E4__this;

		private CBattlePlayer _003Cbp_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CLoadActorModel_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMaster_EnemyData enemy;

		public CDebugActionView _003C_003E4__this;

		private CBattleEnemy _003Cbe_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CLoadTargetModel_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMaster_CharJobData job;

		public CDebugActionView _003C_003E4__this;

		private CBattlePlayer _003Cbp_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CLoadTargetModel_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMaster_EnemyData enemy;

		public CDebugActionView _003C_003E4__this;

		private CBattleEnemy _003Cbe_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private sealed class _003CReloadActionScript_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CDebugActionView _003C_003E4__this;

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
		public _003CReloadActionScript_003Ed__85(int _003C_003E1__state)
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
	private Camera m_Camera;

	[SerializeField]
	private Transform m_3DRoot;

	[SerializeField]
	private Transform m_2DRoot;

	[SerializeField]
	private Transform m_ActionScriptRoot;

	[SerializeField]
	[Header("インフォメーション")]
	private TextMeshProUGUI m_InfoButtonText;

	[SerializeField]
	private Button m_InfoButton;

	[SerializeField]
	private Image m_InfoButtonLabel;

	[SerializeField]
	private TextMeshProUGUI m_Info;

	[SerializeField]
	private ScrollRect m_InfoScrollRect;

	[SerializeField]
	private RectTransform m_InfoScrollContent;

	[SerializeField]
	private Button m_CameraButton;

	[SerializeField]
	private Image m_CameraButtonLabel;

	[SerializeField]
	private Button m_PauseButton;

	[SerializeField]
	private Image m_PauseButtonLabel;

	[SerializeField]
	[Header("メインメニュー")]
	private CDebugTabMenu m_MainMenu;

	[SerializeField]
	[Header("アクターメニュー")]
	private CDebugTabMenu m_ActorMenu;

	[SerializeField]
	[Header("スクリプトメニュー")]
	private CDebugTabMenu m_ScriptMenu;

	[SerializeField]
	[Header("戦闘不能調整メニュー")]
	private CDebugTabMenu m_DeadEditMenu;

	private Menu m_SelectedMenu;

	private string[] m_MenuNames;

	private string[] m_ScriptMenuNames;

	private string[] m_DeadEditorMenuNames;

	private CSkillCard m_ActSkill;

	private CActionSeq m_ActionScript;

	private bool m_IsInfoOpen;

	private string m_InfoText;

	private float m_AngleVertical;

	private float m_AngleHorizontal;

	[SerializeField]
	private float m_Distance;

	private Vector3 m_Look;

	private bool m_IsCameraMode;

	private bool m_IsPause;

	private int m_ScriptFrame;

	private bool m_IsScriptEnd;

	private ScriptTab m_ScriptTab;

	private float m_AnimatorDeltaTime;

	public bool m_IsActorRagdoll;

	private Coroutine m_ReloadActionScript;

	private List<string> m_DeadEdit;

	public Transform ActionScript => null;

	public static Vector3? m_ForceVector { get; set; }

	public static int? m_Force { get; set; }

	public static Vector3? m_TorqueVector { get; set; }

	public static int? m_Torque { get; set; }

	public CBattleCharDef m_Actor { get; private set; }

	public CBattleCharDef m_Target { get; private set; }

	private void Awake()
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

	private void UpdateCamera()
	{
	}

	private void UpdateActionScript()
	{
	}

	private void OnEndScript()
	{
	}

	private void SwCameraMode(bool enable)
	{
	}

	private void SwInfomation(bool open)
	{
	}

	private void SwPause(bool pause)
	{
	}

	private void OpenMenu(Menu menu)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadActorModel_003Ed__79))]
	private UniTask LoadActorModel(CMaster_CharJobData job)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadActorModel_003Ed__80))]
	private UniTask LoadActorModel(CMaster_EnemyData enemy)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadTargetModel_003Ed__81))]
	private UniTask LoadTargetModel(CMaster_CharJobData job)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadTargetModel_003Ed__82))]
	private UniTask LoadTargetModel(CMaster_EnemyData enemy)
	{
		return default;
	}

	private void CreateDeadEditMenu()
	{
	}

	[IteratorStateMachine(typeof(_003CReloadActionScript_003Ed__85))]
	private IEnumerator ReloadActionScript()
	{
		return null;
	}
}
