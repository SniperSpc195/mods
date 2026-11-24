using System;

[Serializable]
public class CMaster_EnemyGroupData : IMasterData
{
	public string id;

	public string[] enemy_table;

	public int level;

	public string[] group_name_table;

	public string map_name;

	public string[] group_tips_table;

	public string model;

	public string motion;

	public float scale;

	public string effect;

	public string se;

	public string bgm;

	public string jingle;

	public int layer;

	public string area;

	public int encount;

	public float camera_distance;

	public float camera_angle_x;

	public float camera_angle_y;

	public float camera_pos_y;

	public float camera_look_y;

	public int first_attack;

	public bool bgm_priority;

	public string ID => null;

	public CMaster_EnemyGroupData(CMaster_EnemyGroupData enemyGroupData)
	{
	}
}
