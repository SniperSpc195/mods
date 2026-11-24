using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CMaster_MapStageData : IMasterData
{
	[Serializable]
	public class CBoss_TurnMotion
	{
		public int boss_motion_turn;

		public string boss_motion_change;
	}

	[Serializable]
	public class CStageStartSE_Turn
	{
		public int stage_start_se_turn;

		public string stage_start_se_turn_se;
	}

	[Serializable]
	public class ObjectRange
	{
		public int min;

		public int max;
	}

	public string id;

	public string[] name_table;

	public string def_time_saving;

	public string sel_time_saving;

	public string level;

	public string level_view;

	public string start_pos;

	public string BGM;

	public string first_town;

	public int open;

	public string floor_water;

	public string floor_mountain;

	public string boss_se;

	public string boss_se_transform_or_offset;

	public string boss_model;

	public string boss_motion;

	public string boss_position;

	public string boss_angle;

	public CBoss_TurnMotion[] boss_motion_turn_table;

	public string stage_start_se;

	public CStageStartSE_Turn[] stage_start_se_turn_table;

	public int max_size_x;

	public int max_size_y;

	public ObjectRange[] start_range_x_table;

	public ObjectRange[] start_range_y_table;

	public string[] area_id_table;

	public string[] boss_id_table;

	public string battlemap;

	public string cloud_model;

	public string[] text_table;

	public string stage_image;

	public string koma_model;

	public int soul_point;

	public string boss_dead_camera;

	public float gold_stage_rate;

	public string[] command_table;

	private List<CMaster_MapTownData> mTowns;

	private int? _Index;

	public string ID => null;

	public int Index => 0;

	public string GetName(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetDescription(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetCommandName(CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetStageImagePath()
	{
		return null;
	}

	public Vector3Int GetStartPosition()
	{
		return default;
	}

	public List<CMaster_MapTownData> GetTownList()
	{
		return null;
	}

	public string LotteryBossGroup(CMain.RND type = CMain.RND.MapAutoGen)
	{
		return null;
	}

	public int GetNumBossGroup(string boss, bool error = false)
	{
		return 0;
	}

	public Vector3? GetSEOffset()
	{
		return null;
	}

	private Vector3 StringToVector3(string v)
	{
		return default;
	}

	public Vector3 GetBossPositionOffset()
	{
		return default;
	}

	public Vector3 GetBossAngleOffset()
	{
		return default;
	}

	public string GetBoss_AnimationName(int remainingTurns)
	{
		return null;
	}
}
