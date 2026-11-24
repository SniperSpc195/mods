Shader "Card/EffectParts" {
	Properties {
		[PerRendererData] _MainTex ("Main Texture", 2D) = "white" {}
		_SecondTex ("Secondary Texture", 2D) = "white" {}
		[Toggle(_USE_SECONDARYTEXTURE)] _UseSecondaryTexture ("Use Secondary Texture", Float) = 0
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend0Src ("Blend0 Src", Float) = 5
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend0Dst ("Blend0 Dst", Float) = 10
		[Enum(UnityEngine.Rendering.BlendOp)] _Blend0Equ ("Blend0 Equ", Float) = 0
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend0SrcAlpha ("Blend0 Src Alpha", Float) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend0DstAlpha ("Blend0 Dst Alpha", Float) = 10
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend1Src ("Blend1 Src", Float) = 5
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend1Dst ("Blend1 Dst", Float) = 10
		[Enum(UnityEngine.Rendering.BlendOp)] _Blend1Equ ("Blend1 Equ", Float) = 0
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend1SrcAlpha ("Blend1 Src Alpha", Float) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _Blend1DstAlpha ("Blend1 Dst Alpha", Float) = 10
		[Toggle(_USE_CUTOFF)] _UseCutoff ("Use Cutoff", Float) = 0
		_CutoffParam ("Cutoff Param", Float) = 0.5
		_GlobalAdderScaler ("Effect Scaler", Vector) = (0,0,0,0)
		[HideInInspector] _StencilComp ("Stencil Comparison", Float) = 8
		[HideInInspector] _Stencil ("Stencil ID", Float) = 0
		[HideInInspector] _StencilOp ("Stencil Operation", Float) = 0
		[HideInInspector] _StencilWriteMask ("Stencil Write Mask", Float) = 255
		[HideInInspector] _StencilReadMask ("Stencil Read Mask", Float) = 255
		[HideInInspector] _ColorMask ("Color Mask", Float) = 15
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
}