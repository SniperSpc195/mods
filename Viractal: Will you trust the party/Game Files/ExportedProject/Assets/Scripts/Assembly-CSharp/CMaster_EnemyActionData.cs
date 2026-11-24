using System;

[Serializable]
public class CMaster_EnemyActionData : IMasterData
{
	public string id;

	public string action_id;

	public string card_id;

	public string effect;

	public int value;

	public string effect_detail;

	public int weight;

	public int go_to_turn;

	public bool skip;

	public bool turn_end;

	public string ID => null;
}
