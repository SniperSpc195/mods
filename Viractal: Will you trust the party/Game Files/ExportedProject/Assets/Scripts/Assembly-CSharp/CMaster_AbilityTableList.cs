using System;
using System.Collections;
using System.Collections.Generic;

public struct CMaster_AbilityTableList : IEnumerator<CMaster_AbilityTableData>, IEnumerator, IDisposable
{
	private int position;

	private List<CMaster_AbilityTableData> list;

	private CMaster_AbilityTableData current;

	private string effectid;

	public CMaster_AbilityTableData Current => null;

	object IEnumerator.Current => null;

	public static CMaster_AbilityTableList Empty()
	{
		return default;
	}

	public CMaster_AbilityTableList(List<CMaster_AbilityTableData> i_List, string i_Effect)
	{
		position = 0;
		list = null;
		current = null;
		effectid = null;
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

	public IEnumerator<CMaster_AbilityTableData> GetEnumerator()
	{
		return null;
	}

	public int Count()
	{
		return 0;
	}

	public bool Any()
	{
		return false;
	}

	public CMaster_AbilityTableData FirstOrDefault()
	{
		return null;
	}

	public CMaster_AbilityTableData ElementAt(int i_Index)
	{
		return null;
	}
}
