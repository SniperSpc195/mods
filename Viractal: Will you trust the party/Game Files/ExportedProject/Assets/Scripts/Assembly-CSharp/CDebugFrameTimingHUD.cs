using System.Diagnostics;
using UnityEngine;
using UnityEngine.Profiling;

[AddComponentMenu("Debug/Measure")]
public class CDebugFrameTimingHUD : SingletonMonoBehaviour<CDebugFrameTimingHUD>
{
	private static CDebugFrameTimingHUD m_Instance;

	private readonly FrameTiming[] m_FrameTimings;

	private const int UpdateTimerLength = 64;

	private readonly double[] m_UpdateTimer;

	private int m_UpdateTimerWriteIndex;

	private int m_UpdateTimerWriteCount;

	private int m_MaxWorkerThreads;

	private int m_MaxIOThreads;

	public bool m_Show;

	private Recorder m_WillRenderCanvasesRecorder;

	[Conditional("UNITY_DEBUG")]
	public static void SetupFrameTimingHUD()
	{
	}

	[Conditional("UNITY_DEBUG")]
	public static void SetShow(bool i_Show)
	{
	}

	public static bool GetShow()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void DrawBar(Vector2 i_Position, double i_Ratio)
	{
	}

	private double CalcFps()
	{
		return 0.0;
	}
}
