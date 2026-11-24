using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;

public class CBtlCursorManager : LwSingleton<CBtlCursorManager>
{
	public enum TargetGroup
	{
		OWN = 0,
		ALLY_ONE = 1,
		ALLY_ALL = 2,
		ALLY_OTHERS = 3,
		ALLY_RANDOM = 4,
		ENEMY_ONE = 5,
		ENEMY_ALL = 6,
		ENEMY_RANDOM = 7,
		OTHERS = 8,
		RANDOM = 9,
		SOMEONE = 10,
		MASS = 11
	}

	public enum Mode
	{
		Movable = 0,
		Multiple = 1
	}

	public enum DecisionMethod
	{
		Random = 0,
		HpLow = 1,
		HpHigh = 2
	}

	private enum InputSelectTarget
	{
		IsOk = 0
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSelectFirstTarget_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleCharDef self;

		public CBtlCursorManager _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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

	public const float HighlightFadeInTime = 30f;

	public const float HighlightFadeOutTime = 30f;

	[SerializeField]
	private Transform[] m_CursorRoot;

	[SerializeField]
	private Animator[] m_CursorAnimator;

	private CInOutPattern[] m_CursorInOutPattern;

	private List<CBattleCharDef> m_TargetList;

	private bool m_Provoke;

	private CBattleCharDef m_Self;

	private bool m_DeadMode;

	private bool m_AutoTarget;

	private Mode m_Mode;

	private DecisionMethod m_DecisionMethod;

	private bool[] m_InputButton;

	private bool m_IsOk;

	private float m_GameSpeed;

	public CBattleCharDef m_Selected { get; private set; }

	public TargetGroup m_TargetGourp { get; private set; }

	public void RemoveOk()
	{
	}

	public void RemoveTarget()
	{
	}

	public static void Enable()
	{
	}

	private void _Enable()
	{
	}

	public static void Disable()
	{
	}

	private void _Disable()
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

	private int GetNearHostileIndex()
	{
		return 0;
	}

	public void Setup(CBattleEnemy self, TargetGroup group, DecisionMethod method)
	{
	}

	public void Setup(CBattlePlayer self, TargetGroup group, bool dead, bool auto = false)
	{
	}

	public void ShowSomeoneMode()
	{
	}

	public static void Show(CBattleCharDef self, TargetGroup group, bool dead)
	{
	}

	private void _Show(CBattleCharDef self, TargetGroup group, bool dead)
	{
	}

	private void _Show(int index, Vector3 position)
	{
	}

	public static void Hide()
	{
	}

	private void _Hide()
	{
	}

	public static void Hide(int index)
	{
	}

	private void _Hide(int index)
	{
	}

	private void HighLightEnemyUI()
	{
	}

	private void SetTarget(TargetGroup group, CBattleCharDef self)
	{
	}

	public List<CBattleCharDef> GetRandomTarget(TargetGroup group, CBattleCharDef self, bool i_DeadMode)
	{
		return null;
	}

	public List<CBattleCharDef> GetDecideTarget()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSelectFirstTarget_003Ed__51))]
	private UniTask SelectFirstTarget(CancellationToken cancel, CBattleCharDef self)
	{
		return default;
	}

	public GameController.PADNUM GetPadNum()
	{
		return GameController.PADNUM.PAD0;
	}
}
