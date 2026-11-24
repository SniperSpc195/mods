using System.Collections.Generic;

public class CMenuStatusInner : CUIGenericMenu
{
	private List<CSkillAbilityData> mAbility;

	private List<CParamCondition> mCondition;

	private new void Awake()
	{
	}

	public void SetAbility(List<CSkillAbilityData> list, bool resetCursor = true)
	{
	}

	public void SetCondition(List<CParamCondition> list, bool resetCursor = true)
	{
	}

	public void SetExplainDisp(bool a, bool activeUpdate = false)
	{
	}

	public void WriteExplain()
	{
	}

	public new bool MoveCursor(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
	{
		return false;
	}
}
