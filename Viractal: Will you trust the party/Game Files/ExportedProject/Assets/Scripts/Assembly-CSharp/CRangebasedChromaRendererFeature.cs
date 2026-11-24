using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CRangebasedChromaRendererFeature : ScriptableRendererFeature
{
	[SerializeField]
	private Material m_Material;

	private CRangebasedChromaRenderPass m_Pass;

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer i_Renderer, ref RenderingData r_RenderingData)
	{
	}

	protected override void Dispose(bool i_Disposing)
	{
	}
}
