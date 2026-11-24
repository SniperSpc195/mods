using UnityEngine;

public class CUIButtonExplanation : MonoBehaviour
{
	public enum LAYOUT
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public class DATA
	{
		public uint mButton;

		public string mText;

		public bool mActive;

		public DATA(uint b, string t, bool a)
		{
		}

		public bool IsEqual(DATA data)
		{
			return false;
		}
	}

	[SerializeField]
	private float mItemWidth;

	[SerializeField]
	private float mSpacingHorizontal;

	[SerializeField]
	private float mSizeButton;

	[SerializeField]
	private float mWidthText;

	[SerializeField]
	private float mSpacingText;

	[SerializeField]
	private float mSpacingNext;

	[SerializeField]
	private string[] mFind_NameButton;

	[SerializeField]
	private string mFind_NameText;

	private static Color mColor_NotAvailable;

	[SerializeField]
	private LAYOUT mLayout;

	private DATA[] mDatas;

	private DATA mData;

	public void Active(bool a)
	{
	}

	public void Initialize(DATA[] data, GameController.PADNUM padNum)
	{
	}

	public void Initialize(DATA data, GameController.PADNUM padNum)
	{
	}

	public void Initialize(uint[] button, string[] text, bool[] activeBtn, GameController.PADNUM padNum)
	{
	}

	public void Initialize(uint[] button, string text, bool[] activeBtn, GameController.PADNUM padNum)
	{
	}

	public void Initialize(uint button, string text, bool activeBtn, GameController.PADNUM padNum)
	{
	}

	public void ButtonActive(bool[] activeBtn)
	{
	}

	public void ButtonActive(int index, bool activeBtn)
	{
	}

	private void SetupItems(int max)
	{
	}

	private float SetupInner(Transform parent, bool active, uint button, string text, bool activeBtn, GameController.PADNUM padNum)
	{
		return 0f;
	}

	private void LayoutUpdate(float widthAll, float[] widths)
	{
	}
}
