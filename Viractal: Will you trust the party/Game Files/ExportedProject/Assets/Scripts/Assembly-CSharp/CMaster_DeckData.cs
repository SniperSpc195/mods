using System;
using System.Collections.Generic;

[Serializable]
public class CMaster_DeckData : IMasterData
{
	[Serializable]
	public class CSkillTable
	{
		public string skill;

		public int count;
	}

	public string id;

	public CSkillTable[] skill_table;

	public string[] lv2_skillcard_table;

	public string[] lv3_skillcard_table;

	public string[] lv4_skillcard_table;

	public string[] lv5_skillcard_table;

	public string[] lv6_skillcard_table;

	public string[] lv7_skillcard_table;

	public string[] lv8_skillcard_table;

	public string[] lv9_skillcard_table;

	public string[] lv10_skillcard_table;

	public string[] lv11_skillcard_table;

	public string[] lv12_skillcard_table;

	public string[] lv13_skillcard_table;

	public string[] lv14_skillcard_table;

	public string[] lv15_skillcard_table;

	public string[] lv16_skillcard_table;

	public string[] lv17_skillcard_table;

	public string[] lv18_skillcard_table;

	public string[] lv19_skillcard_table;

	public string[] lv20_skillcard_table;

	public string[] lv21_skillcard_table;

	public string[] lv22_skillcard_table;

	public string[] lv23_skillcard_table;

	public string[] lv24_skillcard_table;

	public string[] lv25_skillcard_table;

	public string[] lv26_skillcard_table;

	public string[] lv27_skillcard_table;

	public string[] lv28_skillcard_table;

	public string[] lv29_skillcard_table;

	public string[] lv30_skillcard_table;

	[NonSerialized]
	public List<CMaster_SkillCardData>[] m_SkillCardTable;

	public string ID => null;

	public SkillCardList GetSkillCardTable(int level)
	{
		return default;
	}

	private void SetupSkillTable(int i_Index, string[] i_Table)
	{
	}
}
