using System;
using System.Collections.Generic;

[Serializable]
public class CSkillCardData : CMaster_SkillCardData
{
	public enum Exclusion
	{
		None = 0,
		Game = 1,
		Battle = 2
	}

	private static uint mMasterAvailabilityNum;

	public uint mAvailabilityNum;

	public bool mTemporary;

	public Exclusion mExclusion;

	public bool mDraw;

	public static void SetMasterAvailabilityNum(uint a)
	{
	}

	public static uint GetMasterAvailabilityNum()
	{
		return 0u;
	}

	public CSkillCardData(string id)
	{
	}

	public CSkillCardData(CMaster_SkillCardData card)
	{
	}

	public CSkillCardData(JsonNode json)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}
}
