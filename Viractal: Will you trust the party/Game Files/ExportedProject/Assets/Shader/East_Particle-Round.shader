Shader "East/Particle-Round" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [Enum(UnityEngine.Rendering.BlendMode)] _BlendSrc ("BlendSrc", Float) = 5
		[Toggle] _SmoothFloor ("SmoothFloor", Range(0, 1)) = 0
		[Enum(UnityEngine.Rendering.BlendMode)] _BlendDst ("BlendDst", Float) = 10
		[Enum(UnityEngine.Rendering.CompareFunction)] _DepthTest ("DepthTest", Float) = 8
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 0
		_BaseMap ("BaseMap", 2D) = "white" {}
		_ColorScaler ("ColorScaler", Range(0, 4)) = 1
		_AlphaClipThreshold ("AlphaClipThreshold", Range(0, 1)) = 0
		[HideInInspector] _StencilComp ("StencilComp", Float) = 8
		[Toggle] _DepthWrite ("DepthWrite", Range(0, 1)) = 0
		[HideInInspector] _Stencil ("Stencil", Float) = 0
		[HideInInspector] _StencilOp ("StencilOp", Float) = 0
		[HideInInspector] _StencilWriteMask ("StencilWriteMask", Float) = 255
		[Enum(UnityEngine.Rendering.BlendMode)] _BlendSrcAlpha ("BlendSrcAlpha", Float) = 0
		[HideInInspector] _ColorMask ("ColorMask", Float) = 15
		[HideInInspector] _StencilReadMask ("StencilReadMask", Float) = 255
		[ASEEnd] [Enum(UnityEngine.Rendering.BlendMode)] _BlendDstAlpha ("BlendDstAlpha", Float) = 1
		[Enum(UnityEngine.Rendering.BlendOp)] _BlendOp ("BlendOp", Float) = 0
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/InternalErrorShader"
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}