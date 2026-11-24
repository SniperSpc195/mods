using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Camera))]
public class CCameraPostRender : MonoBehaviour
{
	public enum MODE
	{
		One = 0,
		Continue = 1
	}

	private RenderTexture mRenderTexture;

	private Camera m_Camera;

	private MODE mMode;

	private bool mCopied;

	private void Awake()
	{
	}

	public void SetRenderTexture(RenderTexture rt, MODE mode = MODE.One)
	{
	}

	public bool IsComplete()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void RenderPipelineManager_endCameraRendering(ScriptableRenderContext context, Camera camera)
	{
	}
}
