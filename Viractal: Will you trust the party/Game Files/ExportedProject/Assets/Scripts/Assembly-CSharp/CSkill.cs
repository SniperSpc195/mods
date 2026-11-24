using System.Collections.Generic;
using Sting.Script.Engine;

public abstract class CSkill
{
	public enum ActionScriptLabel
	{
		Attack = 0,
		Heal = 1,
		Support = 2
	}

	private Dictionary<CCharDef, List<CMaster_SkillConditionData>> m_ShowedFlyTextCondition;

	public CCharDef m_Self { get; private set; }

	public CActionSeq m_ActionScript { get; protected set; }

	public int m_KillCount { get; set; }

	public CSkill(CCharDef self)
	{
	}

	protected abstract void LoadActionScript();

	public abstract void TrigActionScript();

	public abstract void Execute();

	public abstract void TryDead();

	public CParamDef GetParam()
	{
		return null;
	}

	public abstract string GetID();

	public abstract string GetName();

	public abstract void ApplyHp();

	public abstract Dictionary<string, object> CreateSendParam(bool i_OnlyCharge, List<object> sendWhisperTarget);

	public void ShowFlyTextCondition(CMaster_SkillConditionData i_Condition, CCharDef i_Target)
	{
	}

	public abstract bool IsExecuted();
}
