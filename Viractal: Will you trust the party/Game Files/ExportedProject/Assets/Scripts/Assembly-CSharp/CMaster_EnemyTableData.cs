using System;

[Serializable]
public class CMaster_EnemyTableData : IMasterData
{
	public string id;

	public string[] enemy_group_table;

	public string ID => null;

	public CMaster_EnemyGroupData GetGroup(UtpnRandom rnd)
	{
		return null;
	}
}
