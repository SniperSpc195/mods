using UnityEngine;

public class CUIGenericOpenClose : MonoBehaviour
{
	public enum EASING
	{
		QuartOut = 0,
		CubicInOut = 1
	}

	protected enum MODE
	{
		None = 0,
		Open = 1,
		Close = 2
	}

	[SerializeField]
	private CanvasGroup mCanvasGroup;

	[SerializeField]
	private RectTransform mRectTransform;

	[SerializeField]
	private Vector2 mStart;

	[SerializeField]
	private Vector2 mEnd;

	[SerializeField]
	private float mSpeed;

	[SerializeField]
	private bool mAutoActive;

	[SerializeField]
	private EASING mEasing;

	[SerializeField]
	private string mSeOpen;

	[SerializeField]
	private string mSeClose;

	private const string mDefaultOpenSE = "SE_0004";

	private const string mDefaultCloseSE = "SE_0005";

	protected float mTime;

	private int mWait;

	[SerializeField]
	[ReadOnly]
	protected MODE mMode;

	[SerializeField]
	[ReadOnly]
	protected MODE mSituation;

	public Vector2 GetStartPosition()
	{
		return default;
	}

	public Vector2 GetEndPosition()
	{
		return default;
	}

	public void SetPosition(Vector2[] pos)
	{
	}

	public void SetStartPosition(Vector2 pos)
	{
	}

	public void SetEndPosition(Vector2 pos)
	{
	}

	public float GetTime()
	{
		return 0f;
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public void SetSE(string i_Open, string i_Close = null)
	{
	}

	public void SetStartPosition()
	{
	}

	public void SetEndPosition()
	{
	}

	public void Open(float startTime = 0f, bool playSE = true)
	{
	}

	public void Close(float startTime = 1f, bool playSE = true)
	{
	}

	protected virtual void Update()
	{
	}

	public void UpdateEasing()
	{
	}

	public void Active(bool a)
	{
	}

	protected virtual void SEPlay(string se, string defSe)
	{
	}

	public void SetAutoAcitive(bool i_Switch)
	{
	}
}
