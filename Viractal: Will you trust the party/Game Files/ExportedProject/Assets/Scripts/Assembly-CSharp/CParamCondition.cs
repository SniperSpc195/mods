using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

[Serializable]
public class CParamCondition
{
	public enum BUF
	{
		Hp = 0,
		Sp = 1,
		Max = 2
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CPlayEffect_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CParamCondition _003C_003E4__this;

		public Transform parent;

		public Vector3 offset;

		public float scale;

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

	public bool mSetFirst;

	public int mTurn;

	public int mStack;

	public bool mPermanent;

	public int mCountDrawCard;

	public CMaster_SkillConditionData mData;

	public int[] mBuf;

	public List<CSkillCardData> mExclusionCards { get; private set; }

	public List<string> mStolenItemIDs { get; private set; }

	public bool IsEmpty()
	{
		return false;
	}

	public string GetName()
	{
		return null;
	}

	public string GetDetail()
	{
		return null;
	}

	public CParamCondition(CMaster_SkillConditionData data)
	{
	}

	public CParamCondition(JsonNode json, CParamDef param)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	private void Initialize(CMaster_SkillConditionData data)
	{
	}

	public bool IsEqualRange(string range)
	{
		return false;
	}

	public void ResetTurn()
	{
	}

	public bool Progress()
	{
		return false;
	}

	public void BufDebuf(ref int[] buf)
	{
	}

	public void AddStack()
	{
	}

	public void SubStack()
	{
	}

	public void AddExclusionCard(CSkillCardData i_Card)
	{
	}

	public void ResetExclusionCard(CParamPlayer i_Target)
	{
	}

	public void AddStolenItem(CMaster_ItemData i_Item)
	{
	}

	public void RemoveStolenItem(string i_ItemID)
	{
	}

	public void Poison(CBattleCharDef character)
	{
	}

	public void PoisonConst(CBattleCharDef character)
	{
	}

	public void Shock(CBattleCharDef character)
	{
	}

	public void Possession(CBattleCharDef character, int i_BaseValue, bool i_PlayEffect)
	{
	}

	[AsyncStateMachine(typeof(_003CPlayEffect_003Ed__37))]
	public UniTask PlayEffect(Transform parent, Vector3 offset, float scale)
	{
		return default;
	}

	public int GetEffectValue(CParamDef i_SelfParam)
	{
		return 0;
	}
}
