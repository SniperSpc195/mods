using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CUIControllerButtons : MonoBehaviour
{
	private enum BBB
	{
		L1 = 0,
		L2 = 1,
		Lstick = 2,
		L3 = 3,
		CCross = 4,
		R1 = 5,
		R2 = 6,
		A = 7,
		B = 8,
		X = 9,
		Y = 10,
		Rstick = 11,
		R3 = 12,
		Back = 13,
		Start = 14,
		Max = 15
	}

	private struct BMAP
	{
		public BBB mBBB;

		public uint mBtnBit;

		public string mNum;

		public BMAP(BBB bbb, uint btn, string num)
		{
			mBBB = BBB.L1;
			mBtnBit = 0u;
			mNum = null;
		}
	}

	public enum MAP
	{
		room = 0,
		field = 1,
		battle = 2
	}

	[SerializeField]
	private GameObject[] mGamePads;

	[SerializeField]
	private TextMeshProUGUI mTitleText;

	[SerializeField]
	private Image[] mTitleButtons;

	[SerializeField]
	private Transform mF1Keyboard;

	[SerializeField]
	private Transform mSpeedSwitching;

	[SerializeField]
	private Transform[] mButtons;

	private static BMAP[] mButtonMaps;

	private MAP mMap;

	private void SetText(MAP map)
	{
	}

	public void SetButtons(GameController.PADNUM padNum)
	{
	}

	public void Active(bool a)
	{
	}

	public void Initialize(MAP map, GameController.PADNUM padNum)
	{
	}

	public bool Select(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
	{
		return false;
	}
}
