Shader "Sting/URP/NumberArray" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		_ColumnCount ("ColumnCount", Range(1, 2)) = 2
		_Column0 ("Column0", Range(0, 9)) = 0
		_Column1 ("Column1", Range(0, 9)) = 0
		_BaseMap ("_BaseMap", 2DArray) = "white" {}
		_NormalMap ("_NormalMap", 2DArray) = "white" {}
		_Smoothness ("Smoothness", Range(0, 1)) = 0
		_Metaric ("Metaric", Range(0, 1)) = 0
		_Tint ("Tint", Vector) = (0,0,0,1)
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