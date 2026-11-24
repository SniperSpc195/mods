using UnityEngine;

public class CHexMesh
{
	private Vector2 mHexSize;

	private Vector3[] mOrigineHextVertex;

	private int[] mOrigineHexIndex;

	private Mesh[] mOrigineHexMesh;

	private Mesh[] mOrigineWallMesh;

	private Color[] mOriginalHeightColor;

	private const int HEX_WALL_VERTEX_MAX = 16;

	public float GetWidth()
	{
		return 0f;
	}

	public float GetHeight()
	{
		return 0f;
	}

	public Vector2 GetSize()
	{
		return default;
	}

	public Color GetHeightColor(int h)
	{
		return default;
	}

	public Mesh GetCapMesh(int h)
	{
		return null;
	}

	public Mesh GetWallMesh(int h)
	{
		return null;
	}

	public CHexMesh(float w)
	{
	}

	public static Vector3[] MakeHexVertexCap(float sOuter)
	{
		return null;
	}

	public static int[] MakeHexIndexCap()
	{
		return null;
	}

	public Color[] MakeHexColor(Color col)
	{
		return null;
	}

	public static Vector3[] MakeHexWallVertex(Vector3[] hexV, float height)
	{
		return null;
	}

	public static Color[] MakeHexWallColor(Color col)
	{
		return null;
	}

	public static int[] MakeHexWallIndex()
	{
		return null;
	}
}
