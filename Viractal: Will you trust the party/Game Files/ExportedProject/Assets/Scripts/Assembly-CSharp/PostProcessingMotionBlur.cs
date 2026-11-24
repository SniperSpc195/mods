using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

public class PostProcessingMotionBlur
{
	private enum Pass
	{
		VelocitySetup = 0,
		TileMax1 = 1,
		TileMax2 = 2,
		TileMaxV = 3,
		NeighborMax = 4,
		Reconstruction = 5
	}

	public class PassData
	{
		public Material material;

		public TextureHandle sourceTexture;
	}

	private class ShaderIDs
	{
		internal static readonly int VelocityScale;

		internal static readonly int MaxBlurRadius;

		internal static readonly int RcpMaxBlurRadius;

		internal static readonly int VelocityTex;

		internal static readonly int Tile2RT;

		internal static readonly int Tile4RT;

		internal static readonly int Tile8RT;

		internal static readonly int TileMaxOffs;

		internal static readonly int TileMaxLoop;

		internal static readonly int TileVRT;

		internal static readonly int NeighborMaxTex;

		internal static readonly int LoopCount;
	}

	private static void RenderFunction(PassData i_PassData, RasterGraphContext i_Context, int i_Pass)
	{
	}

	public void ObjectMotionBlur(RenderGraph i_RenderGraph, ContextContainer i_ContextContainer, Material material)
	{
	}
}
