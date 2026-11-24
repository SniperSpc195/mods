using System;
using System.Collections.Generic;

[Serializable]
public class CWhispersEffect
{
	public int mUniqueNum;

	public CMaster_DevilsContractData mContractData;

	public int mEffectAmount;

	public CMaster_DevilsEffectData mEffectData;

	public int mPlayerIndex;

	public CWhispersEffect(int num, CMaster_DevilsContractData data, CFieldPlayer player)
	{
	}

	public CWhispersEffect(JsonNode json)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public static bool CheckSaveData(string savefile, JsonNode json)
	{
		return false;
	}

	public bool IsUnique()
	{
		return false;
	}

	public bool IsEffects(string id)
	{
		return false;
	}

	public bool IsCount()
	{
		return false;
	}

	public int DecEffectAmount()
	{
		return 0;
	}

	public void Activation(int HoldPlayerIndex)
	{
	}
}
