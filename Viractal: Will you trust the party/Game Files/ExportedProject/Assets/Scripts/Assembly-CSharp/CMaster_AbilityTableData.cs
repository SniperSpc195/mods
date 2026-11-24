using System;

[Serializable]
public class CMaster_AbilityTableData : IMasterData
{
	[Serializable]
	public class CAbilityTable
	{
		public string ability;

		public int abi_rate;
	}

	public string id;

	public CAbilityTable[] ability_table;

	public string ID => null;
}
