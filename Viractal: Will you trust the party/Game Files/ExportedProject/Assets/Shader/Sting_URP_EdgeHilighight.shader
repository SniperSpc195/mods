Shader "Sting/URP/EdgeHilighight" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		_BaseMap ("BaseMap", 2D) = "white" {}
		[Toggle] _Mono ("Mono", Float) = 0
		[Toggle] _Nega ("Nega", Float) = 0
		_BaseColor ("BaseColor", Vector) = (1,1,1,1)
		_LayerMap ("LayerMap", 2D) = "white" {}
		_LayerMaskMap ("LayerMaskMap", 2D) = "white" {}
		[KeywordEnum(UV1,UV2)] _UV ("UV", Float) = 0
		[KeywordEnum(None,Alpha,Multiply,Add,ReverseSubtract,AlphaFrip)] _LayerMode ("LayerMode", Float) = 0
		_MultiColor ("MultiColor", Vector) = (1,1,1,1)
		_EdgeColor ("EdgeColor", Vector) = (1,1,1,0)
		_Emission ("Emission", Vector) = (0,0,0,1)
		[Toggle(_USEMETALLICMAP_ON)] _UseMetallicMap ("UseMetallicMap", Float) = 0
		_MetallicMap ("MetallicMap", 2D) = "white" {}
		_Metallic ("Metallic", Range(0, 1)) = 0
		_Smoothness ("Smoothness", Range(0, 1)) = 0
		_Width ("Width", Float) = 0.01
		[Toggle(_USENORMAL_ON)] _UseNormal ("UseNormal", Float) = 0
		[Normal] _NormalMap ("NormalMap", 2D) = "white" {}
		[Toggle(_USEOCCLUSIONMAP_ON)] _UseOcclusionMap ("UseOcclusionMap", Float) = 0
		_OcclusionMap ("OcclusionMap", 2D) = "white" {}
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