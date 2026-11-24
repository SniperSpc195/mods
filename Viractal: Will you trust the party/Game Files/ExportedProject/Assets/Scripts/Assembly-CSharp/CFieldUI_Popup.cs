using Fork.Game;
using UnityEngine;

public class CFieldUI_Popup : MonoBehaviour
{
	private enum POP
	{
		None = -1,
		Enemy = 0,
		Event = 1,
		Town = 2,
		Hex = 3
	}

	private POP mPopType;

	[SerializeField]
	private CUITooltip mTooltip;

	[SerializeField]
	private Vector3 mPopPosition;

	[SerializeField]
	private Vector3 mOffsetTown;

	[SerializeField]
	private Vector3 mOffsetDefault;

	[SerializeField]
	[ReadOnly]
	private bool mPermission;

	[SerializeField]
	[ReadOnly]
	private bool[] mOnOff;

	[SerializeField]
	[ReadOnly]
	private bool mWithinScreen;

	[SerializeField]
	private float mHeightMargin;

	private Camera mCamera;

	private CHexMap mHexMap;

	private float mFramesToStart;

	private bool mShow;

	private string mShowText;

	[SerializeField]
	private string TITLE_SIZE;

	[SerializeField]
	private string COLOR_RED;

	[SerializeField]
	private string COLOR_SKY;

	private string TITLE_SPACE;

	public bool ChangeOnOff(int i)
	{
		return false;
	}

	public void SetOnOff(int i, bool a)
	{
	}

	public void Initialize(Camera camera, CHexMap map)
	{
	}

	public void SetPermission(bool a)
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void Hide()
	{
	}

	public void Show(Vector3Int pos)
	{
	}

	public void Show(Vector3Int pos, Transform cursor)
	{
	}

	private void LateUpdate()
	{
	}

	private void Setup(POP pop, Vector3 popPos)
	{
	}

	private string MakeTextEnemy(CFieldEnemy ene, out POP pop)
	{
		pop = default;
		return null;
	}

	private string MakeTextEvent(string objID)
	{
		return null;
	}

	private string MakeTextTown(CMaster_MapTownData data)
	{
		return null;
	}

	private string MakeTextHex(CHexPosition hex, ref string frameText)
	{
		return null;
	}
}
