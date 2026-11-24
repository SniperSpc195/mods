using System;

[Serializable]
public class CMaster_CharLevelData : IMasterData
{
	[Serializable]
	public class CParamTable
	{
		public int hp;

		public int sp;
	}

	public string id;

	public int exp;

	public CParamTable[] hp_table;

	public string ID => null;
}
