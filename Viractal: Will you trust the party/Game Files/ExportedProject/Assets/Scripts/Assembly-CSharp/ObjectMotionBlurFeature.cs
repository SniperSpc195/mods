using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ObjectMotionBlurFeature : ScriptableRendererFeature
{
	public Shader shader;

	private ObjectMotionBlurPass _objectMotionBlurPass;

	public static bool m_EnableObjectMotionBlur;

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
