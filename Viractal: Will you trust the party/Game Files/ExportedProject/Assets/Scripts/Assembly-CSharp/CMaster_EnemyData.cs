using System;

[Serializable]
public class CMaster_EnemyData : IMasterData
{
	public string id;

	public string name_id;

	public string model;

	public float scale;

	public int lv;

	public int hp;

	public int at;

	public int df;

	public int sp;

	public string type;

	public string action_id;

	public string[] ability_id_table;

	public int gold;

	public int exp;

	public string action_script;

	public string drop_table;

	public int drop_rate;

	private string m_Name;

	public string ID => null;

	public string Name => null;

	public CMaster_ModelData GetModel()
	{
		return null;
	}
}
