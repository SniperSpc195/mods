using System;
using System.Collections;
using System.Collections.Generic;

public struct CMaster_SkillAbilityList : IEnumerator<CSkillAbilityData>, IEnumerator, IDisposable
{
	private int position;

	private List<CSkillAbilityData> list;

	private CSkillAbilityData current;

	private string effectid;

	public CSkillAbilityData Current => null;

	object IEnumerator.Current => null;

	public static CMaster_SkillAbilityList Empty()
	{
		return default;
	}

	public CMaster_SkillAbilityList(List<CSkillAbilityData> i_List, string i_Effect)
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

	public IEnumerator<CSkillAbilityData> GetEnumerator()
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

	public CSkillAbilityData FirstOrDefault()
	{
		return null;
	}

	public CSkillAbilityData ElementAt(int i_Index)
	{
		return null;
	}

	public CSkillAbilityData Get()
	{
		return null;
	}
}
