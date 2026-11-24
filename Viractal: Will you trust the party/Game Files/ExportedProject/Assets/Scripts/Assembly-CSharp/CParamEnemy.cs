using System;
using System.Collections.Generic;

[Serializable]
public class CParamEnemy : CParamDef
{
	public string mColoredName { get; private set; }

	private int AdjustmentMaxHP(int maxhp)
	{
		return 0;
	}

	public CParamEnemy(CMaster_EnemyData enemy, List<CMaster_SkillAbilityData> ability)
	{
	}

	public void SaveParam(Dictionary<string, object> save, bool id = false, bool name = false)
	{
	}

	public void LoadParam(JsonNode json)
	{
	}

	public void LoadLv(JsonNode json)
	{
	}

	public void InitAbility(CMaster_SkillAbilityData ability)
	{
	}

	public override string GetModelID()
	{
		return null;
	}
}
