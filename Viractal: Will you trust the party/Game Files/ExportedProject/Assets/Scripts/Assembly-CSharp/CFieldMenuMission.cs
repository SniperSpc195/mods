using System.Collections.Generic;
using UnityEngine;

public class CFieldMenuMission : MonoBehaviour
{
	private enum MODE
	{
		End = 0,
		Open = 1,
		Select_Mission = 2,
		Move_PlateName = 3,
		Close = 4
	}

	[SerializeField]
	[ReadOnly]
	private string mNameSelectTop;

	[SerializeField]
	private CFieldMenuStatus_PlayerChange mPlayerChange;

	[SerializeField]
	private CUIGenericMenu mMenu;

	[SerializeField]
	private Color[] mColorMission;

	[SerializeField]
	private CMissionInfo mMissionInfo;

	private List<CParamMission> mMissionList;

	private CFieldPlayer mControlPlayer;

	private CFieldPlayer[] mPlayerList;

	private Vector3? mOffsetCameraTarget;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	public int GetPlayerIndex()
	{
		return 0;
	}

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	public void Go(CFieldPlayer[] playerList, int index, Vector3 offset)
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

	private void ChangeNamePlate(int dir)
	{
	}

	private void MakeMissionList()
	{
	}
}
