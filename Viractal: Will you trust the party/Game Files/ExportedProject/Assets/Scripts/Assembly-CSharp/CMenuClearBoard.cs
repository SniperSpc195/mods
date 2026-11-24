using TMPro;
using UnityEngine;

public class CMenuClearBoard : LwSingleton<CMenuClearBoard>
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Close = 2,
		Select = 3,
		GetSoulPoint = 4,
		CloseSoulPoint = 5
	}

	[SerializeField]
	private TextMeshProUGUI mSoulpoint;

	[SerializeField]
	private CUIAchievement mUIAchievement;

	[SerializeField]
	private TextMeshProUGUI mBoardTitle;

	[SerializeField]
	private CEventMessage mGMMessage;

	[SerializeField]
	private CUIButtonExplanation mButtonExp;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	private CUIButtonExplanation.DATA[] mButtonExpData;

	private CUIButtonExplanation.DATA[] mButtonFoward;

	[SerializeField]
	[ReadOnly]
	private CUIPhysicsShapeFocus mEnterFocus;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private double mTime;

	public CUIAchievement UIAchievement => null;

	public void Active(bool a)
	{
	}

	private new void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	public void GoMenu()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}
}
