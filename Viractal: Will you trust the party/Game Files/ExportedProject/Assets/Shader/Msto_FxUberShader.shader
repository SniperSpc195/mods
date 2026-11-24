Shader "Msto/FxUberShader" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Toggle(_MASKABLE_ON)] _Maskable ("Maskable", Float) = 0
		[HideInInspector] _FadeMask ("FadeMask", Vector) = (0,0,0,1)
		[Toggle(_SMOOTHPARTICLE_ON)] _SmoothParticle ("SmoothParticle", Float) = 0
		_FadeLength ("FadeLength", Range(0.0001, 1)) = 0.05
		_LowColor ("LowColor", Vector) = (0,0,0,1)
		_MidColor ("MidColor", Vector) = (0.5,0.5,0.5,1)
		_HighColor ("HighColor", Vector) = (1,1,1,1)
		[Enum(UnityEngine.Rendering.BlendMode)] _BlendSrc ("BlendSrc", Float) = 5
		[Enum(UnityEngine.Rendering.BlendMode)] _BlendDst ("BlendDst", Float) = 10
		[Toggle] _DepthWrite ("DepthWrite", Float) = 0
		[Toggle(_COLORLERP_ON)] _ColorLerp ("ColorLerp", Float) = 0
		_AlphaClipValue ("AlphaClipValue", Range(0, 1)) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _DepthTest ("DepthTest", Float) = 2
		[Toggle(_UVSCROLL_ON)] _UvScroll ("UvScroll", Float) = 0
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 0
		_BackfaceColorScaler ("BackfaceColorScaler", Vector) = (1,1,1,1)
		[Enum(Custom,0,AlphaBlending,1,Additive,2,Subtract,3,Disable,4)] [HideInInspector] _BlendFunction ("_BlendFunction", Range(0, 3)) = 1
		_ColorScaler ("ColorScaler", Range(0, 8)) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _BlendSrcAlpha ("BlendSrcAlpha", Float) = 1
		_MainTex ("MainTex", 2D) = "white" {}
		[Enum(UnityEngine.Rendering.BlendMode)] _BlendDstAlpha ("BlendDstAlpha", Float) = 10
		_MaskTex ("MaskTex", 2D) = "white" {}
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[Enum(UnityEngine.Rendering.BlendOp)] _BlendOp ("BlendOp", Float) = 0
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
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
	Fallback "Hidden/InternalErrorShader"
	//CustomEditor "CFxUberShaderInspector"
}