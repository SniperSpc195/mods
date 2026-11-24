using System;

[Serializable]
public class CMaster_ShopDetailData : IMasterData
{
	[Serializable]
	public class SellData
	{
		public string sell;

		public string high;

		private int[] floor;

		public bool IsFloor(int y)
		{
			return false;
		}
	}

	public string id;

	public string[] name_table;

	public SellData[] sell_table;

	public string ID => null;

	public string GetName()
	{
		return null;
	}
}
