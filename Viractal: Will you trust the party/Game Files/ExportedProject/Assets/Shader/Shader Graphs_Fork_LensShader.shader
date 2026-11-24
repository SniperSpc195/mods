Shader "Shader Graphs/Fork_LensShader" {
	Properties {
		[NoScaleOffset] _Main_Tex ("Main Tex", 2D) = "white" {}
		_Depth ("Depth", Range(0, 1)) = 0
		_Speed ("Speed", Range(0, 1)) = 0.15
		_Tilling ("Tilling", Range(0, 8)) = 1
		_Blend ("Blend", Range(0, 1)) = 0
		_FirstColor ("FirstColor", Vector) = (0.5309274,0.9150943,0.8583424,0)
		_SecondColor ("SecondColor", Vector) = (0.3101638,0.6758143,0.7735849,0)
		_Direction ("Direction", Vector) = (0.1,-0.5,0,0)
		_Distortion ("Distortion", Range(-1, 1)) = -0.05
		_DeepColor ("DeepColor", Vector) = (0.126157,0.4161916,0.4245283,0)
		_Displacement ("Displacement", Float) = 1
		_Offset ("Offset", Vector) = (0.2,0.2,0,0)
		_Int ("Int", Range(0, 1)) = 0.33
		_Far_Plane ("Far Plane", Float) = 0.01
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