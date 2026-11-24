Shader "Shader Graphs/Fork_SlimeShader" {
	Properties {
		[NoScaleOffset] _BaseMap_Outside ("BaseMap_Outside", 2D) = "white" {}
		_BaseColor_Outside ("BaseColor_Outside", Vector) = (0,0,0,0)
		_BaseColor_Contrast ("BaseColor Contrast", Range(-1, 2)) = 1
		_BaseColor_Hue ("BaseColor Hue", Range(-180, 180)) = 0
		_BaseColor_Saturation ("BaseColor Saturation", Range(0, 1)) = 1
		_Light_Smoothstep_Outside ("Light_Smoothstep_Outside", Vector) = (0,1,0,0)
		[NoScaleOffset] _HeightMap ("HeightMap", 2D) = "white" {}
		_Amplitude_Power ("Amplitude_Power", Float) = 1
		_Amplitude_Step ("Amplitude_Step", Float) = 1
		[NoScaleOffset] _ParallaxMap_Inside ("ParallaxMap_Inside", 2D) = "white" {}
		_BaseColor_Inside ("BaseColor_Inside", Vector) = (1,1,1,0)
		_RimLight_Power ("RimLight_Power", Range(0, 4)) = 1
		_RimLight_Color ("RimLight_Color", Vector) = (1,1,1,0)
		_DarkColor_Power ("DarkColor_Power", Float) = 0
		_Polarization_Size ("Polarization_Size", Float) = 5
		_Polarization_Position ("Polarization_Position", Vector) = (0,2,0,0)
		[NoScaleOffset] _SmoothnessMap ("SmoothnessMap", 2D) = "white" {}
		_Metallic_Scale ("Metallic Scale", Range(0, 1)) = 1
		_Smoothness_Scale ("Smoothness Scale", Range(0, 1)) = 1
		[NoScaleOffset] _AOMap ("AOMap", 2D) = "white" {}
		[NoScaleOffset] _EmissionMap ("EmissionMap", 2D) = "black" {}
		[NoScaleOffset] _NormalMap ("NormalMap", 2D) = "white" {}
		[HDR] _LerpColor ("LerpColor", Vector) = (0,0,0,0)
		_VertexDisplacement ("VertexDisplacement", Vector) = (1,0,0,0)
		_NormalStrength ("NormalStrength", Range(0, 4)) = 1
		_RimLevel ("RimLevel", Float) = 1
		_UVScale ("UVScale", Vector) = (1,1,1,0)
		_Color_Hue ("Color_Hue", Range(-180, 180)) = 0
		_TimeSpeed ("TimeSpeed", Float) = 0
		[HideInInspector] _WorkflowMode ("_WorkflowMode", Float) = 1
		[HideInInspector] _CastShadows ("_CastShadows", Float) = 1
		[HideInInspector] _ReceiveShadows ("_ReceiveShadows", Float) = 1
		[HideInInspector] _Surface ("_Surface", Float) = 1
		[HideInInspector] _Blend ("_Blend", Float) = 0
		[HideInInspector] _AlphaClip ("_AlphaClip", Float) = 0
		[HideInInspector] _BlendModePreserveSpecular ("_BlendModePreserveSpecular", Float) = 1
		[HideInInspector] _SrcBlend ("_SrcBlend", Float) = 1
		[HideInInspector] _DstBlend ("_DstBlend", Float) = 0
		[HideInInspector] _SrcBlendAlpha ("_SrcBlendAlpha", Float) = 1
		[HideInInspector] _DstBlendAlpha ("_DstBlendAlpha", Float) = 0
		[ToggleUI] [HideInInspector] _ZWrite ("_ZWrite", Float) = 0
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