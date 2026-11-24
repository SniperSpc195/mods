using System;
using System.Collections.Generic;
using CriWare;

namespace Fork.Game
{
	public class CSoundChannel
	{
		private long mHandle;

		private int mChannel;

		private int mId;

		private string mName;

		private float mCurrentVolume;

		private float mOldVolume;

		private float mTargetVolume;

		private float mFadePauseVolume;

		private int mPriority;

		private float mPitch;

		private bool mAttachFader;

		private bool mAttachVolTween;

		private bool mEndVolTween;

		private bool mHaveStarted;

		private bool mFadePause;

		private List<string> mAttachedAisac;

		private CSoundPlayerBase mSoundPlayer;

		private CriAtomExPlayback mPlayback;

		private CriAtomExPlayer mPlayer;

		private CriAtomEx3dSource m3dSource;

		private CriAtomEx3dListener m3dListener;

		private CriAtomExTween mVolTween;

		private Action mFadeCallback;

		public long Handle
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int Channel => 0;

		public int Priority => 0;

		public int ID => 0;

		public string Name => null;

		public bool IsStarted => false;

		public CriAtomExPlayer Player => null;

		public bool FadePause => false;

		public CriAtomEx3dSource Sound3dSource => null;

		public CriAtomEx3dListener Sound3dListener => null;

		public CriAtomEx3dListener Default3dListener => null;

		public CSoundChannel(int channel, ushort[] categories, CSoundPlayerBase soundPlayer)
		{
		}

		public void Destroy()
		{
		}

		public void Initialize(int channel, ushort[] categories, CSoundPlayerBase soundPlayer)
		{
		}

		private float ActualVolume(float volume)
		{
			return 0f;
		}

		public void Set3dSource(CriAtomEx3dSource source)
		{
		}

		public void Set3dListener(CriAtomEx3dListener listener)
		{
		}

		public void SetSoundByName(CSoundFile soundFile, string name)
		{
		}

		public void SetSoundByID(CSoundFile soundFile, int id)
		{
		}

		public void SetSoundByIndex(CSoundFile soundFile, int index)
		{
		}

		public void SetSoundData(byte[] data, int size)
		{
		}

		public SoundStatus GetStatus()
		{
			return SoundStatus.Stop;
		}

		public void Start()
		{
		}

		public void Stop(bool ignoreReleaseTime = false)
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		private void CancelVolTween()
		{
		}

		public void Update()
		{
		}

		public void SetVolume(float volume)
		{
		}

		public float GetVolume()
		{
			return 0f;
		}

		public void SetPriority(int priority)
		{
		}

		public int GetPriority()
		{
			return 0;
		}

		public void SetPitch(float pitch)
		{
		}

		public float GetPitch()
		{
			return 0f;
		}

		public void FadeIn(int time)
		{
		}

		public void FadeOut(int time)
		{
		}

		public void FadeTo(ushort duration, float volume, Action fadeCallback = null)
		{
		}

		public void FadeOutPause(ushort ms)
		{
		}

		public void ResumeFadeIn(ushort ms)
		{
		}

		public void SetBusSendLevel(string busName, float sendLevel)
		{
		}

		public void AttachAisac(string globalAisacName)
		{
		}

		public void DetachAisac(string globalAisacName)
		{
		}

		public void DetachAisacAll()
		{
		}

		public void SetAisacControl(string controlName, float value)
		{
		}

		public void SetAisacControl(uint controlId, float value)
		{
		}
	}
}
