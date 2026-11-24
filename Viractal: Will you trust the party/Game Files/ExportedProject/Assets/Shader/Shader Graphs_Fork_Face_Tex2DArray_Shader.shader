Shader "Shader Graphs/Fork_Face_Tex2DArray_Shader" {
	Properties {
		[NoScaleOffset] _Base_Map ("Base Map", 2DArray) = "" {}
		_Alpha_Value ("Alpha Value", Float) = 1
		_BaseColor_Contrast ("BaseColor Contrast", Range(-1, 2)) = 1
		_BaseColor_Hue ("BaseColor Hue", Range(-180, 180)) = 0
		_BaseColor_Saturation ("BaseColor Saturation", Range(0, 1)) = 1
		_Map_Index ("Map Index", Range(0, 3)) = 0
		_Normal_Strength ("Normal Strength", Range(0, 2)) = 1
		[NoScaleOffset] _Specular_Smoothness_Map ("Specular Smoothness Map", 2DArray) = "" {}
		_Specular_Scale ("Specular Scale", Range(0, 1)) = 1
		[NoScaleOffset] _Metalic_Smoothness_Map ("Metalic Smoothness Map", 2DArray) = "" {}
		_Metallic_Scale ("Metallic Scale", Range(0, 1)) = 1
		_Smoothness_Scale ("Smoothness Scale", Range(0, 1)) = 1
		[NoScaleOffset] _Normal_Map ("Normal Map", 2D) = "white" {}
		[NoScaleOffset] _Emission_Map ("Emission Map", 2DArray) = "" {}
		_Emission_Value ("Emission Value", Range(-1, 4)) = 1
		[NoScaleOffset] _AmbientOcclusion_Map ("AmbientOcclusion Map", 2D) = "white" {}
		[HDR] _LerpColor ("LerpColor", Vector) = (0,0,0,0)
		_DissolveClipTime ("DissolveClipTime", Range(0, 1)) = 0
		_DissolveEdgeColor ("DissolveEdgeColor", Vector) = (1,1,1,1)
		_DissolveEdgeWidth ("DissolveEdgeWidth", Float) = 0.01
		_NoiseSpeed ("NoiseSpeed", Float) = 0.05
		_NoiseA_Tiling ("NoiseA_Tiling", Float) = 1
		_NoiseB_Tiling ("NoiseB_Tiling", Float) = 0.5
		_1_0_DelayTime ("1.0+DelayTime", Float) = 0.4
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