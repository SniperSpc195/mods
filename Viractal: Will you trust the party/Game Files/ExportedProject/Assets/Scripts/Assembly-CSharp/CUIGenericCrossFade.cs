using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CUIGenericCrossFade : MonoBehaviour
{
	public enum MODE
	{
		None = 0,
		Start = 1,
		Continue = 2
	}

	[SerializeField]
	private Camera mMainCamera;

	[SerializeField]
	private RawImage mCrossFadeImage;

	[SerializeField]
	[ReadOnly]
	private Color mColor;

	[SerializeField]
	[ReadOnly]
	private float mSpeed;

	private RenderTexture mRenderTexture;

	private UnityEvent mCbEndCapture;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	public void Active(bool a)
	{
	}

	public void Initialize()
	{
	}

	public void StartCrossFade(float t, UnityEvent cb = null)
	{
	}

	public MODE GetMode()
	{
		return MODE.None;
	}

	public bool IsFade()
	{
		return false;
	}

	public float GetAlpha()
	{
		return 0f;
	}

	public void Update()
	{
	}

	private void LateUpdate()
	{
	}
}
