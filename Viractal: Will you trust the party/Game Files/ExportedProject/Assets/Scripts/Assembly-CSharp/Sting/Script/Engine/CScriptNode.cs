namespace Sting.Script.Engine
{
	public class CScriptNode
	{
		private enum Type
		{
			Operator = 0,
			Data = 1
		}

		private enum OperatorType
		{
			DoubleEquip = 0,
			NotEquip = 1,
			L_Arrow = 2,
			L_EquipArrow = 3,
			R_Arrow = 4,
			R_EquipArrow = 5,
			And = 6,
			Or = 7,
			Plus = 8,
			Minus = 9,
			Mul = 10,
			Dev = 11,
			Mod = 12,
			L_BitShift = 13,
			R_BitShift = 14,
			BitAnd = 15,
			BitOr = 16
		}

		public class CNodeInfo
		{
			public SNumberParam64Bit m_Prm;

			public byte m_Type;

			public byte m_Ope;

			public CNodeInfo m_Left;

			public CNodeInfo m_Right;
		}

		public class CNodeData
		{
			public long m_Int;

			public float m_Float;

			public string m_String;

			public Number64Mold m_Mold;
		}

		public class CTreeNodeData
		{
			public SNumberParam64Bit m_NumPrm;

			public CScriptString m_String;

			public CTreeNodeData()
			{
			}

			public CTreeNodeData(long i_Data)
			{
			}
		}

		public delegate CParamValue GetValFunc(ref SNumberParam64Bit i_Info, object i_Seq);

		public delegate bool IsFlgFunc(ref SNumberParam64Bit i_Info, object i_Seq);

		public delegate CScriptString GetStrFunc(ref SNumberParam64Bit i_Info, object i_Seq);

		public delegate int GetScrAddrFunc(object i_Seq, int i_Offset);

		private const int _NODE_SIZE = 15;

		private ushort m_Count;

		private ushort m_NodeMax;

		private CNodeInfo[] m_Info;

		private IsFlgFunc m_FlgPrmFunc;

		private GetValFunc m_ValPrmFunc;

		private GetStrFunc m_StrPrmFunc;

		private GetScrAddrFunc m_GetAddrFunc;

		private byte GetU8(byte[] i_Buffer, int i_Ptr)
		{
			return 0;
		}

		private sbyte GetS8(byte[] i_Buffer, int i_Ptr)
		{
			return 0;
		}

		private ushort GetU16(byte[] i_Buffer, int i_Ptr)
		{
			return 0;
		}

		private short GetS16(byte[] i_Buffer, int i_Ptr)
		{
			return 0;
		}

		private uint GetU32(byte[] i_Buffer, int i_Ptr)
		{
			return 0u;
		}

		private int GetS32(byte[] i_Buffer, int i_Ptr)
		{
			return 0;
		}

		private ulong GetU64(byte[] i_Buffer, int i_Ptr)
		{
			return 0uL;
		}

		private long GetS64(byte[] i_Buffer, int i_Ptr)
		{
			return 0L;
		}

		public CScriptNode(ushort i_NodeMax)
		{
		}

		private void CountClear()
		{
		}

		public ushort GetCount()
		{
			return 0;
		}

		public ushort GetNodeMax()
		{
			return 0;
		}

		private CNodeInfo Create()
		{
			return null;
		}

		public void SetDataFunc(IsFlgFunc i_FlgFunc, GetValFunc i_ValFunc, GetStrFunc i_StrFunc, GetScrAddrFunc i_GetAddrFunc)
		{
		}

		private void Parse(CNodeInfo i_Node, byte[] i_Buffer, int i_TopPtr, int i_Ptr)
		{
		}

		public uint BinaryTreeJump(byte[] i_Buffer, int i_Ptr, object i_Seq)
		{
			return 0u;
		}

		private CTreeNodeData BinaryTreeJumpJudge(CNodeInfo i_Node, object i_Seq)
		{
			return null;
		}

		public int BinaryTreeFormula(byte[] buffer, int ptr, ref SNumberParam64Bit data, CScriptString strBuff, object seq)
		{
			return 0;
		}

		private CTreeNodeData BinaryTreeFormulaCalc(CNodeInfo node, object seq)
		{
			return null;
		}

		private void SetStringBuffer(ref SNumberParam64Bit i_psCopyData, CScriptString i_StrBuff, object seq)
		{
		}
	}
}
