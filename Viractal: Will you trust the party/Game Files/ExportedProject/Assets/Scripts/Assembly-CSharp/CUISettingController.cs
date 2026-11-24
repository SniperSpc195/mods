using TMPro;
using UnityEngine;

public class CUISettingController : MonoBehaviour
{
	private enum ICON
	{
		None = -1,
		Controller = 0,
		Handheld = 1,
		Keyboard = 2,
		Max = 3
	}

	[SerializeField]
	private Transform mFrames;

	[SerializeField]
	private TextMeshProUGUI mInstText_Button;

	[SerializeField]
	private CUIGenericFocus mFocus;

	[SerializeField]
	private Transform mIconController;

	[SerializeField]
	private TextMeshProUGUI mNamePlayer;

	[SerializeField]
	private TextMeshProUGUI mNameController;

	private GameController.PADNUM mPadNum;

	public GameController.PADNUM PadNum => GameController.PADNUM.PAD0;

	public void Active(bool a)
	{
	}

	public void Initialize(CUIMenuControllers.PAD_SETTING setting, bool selected)
	{
	}

	public void Selected(bool selected)
	{
	}

	public void StartSetting()
	{
	}

	public void EndSetting()
	{
	}

	public void SetupPadNum(GameController.PADNUM padNum)
	{
	}

	public CUIGenericFocus IsFocus(Vector2 mousePos)
	{
		return null;
	}
}
