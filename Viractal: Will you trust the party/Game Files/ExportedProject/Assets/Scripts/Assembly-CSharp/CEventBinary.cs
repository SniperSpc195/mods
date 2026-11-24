using System.Collections.Generic;

public class CEventBinary
{
	public class EVENT_HEAD
	{
		public string mID;

		public int mIndex;

		public string mFile;

		public string mCallID;

		public EVENT_HEAD(string id, int index, string file = null)
		{
		}
	}

	public class EVENT_DATA
	{
		public string mFileName;

		public byte[] mBinary;

		public EVENT_HEAD mHead;

		public EVENT_DATA(string path, byte[] _bin, EVENT_HEAD _data)
		{
		}

		public bool IsFile()
		{
			return false;
		}

		public string GetID()
		{
			return null;
		}
	}

	private string mFileName;

	private byte[] mBinary;

	private Dictionary<string, EVENT_HEAD> mEvents;

	public List<string> GetEventHeadList()
	{
		return null;
	}

	private short GetShort(int i)
	{
		return 0;
	}

	private int GetInt(int i)
	{
		return 0;
	}

	private string GetString(int i)
	{
		return null;
	}

	public CEventBinary(string path, byte[] data)
	{
	}

	public EVENT_DATA GetEvent(string id)
	{
		return null;
	}
}
