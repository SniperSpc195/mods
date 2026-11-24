using System.Collections.Generic;

namespace Sting.Script.Engine
{
	public class CScriptTerritory
	{
		private const int FUNCTION_LEVEL = 64;

		private int m_TopSeq;

		private int m_CurSeq;

		private float m_VWaitCounter;

		private int m_RecVWait;

		public short m_PushCount;

		public List<CScriptFunc> m_FuncList;

		private int m_ClearSeqPoint;

		public bool m_IsCreate { get; set; }

		public CScriptTerritory(int i_ClearSeqPoint)
		{
		}

		public void Initialize(int i_TopSeq)
		{
		}

		public void Clear(bool i_First = false)
		{
		}

		public void Create(byte i_Index, int i_CurSeq)
		{
		}

		public void CreateOffset(byte i_Index, int i_Offset)
		{
		}

		public int GetCurSeq()
		{
			return 0;
		}

		public void SetCurSeq(int i_Point)
		{
		}

		public int GetAddress(int i_Offset)
		{
			return 0;
		}

		public int GetOffset(int i_Addr)
		{
			return 0;
		}

		public CScriptVar GetAutoVar()
		{
			return null;
		}

		public bool UpdateVWait()
		{
			return false;
		}

		public void SetVWaitCounter(int i_Counter)
		{
		}

		public int GetVWaitCounter()
		{
			return 0;
		}

		public void SetRecVWait(int i_Wait)
		{
		}

		public int GetRecVWait()
		{
			return 0;
		}

		public void AddFunction(byte i_Index, int i_RetFileAddr, byte i_RetMold, long i_RetParamData, short i_RetParamInfo)
		{
		}

		public void DelFunction()
		{
		}

		public void PushFunction()
		{
		}

		public void PopFunction()
		{
		}

		public CScriptFunc GetFuncData()
		{
			return null;
		}
	}
}
