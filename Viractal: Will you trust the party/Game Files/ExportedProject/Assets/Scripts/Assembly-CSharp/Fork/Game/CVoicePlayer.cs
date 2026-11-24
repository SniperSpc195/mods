using CriWare;

namespace Fork.Game
{
	public class CVoicePlayer : CSoundPlayerBase
	{
		public CVoicePlayer(int maxChannel, SoundPlayerType soundPlayerType, CSoundHandleList soundHandleList, CSoundManager soundManager)
			: base(0, SoundPlayerType.BGM, null, null)
		{
		}

		public long Play(string name, float volume, float pitch, int priority, CriAtomEx3dSource source, CriAtomEx3dListener listener)
		{
			return 0L;
		}

		public long Play(int reqId, float volume, float pitch, int priority, CriAtomEx3dSource source, CriAtomEx3dListener listener)
		{
			return 0L;
		}
	}
}
