using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;
using UnityEngine.Pool;

public class CSkillEffect
{
	public delegate void RefBoolAction(ref bool value);

	private enum StealResult
	{
		Success = 0,
		FailedCarryLimit = 1,
		Failed = 2,
		Impossible = 3
	}

	public struct TargetContext
	{
		private CBattleCharDef battle;

		private CFieldPlayer field;

		public CHexPosition hex { get; }

		public TargetContext(CBattleCharDef character)
		{
			battle = null;
			field = null;
			hex = null;
		}

		public TargetContext(CFieldPlayer character)
		{
			battle = null;
			field = null;
			hex = null;
		}

		public TargetContext(CHexPosition hex)
		{
			battle = null;
			field = null;
			this.hex = null;
		}

		public CBattleCharDef GetBattleCharacter()
		{
			return null;
		}

		public CFieldPlayer GetFieldPlayer()
		{
			return null;
		}

		public CCharDef GetCharacter()
		{
			return null;
		}

		public CParamDef GetParam()
		{
			return null;
		}
	}

	public struct EffectContext
	{
		public string effect_id;

		public string effect_target;

		public string effect_detail;

		public string effect_detail2;

		public int effect_value;

		public int effect_value2;
	}

	public delegate int CalcDamage(TargetContext target);

	public delegate int CalcHeal(TargetContext target);

	public delegate void ActSupportEffect(TargetContext target);

	public delegate void Grant(TargetContext target, bool[] i_Grant, out bool[] o_Guard);

	public delegate void MassEffect(TargetContext target);

	public enum TargetType
	{
		None = 0,
		Player = 1,
		Enemy = 2
	}

	public enum RandomUpDown
	{
		Down = -1,
		Up = 1
	}

	public struct Result
	{
		public TargetType targetType;

		public int targetIndex;

		public int[] damage;

		public int[][] additionalDamage;

		public int heal;

		public bool support;

		public bool instantDeath;

		public bool resistDeath;

		public string stealID;

		public bool reflectCondition;

		public bool reflectAbility;

		public bool barrier;

		public bool[] isGrantCondition;

		public int changeDrKind;

		public RandomUpDown changeDrUpDown;

		public List<ResultDevilWhisper> resultDevilWhisper;
	}

	public struct ResultDevilWhisper
	{
		public string ID;

		public int pcIndex;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass159_0
	{
		public CBattlePlayer bp;

		public CUICharacterStatus status;

		internal bool _003CFinalizeDiscardAndForce_003Eb__1()
		{
			return false;
		}

		internal UniTask _003CFinalizeDiscardAndForce_003Eb__0()
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CBalloonText_003Ed__186 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public Transform parent;

		public string text;

		public CancellationToken cancel;

		private CEventMessage _003Cmes_003E5__2;

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
	private struct _003CFinalizeDiscardAndForce_003Ed__159 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CSkillEffect _003C_003E4__this;

		private _003C_003Ec__DisplayClass159_0 _003C_003E8__1;

		private int _003Ccount_003E5__2;

		private Dictionary<CParamPlayer, List<CSkillCardData>>.Enumerator _003C_003E7__wrap2;

		private CParamPlayer _003Cparam_003E5__4;

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
	private struct _003CObtainWilllToken_003Ed__150 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CSkillEffect _003C_003E4__this;

		public CSkill i_Skill;

		public CancellationToken cancel;

		private bool _003CobtainedWill_003E5__2;

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
	private struct _003CObtainWilllToken_003Ed__151 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CSkill i_Skill;

		public List<(string kind, int count)> context;

		public CancellationToken cancel;

		private CBattleCharDef _003Cbtlchr_003E5__2;

		private List<(string kind, int count)>.Enumerator _003C_003E7__wrap2;

		private (string kind, int count) _003Cobtain_003E5__4;

		private List<Vector3> _003ClocalPositions_003E5__5;

		private PooledObject<List<Vector3>> _003C_003E7__wrap5;

		private UniTask<Vector3?>.Awaiter _003C_003Eu__1;

		private int _003Coffset_003E5__7;

		private int _003Ci_003E5__8;

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

	private CSkill m_Skill;

	private List<CMaster_SkillConditionData> m_Condition;

	private List<TargetContext> m_Targets;

	private Dictionary<CParamPlayer, List<CSkillCardData>> m_DiscardAndUpgrade;

	public int m_DualDamageFirst;

	public List<Result> m_Result;

	public EffectContext m_EffectTable { get; private set; }

	public bool m_Excuted { get; private set; }

	public List<CMaster_SkillAbilityData> m_ObtainAbility { get; private set; }

	public List<CMaster_SkillAbilityData> m_RemoveAbility { get; private set; }

	public CalcDamage m_CalcDamage { get; private set; }

	public CalcHeal m_CalcHeal { get; private set; }

	public ActSupportEffect m_ActSupportEffect { get; private set; }

	public Grant m_Grant { get; private set; }

	public MassEffect m_MassEffect { get; private set; }

	public CSkillEffect(CSkill skill, EffectContext effect)
	{
	}

	public void SetTarget(List<CBattleCharDef> targets)
	{
	}

	public void SetTarget(CBattleCharDef target)
	{
	}

	public void SetTarget(List<CFieldPlayer> targets)
	{
	}

	public void SetTarget(CFieldPlayer target)
	{
	}

	public void SetTarget(List<TargetContext> targets)
	{
	}

	public void SetTarget(TargetContext target)
	{
	}

	public TargetContext? GetTarget(int index)
	{
		return null;
	}

	public ReadOnlyCollection<TargetContext> GetTarget()
	{
		return null;
	}

	public int CountTarget()
	{
		return 0;
	}

	private void Initialize()
	{
	}

	private bool _IsDevilWhisperAddDamage(TargetType targetType, int targetIndex, int devilpcIndex)
	{
		return false;
	}

	public void Prepare(int effectIndex = 0, int cumulativeDamage = 0)
	{
	}

	private Dictionary<CBattleCharDef, bool> SimulateBreakBlock()
	{
		return null;
	}

	public List<object> PrepareOnline()
	{
		return null;
	}

	public void Execute()
	{
	}

	public void Execute(int hit)
	{
	}

	private int _CalcDamage(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamage(TargetContext target, int param, float exAtkMul = 0f)
	{
		return 0;
	}

	private int _CalcDamageConst(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageConst(TargetContext target, int value)
	{
		return 0;
	}

	private int _CalcBlockShoot(TargetContext target)
	{
		return 0;
	}

	private int _CalcBlockShootOwn(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageExistBlock(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageGoldThrow(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageDeckRemain(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageEnemyType(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageWill(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageCondition(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageMyCondition(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageSuccessfulBlock(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageNoBlock(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageHpMax(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamagePrediction(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageDropRank(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageAbilityCount(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageSelfHpRate(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageLWork(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageCWork(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageHandKindCount(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageHandRarityCount(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageSameCard(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageFirstActTurn(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageInsect(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageThresholdDeck(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageDependGold(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageConsumeDamageCard(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageCardElementInDeck(TargetContext target)
	{
		return 0;
	}

	private void ActItemInvalidDamage(CParamDef i_TargetPlayer, ref int i_Damage)
	{
	}

	private void OverwriteDamage(CBattleCharDef i_Target, ref int i_Damage)
	{
	}

	public static bool IsAllyTarget(CParamDef source, CParamDef target)
	{
		return false;
	}

	private int _CalcHealAlly(TargetContext target)
	{
		return 0;
	}

	private int _CalcDamageEnemy(TargetContext target)
	{
		return 0;
	}

	private int _CalcHealConstOrMaxHpUp(TargetContext target)
	{
		return 0;
	}

	private int _CalcHealConst(TargetContext target)
	{
		return 0;
	}

	private int _CalcHealMaxRate(TargetContext target)
	{
		return 0;
	}

	private int _CalcHealLWork(TargetContext target)
	{
		return 0;
	}

	private int _CalcHealCWork(TargetContext target)
	{
		return 0;
	}

	private int _CalcHealConsumeWill(TargetContext target)
	{
		return 0;
	}

	private int GetHealWillConsumption(out CardRenderTextureSpriteRenderer.ManaKind? kind)
	{
		kind = null;
		return 0;
	}

	private void _ConsumeHealWill(TargetContext target)
	{
	}

	private void _SetHp1(TargetContext target)
	{
	}

	private void _SetHp1IfBelow(TargetContext target)
	{
	}

	private void _SetHpReverse(TargetContext target)
	{
	}

	private void _StartGurad(TargetContext target)
	{
	}

	public void EndGuard(CBattleCharDef i_Character)
	{
	}

	private void _StartBlock(TargetContext target)
	{
	}

	private void _ObtainBlockRemainDeck(TargetContext target)
	{
	}

	private void _ObtainBlockInsectTag(TargetContext target)
	{
	}

	private void _ObtainBlockWillToken(TargetContext target)
	{
	}

	public static void ObtainBlock(CBattleCharDef i_Target, int i_Value, bool i_UpdateUI = true)
	{
	}

	private void _BreakBlock(TargetContext target)
	{
	}

	private void _Grant(TargetContext target, bool[] i_Grant, out bool[] o_Guard)
	{
		o_Guard = null;
	}

	private CMaster_TreasureTableData LotterySteal(TargetContext target, out StealResult result)
	{
		result = default;
		return null;
	}

	private void _Steal(TargetContext target)
	{
	}

	private void _EnemyStealItem(TargetContext target)
	{
	}

	private void _StealGold(TargetContext target)
	{
	}

	private void _ConsumeGold(TargetContext target)
	{
	}

	private void _StealBlock(TargetContext target)
	{
	}

	private void _StealCondition(TargetContext target)
	{
	}

	private void _GiveCondition(TargetContext target)
	{
	}

	private void RefleshBattleCharacter(CBattleCharDef i_Character)
	{
	}

	private void _ChangeActionRoutine(TargetContext target)
	{
	}

	private void _ClearCondition(TargetContext target)
	{
	}

	private void _ClearConditionOnlyGood(TargetContext target)
	{
	}

	private void _ClearConditionOnlyBad(TargetContext target)
	{
	}

	private void _ClearConditionSpecific(TargetContext target)
	{
	}

	private void _ClearConditionKind(TargetContext target)
	{
	}

	private void _Escape(TargetContext target)
	{
	}

	private void _ObtainCardToDeckRandom(TargetContext target)
	{
	}

	private void _ObtainRandomCardToDeckTop(TargetContext target)
	{
	}

	private void _LostCard(TargetContext target)
	{
	}

	private void _RecycleCard(TargetContext target)
	{
	}

	private void _ObtainRandomItem(TargetContext target)
	{
	}

	private void _ObtainWillToken(TargetContext target)
	{
	}

	[AsyncStateMachine(typeof(_003CObtainWilllToken_003Ed__150))]
	private UniTask ObtainWilllToken(CSkill i_Skill, CancellationToken cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CObtainWilllToken_003Ed__151))]
	public static UniTask ObtainWilllToken(CSkill i_Skill, List<(string kind, int count)> context, CancellationToken cancel)
	{
		return default;
	}

	private static bool HasWillChargeRequest(List<(string kind, int count)> context)
	{
		return false;
	}

	public static void ActConditionWillChargedDamage(CBattleCharDef charger)
	{
	}

	private static void OccurConditionDamage(CBattleCharDef target, int damage)
	{
	}

	private void _ReverseTimeline(TargetContext target)
	{
	}

	private void _Discard(TargetContext target)
	{
	}

	private void _DiscardOtherDamageCard(TargetContext target)
	{
	}

	private void _DiscardAndForce(TargetContext target)
	{
	}

	[AsyncStateMachine(typeof(_003CFinalizeDiscardAndForce_003Ed__159))]
	public UniTask FinalizeDiscardAndForce()
	{
		return default;
	}

	private void _LoseDpOnHeal(TargetContext target)
	{
	}

	private void _IncreaseFullHpMaxHp(TargetContext target)
	{
	}

	private void _IncreaseHp(TargetContext target)
	{
	}

	private void _IncreaseSp(TargetContext target)
	{
	}

	private void _IncreaseSkillDr(TargetContext target)
	{
	}

	private void _IncreaseSkillDr(TargetContext target, int value)
	{
	}

	private void _IncreaseItemDr(TargetContext target)
	{
	}

	private void _IncreaseItemDr(TargetContext target, int value)
	{
	}

	private void _IncreaseTagDr(TargetContext target)
	{
	}

	private void _IncreaseTagDr(TargetContext target, int value)
	{
	}

	private void _IncreaseGoldDr(TargetContext target)
	{
	}

	private void _IncreaseGoldDr(TargetContext target, int value)
	{
	}

	private void _IncreaseRandomDr(TargetContext target)
	{
	}

	private void _RandomFluctuationRandomDr(TargetContext target)
	{
	}

	private void _IncreaseMovePower(TargetContext target)
	{
	}

	private void _ObtainAbility(TargetContext target)
	{
	}

	private void _ObtainRandomAbility(TargetContext target)
	{
	}

	private void _ObtainRandomAbility(TargetContext target, int i_Num)
	{
	}

	private void _ExchangeRandomAbility(TargetContext target)
	{
	}

	private void _ObtainAbilityFromTable(TargetContext target)
	{
	}

	private void _ChangeWillToken(TargetContext target)
	{
	}

	private void _ObtainDP(TargetContext target)
	{
	}

	private void _Ladder(TargetContext target)
	{
	}

	private void _Teleport(TargetContext target)
	{
	}

	private void _TeleportAlly(TargetContext target)
	{
	}

	private void _ClearCloud(TargetContext target)
	{
	}

	[AsyncStateMachine(typeof(_003CBalloonText_003Ed__186))]
	private UniTask BalloonText(string text, Transform parent, CancellationToken cancel)
	{
		return default;
	}

	public void GrantCondition(CCharDef i_Target, string i_ConditionID, int i_Stack = 1)
	{
	}

	public static bool GrantCondition(CCharDef i_Self, CCharDef i_Target, string i_ConditionID, int i_Stack = 1, bool i_UpdateUI = true)
	{
		return false;
	}

	private static void TriggerConditionStackEffect(CBattleCharDef i_Target, string i_ConditionID, int i_RequiredStack, string i_TriggerEffect, bool i_UpdateUI, (RefBoolAction, bool) i_OnPreActivate)
	{
	}

	private static int GetConditionStackCount(CParamDef i_Param, string i_ConditionID)
	{
		return 0;
	}

	private static void ExecuteConditionStackEffect(CBattleCharDef i_Target, string i_TriggerEffect, bool i_UpdateUI, (RefBoolAction, bool) i_OnPreActivate)
	{
	}

	private static void OccurConditionDeath(CBattleCharDef i_Target, int i_BaseRate)
	{
	}

	private static bool _GrantCondition(CCharDef i_Self, CCharDef i_Target, string i_ConditionID, int i_Stack = 1, bool i_UpdateUI = true)
	{
		return false;
	}

	public void SetCondition(JsonNode i_Json, ref Result result)
	{
	}

	private void InterruptActionScript()
	{
	}

	private void OccurReflectDamage(int i_Damage, CBattleCharDef i_Target)
	{
	}

	private void GrantConditionToCondition(CBattleCharDef i_Self, CBattleCharDef i_Target, string i_ConditionID)
	{
	}

	public static void AddConditionAtWillOverflow(CBattleCharDef i_ChargeCharacter, int i_DeleteCount)
	{
	}
}
