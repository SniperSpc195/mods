using UnityEngine;

public class CMenuMasterDownload : SingletonMonoBehaviour<CMenuMasterDownload>
{
	[SerializeField]
	private CUIGenericMenu mMenuTop;

	[SerializeField]
	private CUIGenericMenu mMenuBranch;

	private void OnDestroy()
	{
	}
}
