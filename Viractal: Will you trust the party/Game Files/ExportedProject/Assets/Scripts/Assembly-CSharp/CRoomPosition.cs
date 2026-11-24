using TMPro;
using UnityEngine;

public class CRoomPosition : MonoBehaviour
{
	private static Camera mCamera;

	private static RectTransform m3DToUI;

	[SerializeField]
	[ReadOnly]
	private CGameRoom.ROOM_POS mRoomPos;

	[SerializeField]
	[ReadOnly]
	private Vector2 mPositionUI;

	[SerializeField]
	private float mAdsorptionSize;

	[SerializeField]
	private float mScale;

	[SerializeField]
	private Transform mParentPlaceInfo;

	private TextMeshProUGUI mTextPlaceInfo;

	private GameObject[][] mMarkPlaceInfo;

	private int mSelectMark;

	[SerializeField]
	[ReadOnly]
	private Vector2 mTextCenter;

	[SerializeField]
	private string mPlaceText;

	[SerializeField]
	private string mSystemText;

	[SerializeField]
	private RectTransform mDebugUI;

	private CMenuClearBoard mMenuClearBoard;

	private bool mCalcPosition;

	public string SystemText => null;

	public static void Initialize(Camera camera, RectTransform ui)
	{
	}

	public void Active(bool a)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public Transform GetLookAtTransform()
	{
		return null;
	}

	public Vector2 GetMousePosition()
	{
		return default;
	}

	public float GetAdsorptionSize()
	{
		return 0f;
	}

	public void Initialize(CGameRoom.ROOM_POS n, CMenuClearBoard menu)
	{
	}

	public void Focus(bool a)
	{
	}

	public void Visible(bool a)
	{
	}

	public void CalcUpdate()
	{
	}

	public bool IsCalcPosition()
	{
		return false;
	}

	private void LateUpdate()
	{
	}
}
