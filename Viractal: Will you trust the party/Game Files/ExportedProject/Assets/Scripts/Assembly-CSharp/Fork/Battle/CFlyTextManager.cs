using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Pool;

namespace Fork.Battle
{
	public class CFlyTextManager : LwSingleton<CFlyTextManager>
	{
		private struct CacheFlyText
		{
			public Transform target;

			public List<CFlyText> texts;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass68_0
		{
			public Transform i_Target;

			public List<CFlyText> flytexts;

			public CFlyText uiNumber;

			internal bool _003C_ShowDamageValue_003Eb__3(CacheFlyText x)
			{
				return false;
			}

			internal bool _003C_ShowDamageValue_003Eb__0()
			{
				return false;
			}

			internal bool _003C_ShowDamageValue_003Eb__1()
			{
				return false;
			}

			internal bool _003C_ShowDamageValue_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass71_0
		{
			public Transform i_Target;

			public List<CFlyText> flytexts;

			public CFlyText uiNumber;

			internal bool _003C_ShowHealValue_003Eb__3(CacheFlyText x)
			{
				return false;
			}

			internal bool _003C_ShowHealValue_003Eb__0()
			{
				return false;
			}

			internal bool _003C_ShowHealValue_003Eb__1()
			{
				return false;
			}

			internal bool _003C_ShowHealValue_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass74_0
		{
			public Transform i_Target;

			public List<CFlyText> flytexts;

			public CFlyText uiNumber;

			internal bool _003C_ShowBlockValue_003Eb__3(CacheFlyText x)
			{
				return false;
			}

			internal bool _003C_ShowBlockValue_003Eb__0()
			{
				return false;
			}

			internal bool _003C_ShowBlockValue_003Eb__1()
			{
				return false;
			}

			internal bool _003C_ShowBlockValue_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass81_0
		{
			public Transform i_Target;

			public List<CFlyText> flytexts;

			public CFlyText uiNumber;

			internal bool _003C_ShowStatusEffect_003Eb__3(CacheFlyText x)
			{
				return false;
			}

			internal bool _003C_ShowStatusEffect_003Eb__0()
			{
				return false;
			}

			internal bool _003C_ShowStatusEffect_003Eb__1()
			{
				return false;
			}

			internal bool _003C_ShowStatusEffect_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass84_0
		{
			public Transform i_Target;

			public List<CFlyText> flytexts;

			public CFlyText uiNumber;

			internal bool _003C_ShowText_003Eb__3(CacheFlyText x)
			{
				return false;
			}

			internal bool _003C_ShowText_003Eb__0()
			{
				return false;
			}

			internal bool _003C_ShowText_003Eb__1()
			{
				return false;
			}

			internal bool _003C_ShowText_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass87_0
		{
			public Transform i_Target;

			public List<CFlyText> flytexts;

			public CFlyText uiNumber;

			internal bool _003C_ShowAbility_003Eb__2(CacheFlyText x)
			{
				return false;
			}

			internal bool _003C_ShowAbility_003Eb__0()
			{
				return false;
			}

			internal bool _003C_ShowAbility_003Eb__1()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CFlyTextManager _003C_003E4__this;

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
		private sealed class _003C_ShowAbility_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform i_Target;

			public CSkillAbilityData i_Data;

			public CCharDef i_Character;

			public CFlyTextManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass87_0 _003C_003E8__1;

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
			public _003C_ShowAbility_003Ed__87(int _003C_003E1__state)
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
		private sealed class _003C_ShowBlockValue_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform i_Target;

			public CFlyTextManager _003C_003E4__this;

			public int i_Value;

			public CCharDef i_Character;

			private _003C_003Ec__DisplayClass74_0 _003C_003E8__1;

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
			public _003C_ShowBlockValue_003Ed__74(int _003C_003E1__state)
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
		private sealed class _003C_ShowDamageValue_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform i_Target;

			public CFlyTextManager _003C_003E4__this;

			public int i_Damage;

			public CCharDef i_Character;

			private _003C_003Ec__DisplayClass68_0 _003C_003E8__1;

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
			public _003C_ShowDamageValue_003Ed__68(int _003C_003E1__state)
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
		private sealed class _003C_ShowHealValue_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform i_Target;

			public CFlyTextManager _003C_003E4__this;

			public int i_Heal;

			public CCharDef i_Character;

			private _003C_003Ec__DisplayClass71_0 _003C_003E8__1;

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
			public _003C_ShowHealValue_003Ed__71(int _003C_003E1__state)
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
		private sealed class _003C_ShowStatusEffect_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform i_Target;

			public CMaster_SkillConditionData i_Condition;

			public CFlyTextManager _003C_003E4__this;

			public string i_Name;

			public CCharDef i_Character;

			private _003C_003Ec__DisplayClass81_0 _003C_003E8__1;

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
			public _003C_ShowStatusEffect_003Ed__81(int _003C_003E1__state)
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
		private sealed class _003C_ShowText_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform i_Target;

			public CFlyTextManager _003C_003E4__this;

			public string i_Name;

			public CCharDef i_Character;

			private _003C_003Ec__DisplayClass84_0 _003C_003E8__1;

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
			public _003C_ShowText_003Ed__84(int _003C_003E1__state)
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
		private Canvas m_Canvas;

		[SerializeField]
		private Transform[] m_Categories;

		private Transform m_Parent;

		private GameObject m_DamageValuePrefab;

		private GameObject m_HealValuePrefab;

		private GameObject m_BlockPlusValuePrefab;

		private GameObject m_BlockMinusValuePrefab;

		private GameObject m_StatusEffectNormalPrefab;

		private GameObject m_StatusEffectGoodPrefab;

		private GameObject m_StatusEffectBadPrefab;

		private GameObject m_AbilityPrefab;

		private List<CacheFlyText> m_CacheFlyText1;

		private List<CacheFlyText> m_CacheFlyText2;

		private List<CacheFlyText> m_CacheFlyText3;

		public ObjectPool<CFlyText> m_DamageValuePool { get; private set; }

		public ObjectPool<CFlyText> m_HealValuePool { get; private set; }

		public ObjectPool<CFlyText> m_BlockPlusValuePool { get; private set; }

		public ObjectPool<CFlyText> m_BlockMinusValuePool { get; private set; }

		public ObjectPool<CFlyText> m_StatusEffectNormalPool { get; private set; }

		public ObjectPool<CFlyText> m_StatusEffectGoodPool { get; private set; }

		public ObjectPool<CFlyText> m_StatusEffectBadPool { get; private set; }

		public ObjectPool<CFlyText> m_AbilityPool { get; private set; }

		private void Awake()
		{
		}

		private new void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__49))]
		public UniTask Initialize()
		{
			return default;
		}

		public void ReleaseAsset()
		{
		}

		private CFlyText CreatePooledDamageValue()
		{
			return null;
		}

		private CFlyText CreatePooledHealValue()
		{
			return null;
		}

		private CFlyText CreatePooledBlockPlusValue()
		{
			return null;
		}

		private CFlyText CreatePooledBlockMinusValue()
		{
			return null;
		}

		private CFlyText CreatePooledStatusNormalEffect()
		{
			return null;
		}

		private CFlyText CreatePooledStatusGoodEffect()
		{
			return null;
		}

		private CFlyText CreatePooledStatusBadEffect()
		{
			return null;
		}

		private CFlyText CreatePooledAbiilty()
		{
			return null;
		}

		private void OnTakeFromPool(CFlyText i_Component)
		{
		}

		private void OnReturnedToPool(CFlyText i_Component)
		{
		}

		private void OnDestroyPoolObject(CFlyText i_Component)
		{
		}

		private CFlyText GetDamageValue(uint i_Number, Transform i_Target)
		{
			return null;
		}

		private CFlyText GetHealValue(uint i_Number, Transform i_Target)
		{
			return null;
		}

		private CFlyText GetBlockValue(int i_Number, Transform i_Target)
		{
			return null;
		}

		private CFlyText GetStatusPopup(string i_Name, Transform i_Target, string i_Kind)
		{
			return null;
		}

		public void ShowDamageValue(int i_Damage, Transform i_Target, CCharDef i_Character)
		{
		}

		public void ShowDamageValue(int i_Damage, CCharDef i_Character)
		{
		}

		[IteratorStateMachine(typeof(_003C_ShowDamageValue_003Ed__68))]
		private IEnumerator _ShowDamageValue(int i_Damage, Transform i_Target, CCharDef i_Character)
		{
			return null;
		}

		public void ShowHealValue(int i_Heal, Transform i_Target, CCharDef i_Character)
		{
		}

		public void ShowHealValue(int i_Heal, CCharDef i_Character)
		{
		}

		[IteratorStateMachine(typeof(_003C_ShowHealValue_003Ed__71))]
		private IEnumerator _ShowHealValue(int i_Heal, Transform i_Target, CCharDef i_Character)
		{
			return null;
		}

		public void ShowBlockValue(int i_Value, Transform i_Target, CCharDef i_Character)
		{
		}

		public void ShowBlockValue(int i_Value, CCharDef i_Character)
		{
		}

		[IteratorStateMachine(typeof(_003C_ShowBlockValue_003Ed__74))]
		private IEnumerator _ShowBlockValue(int i_Value, Transform i_Target, CCharDef i_Character)
		{
			return null;
		}

		public void ShowBadStatusEffect(string i_Name, Transform i_Target, CCharDef i_Character, CMaster_SkillConditionData i_Condition)
		{
		}

		public void ShowBadStatusEffect(string i_Name, CCharDef i_Character, CMaster_SkillConditionData i_Condition)
		{
		}

		public void ShowGoodStatusEffect(string i_Name, Transform i_Target, CCharDef i_Character, CMaster_SkillConditionData i_Condition)
		{
		}

		public void ShowGoodStatusEffect(string i_Name, CCharDef i_Character, CMaster_SkillConditionData i_Condition)
		{
		}

		public void ShowNormalStatusEffect(string i_Name, Transform i_Target, CCharDef i_Character, CMaster_SkillConditionData i_Condition)
		{
		}

		public void ShowNormalStatusEffect(string i_Name, CCharDef i_Character, CMaster_SkillConditionData i_Condition)
		{
		}

		[IteratorStateMachine(typeof(_003C_ShowStatusEffect_003Ed__81))]
		private IEnumerator _ShowStatusEffect(string i_Name, Transform i_Target, Color32 i_Color, CCharDef i_Character, CMaster_SkillConditionData i_Condition)
		{
			return null;
		}

		public void ShowText(string i_Name, Transform i_Target, CCharDef i_Character)
		{
		}

		public void ShowText(string i_Name, CCharDef i_Character)
		{
		}

		[IteratorStateMachine(typeof(_003C_ShowText_003Ed__84))]
		private IEnumerator _ShowText(string i_Name, Transform i_Target, Color32 i_Color, CCharDef i_Character)
		{
			return null;
		}

		public void ShowAbility(CSkillAbilityData i_Data, Transform i_Target, CCharDef i_Character, bool i_Follow = false)
		{
		}

		public void ShowAbility(CSkillAbilityData i_Data, CCharDef i_Character, bool i_Follow = false)
		{
		}

		[IteratorStateMachine(typeof(_003C_ShowAbility_003Ed__87))]
		private IEnumerator _ShowAbility(CSkillAbilityData i_Data, Transform i_Target, CCharDef i_Character, bool i_Follow = false)
		{
			return null;
		}

		public void Release()
		{
		}

		public void EnableCanvas()
		{
		}

		public void DisableCanvas()
		{
		}
	}
}
