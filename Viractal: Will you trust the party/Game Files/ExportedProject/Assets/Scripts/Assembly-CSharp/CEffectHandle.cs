using System;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Serializable]
public class CEffectHandle
{
	private static long gEffNum;

	[SerializeField]
	[ReadOnly]
	private long mEffNum;

	[SerializeField]
	[ReadOnly]
	private CEventEnum.EVID mEVID;

	[SerializeField]
	[ReadOnly]
	private string mName;

	private AsyncOperationHandle<GameObject> mLoadHandle;

	[SerializeField]
	[ReadOnly]
	private bool mAutoDeath;

	[SerializeField]
	[ReadOnly]
	private CEffectPlayer mPlayer;

	private CEffectState mState;

	public bool IsLoad()
	{
		return false;
	}

	public bool IsPlay()
	{
		return false;
	}

	public bool IsStop()
	{
		return false;
	}

	public CEffectHandle(string path, Transform parent, Vector3 position, bool async = false, bool autoDeath = true, bool autoPlay = true)
	{
	}

	private void Setup(bool autoPlay = true)
	{
	}

	public long GetEffNum()
	{
		return 0L;
	}

	public void SetEVID(CEventEnum.EVID a)
	{
	}

	public CEventEnum.EVID GetEVID()
	{
		return CEventEnum.EVID._000;
	}

	public string GetName()
	{
		return null;
	}

	public CEffectPlayer GetEffectPlayer()
	{
		return null;
	}

	public bool IsParticleZero()
	{
		return false;
	}

	public float GetPlayTime()
	{
		return 0f;
	}

	public bool IsLoop()
	{
		return false;
	}

	public int GetLoopCount()
	{
		return 0;
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public void SetOffsetPosition(Vector3 pos)
	{
	}

	public void SetAngle(Vector3 a)
	{
	}

	public void SetScale(float s)
	{
	}

	public void SetScale(Vector3 s)
	{
	}

	public void LoopOff()
	{
	}

	public bool Update()
	{
		return false;
	}

	public void Destroy()
	{
	}

	public void SetEmpty()
	{
	}
}
