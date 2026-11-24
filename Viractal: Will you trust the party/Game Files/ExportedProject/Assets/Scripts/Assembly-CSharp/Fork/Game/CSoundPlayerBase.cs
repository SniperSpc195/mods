using System;
using System.Collections.Generic;
using CriWare;

namespace Fork.Game
{
	public class CSoundPlayerBase
	{
		private float mMasterVolume;

		private int mMaxChannel;

		private Queue<CSoundChannel> mFreeChannel;

		private List<CSoundChannel> mUseChannel;

		private CSoundChannel[] mChannelTbl;

		private CSoundHandleList mHandleList;

		private SoundPlayerType mSoundPlayerType;

		private bool mIsUpdatedMasterVolume;

		private CSoundManager mSoundManager;

		private CriAtomEx3dListener m3dListener;

		protected Dictionary<int, Tuple<CSoundFile, int>> mSoundIndexList;

		protected Dictionary<string, CSoundFile> mSoundNameList;

		public List<CSoundChannel> UseChannel => null;

		public int MaxChannel => 0;

		public CriAtomEx3dListener Sound3dListener => null;

		public CriAtomEx3dListener Default3dListener => null;

		public SoundPlayerType PlayerType => SoundPlayerType.BGM;

		public CSoundPlayerBase(int maxChannel, SoundPlayerType soundPlayerType, CSoundHandleList handleList, CSoundManager soundManager)
		{
		}

		public void Destroy()
		{
		}

		public void SetSoundFile(CSoundFile soundFile, int index)
		{
		}

		public void UnsetSoundFile()
		{
		}

		public int GetSoundListCount()
		{
			return 0;
		}

		public string[] GetNameList()
		{
			return null;
		}

		public SoundStatus GetStatus(int channel)
		{
			return SoundStatus.Stop;
		}

		public CSoundChannel GetSoundChannel(int channel)
		{
			return null;
		}

		public int GetNextPlayChannel()
		{
			return 0;
		}

		public long AddChannel(CSoundChannel soundChannel)
		{
			return 0L;
		}

		public void RemoveChannel(CSoundChannel soundChannel)
		{
		}

		public CSoundChannel SearchRequest(int id, CriAtomEx3dSource source)
		{
			return null;
		}

		public CSoundChannel SearchRequest(string name, CriAtomEx3dSource source)
		{
			return null;
		}

		public int GetMaxChannel()
		{
			return 0;
		}

		public float ActualVolume(float volume)
		{
			return 0f;
		}

		public void SetMasterVolume(float masterVol)
		{
		}

		public float GetMasterVolume()
		{
			return 0f;
		}

		public void AttachAisac(int channel, string globalAisacName)
		{
		}

		public void DetachAisac(int channel, string globalAisacName)
		{
		}

		public void SetAisacControl(int channel, string controlName, float value)
		{
		}

		public void SetAisacControl(int channel, uint controlId, float value)
		{
		}

		public void Set3dListener(CriAtomEx3dListener listener)
		{
		}

		public CriAtomEx3dSource Get3dSource(int channel)
		{
			return null;
		}

		public virtual long Play(int channel, CSoundFile soundFile, string name, float volume, float pitch, int priority, CriAtomEx3dSource source, CriAtomEx3dListener listener)
		{
			return 0L;
		}

		public virtual long Play(int channel, CSoundFile soundFile, int id, float volume, float pitch, int priority, CriAtomEx3dSource source, CriAtomEx3dListener listener)
		{
			return 0L;
		}

		public virtual void Stop(int channel, bool ignoreReleaseTime = false)
		{
		}

		public void StopAll()
		{
		}

		public void Pause(int channel)
		{
		}

		public void PauseAll()
		{
		}

		public void Resume(int channel)
		{
		}

		public void ResumeAll()
		{
		}

		public void FadeIn(int channel, int ms)
		{
		}

		public void FadeOut(int channel, int ms)
		{
		}

		public void FadeTo(int channel, ushort ms, float volume, Action callback = null)
		{
		}

		public void FadeOutPause(int channel, ushort ms)
		{
		}

		public void ResumeFadeIn(int channel, ushort ms)
		{
		}

		public void SetVolume(int channel, float volume)
		{
		}

		public float GetVolume(int channel)
		{
			return 0f;
		}

		public void SetPitch(int channel, float pitch)
		{
		}

		public float GetPitch(int channel)
		{
			return 0f;
		}

		public void Update()
		{
		}

		public void Mute(bool mute)
		{
		}

		public bool IsMuted()
		{
			return false;
		}

		public void SetBusSendLevel(int channel, string busName, float sendLevel)
		{
		}
	}
}
