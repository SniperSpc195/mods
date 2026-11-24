using System;
using Fork.Game;
using UnityEngine;

[Serializable]
public class CFieldSound
{
	public enum TYPE
	{
		Bgm = 0,
		Se = 1,
		Voice = 2
	}

	[SerializeField]
	[ReadOnly]
	private long mHandle;

	[SerializeField]
	[ReadOnly]
	private string mReqName;

	private float mWait;

	[SerializeField]
	[ReadOnly]
	private TYPE mType;

	private CSoundChannel mSc;

	[SerializeField]
	[ReadOnly]
	private CSound.Status mStat;

	public long GetHandle()
	{
		return 0L;
	}

	public CSoundChannel GetSoundChannel()
	{
		return null;
	}

	public string GetRequest()
	{
		return null;
	}

	public CSound.Status GetStatus()
	{
		return CSound.Status.Stop;
	}

	public bool IsPlay()
	{
		return false;
	}

	public bool IsPause()
	{
		return false;
	}

	public bool IsStop()
	{
		return false;
	}

	public CFieldSound(long h, string name, TYPE type)
	{
	}

	public void Stop()
	{
	}
}
