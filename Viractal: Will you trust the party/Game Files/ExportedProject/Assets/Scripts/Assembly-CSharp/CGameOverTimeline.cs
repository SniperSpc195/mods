using UnityEngine;

public class CGameOverTimeline : MonoBehaviour
{
	[SerializeField]
	private CTimelineReferenceChanger[] m_TimelineReferenceChanger;

	[SerializeField]
	private SignalSE m_DeadLeftSE;

	[SerializeField]
	private SignalSE m_DeadRightSE;

	public CTimelineReferenceChanger ActiveTimelineReferenceChanger(int i_Index)
	{
		return null;
	}

	public void SetDeadLeftSE(string i_AnimeName)
	{
	}

	public void SetDeadRightSE(string i_AnimeName)
	{
	}
}
