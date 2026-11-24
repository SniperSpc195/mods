using System;

[Serializable]
public class CMaster_StaffrollData : IMasterData
{
	public enum StaffrollType
	{
		Headline = 0,
		Staff = 1,
		Space = 2,
		Picture = 3
	}

	public string id;

	public string sort;

	public string[] label_table;

	public string[] text_table;

	private StaffrollType? m_Type;

	public string ID => null;

	public StaffrollType Type => StaffrollType.Headline;

	public string GetLabel()
	{
		return null;
	}

	public string GetText()
	{
		return null;
	}
}
