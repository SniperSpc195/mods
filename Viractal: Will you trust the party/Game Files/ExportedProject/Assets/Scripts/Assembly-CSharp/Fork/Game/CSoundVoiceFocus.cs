using net;

namespace Fork.Game
{
	public class CSoundVoiceFocus : RtChat.ISound
	{
		private bool mbVoiceFocus;

		private float mDiff;

		private float mTargetVolume;

		private float mCurrentVolume;

		public bool IsVoiceFocus()
		{
			return false;
		}

		public void SetVoiceFocus(bool flag)
		{
		}

		public bool IsEnabledBinauralizer()
		{
			return false;
		}

		public void Update()
		{
		}
	}
}
