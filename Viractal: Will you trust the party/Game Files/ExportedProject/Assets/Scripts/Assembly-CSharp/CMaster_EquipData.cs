using System;

[Serializable]
public class CMaster_EquipData : IMasterData
{
	public string id;

	public string name_id;

	public string rare;

	public string icon;

	public int price;

	public string type;

	public int drop;

	public int at;

	public int df;

	public int sp;

	public string effect;

	public int value;

	private string m_Name;

	private string m_Detail;

	public string ID => null;

	public string GetName()
	{
		return null;
	}
}
