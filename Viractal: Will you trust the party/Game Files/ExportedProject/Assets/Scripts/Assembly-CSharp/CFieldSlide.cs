using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CFieldSlide : MonoBehaviour
{
	private class ORG_PARENT
	{
		public CCharDef cDef;

		public Transform parent;

		public int index;

		public HexDupPosition.INIT_DATA dupData;

		public ORG_PARENT(CCharDef c)
		{
		}

		public void ComebackParent()
		{
		}

		public void ComebackIndex()
		{
		}

		public void SetHexPosition()
		{
		}
	}

	private enum MODE
	{
		None = 0,
		Load = 1,
		SlideOut = 2,
		Comeback = 3,
		End = 4
	}

	private class StageClear_PlayerSlide
	{
		private enum MODE
		{
			None = 0,
			Appearance = 1,
			Wait = 2,
			Exit = 3
		}

		public List<CFieldPlayer> mPlayers;

		public int mIndex;

		public float[] mWait;

		private MODE mMode;

		public bool IsExec()
		{
			return false;
		}

		public StageClear_PlayerSlide(List<CFieldPlayer> players)
		{
		}

		public void Exit_Players()
		{
		}

		public void OrgPosition(ORG_PARENT[] orgParent)
		{
		}

		private bool Appearance()
		{
			return false;
		}

		private bool Exit()
		{
			return false;
		}

		public void Update()
		{
		}
	}

	public const float SLIDE_WIDTH = 300f;

	[SerializeField]
	private Vector3 mNow;

	[SerializeField]
	private Vector3 mStart;

	[SerializeField]
	private Vector3 mTarget;

	[SerializeField]
	private float mTime;

	private float mEndTime;

	private float mSpeed;

	private ORG_PARENT[] mOrgParent;

	private CFieldPlayer[] mPlayers;

	private CFieldPlayer mExecPlayer;

	private bool mLanding;

	private Vector3 mCenterPosition;

	private string mAnimeName;

	private AsyncOperationHandle<GameObject> mHandle;

	private Transform mEventMap;

	[SerializeField]
	private Transform mParentPlayer;

	[SerializeField]
	private Transform mBaseParent;

	private List<Transform> mAdulation;

	[SerializeField]
	private MODE mMode;

	private StageClear_PlayerSlide mClear_PlayerSlide;

	public Vector3 GetNowPosition()
	{
		return default;
	}

	public Vector3 GetCenterPosition()
	{
		return default;
	}

	public bool IsExistMap()
	{
		return false;
	}

	public void Adulation(Transform a)
	{
	}

	public void SlideOut(List<CCharDef> list, string eventmap_path)
	{
	}

	public void SlideOut(Vector3 center, string eventmap_path)
	{
	}

	private void LoadModel(string eventmap_path)
	{
	}

	public void Comeback()
	{
	}

	public void Release()
	{
	}

	public Vector3 GetNow()
	{
		return default;
	}

	public bool IsPlay()
	{
		return false;
	}

	public bool IsMove()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}

	private void AdvanceTime()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetPlayers(List<CFieldPlayer> players, CFieldPlayer execPlayer)
	{
	}

	public void ExitPlayers()
	{
	}

	public bool IsExec_PlayerSlide()
	{
		return false;
	}
}
