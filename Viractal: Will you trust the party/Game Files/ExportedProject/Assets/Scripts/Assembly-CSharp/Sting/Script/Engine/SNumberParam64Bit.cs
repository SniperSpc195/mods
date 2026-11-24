namespace Sting.Script.Engine
{
	public struct SNumberParam64Bit
	{
		public long m_Data;

		private byte m_Format;

		private byte m_Mold;

		private byte m_Discrimination;

		public bool IsParam()
		{
			return false;
		}

		public bool IsNumber()
		{
			return false;
		}

		public bool IsString()
		{
			return false;
		}

		public bool CheckParamMold(Number64Mold i_Mold)
		{
			return false;
		}

		public bool IsParamValue()
		{
			return false;
		}

		public bool IsParamInt()
		{
			return false;
		}

		public bool IsParamFloat()
		{
			return false;
		}

		public bool IsParamBool()
		{
			return false;
		}

		public bool IsParamString()
		{
			return false;
		}

		public long GetIntNumber()
		{
			return 0L;
		}

		public void SetIntNumber(long i_Num)
		{
		}

		public float GetFloatNumber()
		{
			return 0f;
		}

		public void SetFloatNumber(float i_Num)
		{
		}

		public int GetStringAddr()
		{
			return 0;
		}

		public int GetParamNo()
		{
			return 0;
		}

		public void SetParamNo(int i_No)
		{
		}

		public void SetInfo(short i_Info)
		{
		}

		public short GetInfo()
		{
			return 0;
		}

		public ScriptFpFormatType GetParamFormat()
		{
			return ScriptFpFormatType.Auto;
		}

		public void SetParamFormat(ScriptFpFormatType i_Format)
		{
		}

		public Number64Mold GetMold()
		{
			return Number64Mold.Int;
		}

		public void SetMold(Number64Mold i_Mold)
		{
		}

		public Number64Disc GetDiscrimination()
		{
			return Number64Disc.Number;
		}

		public void SetDiscrimination(Number64Disc i_Disc)
		{
		}
	}
}
