using System;

[Serializable]
public class CMaster_SkillAbility_GetTableData : IMasterData
{
	public string id;

	public string table_id;

	public int[] probability_table;

	public string ability_id;

	public string ID => null;
}
