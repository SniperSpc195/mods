using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CFieldUI_Player : MonoBehaviour
{
	private class UI_TEXT
	{
		private TextMeshProUGUI mTMPro;

		private string mText;

		private int mNum;

		public UI_TEXT(TextMeshProUGUI a)
		{
		}

		public void Set(string a)
		{
		}

		public void Set(int a)
		{
		}
	}

	private enum TMT
	{
		Hp = 0,
		MaxHp = 1,
		Lv = 2,
		Name = 3,
		Dp = 4,
		Max = 5
	}

	public enum SW
	{
		Name = 1,
		Lv = 2,
		Hp = 4,
		Max = 8,
		Dp = 16,
		HpCnt = 256,
		Face = 4096,
		All = 4127
	}

	private UI_TEXT[] mUIText;

	private bool mInitialize;

	private GameObject mOnline;

	private TextMeshProUGUI mOnlineText;

	private Image mHPbar;

	private Image mUIFace;

	private CParamPlayer mParam;

	private string mFaceFilename;

	private string mFaceName;

	[SerializeField]
	[ReadOnly]
	private I_LEAP mLeapHp;

	public void Initialize(CParamPlayer p, string faceFilename)
	{
	}

	public void UpdateUI(int sw)
	{
	}

	public void SetOnlineControl(bool disp, bool thisDevice = false)
	{
	}

	private void Update()
	{
	}
}
