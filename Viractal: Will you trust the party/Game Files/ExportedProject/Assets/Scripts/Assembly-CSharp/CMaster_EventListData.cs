using System;
using System.Collections.Generic;

[Serializable]
public class CMaster_EventListData : EventBase_Activation, IMasterData
{
	[Serializable]
	public class CValue1Table
	{
		public int value1;

		public int value2;

		public int value3;

		public int value4;

		public int value5;
	}

	public string mass;

	public string eventmap;

	public bool record_flag;

	public CValue1Table[] value1_table;

	private List<string> mDetail;

	public string ID => null;

	public List<string> GetHexDetail()
	{
		return null;
	}

	public int GetValue1(string key)
	{
		return 0;
	}
}
