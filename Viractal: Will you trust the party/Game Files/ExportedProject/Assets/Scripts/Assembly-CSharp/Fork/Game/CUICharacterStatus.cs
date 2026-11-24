using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.ModelButtons;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/CharacterStatus")]
	public class CUICharacterStatus : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass69_0
		{
			public ParticleSystem appearEffectPs;

			internal bool _003C_DpGainEffect_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass71_0
		{
			public CUICharacterStatus _003C_003E4__this;

			public int i_Index;

			internal bool _003C_DpRemoveEffect_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDrawCard_003Ed__73 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatus _003C_003E4__this;

			public bool i_RedrawAll;

			private PooledObject<List<CSkillCardData>> _003CpoolObject0_003E5__2;

			private PooledObject<List<CSkillCardData>> _003CpoolObject1_003E5__3;

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
		private struct _003CDropCard_003Ed__74 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatus _003C_003E4__this;

			public CancellationToken i_CacellationToken;

			private PooledObject<List<CSkillCardData>> _003CpoolObject0_003E5__2;

			private PooledObject<List<CSkillCardData>> _003CpoolObject1_003E5__3;

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
		private struct _003CFocusValueChange_003Ed__81 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatus _003C_003E4__this;

			public float i_Time;

			public CancellationToken i_CancellationToken;

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
		private struct _003C_DpGainEffect_003Ed__69 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int i_DelayMillSec;

			public CancellationToken i_CancellationToken;

			public CUICharacterStatus _003C_003E4__this;

			public int i_Index;

			private _003C_003Ec__DisplayClass69_0 _003C_003E8__1;

			private AsyncOperationHandle<GameObject> _003ClineEffect_003E5__2;

			private AsyncOperationHandle<GameObject> _003CappearEffect_003E5__3;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

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
		private struct _003C_DpRemoveEffect_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatus _003C_003E4__this;

			public int i_Index;

			public int i_DelayMillSec;

			public CancellationToken i_CancellationToken;

			private _003C_003Ec__DisplayClass71_0 _003C_003E8__1;

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
		private struct _003C_MoveDpLine_003Ed__70 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatus _003C_003E4__this;

			public int i_Index;

			public GameObject i_Effect;

			public float i_Height;

			public CancellationToken i_CancellationToken;

			private Vector3 _003CstartPoint_003E5__2;

			private Vector3 _003CendPoint_003E5__3;

			private double _003CstartTime_003E5__4;

			private float _003Ctime_003E5__5;

			private float _003Cip_003E5__6;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003C_SetMoneyViewMode_003Ed__86 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public bool i_Switch;

			public CUICharacterStatus _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			private double _003CstartTime_003E5__2;

			private float _003CtimeLength_003E5__3;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003C_SetStatusViewMode_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public bool i_Switch;

			public CUICharacterStatus _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			public CCharDef i_GamePadHolder;

			private double _003CstartTime_003E5__2;

			private float _003CtimeLength_003E5__3;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003C_SetStatusViewModeForAbilitySelect_003Ed__80 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatus _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			public CUICharacterStatusAbilityHolder i_TemporaryHolder;

			public CCharDef i_GamePadHolder;

			private double _003CstartTime_003E5__2;

			private float _003CtimeLength_003E5__3;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

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

		private static readonly string SEDPGain;

		[SerializeField]
		private CUIModelButtonGroup m_RootButtonGroup;

		[SerializeField]
		private CUIModelButtonGroup[] m_ButtonGroups;

		[SerializeField]
		private CUIModelHPBar m_HPBar;

		[SerializeField]
		private CUIDeckHolder m_DeckHolder;

		[SerializeField]
		private CUIModelGold m_Gold;

		[SerializeField]
		private CUIDropRankGroup m_DropRankGroup;

		[SerializeField]
		private Transform m_DpRoot;

		[SerializeField]
		private CUILevelNumber m_LevelDisplay;

		[SerializeField]
		private CUICharacterStatusConditionHolder m_ConditionHolder;

		[SerializeField]
		private CUICharacterStatusAbilityHolder m_AbilityHolder;

		[SerializeField]
		private CUICharacterStatusAbilityHolder m_AdditionalAbilityHolder;

		[SerializeField]
		public CUIHandCard m_HandCard;

		[SerializeField]
		private CUICharacterStatusFace m_Face;

		[SerializeField]
		public ParentConstraint m_StatusViewConstraint;

		[SerializeField]
		private ParentConstraint m_MoneyViewConstraint;

		[SerializeField]
		private Animator m_Animator;

		[SerializeField]
		private Renderer m_Selection;

		[SerializeField]
		private CUIDpGroup m_DpGroup;

		[SerializeField]
		private CMeshFade m_MeshFade;

		[SerializeField]
		private CUINamePlate m_NamePlate;

		[SerializeField]
		private Transform m_ShopIconRoot;

		[SerializeField]
		private CUICharacterStatusVoicechatIcon m_VoicechatIcon;

		[SerializeField]
		private Animator m_DiceRoot;

		private List<CUIDp> m_DpInOut;

		private CParamPlayer m_BackupParameter;

		private int m_BackupBlock;

		private MaterialPropertyBlock m_SelectionProp;

		private CancellationTokenSource m_ChangeStatusViewCancellationTokenSource;

		private CancellationTokenSource m_UpdateDPCancellationTokenSource;

		private CancellationTokenSource m_MoneyFocusCancellationTokenSource;

		private bool m_VisibilityChanged;

		public float m_FocusEnterTime;

		public float m_FocusLeaveTime;

		private List<CUIModelButtonGroup> m_TemporaryButtonGroup;

		private ColoredUnit m_Color;

		public CBattleCharDef m_BattleCharacter { get; set; }

		public CParamPlayer m_Parameter { get; private set; }

		public CUICharacterStatusGroup m_Parent { get; private set; }

		public CInOutPattern m_InOut { get; private set; }

		public UnityEvent onEndOfTop { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void Wakeup(bool i_IsWakeup)
		{
		}

		public void SetParent(CUICharacterStatusGroup i_Parent)
		{
		}

		public void OnValueChanged(float i_Time = 0f, CUICharacterStatusGroup.UpdateIgnoreMask i_Mask = CUICharacterStatusGroup.UpdateIgnoreMask.None)
		{
		}

		public void InitParameter(CParamPlayer i_Parameter, CBattleCharDef i_BattleCharacter = null)
		{
		}

		private void SetValuesImmediatePart()
		{
		}

		public void UpdateControll(GamePad i_GamePad)
		{
		}

		private void SetValuesImmediate(CUICharacterStatusGroup.UpdateIgnoreMask i_Mask)
		{
		}

		private void ReconnectAbilityButtonGroup()
		{
		}

		private void UpdateDPImmediate()
		{
		}

		private bool HandCardIsChanged()
		{
			return false;
		}

		private void SetValuesAnimate(float i_Time, CUICharacterStatusGroup.UpdateIgnoreMask i_Mask)
		{
		}

		private void UpdateDpAnimate(float i_Time)
		{
		}

		[AsyncStateMachine(typeof(_003C_DpGainEffect_003Ed__69))]
		private UniTask _DpGainEffect(int i_Index, int i_DelayMillSec, CancellationToken i_CancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_MoveDpLine_003Ed__70))]
		private UniTask _MoveDpLine(GameObject i_Effect, float i_Height, int i_Index, CancellationToken i_CancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_DpRemoveEffect_003Ed__71))]
		private UniTask _DpRemoveEffect(int i_Index, int i_DelayMillSec, CancellationToken i_CancellationToken)
		{
			return default;
		}

		public void ShowHandDeck(bool i_IsShow)
		{
		}

		[AsyncStateMachine(typeof(_003CDrawCard_003Ed__73))]
		public UniTask DrawCard(bool i_RedrawAll = false)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CDropCard_003Ed__74))]
		public UniTask DropCard(CancellationToken i_CacellationToken = default(CancellationToken))
		{
			return default;
		}

		public bool IsStatusViewMode()
		{
			return false;
		}

		public void SetStatusViewMode(bool i_Switch, CCharDef i_GamePadHolder)
		{
		}

		public void StartStatusViewModeForAbilitySelect(CCharDef i_GamePadHolder, CUICharacterStatusAbilityHolder i_TemporaryHolder)
		{
		}

		public void EndStatusViewModeForAbilitySelect(CCharDef i_GamePadHolder)
		{
		}

		[AsyncStateMachine(typeof(_003C_SetStatusViewMode_003Ed__79))]
		private UniTask _SetStatusViewMode(bool i_Switch, CCharDef i_GamePadHolder, CancellationToken i_CancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003C_SetStatusViewModeForAbilitySelect_003Ed__80))]
		private UniTask _SetStatusViewModeForAbilitySelect(CCharDef i_GamePadHolder, CUICharacterStatusAbilityHolder i_TemporaryHolder, CancellationToken i_CancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CFocusValueChange_003Ed__81))]
		public UniTask FocusValueChange(float i_Time, CancellationToken i_CancellationToken = default(CancellationToken))
		{
			return default;
		}

		public bool IsViewMoving()
		{
			return false;
		}

		public Transform GetDeckHolder()
		{
			return null;
		}

		public CFieldPlayer GetFieldPlayer()
		{
			return null;
		}

		public void SetMoneyFocus(bool i_Switch)
		{
		}

		[AsyncStateMachine(typeof(_003C_SetMoneyViewMode_003Ed__86))]
		private UniTask _SetMoneyViewMode(bool i_Switch, CancellationToken i_CancellationToken)
		{
			return default;
		}

		public void SetDpActive(int i_Count)
		{
		}

		public void Fade(bool i_Switch)
		{
		}

		public CUICharacterStatusAbilityHolder GetAbilityHolder()
		{
			return null;
		}

		public CUICharacterStatusAbilityHolder GetAdditionalAbilityHolder()
		{
			return null;
		}

		public Vector2 ShopIconPoint(Canvas i_TarngetCanvas = null)
		{
			return default;
		}

		public CUIModelButton GetCurrentActiveButton()
		{
			return null;
		}

		public void AddTemporaryButtonGroup(CUIModelButtonGroup i_ModelButtonGroup)
		{
		}

		public void RemoveTemporaryButtonGroup(CUIModelButtonGroup i_ModelButtonGroup)
		{
		}

		public CUIModelButtonGroup GetCurrentActiveButtonGroup()
		{
			return null;
		}

		public CUiCharacterStatusCondition GetCondition(int i_Index)
		{
			return null;
		}

		public void OnEndTopCallback()
		{
		}

		public void ShowButtonTooltip()
		{
		}

		public void ShowDice(int i_DiceNum)
		{
		}

		public void HideDice()
		{
		}

		private void PrepareDice(ColoredUnit color)
		{
		}

		public void SetHandcardTimeSavingMode(bool i_Enabled)
		{
		}

		public SpriteRenderer GetMedalSpriteRenderer()
		{
			return null;
		}
	}
}
