using System.Collections.Generic;

public class CItem : CSkill
{
	public CMaster_ItemData m_Data { get; private set; }

	public CSkillEffect m_SkillEffect { get; private set; }

	public CItem(CMaster_ItemData item, CBattleCharDef self)
		: base(null)
	{
	}

	public CItem(CMaster_ItemData item, CFieldPlayer self)
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

	public override Dictionary<string, object> CreateSendParam(bool i_OnlyCharge = false, List<object> sendWhisperTarget = null)
	{
		return null;
	}

	public void SetJson(JsonNode i_JsonNode)
	{
	}
}
