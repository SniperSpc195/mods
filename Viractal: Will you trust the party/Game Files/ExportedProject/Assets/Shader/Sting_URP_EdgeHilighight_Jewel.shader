Shader "Sting/URP/EdgeHilighight_Jewel" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		_Albedo_map ("Albedo_map", 2D) = "white" {}
		_Parallax_map ("Parallax_map", 2D) = "white" {}
		_ParallaxAlbedo ("Parallax Albedo", 2D) = "white" {}
		_ParallaxAlbBlend ("Parallax Alb Blend", Range(0, 1)) = 1
		_ParallaxIntensity ("Parallax Intensity", Range(0, 0.3)) = 0.05
		_EdgeParallax_test ("Edge Parallax_test", Range(0, 1)) = 0
		_Emission_map ("Emission_map", 2D) = "black" {}
		_EdgeColor ("EdgeColor", Vector) = (1,1,1,0)
		_EmissionIntensity ("Emission Intensity", Range(0, 1)) = 1
		_Metallic ("Metallic", Range(0, 1)) = 0
		_Smoothness ("Smoothness", Range(0, 1)) = 0
		_MatCap ("MatCap", 2D) = "white" {}
		_Width ("Width", Float) = 0.01
		[Toggle(_USENORMAL_ON)] _UseNormal ("UseNormal", Float) = 0
		_MatcapIntensity ("Matcap Intensity", Range(0, 1)) = 0.5
		[Normal] _NormalMap ("NormalMap", 2D) = "white" {}
		[KeywordEnum(Add,Multiply)] _BlendingMode ("Blending Mode", Float) = 0
		_EdgeMask ("EdgeMask", 2D) = "white" {}
		_EdgeMaskIntensity ("EdgeMaskIntensity", Range(0, 1)) = 1
		[HDR] _MainColor ("MainColor", Vector) = (1,1,1,0)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[ToggleOff] [HideInInspector] _SpecularHighlights ("Specular Highlights", Float) = 1
		[ToggleOff] [HideInInspector] _EnvironmentReflections ("Environment Reflections", Float) = 1
		[ToggleOff] [HideInInspector] _ReceiveShadows ("Receive Shadows", Float) = 1
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
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraphLitGUI"
}