using UnityEngine;
using UnityEngine.InputSystem;

namespace Fork.SoundLocal
{
	public class CInputKeyboad
	{
		[SerializeField]
		private string mKeyboardLayout;

		public void Initialize()
		{
		}

		public void Update()
		{
		}

		public bool IsPress(Key key)
		{
			return false;
		}

		public bool IsTrigger(Key key)
		{
			return false;
		}

		public bool IsRelease(Key key)
		{
			return false;
		}
	}
}
