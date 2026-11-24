using TMPro;
using UnityEngine;

public class CMissionInfo : MonoBehaviour
{
	[SerializeField]
	private GameObject mParent;

	[SerializeField]
	private TextMeshProUGUI mInfoType;

	[SerializeField]
	private TextMeshProUGUI mInfoText;

	[SerializeField]
	private Transform mInfoRewardsParent;

	[SerializeField]
	private TextMeshProUGUI[] mInfoRewardText;

	[SerializeField]
	private TextMeshProUGUI mInfoProgressName;

	[SerializeField]
	private TextMeshProUGUI mInfoProgressNum;

	public void Write(CParamMission mission)
	{
	}

	public void UpdateAchieved(CParamMission mission)
	{
	}
}
