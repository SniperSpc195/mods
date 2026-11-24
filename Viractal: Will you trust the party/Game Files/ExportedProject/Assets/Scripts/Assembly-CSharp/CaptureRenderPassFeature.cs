using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

public class CaptureRenderPassFeature : ScriptableRendererFeature
{
	private class CaptureRenderPass : ScriptableRenderPass
	{
		private class PassData
		{
			public Material material;

			public TextureHandle sourceTexture;
		}

		internal static readonly int GrabTexture;

		public Material m_Material;

		private static void ExecutePass(PassData data, RasterGraphContext context)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public CaptureRenderPass(Shader shader)
		{
		}
	}

	public Shader shader;

	private CaptureRenderPass m_ScriptablePass;

	public static Camera targetCamera;

	public static void SetTargetCamera(Camera camera)
	{
	}

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
