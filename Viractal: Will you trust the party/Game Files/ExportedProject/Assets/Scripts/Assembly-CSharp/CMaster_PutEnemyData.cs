using System;

[Serializable]
public class CMaster_PutEnemyData : IMasterData
{
	public string id;

	public string stage;

	public string model;

	public float scale;

	public string group;

	public string[] enemy_pos_table;

	public string ID => null;
}
