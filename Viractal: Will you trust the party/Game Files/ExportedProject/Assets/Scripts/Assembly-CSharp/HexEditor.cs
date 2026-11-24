using System.Collections.Generic;
using Fork.Game.AutoGenerateMap;
using TMPro;
using UnityEngine;

public class HexEditor : SingletonMonoBehaviour<HexEditor>
{
	private class OBJECTS
	{
		public string mDetail;

		public GameObject mPrefab;

		public int mMapIndex;

		public bool mIsGround;
	}

	private enum MODE
	{
		TopMenu = 0,
		StageSelect = 1,
		Load = 2,
		Save = 3,
		Save_InputFilename = 4,
		Save_Check = 5,
		Save_Overwrite = 6,
		Clear = 7,
		Edit = 8,
		SelectObjects = 9,
		Auto_Generate = 10,
		Auto_Road = 11
	}

	private string[] mOldGroundId;

	private string[] mNewGroundId;

	public static readonly string[] SaveVersion;

	public const int MAP_DEPTH = 26;

	public const int MAP_WIDTH = 29;

	private Vector3 mHexScale;

	private Transform mHexs;

	private Vector3Int mMapSize;

	public CHexPosition[][] mHexMap;

	private List<HexMap.SpawnObject> mSpawnEnemyList;

	private static float mHexWidth;

	private static Vector3[] mOrigineHextVertex;

	private static int[] mOrigineHexIndex;

	private static Mesh[] mOrigineHexMesh;

	private static Mesh[] mOrigineWallMesh;

	private static Color[] mOriginalHeightColor;

	private CMainCamera mCamera;

	[SerializeField]
	[ReadOnly]
	private Vector3 mCameraAngle;

	[SerializeField]
	[ReadOnly]
	private float mCameraDistance;

	[SerializeField]
	[ReadOnly]
	private int mCamXAngleI;

	private float[] mCamXAngleList;

	[SerializeField]
	[ReadOnly]
	private int mCamYAngleI;

	private float[] mCamYAngleList;

	private SimpleHexCursor mCursor;

	[SerializeField]
	private CScrollMenu mTopMenu;

	[SerializeField]
	private CScrollMenu mObjectMenu;

	[SerializeField]
	private CScrollMenu mStageMenu;

	private Dictionary<string, OBJECTS> mObjects;

	private int mSelectObject;

	public Dictionary<string, Texture2D> mHexMapMask;

	[SerializeField]
	private GameObject mFileMenu;

	[SerializeField]
	private GameObject mFileInfo;

	[SerializeField]
	private TMP_InputField mInputField;

	[SerializeField]
	private TextMeshProUGUI mFolderName;

	[SerializeField]
	private CScrollMenu mFileList;

	[SerializeField]
	private CScrollMenu mYesNo;

	private string[] mHexLFiles;

	private static string mSavePath;

	private string mLastSaveFilename;

	private string mSaveFilename;

	private string mLoadHexJson;

	[SerializeField]
	private RectTransform mInfoHex;

	[SerializeField]
	private RectTransform mInfoSelectObject;

	private AutoGenerateMap mAutoGenerateMap;

	public bool mMapRandom;

	public float mMapOrgRange;

	public int mMapWidth;

	public int mMapDepth;

	public float mMapOrgX;

	public float mMapOrgY;

	public float mMapScale;

	public int mOctave;

	public string mStageId;

	private int mSelectStage;

	private MODE mMode;

	private int mWait;

	private const int HEX_WALL_VERTEX_MAX = 16;

	public string GroundIdConv(string groundId)
	{
		return null;
	}

	public Vector3[] GetOrigineHextVertex()
	{
		return null;
	}

	public int[] GetOrigineHexIndex()
	{
		return null;
	}

	public Mesh GetHexMesh(int h)
	{
		return null;
	}

	public Mesh GetWallMesh(int h)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnEndInputText(string text)
	{
	}

	private void ClearHex()
	{
	}

	private void OpenFileMenu(bool load)
	{
	}

	private void SaveHexLayout(string path)
	{
	}

	private void UpdateCamera()
	{
	}

	private void EditLayout()
	{
	}

	private bool IsExist(Vector3Int p)
	{
		return false;
	}

	private void DeleteHex(Vector3Int p)
	{
	}

	private CHexPosition AddHex(Vector3Int p, Vector3 objectAngles)
	{
		return null;
	}

	private void SetupHex(CHexPosition hp, Vector3Int position)
	{
	}

	private void UpdateFringe(Vector3Int p)
	{
	}

	private void UpdateHexWall(CHexPosition hp, Vector3Int ip)
	{
	}

	public static Vector3[] MakeHexVertexCap(float sOuter)
	{
		return null;
	}

	public static int[] MakeHexIndex()
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
