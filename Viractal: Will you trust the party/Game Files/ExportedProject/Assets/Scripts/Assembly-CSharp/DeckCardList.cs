using System;
using System.Collections;
using System.Collections.Generic;

public struct DeckCardList : IEnumerator<CMaster_DeckCardData>, IEnumerator, IDisposable
{
	[Flags]
	public enum Squeeze
	{
		Opened = 1,
		CheckAppear = 2
	}

	private int position;

	private List<CMaster_DeckCardData> listDeckCard;

	private CMaster_DeckCardData current;

	private Squeeze squeeze;

	public CMaster_DeckCardData Current => null;

	object IEnumerator.Current => null;

	public static DeckCardList Empty()
	{
		return default;
	}

	public DeckCardList(List<CMaster_DeckCardData> i_List, params Squeeze[] i_Squeeze)
	{
		position = 0;
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

	public IEnumerator<CMaster_DeckCardData> GetEnumerator()
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

	public CMaster_DeckCardData FirstOrDefault()
	{
		return null;
	}

	public CMaster_DeckCardData ElementAt(int i_Index)
	{
		return null;
	}
}
