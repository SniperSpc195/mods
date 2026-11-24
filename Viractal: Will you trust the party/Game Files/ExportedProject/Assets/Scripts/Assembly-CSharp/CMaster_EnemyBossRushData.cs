using System;

[Serializable]
public class CMaster_EnemyBossRushData : IMasterData
{
	[Serializable]
	public class EnemyGroup
	{
		public string group;

		public string battle_map;

		public string boss_dead_camera;
	}

	public string id;

	public EnemyGroup[] group_table;

	public string ID => null;
}
