using System.Collections.Generic;

public class CSkillCard : CSkill
{
	public int m_DamageCount;

	public bool m_CostFree;

	public bool m_OnlyCharge;

	public int m_CurseDamage;

	public CSkillCardData m_Data { get; private set; }

	public List<CSkillEffect> m_SkillEffects { get; private set; }

	public List<CParamCondition> m_ConsumedCondition { get; private set; }

	public CSkillCard(string id, CBattleCharDef self)
		: base(null)
	{
	}

	public CSkillCard(CSkillCardData data, CBattleCharDef self)
		: base(null)
	{
	}

	private void Initialize()
	{
	}

	protected override void LoadActionScript()
	{
	}

	public override void TrigActionScript()
	{
	}

	public override void Execute()
	{
	}

	public bool Hit()
	{
		return false;
	}

	public override void TryDead()
	{
	}

	public override string GetID()
	{
		return null;
	}

	public override string GetName()
	{
		return null;
	}

	public override void ApplyHp()
	{
	}

	public override bool IsExecuted()
	{
		return false;
	}

	public void Curse()
	{
	}

	public bool TryExclusion()
	{
		return false;
	}

	public void Prepare(CBattleCharDef i_User, bool i_OnlyCharge, List<object> sendWhisperTarget)
	{
	}

	public override Dictionary<string, object> CreateSendParam(bool i_OnlyCharge, List<object> sendWhisperTarget)
	{
		return null;
	}

	public void SetJson(JsonNode i_JsonNode)
	{
	}
}
