using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CSelectionAbilities : MonoBehaviour
{
	private enum MODE
	{
		End = 0,
		Open = 1,
		Execute = 2,
		Full_Inquiry = 3,
		ToEnd = 4,
		Close = 5
	}

	[SerializeField]
	private GameObject mFullExplanation;

	[SerializeField]
	private TextMeshProUGUI mTextFullExplanation;

	[SerializeField]
	private CUIGenericMenu mMenu;

	private bool mExplainDisp;

	[SerializeField]
	private TextMeshProUGUI mNumPossession;

	[SerializeField]
	private GameObject mDispose;

	private CFieldPlayer mPlayer;

	private List<CMaster_SkillAbilityData> mNewAbilities;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private float mWait;

	public void Active(bool a)
	{
	}

	public void GoFull(CFieldPlayer player, List<string> abilities)
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

	private void UpdateList(bool resetPosition)
	{
	}

	private void UpdatePopup()
	{
	}

	private bool UpdateNum()
	{
		return false;
	}
}
