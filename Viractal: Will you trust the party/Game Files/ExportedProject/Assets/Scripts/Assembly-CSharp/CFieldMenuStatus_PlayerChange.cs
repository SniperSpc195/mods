using UnityEngine;

public class CFieldMenuStatus_PlayerChange : MonoBehaviour
{
	[SerializeField]
	private Transform mParentName;

	[SerializeField]
	private GameObject mParentButton;

	[SerializeField]
	private RectTransform mButtonR;

	private Color[] mOrgColor;

	private Vector2[] mOrgPosition;

	private CMenuStatusPlateName[] mPlateName;

	private Vector2 mOrgPositionR1;

	private CFieldPlayer[] mPlayer;

	private int mIndex;

	private bool mHarf;

	public int GetIndex()
	{
		return 0;
	}

	private void Awake()
	{
	}

	public void Active(bool a)
	{
	}

	public void SetPlayer(CFieldPlayer[] player, int index = 0)
	{
	}

	public CFieldPlayer Immediately(int target)
	{
		return null;
	}

	public CFieldPlayer Change(int dir)
	{
		return null;
	}

	public bool IsHarf()
	{
		return false;
	}

	public bool MovePanel()
	{
		return false;
	}
}
