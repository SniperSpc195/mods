using System;
using System.Collections.Generic;

[Serializable]
public class CSkillAbilityData : CMaster_SkillAbilityData
{
	public bool mBattle;

	public bool mEnable;

	public CSkillAbilityData(string id)
	{
	}

	public CSkillAbilityData(CMaster_SkillAbilityData data)
	{
	}

	public CSkillAbilityData(JsonNode json)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}
}
