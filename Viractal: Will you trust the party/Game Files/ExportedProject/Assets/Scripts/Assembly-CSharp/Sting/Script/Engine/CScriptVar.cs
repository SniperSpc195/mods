using StUtility;

namespace Sting.Script.Engine
{
	public class CScriptVar
	{
		private const int VAL_I_AUTO_MAX = 64;

		private const int VAL_F_AUTO_MAX = 32;

		private const int FLG_AUTO_MAX = 128;

		private const int STR_AUTO_MAX = 16;

		public CPrmBit m_AutoFlg;

		public CPrmValS64 m_AutoValI;

		public CPrmValF32 m_AutoValF;

		public CPrmStr m_AutoStr;

		public void Clear()
		{
		}
	}
}
