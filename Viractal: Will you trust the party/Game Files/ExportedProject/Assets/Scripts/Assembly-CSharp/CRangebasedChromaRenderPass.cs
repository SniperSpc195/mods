using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

public class CRangebasedChromaRenderPass : ScriptableRenderPass
{
	private class PassData
	{
		public Material material;

		public TextureHandle sourceTexture;
	}

	private Material m_Material;

	private CRangebasedChromaVolume m_VolumeComponent;

	private static readonly int MainTexKey;

	private static readonly int ParamUKey;

	private static readonly int ParamVKey;

	private static readonly int ColorKey;

	public void Cleanup()
	{
	}

	private void Dispose()
	{
	}

	private static void RenderFunction(PassData i_PassData, RasterGraphContext i_Context)
	{
	}

	public override void RecordRenderGraph(RenderGraph i_RenderGraph, ContextContainer i_FrameData)
	{
	}

	public void Setup(ScriptableRenderer i_Renderer, Material i_Material, CRangebasedChromaVolume i_VolumeComponent)
	{
	}
}
