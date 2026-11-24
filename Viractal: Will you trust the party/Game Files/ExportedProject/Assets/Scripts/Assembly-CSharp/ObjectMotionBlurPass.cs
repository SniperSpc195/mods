using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

public class ObjectMotionBlurPass : ScriptableRenderPass
{
	private readonly ProfilingSampler _objectMotionBlurSampler;

	private readonly PostProcessingMotionBlur _postProcessingMotionBlur;

	private Material _material;

	public ObjectMotionBlurPass(Shader shader)
	{
	}

	public override void RecordRenderGraph(RenderGraph i_RenderGraph, ContextContainer i_ContextContainer)
	{
	}
}
