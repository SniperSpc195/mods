using System;

[Serializable]
public class CMaster_MapTownData : IMasterData
{
	public string id;

	public string[] name_table;

	public string shop_id;

	public bool upgrade_shop;

	public int upgrade_gold;

	public int upgrade_times;

	public bool dispose_shop;

	public int dispose_gold;

	public int dispose_times;

	public string detail_id;

	public int heal_point;

	public string bgm;

	public string se;

	public string[] message_table;

	public string ID => null;

	public string GetName()
	{
		return null;
	}

	public string GetMessage()
	{
		return null;
	}

	public string GetEnvironmentSE()
	{
		return null;
	}
}
