using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace Fork
{
	[Serializable]
	public class StEvent
	{
		private Dictionary<string, UnityAction> m_List;

		public void AddListener(string key, UnityAction call)
		{
		}

		public void RemoveListener(string key)
		{
		}

		public void RemoveAllListeners()
		{
		}

		public int Count(UnityAction call)
		{
			return 0;
		}

		public int Count()
		{
			return 0;
		}

		public void Invoke()
		{
		}
	}
	[Serializable]
	public class StEvent<T0>
	{
		private Dictionary<string, T0> m_Arguments;

		private Dictionary<string, UnityAction<T0>> m_List;

		public void AddListener(string key, UnityAction<T0> call, T0 arg)
		{
		}

		public void RemoveListener(string key)
		{
		}

		public void RemoveAllListeners()
		{
		}

		public int Count(UnityAction<T0> call)
		{
			return 0;
		}

		public int Count()
		{
			return 0;
		}

		public void Invoke()
		{
		}

		public void Invoke(string key)
		{
		}
	}
}
