using System;
using Sting.Rigging;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CBlueMan : MonoBehaviour
{
	public enum Position
	{
		LEFT = 0,
		RIGHT = 1
	}

	[Serializable]
	public class ShowControl
	{
		public Renderer mRenderer;

		public MaterialPropertyBlock mMaterialPropertyBlock;

		public int mMatIndex;

		public int mPropertyNum;

		public ShowControl(Renderer render)
		{
		}

		public void Update(float a)
		{
		}
	}

	private Position mPosition;

	public COnline.PlayerInfo mOnlinePlayerInfo;

	private GameObject mModel;

	[SerializeField]
	[ReadOnly]
	private ShowControl[] mShowControl;

	public float mDissolveClipTime;

	private const float mMaxDissolveClipTime = 0.7f;

	public float mSpeed;

	[SerializeField]
	[ReadOnly]
	private bool mShow;

	[SerializeField]
	[ReadOnly]
	private bool mHideShow;

	private AsyncOperationHandle<GameObject> mHandleHeadgear;

	private GameObject mHeadgear;

	private CAnimePlayer mAnimePlayer;

	private CLookAtRig mHeadRig;

	private Transform mHead;

	private string mEffectName;

	private float _MoveTime;

	public float HeadRigSpeed;

	public float HeadRigHeight;

	private const float m_ThreshouldRMSMin = -96f;

	private const float m_ThreshouldRMSMax = -24f;

	private const float m_ThreshouldHead = -78f;

	private Transform _RootNode;

	public CAnimePlayer AnimePlayer => null;

	public Position GetPosition()
	{
		return Position.LEFT;
	}

	public void Initialize(string effectName, int position)
	{
	}

	public void UnloadHeadgear()
	{
	}

	private void SetupMaterial(Transform model)
	{
	}

	private void Start()
	{
	}

	public bool IsValidGUID()
	{
		return false;
	}

	public bool IsGUID(COnline.PlayerInfo info)
	{
		return false;
	}

	public bool IsShow()
	{
		return false;
	}

	public bool IsStop()
	{
		return false;
	}

	public void Show()
	{
	}

	public void Effect_Show(bool onEffect = true)
	{
	}

	public void HideShow()
	{
	}

	public void Hide(bool immediate = false)
	{
	}

	public void Effect_Hide(bool immediate = false)
	{
	}

	public void Update()
	{
	}

	private void UpdateShader()
	{
	}

	private void UpdateHeadRig()
	{
	}
}
