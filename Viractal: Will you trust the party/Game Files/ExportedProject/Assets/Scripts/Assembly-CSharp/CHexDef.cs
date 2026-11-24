using UnityEngine;

public class CHexDef
{
	public enum DIR
	{
		None = -1,
		LeftForward = 0,
		RightForward = 1,
		Left = 2,
		Right = 3,
		LeftBack = 4,
		RightBack = 5,
		Max = 6,
		InFront = 7
	}

	public const int HEX_SLIDE_Z = 6;

	public const float HEX_SIZE = 4f;

	private static float mDefHexWidth;

	private static Vector2 mHexRelative;

	public const float CAP_Y_OFFSET = 0.07f;

	public const float CURSOR_Y_OFFSET = 0.1f;

	public const int WALK_MAX = 24;

	public const uint FLAG_DEF_LADDER = 1u;

	public const uint FLAG_ADD_LADDER = 2u;

	public const uint FLAG_VALID_HEX = 16u;

	public const uint FLAG_CLOUD = 32u;

	public const int AREA_HEIGHT_MIN = 0;

	public const int AREA_HEIGHT_MAX = 4;

	public const int HEX_FLOOR_MIN = -2;

	public const int HEX_FLOOR_MAX = 7;

	public const int HEX_FLOOR_COUNT = 9;

	private static float[] HEX_FLOOR;

	private static Vector3 mMapSizeF;

	private static Vector3Int mMapSize;

	private static DIR[] mReverseDir;

	private static float[] mDirYAngle;

	private static Vector3Int[] mHexArrayOffset;

	public static float GetDefHexWidth()
	{
		return 0f;
	}

	public static void Initialize()
	{
	}

	public static int GetFloorBase(Vector3Int a)
	{
		return 0;
	}

	public static Vector3Int GetFloorBaseV3(Vector3Int a)
	{
		return default;
	}

	public static int GetFloorBase(int y)
	{
		return 0;
	}

	public static void SetFloor(int n, float y)
	{
	}

	public static void SetMapSize(Vector3Int s)
	{
	}

	public static bool StringToPosXZ(string a, out Vector3Int v)
	{
		v = default;
		return false;
	}

	public static float GetFloor(int n)
	{
		return 0f;
	}

	public static T[][] MakeHexArray<T>(Vector3Int size)
	{
		return null;
	}

	public static Vector3Int GetHexArrayCenter(Vector3Int a)
	{
		return default;
	}

	public static Vector3 GetHexArrayPosition(int xNum, int zNum)
	{
		return default;
	}

	public static bool IsEqualXZ(Vector3Int a, Vector3Int b)
	{
		return false;
	}

	public static int GetHexDistance(Vector3Int a, Vector3Int b)
	{
		return 0;
	}

	public static float GetWorldDistance(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	public static DIR GetReverseDir(DIR d)
	{
		return DIR.LeftForward;
	}

	public static float GetDirToAngle(DIR d)
	{
		return 0f;
	}

	public static DIR GetPadDir(uint a, Vector3Int pos)
	{
		return DIR.LeftForward;
	}

	public static Vector3Int GetDirOffset(DIR d)
	{
		return default;
	}

	public static bool IsRangeArray(Vector3Int size, Vector3Int pos, DIR d)
	{
		return false;
	}

	public static Vector3Int Move(Vector3Int pos, DIR d)
	{
		return default;
	}

	public static Vector3 HexToWorldPosition(Vector3Int i3, float Hex_Width = -1f)
	{
		return default;
	}

	public static Vector3 GetMapCenterPosition()
	{
		return default;
	}
}
