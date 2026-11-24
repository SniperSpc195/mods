using System.Collections.Generic;
using UnityEngine;

public class CSaleItem
{
	public string mID;

	public int mPlayerIndex;

	public object mData;

	public CSaleItem(string id)
	{
	}

	public CSaleItem(JsonNode json)
	{
	}

	public bool IsSoldout()
	{
		return false;
	}

	public bool IsConsumeItem()
	{
		return false;
	}

	public string GetName()
	{
		return null;
	}

	public string GetIconName(bool space = false)
	{
		return null;
	}

	public string GetDetail()
	{
		return null;
	}

	public int GetPrice(int discount)
	{
		return 0;
	}

	public Sprite GetIcon()
	{
		return null;
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}
}
