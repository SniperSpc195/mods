using UnityEngine;

public class CFractalNoiseGenerator : SingletonMonoBehaviour<CFractalNoiseGenerator>
{
	private static readonly string m_PropertyName;

	[SerializeField]
	private Vector2Int m_RenderTextureSize;

	[SerializeField]
	private int m_InitialKernelSize;

	[SerializeField]
	private float m_Exponent;

	private Camera m_CanvasCamera;

	[SerializeField]
	private Renderer m_FullscreenQuad;

	private RenderTexture m_RenderTexture;

	private MaterialPropertyBlock m_Properties;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static void Activate(bool i_Switch)
	{
	}

	public static bool IsPrepared()
	{
		return false;
	}
}
