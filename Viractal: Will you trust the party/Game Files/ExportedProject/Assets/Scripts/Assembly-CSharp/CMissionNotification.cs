using System.Collections.Generic;
using UnityEngine;

public class CMissionNotification : MonoBehaviour
{
	[SerializeField]
	private RectTransform[] mParentUI;

	[SerializeField]
	private RectTransform mParentNotification;

	[SerializeField]
	private float mNextY;

	private List<CMissionNotification_UI> mList;

	public void Notification(CParamMission pMiss)
	{
	}

	private void Update()
	{
	}
}
