using System;
using System.Collections.Generic;
using UnityEngine;

public class CAnimePlayer : MonoBehaviour
{
	public enum TYPE
	{
		None = 0,
		Base = 1,
		Body = 2,
		Face = 3,
		Other = 4
	}

	[Serializable]
	public class ANIMECLIP
	{
		public string mName;

		public int mLayer;

		private AnimationClip mClip;

		public ANIMECLIP(AnimationClip clip, TYPE type)
		{
		}

		public bool IsValid()
		{
			return false;
		}

		public string GetName()
		{
			return null;
		}

		public string GetClipName()
		{
			return null;
		}

		public float GetFrameLength()
		{
			return 0f;
		}

		public AnimationClip GetClip()
		{
			return null;
		}

		public float GetFrameRate()
		{
			return 0f;
		}

		public WrapMode GetWrapMode()
		{
			return WrapMode.Default;
		}
	}

	private class RESERVE
	{
		public string mGameObjectName;

		public bool mBlend;

		public string mName;

		public float mSpeed;

		public float mStartFrame;

		public float mDuration;

		public RESERVE(string gName, string name, float speed, float startFrame)
		{
		}

		public RESERVE(string gName, string name, float speed, float duration, float startFrame)
		{
		}
	}

	public const float DEF_DURATION_TIME = 0.25f;

	public const float BTL_DURATION_TIME = 0.1f;

	[SerializeField]
	[ReadOnly]
	private TYPE mType;

	private int mLayer;

	[SerializeField]
	[ReadOnly]
	private bool mLoop;

	[SerializeField]
	[ReadOnly]
	private bool mBlend;

	[SerializeField]
	[ReadOnly]
	private float mLength;

	public float mSpeed;

	[SerializeField]
	[ReadOnly]
	private float mFrame;

	[SerializeField]
	[ReadOnly]
	private int mLoopCount;

	private float mWeight;

	private float mDuration;

	private Animator mAnimator;

	private bool mKeepAnimatorControllerStateOnDisable;

	private bool mCheckBlend;

	[SerializeField]
	[ReadOnly]
	private Dictionary<string, ANIMECLIP> mClips;

	[SerializeField]
	[ReadOnly]
	private ANIMECLIP mPlaying;

	private CAnimePlayer mBasePlayer;

	private CAnimePlayer mFacePlayer;

	private bool mPlayLink;

	private List<CAnimePlayer> mOtherPlayer;

	private RESERVE mReserve;

	public static CAnimePlayer CreateAnimePlayers(GameObject g)
	{
		return null;
	}

	public static CAnimePlayer CreateAnimePlayer(GameObject g, Animator animator, TYPE type, bool includeFace = false)
	{
		return null;
	}

	public bool IsExistOtherPlayer()
	{
		return false;
	}

	private bool GetLink(string name)
	{
		return false;
	}

	public void SetLink(bool a)
	{
	}

	public void Initialize(Animator a, TYPE type = TYPE.None, bool includeFace = false)
	{
	}

	public void SetFacePlayer(CAnimePlayer a)
	{
	}

	public CAnimePlayer GetFacePlayer()
	{
		return null;
	}

	public void SetBasePlayer(CAnimePlayer a)
	{
	}

	public CAnimePlayer GetBasePlayer()
	{
		return null;
	}

	public void FirstPlay()
	{
	}

	public void FirstBlend()
	{
	}

	public int GetAnimationCount()
	{
		return 0;
	}

	public ANIMECLIP[] GetANIMECLIPs()
	{
		return null;
	}

	public Animator GetAnimator()
	{
		return null;
	}

	public float GetFrameLength(string name)
	{
		return 0f;
	}

	public bool IsLoop(TYPE type = TYPE.None)
	{
		return false;
	}

	public bool IsLoop(string name, TYPE type = TYPE.None)
	{
		return false;
	}

	public void ForceUpdate()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void InitState(string name, bool blend, float speed, float duration = 0f, float startFrame = 0f)
	{
	}

	public bool IsExist(string name)
	{
		return false;
	}

	public void Play(string name, float speed = 1f, float startFrame = 0f)
	{
	}

	public void PlayOverwrite(string name, float speed = 1f, float startFrame = 0f)
	{
	}

	public void Blend(string name, float speed = 1f, float duration = 0.25f, float startFrame = 0f)
	{
	}

	public void BlendOverwrite(string name, float speed = 1f, float duration = 0.25f, float startFrame = 0f)
	{
	}

	public bool IsEnd(TYPE type = TYPE.None)
	{
		return false;
	}

	public string GetPlayName(TYPE type = TYPE.None)
	{
		return null;
	}

	public void SetPlaySpeed(float speed)
	{
	}

	public float GetPlaySpeed(TYPE type = TYPE.None)
	{
		return 0f;
	}

	public float GetPlayFrame(TYPE type = TYPE.None)
	{
		return 0f;
	}

	public float GetMaxFrame(TYPE type = TYPE.None)
	{
		return 0f;
	}

	public int GetLoopCount(TYPE type = TYPE.None)
	{
		return 0;
	}

	public string GetFrameText()
	{
		return null;
	}

	private int _Play(string name, float speed, float startFrame)
	{
		return 0;
	}

	private int _PlayOverwrite(string name, float speed = 1f, float startFrame = 0f)
	{
		return 0;
	}

	private void SetPlay(string name, float speed, float startFrame)
	{
	}

	public int _Blend(string name, float speed = 1f, float duration = 0.25f, float startFrame = 0f)
	{
		return 0;
	}

	public int _BlendOverwrite(string name, float speed = 1f, float duration = 0.25f, float startFrame = 0f)
	{
		return 0;
	}

	private void SetBlend(string name, float speed, float duration, float startFrame)
	{
	}
}
