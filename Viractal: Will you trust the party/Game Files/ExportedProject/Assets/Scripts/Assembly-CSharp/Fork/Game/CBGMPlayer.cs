using CriWare;

namespace Fork.Game
{
	public class CBGMPlayer : CSoundPlayerBase
	{
		private ushort mCrossFadeTime;

		public CBGMPlayer(int maxChannel, SoundPlayerType soundPlayerType, CSoundHandleList soundHandleList, CSoundManager soundManager)
			: base(0, SoundPlayerType.BGM, null, null)
		{
		}

		public void SetCrossFadeTime(ushort ms)
		{
		}

		public long Play(int channel, string name, float volume, float pitch, int priority, CriAtomEx3dSource source, CriAtomEx3dListener listener)
		{
			return 0L;
		}

		public long Play(int channel, int reqId, float volume, float pitch, int priority, CriAtomEx3dSource source, CriAtomEx3dListener listener)
		{
			return 0L;
		}
	}
}
