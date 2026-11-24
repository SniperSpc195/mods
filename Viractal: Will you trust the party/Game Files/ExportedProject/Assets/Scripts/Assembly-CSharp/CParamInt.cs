using System;

[Serializable]
public class CParamInt : CDefine.CryptInt
{
	public int mMin;

	public int mMax;

	public CParamInt(int num, int min, int max)
	{
	}

	public new int Get()
	{
		return 0;
	}

	public int Check(int a)
	{
		return 0;
	}

	public int GetDigit()
	{
		return 0;
	}

	public string GetString()
	{
		return null;
	}

	public int GetMax()
	{
		return 0;
	}

	public new int Set(int a)
	{
		return 0;
	}

	public int Set(int a, int max)
	{
		return 0;
	}

	public int Add(int a)
	{
		return 0;
	}

	public int SetAdd(int a)
	{
		return 0;
	}

	public int SetAdd(int a, int max)
	{
		return 0;
	}

	public int Sub(int a)
	{
		return 0;
	}

	public int SetSub(int a)
	{
		return 0;
	}

	public int SetSub(int a, int min)
	{
		return 0;
	}

	public int Multi(int mt)
	{
		return 0;
	}

	public int AddMulti(int a, int mt)
	{
		return 0;
	}
}
