using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;

public class CBtlEncountCamera : MonoBehaviour
{
	[SerializeField]
	private GameObject[] m_Inactive;

	[SerializeField]
	private PlayableDirector m_PlayableDirector;

	[SerializeField]
	private CTimelineReferenceChanger m_ReferernceChanger;

	[SerializeField]
	private GameObject m_VCamRoot;

	[SerializeField]
	private CinemachineVirtualCamera m_FirstCamera;

	[SerializeField]
	private CSignalMapMove m_SignalMapMove;

	[SerializeField]
	private CSignalHideField m_SignalHideField;

	private float? m_GameSpeed;

	public CTimelineReferenceChanger ReferernceChanger => null;

	public CSignalMapMove SignalMapMove => null;

	public CSignalHideField SignalHideField => null;

	public CinemachineTransposer m_CinemachineTransposer { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ActiveCamera()
	{
	}

	public void InActiveRoot()
	{
	}

	public void Play(CinemachineBrain i_CameraBrain)
	{
	}

	public void Stop()
	{
	}

	public bool IsDone()
	{
		return false;
	}

	public void SetFirstCameraPosition(Vector3 position, Quaternion rotation)
	{
	}

	private void SetBind(CinemachineBrain camBrain)
	{
	}
}
