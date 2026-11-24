using System;

[Serializable]
public class CMaster_UnlockData : IMasterData
{
	public string id;

	public string set_id;

	public string[] name_table;

	public string illust;

	public int priority;

	public string unlock_if;

	public string if_value1;

	public string if_value2;

	public int price;

	public bool since_v0_3_0;

	public string[] details_table;

	public string[] lock_details_table;

	private int? _Index;

	public string ID => null;

	public int Index => 0;

	public string GetName()
	{
		return null;
	}

	public string GetDetails()
	{
		return null;
	}

	public string GetLockDetails()
	{
		return null;
	}
}
