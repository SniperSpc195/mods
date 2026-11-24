using System;

[Serializable]
public class CMaster_CharJobData : IMasterData
{
	[Serializable]
	public class CBtlModelTable
	{
		public int btl_model_lv;

		public string btl_model_id;
	}

	public string id;

	public int level_index;

	public string[] name_table;

	public string model_id;

	public int open;

	public float scale;

	public string use_text;

	public string[] job_text_table;

	public int lv;

	public int hp;

	public int sp;

	public int dr_skill;

	public int dr_item;

	public int dr_tag;

	public int dr_gold;

	public int gold;

	public int exp;

	public string[] ability_table;

	public string action_script;

	public CBtlModelTable[] btl_model_lv_table;

	public string battle_bgm;

	private int? _Index;

	public string ID => null;

	public int Index => 0;

	public string GetName()
	{
		return null;
	}

	public string GetJobText()
	{
		return null;
	}

	public CMaster_ModelData GetModel()
	{
		return null;
	}

	public CMaster_ModelData GetBtlModel(int i_Level)
	{
		return null;
	}
}
