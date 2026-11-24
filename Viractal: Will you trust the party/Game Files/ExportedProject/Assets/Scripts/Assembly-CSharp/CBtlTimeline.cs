using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;
using UnityEngine.Pool;

public class CBtlTimeline : LwSingleton<CBtlTimeline>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public CParamDef now;

		internal bool _003CResort_003Eb__0(CBtlTimelineUnit x)
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCreate_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public List<CBattlePlayer> i_Players;

		public List<CBattleEnemy> i_Enemies;

		public CBtlTimeline _003C_003E4__this;

		public CancellationToken i_Cancel;

		private PooledObject<List<CBattleCharDef>> _003C_003E7__wrap1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCreateUI_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlTimeline _003C_003E4__this;

		public CancellationToken i_Cancel;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBattleCharDef i_StartCharacter;

		public List<CBattlePlayer> i_Players;

		public List<CBattleEnemy> i_Enemies;

		public CancellationToken i_Cancel;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CResort_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlTimeline _003C_003E4__this;

		public CancellationToken i_Cancel;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		private Dictionary<CBattleCharDef, int> _003Cacted_003E5__2;

		private List<CBattlePlayer> _003Cplayers_003E5__3;

		private List<CBattleEnemy> _003Cenemies_003E5__4;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReverse_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlTimeline _003C_003E4__this;

		public List<CBattlePlayer> i_Players;

		public List<CBattleEnemy> i_Enemies;

		public CancellationToken i_Cancel;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CTurnEnd_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlTimeline _003C_003E4__this;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_Initialize_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlTimeline _003C_003E4__this;

		public CBattleCharDef i_StartCharacter;

		public CancellationToken i_Cancel;

		public List<CBattlePlayer> i_Players;

		public List<CBattleEnemy> i_Enemies;

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

	[SerializeField]
	private CBtlTimelineUnit m_IconSource;

	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private CBtlTimelineUnit m_ActiveIcon;

	private List<CBtlTimelineUnit> m_ReserveIcons;

	private List<CBattleCharDef> m_Sort;

	private Color m_BlinkColorStart;

	private Color m_BlinkColorEnd;

	private bool m_ResortTurnEnd;

	private CInOutPattern m_InOut { get; set; }

	public Color BlinkColorStart => default;

	public Color BlinkColorEnd => default;

	public float m_BlinkTime { get; private set; }

	public CBattleCharDef m_StartCharacter { get; private set; }

	public bool m_Reverse { get; private set; }

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__29))]
	public static UniTask Initialize(CBattleCharDef i_StartCharacter, List<CBattlePlayer> i_Players, List<CBattleEnemy> i_Enemies, CancellationToken i_Cancel)
	{
		return default;
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

	[AsyncStateMachine(typeof(_003C_Initialize_003Ed__33))]
	private UniTask _Initialize(CBattleCharDef i_StartCharacter, List<CBattlePlayer> i_Players, List<CBattleEnemy> i_Enemies, CancellationToken i_Cancel)
	{
		return default;
	}

	public void SetResortTurnEnd()
	{
	}

	[AsyncStateMachine(typeof(_003CTurnEnd_003Ed__35))]
	public UniTask TurnEnd()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCreate_003Ed__36))]
	private UniTask Create(List<CBattlePlayer> i_Players, List<CBattleEnemy> i_Enemies, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CResort_003Ed__37))]
	public UniTask Resort(CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCreateUI_003Ed__38))]
	private UniTask CreateUI(CancellationToken i_Cancel)
	{
		return default;
	}

	[Conditional("UNITY_DEBUG")]
	public void ApplyUI()
	{
	}

	private List<CBattleCharDef> Sort(List<CBattleCharDef> i_OrderCharacter, CBattleCharDef i_StartCharactrer)
	{
		return null;
	}

	public static List<CBattleCharDef> SortClockwise(List<CBattleCharDef> i_OrderCharacter, CBattleCharDef i_StartCharacter)
	{
		return null;
	}

	public static List<CBattleCharDef> SortCounterClockwise(List<CBattleCharDef> i_OrderCharacter, CBattleCharDef i_StartCharactrer)
	{
		return null;
	}

	private List<CBattleCharDef> SortSpeed(List<CBattleCharDef> i_OrderCharacter)
	{
		return null;
	}

	public static CParamDef Now()
	{
		return null;
	}

	private CParamDef _Now()
	{
		return null;
	}

	public static void Next()
	{
	}

	private void _Next()
	{
	}

	public static CParamDef GetNextChrParam()
	{
		return null;
	}

	private CParamDef _GetNextChrParam()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReverse_003Ed__50))]
	private UniTask Reverse(List<CBattlePlayer> i_Players, List<CBattleEnemy> i_Enemies, CancellationToken i_Cancel)
	{
		return default;
	}

	public void Erase(CBattleCharDef character)
	{
	}

	public void Erase(int index)
	{
	}

	private void _Erase(int index)
	{
	}

	public void EraseAll()
	{
	}

	public CBtlTimelineUnit GetUI(CBattleCharDef character)
	{
		return null;
	}

	public void Show(bool i_Immediate)
	{
	}

	public void Hide(bool i_Immediate)
	{
	}

	public List<CBattleCharDef> GetOrder()
	{
		return null;
	}

	public void SetReverse(CBattleCharDef i_StartPlayer)
	{
	}
}
