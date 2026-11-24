using System;

[Serializable]
public class CMaster_ShelfData : IMasterData
{
	public string id;

	public string model_id;

	public string model_motion;

	public int sort;

	public int color;

	public string[] details_table;

	public string ID => null;

	public string GetDetail()
	{
		return null;
	}
}
