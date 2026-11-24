using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CMissionBoard : MonoBehaviour
{
	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private Transform mParentAllMembers;

	[SerializeField]
	private Transform mParentPrivate;

	[SerializeField]
	private Image mImageNext;

	[SerializeField]
	private float mNextY;

	private List<CParamMission> mMissionList;

	private int mMax;

	private const int BOARD_MAX = 5;

	public void Active(bool a)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public bool ReplaceBoard(CFieldPlayer player)
	{
		return false;
	}

	private void Update_Info(Transform parent, CParamMission miss)
	{
	}
}
