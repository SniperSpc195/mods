using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game.AutoGenerateMap;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CHexMap : MonoBehaviour
{
	public class OBJECTS
	{
		public string mDetail;

		public GameObject mPrefab;

		public int mMapIndex;

		public OBJECTS()
		{
		}

		public OBJECTS(string detail, GameObject g, int mapIndex)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCreateMap_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<HexMap> _003C_003Et__builder;

		public CHexMap _003C_003E4__this;

		public string stageId;

		public int? randomseed;

		public bool isHost;

		private List<AsyncOperationHandle<Texture2D>> _003CmaskTextureHandleList_003E5__2;

		private string _003ChexMapMaskPath_003E5__3;

		private AsyncOperationHandle<Texture2D> _003ChMapMask_003E5__4;

		private UniTask<Texture2D>.Awaiter _003C_003Eu__1;

		private CMaster_MapAreaShapeData[] _003C_003E7__wrap4;

		private int _003C_003E7__wrap5;

		private CMaster_MapAreaShapeData _003CshapeData_003E5__7;

		private UniTask<HexMap>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadFileHexMap_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CHexMap _003C_003E4__this;

		public string address;

		public bool setMapSize;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadHexMap_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CHexMap _003C_003E4__this;

		public string stageID;

		public JsonNode save;

		public bool setMapSize;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadOnjects_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CHexMap _003C_003E4__this;

		public string stageID;

		private Transform _003CparentTransform_003E5__2;

		private List<CMaster_HexDetailData> _003CreadDetail_003E5__3;

		private string _003CobjLadder_003E5__4;

		private AsyncOperationHandle<GameObject> _003ChLadder_003E5__5;

		private CMaster_ModelData _003CcloudData_003E5__6;

		private AsyncOperationHandle<GameObject> _003ChCloud_003E5__7;

		private UniTask<GameObject[]>.Awaiter _003C_003Eu__1;

		private UniTask<GameObject>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetupAutoGenerateMap_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CHexMap _003C_003E4__this;

		public string stageId;

		public bool isOnline;

		public int? randomseed;

		public bool setMapSize;

		private UniTask.Awaiter _003C_003Eu__1;

		private UniTask<HexMap>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetupMap_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CHexMap _003C_003E4__this;

		public string stageID;

		public string mapData;

		public bool setMapSize;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	[ReadOnly]
	private Vector3Int mMapSize;

	[SerializeField]
	[ReadOnly]
	private CHexPosition[][] mHexMap;

	private Vector3Int mStartPos;

	private AutoGenerateMap mAutoGenerateMap;

	public Dictionary<string, Texture2D> mHexMapMask;

	private List<HexMap.SpawnObject> mSpawnEnemyList;

	private List<HexMap.SpawnObject> mSpawnEventList;

	[SerializeField]
	[ReadOnly]
	private List<Vector2Int> mValidPosition;

	private string mHexMapPath;

	private Vector3 mMinPosition;

	private Vector3 mMaxPosition;

	private List<CHexPosition> mAddLadder;

	private GameObject mDupHexnum;

	private List<OBJECTS> mObjects;

	private GameObject mAddModelLadder;

	private GameObject mModelCloud;

	private List<Vector3Int> mRoadList;

	private List<CNum_HexObjectScale> mNumObjectScale;

	private List<CFieldPlayer> mPlayerList;

	private List<CFieldEnemy> mEnemyList;

	private List<CFieldTBox> mTresureList;

	private List<CFieldEventObject> mEventObjectList;

	private List<CFieldMain.HEX_TOWN> mTownList;

	private bool mObjectUpdate;

	public List<HexMap.SpawnObject> SpawnEnemyList => null;

	public List<HexMap.SpawnObject> SpawnEventList => null;

	public List<Vector2Int> GetValidPosition()
	{
		return null;
	}

	public Vector3Int GetMapSize()
	{
		return default;
	}

	public Vector3Int GetMapCenter()
	{
		return default;
	}

	public Vector3Int GetHexPosition(Vector3Int a)
	{
		return default;
	}

	public CHexPosition GetCHex(Vector3Int p)
	{
		return null;
	}

	public CHexPosition GetCHex(int x, int z)
	{
		return null;
	}

	public CHexPosition GetStartCHex()
	{
		return null;
	}

	public bool IsExist(Vector3Int p)
	{
		return false;
	}

	public bool IsExist(int x, int z)
	{
		return false;
	}

	public Vector3 GetHexWorldPosition(Vector3Int p)
	{
		return default;
	}

	public bool IsCloud(Vector3Int p)
	{
		return false;
	}

	public List<CHexCloud> GetCloud_Floor(Vector3Int p)
	{
		return null;
	}

	public bool IsValidHex(CHexPosition hex)
	{
		return false;
	}

	public void SetEnemy(Vector3Int p, CEventEnum.EVID a)
	{
	}

	public bool IsEnemy(Vector3Int p)
	{
		return false;
	}

	public CEventEnum.EVID GetEnemy(Vector3Int p)
	{
		return CEventEnum.EVID._000;
	}

	public List<CHexPosition> GetKind(string kind)
	{
		return null;
	}

	public List<CHexPosition> GetArea(string area)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void AddLoadObjects(CMaster_HexDetailData data, ref List<CMaster_HexDetailData> readDetail, ref List<UniTask<GameObject>> opHandles, Transform parent)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadOnjects_003Ed__41))]
	private UniTask LoadOnjects(string stageID)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCreateMap_003Ed__42))]
	public UniTask<HexMap> CreateMap(bool isHost, string stageId, int? randomseed = null)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CSetupAutoGenerateMap_003Ed__43))]
	public UniTask SetupAutoGenerateMap(bool isOnline, string stageId, bool setMapSize, int? randomseed = null)
	{
		return default;
	}

	private void MakeStartPosition(CMaster_MapTimeSavingData timeSaving)
	{
	}

	private List<Vector3Int> MakeRoad(Vector3Int endPos)
	{
		return null;
	}

	private bool IsObjectPosition(Vector3Int pos)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CLoadFileHexMap_003Ed__48))]
	public UniTask LoadFileHexMap(string address, bool setMapSize)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadHexMap_003Ed__49))]
	public UniTask LoadHexMap(string stageID, JsonNode save, bool setMapSize)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CSetupMap_003Ed__50))]
	public UniTask SetupMap(string stageID, string mapData, bool setMapSize)
	{
		return default;
	}

	private void SetupLadder(JsonNode addLadder)
	{
	}

	private CHexPosition AddHex(Vector3Int p, string objectId)
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

	public int BackHieght(CHexPosition nowHex)
	{
		return 0;
	}

	public void MoveOn(List<CHexPosition> onList, CFieldPlayer player = null)
	{
	}

	public void MoveOff()
	{
	}

	public void HilightLadder(CFieldMain fMain, bool active)
	{
	}

	public void LimitMinMaxPosition(ref Vector3 a, float marginX = 0f, float marginZ = 0f)
	{
	}

	public bool IsSetLadder(Vector3Int a)
	{
		return false;
	}

	public bool AddLadder(Vector3Int a)
	{
		return false;
	}

	public void RemoveLadder(Vector3Int a)
	{
	}

	public Dictionary<string, object> Save(bool _string = true)
	{
		return null;
	}

	public static bool CheckSaveData(string savefile, JsonNode save)
	{
		return false;
	}

	public void SetupList(List<CFieldPlayer> pList, List<CFieldEnemy> eList, List<CFieldTBox> tList, List<CFieldEventObject> objList, List<CFieldMain.HEX_TOWN> townList)
	{
	}

	public void SetObjectUpdate(bool a)
	{
	}

	private void Update()
	{
	}

	private void UpdateObjectScale(bool imm = false)
	{
	}

	private void ObjectScaleDown(Vector3Int p, bool imm = false)
	{
	}

	public void UnmovableCheck()
	{
	}

	public List<Vector3Int> GetCenterArea(Vector3Int center, int distance, bool checkHeight = false, bool cloud = false)
	{
		return null;
	}
}
