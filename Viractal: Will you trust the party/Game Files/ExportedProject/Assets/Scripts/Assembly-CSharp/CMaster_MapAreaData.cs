using System;

[Serializable]
public class CMaster_MapAreaData : IMasterData
{
	[Serializable]
	public class ObjectRate
	{
		public int min;

		public int max;
	}

	[Serializable]
	public class ObstaclesTbl
	{
		public string obstacles;

		public int lottery;
	}

	[Serializable]
	public class DecorateTbl
	{
		public string decorate;

		public int lottery;
	}

	public string id;

	public string name;

	public string range_x;

	public string range_y;

	public int height;

	public string under;

	public string shape;

	public string detail_asset;

	public string route_type;

	public string town_id;

	public string town_pos;

	public ObjectRate[] area_enemy_vol_table;

	public int area_enemy_rand_vol;

	public int area_enemy_rand_road_vol;

	public int area_enemy_rand_road2_vol;

	public int area_enemy_max_vol;

	public ObjectRate[] area_eobj_vol_table;

	public int area_eobj_max_vol;

	public int clouding;

	public int clouding_town;

	public ObjectRate[] obstacles_along_table;

	public string along_type;

	public ObjectRate[] obstacles_random_table;

	public ObjectRate[] decorate_random_table;

	public DecorateTbl[] decorate_table;

	public ObstaclesTbl[] obstacles_table;

	public string ID => null;
}
