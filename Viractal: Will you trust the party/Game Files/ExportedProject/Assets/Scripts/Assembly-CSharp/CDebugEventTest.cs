using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CDebugEventTest : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		End = 1,
		TopSelect = 2,
		SubMenu = 3,
		Exec = 4,
		BattleResult = 5
	}

	[SerializeField]
	private CUIGenericMenu mTopMenu;

	[SerializeField]
	private CUIGenericMenu mSubMenu;

	[SerializeField]
	private CUIGenericMenu mBtlResMenu;

	[SerializeField]
	private TextMeshProUGUI mTitle;

	[SerializeField]
	private Transform mInfoOparation;

	private CEventScript mEventScript;

	private Dictionary<string, CEventBinary> mEventData;

	private List<string> mEventFiles;

	private CEventBinary mSelectBin;

	private List<string> mEventIDs;

	private MODE mMode;

	public bool IsEnd()
	{
		return false;
	}
}
