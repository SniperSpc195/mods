using System;

[Serializable]
public class CMaster_DeckCardData : IMasterData
{
	public string id;

	public string card_id;

	public string chr_id;

	public int count;

	public int[] rate_table;

	[NonSerialized]
	private CMaster_SkillCardData m_SkillCardData;

	public string ID => null;

	public CMaster_SkillCardData GetSkillCard()
	{
		return null;
	}
}
