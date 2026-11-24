using System.Collections.Generic;
using Fork;

public class CSkillManager
{
	private struct UsingSkill
	{
		public string m_SkillCard;

		public int m_Count;
	}

	private CBattleCharDef m_Self;

	private UsingSkill m_PreviousUsedSkillCard;

	public StEvent<CBattleCharDef> m_OnTurnStart { get; private set; }

	private List<string> m_UsageHistorySkillCard { get; set; }

	public CSkillManager(CBattleCharDef character)
	{
	}

	public void AddUsedSkillCard(string i_ID)
	{
	}

	public static bool IsSameSkillCard(string i_ID1, string i_ID2, bool i_Compatible)
	{
		return false;
	}

	public bool IsUsedSkillCard(string i_ID, bool i_Compatible)
	{
		return false;
	}

	public bool IsUsedLastSkillCard(string i_ID, bool i_Compatible)
	{
		return false;
	}

	public string GetPreviousSkillCard()
	{
		return null;
	}

	public int CountPreviousSkillCard()
	{
		return 0;
	}
}
