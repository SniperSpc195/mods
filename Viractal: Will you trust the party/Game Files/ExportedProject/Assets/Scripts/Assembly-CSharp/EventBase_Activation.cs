using System;

[Serializable]
public class EventBase_Activation
{
	[Serializable]
	public class CTermTable
	{
		public string term_id;

		public string term_detail;

		public int term_value;
	}

	public string id;

	public int priority;

	public int random;

	public int lottery;

	public CTermTable[] term_id_table;

	public string overlap;
}
