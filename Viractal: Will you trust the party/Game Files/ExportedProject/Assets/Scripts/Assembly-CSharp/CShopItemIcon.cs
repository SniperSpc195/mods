using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class CShopItemIcon : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Move = 1,
		Disappear = 2,
		End = 3
	}

	private static Color m_ColorDark;

	private static Color m_ColorEnoughMoney;

	[SerializeField]
	private Image[] mFrame;

	[SerializeField]
	private Image mIcon;

	[SerializeField]
	private Image[] mActiveFrame;

	[SerializeField]
	private Image[] mBuySell;

	[SerializeField]
	private Image mCoin;

	[SerializeField]
	private TextMeshProUGUI[] mText;

	private List<Vector2> mSplineData;

	private float mSplineIndex;

	private float mScale;

	private float mDisappearSpd;

	private const float mSplineCreateStep = 0.03f;

	private const float mSplineMoveStep = 1f;

	private MODE mMode;

	public void Active(bool a)
	{
	}

	public void SetBuy(Sprite icon, int buy_price, bool soldOut, bool selected, int money)
	{
	}

	public void SetSell(CMaster_ItemData data, bool selected)
	{
	}

	public void Selected(bool a)
	{
	}

	private void LateUpdate()
	{
	}

	public void StartSpline(Vector2 endPos)
	{
	}

	public void StartDisappear()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}
}
