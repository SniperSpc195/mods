using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

public class PreUIFadeRenderPassFeature : ScriptableRendererFeature
{
	private class PreUIFadeRenderPass : ScriptableRenderPass
	{
		private class PassData
		{
			public Material material;

			public TextureHandle sourceTexture;
		}

		internal static readonly int HalfTexture;

		private Material m_MaterialHalf;

		private Material m_MaterialBlur;

		private float m_Alpha;

		private static void ExecutePassHalf(PassData data, RasterGraphContext context)
		{
		}

		private static void ExecutePassBlur(PassData data, RasterGraphContext context)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public PreUIFadeRenderPass(Shader shaderHalf)
		{
		}

		public void SetStyle(Material material, float alpha)
		{
		}
	}

	public Shader shaderHalf;

	public Material[] filterSettings;

	private PreUIFadeRenderPass m_ScriptablePass;

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
