namespace StUtility
{
	public class CRandom
	{
		private const int RAND_N = 624;

		private const int RAND_M = 397;

		private const uint MATRIX_A = 2567483615u;

		private const uint UPPER_MASK = 2147483648u;

		private const uint LOWER_MASK = 2147483647u;

		private uint m_Seed;

		private uint[] m_Mt;

		private int m_Mti;

		private uint[] m_Mag01;

		public void SetSeed(uint i_Seed)
		{
		}

		public uint GetSeed()
		{
			return 0u;
		}

		public uint Rand()
		{
			return 0u;
		}

		public int RandInt()
		{
			return 0;
		}

		public uint Rand(uint i_Range)
		{
			return 0u;
		}

		public int RandInt(int i_Range)
		{
			return 0;
		}

		public uint Rand(uint i_Min, uint i_Max)
		{
			return 0u;
		}

		public int RandInt(int i_Min, int i_Max)
		{
			return 0;
		}
	}
}
