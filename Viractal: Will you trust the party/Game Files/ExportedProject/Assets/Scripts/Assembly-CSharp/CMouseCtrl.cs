using UnityEngine;

public class CMouseCtrl : MonoBehaviour
{
	public enum MODE
	{
		None = 0,
		Pad = 1,
		Adsorption = 2
	}

	public enum FACILITY
	{
		None = -1,
		Refine = 0,
		GameMaster = 1,
		Shelf = 2,
		GameTable = 3,
		Note = 4,
		Memo = 5,
		Door = 6,
		Achievement = 7,
		Max = 8
	}

	[SerializeField]
	private Texture2D mTextureMouseCursor;

	[SerializeField]
	private Vector2 mPivotMouseCursor;

	[SerializeField]
	private Texture2D mTextureMouseCursorOSX;

	[SerializeField]
	private Vector2 mPivotMouseCursorOSX;

	[SerializeField]
	private Vector2 mOffsetCursor_RoomPosition;

	[SerializeField]
	private RectTransform mSwMouseCursor;

	[SerializeField]
	private Vector2 mSwPivotMouseCursor;

	[SerializeField]
	[ReadOnly]
	private Vector2 mPosition;

	[SerializeField]
	private float mMaxSpeed;

	[SerializeField]
	[ReadOnly]
	private CRoomPosition[] mRoomPosition;

	private Vector2 mPivotCursor;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private Vector2[] mAdsorption;

	[SerializeField]
	[ReadOnly]
	private float mTimeAdsorption;

	[SerializeField]
	private float mSpeedAdsorption;

	private Vector2 GetCursorOffset()
	{
		return default;
	}

	public Vector2 GetPosition()
	{
		return default;
	}

	public void Initialize(CRoomPosition[] roomPos)
	{
	}

	private void OnDestroy()
	{
	}

	public void Active(bool a)
	{
	}

	public void MouseMove(GamePad pad, bool degitMove = true, bool adsorption = true)
	{
	}

	private bool DigitMove(GamePad pad)
	{
		return false;
	}

	public int SetCursorPosition(int i)
	{
		return 0;
	}

	private int CheckImpact(out Vector2 magPos, bool checkMode = false)
	{
		magPos = default;
		return 0;
	}

	private int GetIndexDegitNear(uint digit)
	{
		return 0;
	}

	private int GetNearIndex(FACILITY[] check)
	{
		return 0;
	}

	public void SetPosition(Vector2 i_Position)
	{
	}
}
