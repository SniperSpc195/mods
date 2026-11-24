Shader "Shader Graphs/Fork_Hex_Tex2DArray_Shader" {
	Properties {
		[NoScaleOffset] _Base_Map ("Base Map", 2DArray) = "" {}
		_Map_Index ("Map Index", Range(0, 15)) = 0
		_BaseColor_Contrast ("BaseColor Contrast", Range(-1, 2)) = 1
		_BaseColor_Hue ("BaseColor Hue", Range(-180, 180)) = 0
		_BaseColor_Saturation ("BaseColor Saturation", Range(0, 1)) = 1
		[NoScaleOffset] _Normal_Map ("Normal Map", 2DArray) = "" {}
		_Normal_Strength ("Normal Strength", Range(0, 2)) = 1
		[HDR] _LerpColor ("LerpColor", Vector) = (0,0,0,0)
		[NoScaleOffset] _Specular_Smoothness_Map ("Specular Smoothness Map", 2DArray) = "" {}
		[NoScaleOffset] _Emission_Map ("Emission Map", 2D) = "black" {}
		_Emission_Value ("Emission Value", Range(0, 2)) = 1
		[NoScaleOffset] _AmbientOcclusion_Map ("AmbientOcclusion Map", 2DArray) = "" {}
		[NoScaleOffset] _Metalic_Smoothness_Map ("Metalic Smoothness Map", 2DArray) = "" {}
		[HideInInspector] _WorkflowMode ("_WorkflowMode", Float) = 0
		[HideInInspector] _CastShadows ("_CastShadows", Float) = 1
		[HideInInspector] _ReceiveShadows ("_ReceiveShadows", Float) = 1
		[HideInInspector] _Surface ("_Surface", Float) = 0
		[HideInInspector] _Blend ("_Blend", Float) = 0
		[HideInInspector] _AlphaClip ("_AlphaClip", Float) = 0
		[HideInInspector] _BlendModePreserveSpecular ("_BlendModePreserveSpecular", Float) = 1
		[HideInInspector] _SrcBlend ("_SrcBlend", Float) = 1
		[HideInInspector] _DstBlend ("_DstBlend", Float) = 0
		[HideInInspector] _SrcBlendAlpha ("_SrcBlendAlpha", Float) = 1
		[HideInInspector] _DstBlendAlpha ("_DstBlendAlpha", Float) = 0
		[ToggleUI] [HideInInspector] _ZWrite ("_ZWrite", Float) = 1
		[HideInInspector] _ZWriteControl ("_ZWriteControl", Float) = 0
		[HideInInspector] _ZTest ("_ZTest", Float) = 4
		[HideInInspector] _Cull ("_Cull", Float) = 2
		[HideInInspector] _AlphaToMask ("_AlphaToMask", Float) = 0
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
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}