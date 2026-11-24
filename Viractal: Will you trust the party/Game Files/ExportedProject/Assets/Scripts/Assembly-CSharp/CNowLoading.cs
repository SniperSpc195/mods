using TMPro;
using UnityEngine;

public class CNowLoading : SingletonMonoBehaviour<CNowLoading>
{
	private enum MODE
	{
		None = 0,
		Show = 1,
		Stop = 2
	}

	[SerializeField]
	private CanvasGroup mCanvasGroup;

	[SerializeField]
	private CInOutBehaviour mLoadingIcon;

	[SerializeField]
	private GameObject mSynchronizing;

	[SerializeField]
	private TextMeshProUGUI mSyncWait;

	[SerializeField]
	private TextMeshProUGUI mVersion;

	[SerializeField]
	[ReadOnly]
	private bool mLoading;

	[SerializeField]
	[ReadOnly]
	private bool mSync;

	[SerializeField]
	private TMP_Text mCommonText;

	[SerializeField]
	private Vector2 mPosition_BuildVersion;

	[SerializeField]
	private Vector2[] mPosition_SwitchVersion;

	private float mDispTime;

	private double mNowTime;

	private float mAlpha;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private void Awake()
	{
	}

	public void SetVersionText(string date)
	{
	}

	public void Go(float time = 0.1f, string commonText = "")
	{
	}

	public void Stop(bool immediate = false)
	{
	}

	private void Active(bool a)
	{
	}

	public bool IsActiveNowLoading()
	{
		return false;
	}

	public void GoSync(COnline.PlayerInfo ply, float time = 3f)
	{
	}

	public void StopSync(bool immediate = false)
	{
	}

	public void ChangeSyncName(COnline.PlayerInfo ply)
	{
	}

	public void Update()
	{
	}
}
