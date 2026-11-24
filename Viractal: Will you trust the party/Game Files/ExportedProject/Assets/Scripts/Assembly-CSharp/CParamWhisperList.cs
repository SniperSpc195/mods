using System;
using System.Collections;
using System.Collections.Generic;

public struct CParamWhisperList : IEnumerator<CWhispersEffect>, IEnumerator, IDisposable
{
	private int position;

	private List<CWhispersEffect> list;

	private CWhispersEffect current;

	private string id;

	public CWhispersEffect Current => null;

	object IEnumerator.Current => null;

	public static CParamWhisperList Empty()
	{
		return default;
	}

	public CParamWhisperList(List<CWhispersEffect> i_List, string i_ID)
	{
		position = 0;
		list = null;
		current = null;
		id = null;
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

	public IEnumerator<CWhispersEffect> GetEnumerator()
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

	public CWhispersEffect FirstOrDefault()
	{
		return null;
	}

	public CWhispersEffect ElementAt(int i_Index)
	{
		return null;
	}
}
