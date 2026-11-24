using System;
using System.Collections.Generic;

namespace Fork.Game
{
	public class CSoundHandleList
	{
		private long mHandleCounter;

		private Dictionary<long, Tuple<CSoundPlayerBase, int>> mHandleList;

		public bool Exists(long handle)
		{
			return false;
		}

		public bool GetHandle(long handle, out CSoundPlayerBase soundPlayer, out int channel)
		{
			soundPlayer = null;
			channel = default;
			return false;
		}

		public long Add(CSoundPlayerBase soundPlayer, int channel)
		{
			return 0L;
		}

		public void Remove(long handle)
		{
		}
	}
}
