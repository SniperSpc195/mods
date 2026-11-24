using System;
using System.Collections.Generic;

[Serializable]
public class CParamDef
{
	public class Condition_Summary
	{
		public CParamCondition mParamCondition;

		public int mCount;
	}

	public string mID;

	public string mName;

	public CParamInt mLv;

	public CParamInt mMaxHp;

	protected int mLvMaxHp;

	protected CParamInt mPermanentMaxHp;

	public CParamInt mHp;

	public List<CSkillAbilityData> mAbility;

	protected CParamInt mSp;

	protected int mLvSp;

	protected CParamInt mPermanentSp;

	public CParamInt mGold;

	public CParamInt mExp;

	public int[] mBuf;

	public List<CParamCondition> mCondition;

	public int GetMaxHp()
	{
		return 0;
	}

	public int GetHp()
	{
		return 0;
	}

	public float GetHpPer()
	{
		return 0f;
	}

	public int SetHp(int a)
	{
		return 0;
	}

	public int AddHp(int a)
	{
		return 0;
	}

	public int SubHpMin1(int a)
	{
		return 0;
	}

	public int ResetPermanentMaxHp()
	{
		return 0;
	}

	public int AddPermanentMaxHp(int a)
	{
		return 0;
	}

	public int GetPermanentMaxHp()
	{
		return 0;
	}

	public bool IsAlive()
	{
		return false;
	}

	public bool IsDead()
	{
		return false;
	}

	public int GetSp()
	{
		return 0;
	}

	public int ResetPermanentSp()
	{
		return 0;
	}

	public int AddPermanentSp(int a)
	{
		return 0;
	}

	public int GetPermanentSp()
	{
		return 0;
	}

	public CParamCondition AddCondition(CMaster_SkillConditionData data)
	{
		return null;
	}

	public void EraseCondition(CParamCondition i_Condition)
	{
	}

	public void EraseCondition(string id)
	{
	}

	public void EraseConditionToEffectID(string id)
	{
	}

	public void ConsumeConditionToEffectID(string id)
	{
	}

	public void ConsumeCondition(string id)
	{
	}

	public void EraseConditionAll(string id)
	{
	}

	public void EraseConditionAll(string id, out bool clear)
	{
		clear = default;
	}

	public void EraseConditionAllToEffectID(string id)
	{
	}

	public void EraseConditionForKind(string kind)
	{
	}

	public List<Condition_Summary> GetConditionSummary()
	{
		return null;
	}

	public CParamConditionList GetConditionList(string id)
	{
		return default;
	}

	public CParamConditionList GetConditionListToEffectID(string id)
	{
		return default;
	}

	public CParamCondition GetCondition(string id)
	{
		return null;
	}

	public List<CParamCondition> GetConditions(string id)
	{
		return null;
	}

	public List<CMaster_SkillConditionData> ProgressCondition(string range)
	{
		return null;
	}

	public void IncrementDrawCardCounter()
	{
	}

	public bool ClearCondition()
	{
		return false;
	}

	public bool ClearCondition(string range)
	{
		return false;
	}

	public bool ClearConditionDead()
	{
		return false;
	}

	public void SetupCondition()
	{
	}

	public CMaster_SkillAbilityData GetAbility(string id, bool onlyBattle = false)
	{
		return null;
	}

	public bool IsEffectID(string id)
	{
		return false;
	}

	public CMaster_SkillAbilityList GetAbilityToEffectID(string id)
	{
		return default;
	}

	public List<CMaster_SkillAbilityData> GetAbilityToGenre(string genre)
	{
		return null;
	}

	public int IsAddAbility(string id, bool inBattle = false)
	{
		return 0;
	}

	public CMaster_SkillAbilityData AddAbility(string id, bool enableBattle = false)
	{
		return null;
	}

	public CMaster_SkillAbilityData AddAbility(string id, out bool o_Success, bool enableBattle = false)
	{
		o_Success = default;
		return null;
	}

	public void RemoveAbility(CMaster_SkillAbilityData data)
	{
	}

	public void RemoveAbility(string id)
	{
	}

	public void RemoveBattleAbility()
	{
	}

	private void Reflecting_AbilityEffects(CMaster_SkillAbilityData ab, bool add)
	{
	}

	public void SaveID(Dictionary<string, object> save)
	{
	}

	public void SaveName(Dictionary<string, object> save)
	{
	}

	public void SaveLv(Dictionary<string, object> save)
	{
	}

	public void SaveHp(Dictionary<string, object> save)
	{
	}

	public void SaveGold(Dictionary<string, object> save)
	{
	}

	public void SaveExp(Dictionary<string, object> save)
	{
	}

	public void SaveBuf(Dictionary<string, object> save)
	{
	}

	public void SaveCondition(Dictionary<string, object> save)
	{
	}

	public void LoadID(JsonNode json)
	{
	}

	public void LoadName(JsonNode json)
	{
	}

	public void LoadHp(JsonNode json)
	{
	}

	public void LoadGold(JsonNode json)
	{
	}

	public void LoadExp(JsonNode json)
	{
	}

	public void LoadBuf(JsonNode json)
	{
	}

	public void LoadCondition(JsonNode json)
	{
	}

	public virtual string GetModelID()
	{
		return null;
	}

	public void LoadError(string title, string item)
	{
	}
}
