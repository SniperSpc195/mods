using System;
using System.Collections.Generic;

[Serializable]
public class CParamWhispers
{
	private int mPlayerIndex;

	public CParamInt mNumContracted;

	public CParamInt mNumRefusals;

	public CParamInt mPoint;

	public CParamInt mTurn;

	public CParamInt mLv;

	public CParamInt mReward;

	public List<string> mContracted;

	public List<CWhispersEffect> mEffects;

	public void Initialize(int index)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public void Load(JsonNode json)
	{
	}

	public static bool CheckSaveData(string savefile, int index, string name, JsonNode json)
	{
		return false;
	}

	public void AddEffects(CWhispersEffect eff)
	{
	}

	public void Remove(CWhispersEffect eff)
	{
	}

	public void AddContracted(CMaster_DevilsContractData data)
	{
	}

	public int GetNumContracted()
	{
		return 0;
	}

	public int IncNumContracted()
	{
		return 0;
	}

	public int GetNumRefusals()
	{
		return 0;
	}

	public int IncNumRefusals()
	{
		return 0;
	}

	public int AddPoint()
	{
		return 0;
	}

	public void ResetPoint()
	{
	}

	public bool LotteryWhispers(CMain.RND selectRandom = CMain.RND.Event)
	{
		return false;
	}

	public CMaster_DevilsContractData LotteryDevilsContract(CMain.RND selectRandom = CMain.RND.Event)
	{
		return null;
	}

	public bool IsContracted(string id)
	{
		return false;
	}

	public CWhispersEffect GetEffect(string id)
	{
		return null;
	}

	public CParamWhisperList GetEffectList(string id)
	{
		return default;
	}

	public void Activation(CWhispersEffect wEff)
	{
	}

	public void Wait_ClientActivation(bool wait)
	{
	}
}
