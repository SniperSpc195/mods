using System.Collections.Generic;

namespace Sting.Script.Engine
{
	public class CScriptHeader : CScriptHeaderData
	{
		public struct SCompress
		{
			public int m_Type;

			public uint m_OriginSize;

			public uint m_EncodeSize;
		}

		public struct SSecurity
		{
			public int m_Type;

			public uint m_OriginSize;

			public uint m_EncodeSize;

			public uint m_Verify;
		}

		public class CResInfo
		{
			public int m_DataCount;

			public int m_DataAddr;
		}

		public uint m_ToolVer;

		public string m_FileName;

		public ushort m_TimeYear;

		public ushort m_TimeMonth;

		public ushort m_TimeDay;

		public ushort m_TimeHour;

		public ushort m_TimeMinute;

		public ushort m_TimeSecond;

		public ushort m_TimeMilliSecond;

		public ushort m_FileNo;

		public SCompress m_Compress;

		public SSecurity m_Security;

		public List<string> m_UseFileName;

		public int m_ResInfoListCount;

		public List<CResInfo> m_ResInfoList;

		public bool m_IsCmdLineInfo { get; set; }

		private byte GetU8(byte[] i_Buffer, int i_Offset)
		{
			return 0;
		}

		private ushort GetU16(byte[] i_Buffer, int i_Offset)
		{
			return 0;
		}

		private uint GetU32(byte[] i_Buffer, int i_Offset)
		{
			return 0u;
		}

		public int Load(byte[] i_Buffer, int i_Offset)
		{
			return 0;
		}
	}
}
