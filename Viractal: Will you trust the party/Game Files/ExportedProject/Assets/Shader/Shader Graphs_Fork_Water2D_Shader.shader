Shader "Shader Graphs/Fork_Water2D_Shader" {
	Properties {
		[NoScaleOffset] _Tex_Main ("Tex Main", 2D) = "white" {}
		[NoScaleOffset] _Tex_Normal ("Tex Normal", 2D) = "white" {}
		_Normal_Strength ("Normal Strength", Range(0, 2)) = 1
		[NoScaleOffset] _Tex_Ambient_Occlusion ("Tex Ambient Occlusion", 2D) = "white" {}
		_AO_Value ("AO Value", Range(0, 2)) = 1
		_Smoothness ("Smoothness", Range(0, 1)) = 0.5
		_Metallic ("Metallic", Range(0, 1)) = 0
		_WaterEdge_Value ("WaterEdge Value", Range(0, 1)) = 1
		_Metallic_Saturation_Value ("Metallic Saturation Value", Range(0, 1)) = 1
		_Emission_Saturation_Value ("Emission Saturation Value", Range(0, 1)) = 0
		[NoScaleOffset] _Metallic_Smoothness ("Metallic Smoothness", 2D) = "white" {}
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