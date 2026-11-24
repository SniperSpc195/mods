using System;
using System.Collections;
using System.Collections.Generic;

public struct CParamConditionList : IEnumerator<CParamCondition>, IEnumerator, IDisposable
{
	public enum IdType
	{
		ConditionID = 0,
		EffectID = 1
	}

	private int position;

	private List<CParamCondition> list;

	private CParamCondition current;

	private string id;

	private IdType m_IdType;

	public CParamCondition Current => null;

	object IEnumerator.Current => null;

	public static CParamConditionList Empty()
	{
		return default;
	}

	public CParamConditionList(List<CParamCondition> i_List, string i_ID, IdType i_IdType)
	{
		position = 0;
		list = null;
		current = null;
		id = null;
		m_IdType = IdType.ConditionID;
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

	public IEnumerator<CParamCondition> GetEnumerator()
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

	public bool Contain(string i_Id)
	{
		return false;
	}

	public CParamCondition FirstOrDefault()
	{
		return null;
	}

	public CParamCondition ElementAt(int i_Index)
	{
		return null;
	}
}
