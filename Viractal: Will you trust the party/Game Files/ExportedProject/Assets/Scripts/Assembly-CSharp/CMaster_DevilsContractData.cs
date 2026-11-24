using System;

[Serializable]
public class CMaster_DevilsContractData : IMasterData
{
	public string id;

	public string devil_eff;

	public bool unique;

	public string target;

	public int reward_point;

	public bool count;

	public string point;

	public int level;

	public int random_vol;

	public int limit_time;

	public string ID => null;

	public bool IsOther()
	{
		return false;
	}

	public bool IsMe()
	{
		return false;
	}

	public bool IsAll()
	{
		return false;
	}

	public int GetPointNum()
	{
		return 0;
	}

	public CMaster_DevilsEffectData GetEffectData()
	{
		return null;
	}

	public string GetDebugID()
	{
		return null;
	}
}
