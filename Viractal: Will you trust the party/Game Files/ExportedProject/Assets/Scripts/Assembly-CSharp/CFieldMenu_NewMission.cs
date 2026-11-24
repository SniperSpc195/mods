using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CFieldMenu_NewMission : MonoBehaviour
{
	private enum MODE
	{
		End = 0,
		Open = 1,
		Select_Mission = 2,
		Close = 3,
		DebugMode = 4,
		MissionClear = 5
	}

	[SerializeField]
	[ReadOnly]
	private string mNameSelectTop;

	[SerializeField]
	[ReadOnly]
	private string mNameDebugMode;

	[SerializeField]
	private GameObject mTop;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private CUIGenericMenu mMenu;

	[SerializeField]
	private Sprite[] mTypeIcons;

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private TextMeshProUGUI mTitle;

	[SerializeField]
	private Transform mMissionType;

	[SerializeField]
	private Transform mMissionContents;

	[SerializeField]
	private Transform mRewardRange;

	[SerializeField]
	private Transform mRewardDetails;

	[SerializeField]
	private Transform mRewardItems;

	[SerializeField]
	private Sprite[] mRewardIcons;

	[SerializeField]
	private Transform mDebugInfo;

	private List<CParamMission> mMissions;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private Color ClearTextColor;

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	public void Go()
	{
	}

	public bool IsExecute()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}

	private void SetupMission(bool resetCursor)
	{
	}

	private void SetupMissionList(Transform parent, CParamMission data)
	{
	}

	private void SetupMissionInfo(CParamMission data)
	{
	}
}
