using System.Collections.Generic;

public class CRegistryShop
{
	public CMaster_ShopDetailData mData;

	public List<CSaleItem> mItems;

	public int mCardUpgrade;

	public int mCardDispose;

	public CRegistryShop(CMaster_ShopDetailData shop, int floorY)
	{
	}

	public CRegistryShop(JsonNode json)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public static bool CheckSaveData(string savefile, JsonNode json)
	{
		return false;
	}
}
