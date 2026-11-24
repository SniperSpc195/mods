using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CHexCursor : MonoBehaviour
{
	private const int HEX_VERTEX_MAX = 12;

	private static CHexMap mHexMap;

	[SerializeField]
	[ReadOnly]
	private int mNumTexture;

	public Vector3Int mMapPosition;

	[SerializeField]
	private Vector3 mYOffset;

	private static List<AsyncOperationHandle<Texture>> mTextureList;

	public const int NUM_TEXTURE_MAX = 19;

	private CHexPosition mNowHex;

	private static CHexDef.DIR[] DownDir;

	private static CHexDef.DIR[] UpDir;

	private static Vector3[] mHexCapVertex;

	private static int[] mHexCapIndex;

	private static Color[] mHexCapColor;

	private static Vector3[] mHexNumVertex;

	private static Color[] mHexNumColor;

	private static Vector2[] mHexNumUV;

	private static int[] mHexNumIndex;

	public static void SetHexMap(CHexMap a)
	{
	}

	public static void LoadNumTextures()
	{
	}

	public static void ReleaseNumTextures()
	{
	}

	public static Texture GetNumTexture(int n)
	{
		return null;
	}

	private void Awake()
	{
	}

	public void SetYOffset(float y)
	{
	}

	public void SetMaterialColor(Color c)
	{
	}

	public void Active(bool a)
	{
	}

	public void SetActive(Vector3Int p, int num)
	{
	}

	public void SetNum(int n)
	{
	}

	public Vector3 SetMapPosition(Vector3Int a, bool hold = false)
	{
		return default;
	}

	private CHexPosition GetHexDir(Vector3Int a, CHexDef.DIR[] dir)
	{
		return null;
	}

	public Vector3 UpdateWorldPosition()
	{
		return default;
	}

	public static Vector3[] MakeHexCapVertex()
	{
		return null;
	}

	public static int[] MakeHexCapIndex()
	{
		return null;
	}

	public static Color[] MakeHexCapColor()
	{
		return null;
	}

	public static Color[] MakeHexCapColor(Color col)
	{
		return null;
	}

	public static Vector3[] MakeHexNumVertex()
	{
		return null;
	}

	public static Color[] MakeHexNumColor()
	{
		return null;
	}

	public static Vector2[] MakeHexNumUV()
	{
		return null;
	}

	public static int[] MakeHexNumIndex()
	{
		return null;
	}
}
