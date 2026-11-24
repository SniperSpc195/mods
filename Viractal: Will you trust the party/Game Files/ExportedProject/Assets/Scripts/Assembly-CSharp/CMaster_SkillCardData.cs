using System;
using System.Collections.Generic;
using Cysharp.Text;

[Serializable]
public class CMaster_SkillCardData : IMasterData
{
	[Serializable]
	public class CEffectIdTable
	{
		public string effect_id;

		public string effect_target;

		public string effect_detail;

		public string effect_detail2;

		public int effect_value;

		public int effect_value2;

		public bool IsNeedExplanation()
		{
			return false;
		}

		public bool IsNeedExplanationCondition()
		{
			return false;
		}

		public bool IsNeedExplanationAbility()
		{
			return false;
		}

		public bool IsNeedExplanationCard()
		{
			return false;
		}

		public List<CMaster_SkillConditionData> GetConditions()
		{
			return null;
		}

		public List<CMaster_SkillAbilityData> GetAbilities()
		{
			return null;
		}

		public List<CMaster_SkillCardData> GetCards()
		{
			return null;
		}
	}

	public string id;

	public int user;

	public string name_id;

	public int open;

	public string rarity;

	public string lower_ids;

	public string upgrade;

	public string type;

	public string prediction;

	public string kind;

	public string job;

	public int rank;

	public int cost_jus;

	public int cost_dig;

	public int cost_wis;

	public int cost_mer;

	public string picture;

	public int drop;

	public int get_jus;

	public int get_dig;

	public int get_wis;

	public int get_mer;

	public bool exclusion;

	public bool high_exclusion;

	public CEffectIdTable[] effect_id_table;

	public string action_script;

	public int insect_tag;

	protected string m_Name;

	protected string m_Detail;

	private int? _Index;

	public string ID => null;

	public int Index => 0;

	public string GetName()
	{
		return null;
	}

	public string GetDetail()
	{
		return null;
	}

	public void CopyName(out string name)
	{
		name = null;
	}

	public void CopyDetail(out string detail)
	{
		detail = null;
	}

	public bool IsAttack()
	{
		return false;
	}

	public bool IsSkill()
	{
		return false;
	}

	public string GetIllustName()
	{
		return null;
	}

	public void Copy(ref CMaster_SkillCardData dest)
	{
	}

	private Utf16ValueStringBuilder ReplaceConditionTag(int i_Index, ref Utf16ValueStringBuilder i_Text)
	{
		return default;
	}

	private Utf16ValueStringBuilder ReplaceWillTag(int i_Index, ref Utf16ValueStringBuilder i_Text)
	{
		return default;
	}
}
