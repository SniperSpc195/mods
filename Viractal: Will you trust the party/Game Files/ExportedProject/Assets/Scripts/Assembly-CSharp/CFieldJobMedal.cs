using Fork.Game;
using UnityEngine;

public class CFieldJobMedal : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Hidden = 1,
		Visible = 2
	}

	private const float DEF_OFFSET_X = 1f;

	private const float DEF_OFFSET_Y = 2.5f;

	private const float DEF_SCALE = 2f;

	private static Vector3 mDefScale;

	private const float SPEED = 0.05f;

	private static Vector3[][] mOffsetPosition;

	private static string[] mFilenameJobMedal;

	private CUICharacterStatusFace mFace;

	private CFieldPlayer mPlayer;

	private const float mSpeed = 0.1f;

	[SerializeField]
	[ReadOnly]
	private float mEasing;

	[SerializeField]
	[ReadOnly]
	private Vector2Int mOffsetIndex;

	[SerializeField]
	[ReadOnly]
	private Vector3Int mHexPosition;

	[SerializeField]
	[ReadOnly]
	private Vector3 mBasePosition;

	[SerializeField]
	[ReadOnly]
	private Vector3 mTopPosition;

	private MODE mMode;

	public static string CreateMedalPath(int i)
	{
		return null;
	}

	public void Initialize(CFieldPlayer player)
	{
	}

	public void Active(bool a)
	{
	}

	public void SetHide(bool imm = false)
	{
	}

	public void SetVisible(int offsetI, int offsetJ, bool imm = false)
	{
	}

	public void Update()
	{
	}
}
