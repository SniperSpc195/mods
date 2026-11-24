using UnityEngine;

public class CDynamicResolution : MonoBehaviour
{
	private static CDynamicResolution _instance;

	private FrameTiming[] m_FrameTimings;

	[SerializeField]
	private bool m_Active;

	[SerializeField]
	[Range(0.1f, 1f)]
	private float m_MinScale;

	[SerializeField]
	private float m_TargetFPS;

	private float m_Threshould_GoodMillSec;

	private float m_Threshould_WarningMillSec;

	private float m_Threshould_BadMillSec;

	public static CDynamicResolution Instance => null;

	public static float scaleFactor { get; private set; }

	public static void ResizeBuffer(float scale)
	{
	}

	public void SetActive(bool isActive, float targetFPS = -1f)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public float GetTargetFps()
	{
		return 0f;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
