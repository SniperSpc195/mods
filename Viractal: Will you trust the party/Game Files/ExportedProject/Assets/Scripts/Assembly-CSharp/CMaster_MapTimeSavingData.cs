using System;

[Serializable]
public class CMaster_MapTimeSavingData : IMasterData
{
	public string id;

	public int start_town;

	public int start_distance;

	public int sub_turns;

	public int start_level;

	public int card_acquisition_min;

	public int card_acquisition_max;

	public int drank_min;

	public int drank_max;

	public int gold_min;

	public int gold_max;

	public int dp_min;

	public int dp_max;

	public string[] item_table;

	public string ID => null;

	public CMaster_MapTimeSavingData(JsonNode json)
	{
	}
}
