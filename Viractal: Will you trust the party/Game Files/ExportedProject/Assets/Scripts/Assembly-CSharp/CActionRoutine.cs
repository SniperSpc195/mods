using System.Collections.Generic;

public class CActionRoutine
{
	private List<CMaster_EnemyActionData> m_Data;

	private List<CMaster_EnemyActionData> m_Candidate;

	private CBattleEnemy m_Self;

	private int m_CurrentTurn;

	public CSpeechBubble m_SpeechBubble { get; private set; }

	public bool m_TunrEnd { get; private set; }

	public CMaster_EnemyActionData m_DecisionAction { get; private set; }

	public CActionRoutine(CBattleEnemy enemy)
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public void DecideUseSkill()
	{
	}

	public bool ExecuteSkill()
	{
		return false;
	}

	public void ResetDecisionAction()
	{
	}

	public bool Skip()
	{
		return false;
	}

	private void SqueezeCandidate(out bool o_Extra)
	{
		o_Extra = default;
	}

	public void SetDecisionData(JsonNode i_Json, bool i_ShowSpeechBubble = true)
	{
	}

	private void ShowSpeechBubble()
	{
	}
}
