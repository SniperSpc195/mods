using System;

[Serializable]
public class CMaster_MissionRewardData : IMasterData
{
	public string id;

	public string table_id;

	public string item_id;

	public int gold;

	public string ability_id;

	public string skill_card_id;

	public int soul;

	public string ID => null;

	public string Lottery(UtpnRandom rnd)
	{
		return null;
	}

	public string GetRewardName(string lottery_key)
	{
		return null;
	}
}
