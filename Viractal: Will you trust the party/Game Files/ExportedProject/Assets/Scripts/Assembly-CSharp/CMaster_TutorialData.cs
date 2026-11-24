using System;

[Serializable]
public class CMaster_TutorialData : IMasterData
{
	public class Page
	{
		public string picture;

		public bool small;
	}

	public string id;

	public string genre;

	public int max_page;

	public string[] title_table;

	public string flag;

	public string picture_1;

	public bool small_1;

	public string[] page_1_table;

	public string picture_2;

	public bool small_2;

	public string[] page_2_table;

	public string picture_3;

	public bool small_3;

	public string[] page_3_table;

	private int? _GenreIndex;

	private int? _HelpIndex;

	private int? _FlagIndex;

	private Page[] _Pages;

	public string ID => null;

	public int GenreIndex => 0;

	public int HelpIndex => 0;

	public int FlagIndex => 0;

	public Page[] Pages => null;

	public string GetTitle()
	{
		return null;
	}

	public string GetLocalizedText(int page, GameController.PADNUM pad = GameController.PADNUM.None)
	{
		return null;
	}
}
