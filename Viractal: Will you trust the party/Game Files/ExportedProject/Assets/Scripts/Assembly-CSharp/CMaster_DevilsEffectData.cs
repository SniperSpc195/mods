using System;

[Serializable]
public class CMaster_DevilsEffectData : IMasterData
{
	public string id;

	public string name;

	public string[] text_top_table;

	public string[] text_bottom_table;

	public string ID => null;

	public string GetTextTop(CMaster_DevilsContractData cData, CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}

	public string GetTextBottom(CMaster_DevilsContractData cData, CFontType.LANG lang = CFontType.LANG.Default)
	{
		return null;
	}
}
