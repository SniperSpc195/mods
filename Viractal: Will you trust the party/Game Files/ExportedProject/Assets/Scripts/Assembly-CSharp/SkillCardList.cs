using System;
using System.Collections;
using System.Collections.Generic;

public struct SkillCardList : IEnumerator<CMaster_SkillCardData>, IEnumerator, IDisposable
{
	private enum ListType
	{
		SkillCard = 0,
		DeckCard = 1
	}

	[Flags]
	public enum Squeeze
	{
		Opened = 1
	}

	private ListType listType;

	private int position;

	private List<CMaster_SkillCardData> listSkillCard;

	private List<CMaster_DeckCardData> listDeckCard;

	private CMaster_SkillCardData current;

	private Squeeze squeeze;

	public CMaster_SkillCardData Current => null;

	object IEnumerator.Current => null;

	public static SkillCardList Empty()
	{
		return default;
	}

	public SkillCardList(List<CMaster_SkillCardData> i_List, params Squeeze[] i_Squeeze)
	{
		listType = ListType.SkillCard;
		position = 0;
		listSkillCard = null;
		listDeckCard = null;
		current = null;
		squeeze = (Squeeze)0;
	}

	public SkillCardList(List<CMaster_DeckCardData> i_List, params Squeeze[] i_Squeeze)
	{
		listType = ListType.SkillCard;
		position = 0;
		listSkillCard = null;
		listDeckCard = null;
		current = null;
		squeeze = (Squeeze)0;
	}

	public void Dispose()
	{
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Reset()
	{
	}

	public IEnumerator<CMaster_SkillCardData> GetEnumerator()
	{
		return null;
	}

	public bool Any()
	{
		return false;
	}

	public int Count()
	{
		return 0;
	}

	public CMaster_SkillCardData FirstOrDefault()
	{
		return null;
	}

	public CMaster_SkillCardData ElementAt(int i_Index)
	{
		return null;
	}
}
