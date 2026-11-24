using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game.AutoGenerateMap
{
	public class AutoGenerateMap
	{
		public class HexParts
		{
			private int mIndex;

			private int mAngleY;

			public int Index => 0;

			public int AngleY => 0;

			public HexParts(int index, int angleY)
			{
			}

			public virtual bool Equals(HexParts hexParts)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[Flags]
		public enum RoadDir
		{
			LowerLeft = 1,
			Left = 2,
			UpperLeft = 4,
			UpperRight = 8,
			Right = 0x10,
			LowerRight = 0x20
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGenerateAreaMap_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public AutoGenerateMap _003C_003E4__this;

			public UtpnRandom rnd;

			public CMaster_MapStageData stageData;

			public Dictionary<string, Texture2D> hexMapMask;

			private int _003CtrimMinX_003E5__2;

			private int _003CtrimMinY_003E5__3;

			private int _003CtrimMaxX_003E5__4;

			private int _003CtrimMaxY_003E5__5;

			private Texture2D _003CmaskTexture_003E5__6;

			private int _003CofsX_003E5__7;

			private int _003CofsY_003E5__8;

			private MainThreadAwaitable _003C_003Eu__1;

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
		private struct _003CGenerateMap_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<HexMap> _003C_003Et__builder;

			public AutoGenerateMap _003C_003E4__this;

			public string stage;

			public int? randomseed;

			public Dictionary<string, Texture2D> hexMapMask;

			private CMaster_MapStageData _003CstageData_003E5__2;

			private UtpnRandom _003Crnd_003E5__3;

			private int _003Ccount_003E5__4;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

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
		private struct _003CGenerateRoad_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public AutoGenerateMap _003C_003E4__this;

			public UtpnRandom rnd;

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

		private readonly List<HexMap.SpawnObject> mFixedEventObjects;

		private List<RoadBarrierPlan> mRoadBarriers;

		private string mRoadBarrierFailure;

		private bool mRoadObstaclesPrepared;

		private StageLayoutDefinition mStageLayout;

		private int mWidth;

		private int mHeight;

		private HexMap mHexMap;

		private float[,] mHeightMap;

		private float[,] mPerlinMap;

		private int[,] mLevelMap;

		private (int area, float weight)[,] mAreaMap;

		private int[,] mAreaStencil;

		private List<MapArea> mMapAreaList;

		private Vector2Int mStartPos;

		private List<Vector2Int> mMovableRange;

		private readonly AutoGenerateMapDataSource mData;

		public static readonly HexParts[] mHexParts;

		public string SelectedLayoutPatternId { get; private set; }

		private StageLayoutDefinition ActiveLayout => null;

		public int Width => 0;

		public int Height => 0;

		public List<MapArea> MapAreaList => null;

		public Vector2Int StartPos => default;

		private void InitializeFixedEventObjects()
		{
		}

		private void ReserveConfiguredEventObjectPositions()
		{
		}

		private List<HexMap.SpawnObject> CreateConfiguredEventObjects(out int treasures, out int objects)
		{
			treasures = default;
			objects = default;
			return null;
		}

		private static bool HasEventObjectId(CMaster_EventObjectData master, int treasures, int objects)
		{
			return false;
		}

		private static CEventEnum.EVID AllocateEventObjectId(CMaster_EventObjectData master, ref int treasures, ref int objects)
		{
			return CEventEnum.EVID._000;
		}

		private void InitializeRoadBarriers(string stageId)
		{
		}

		private bool TryPlanConfiguredRoadBarriers(UtpnRandom random)
		{
			return false;
		}

		private void ApplyConfiguredRoadBarriers()
		{
		}

		private void ReserveConfiguredRoadEnemyPositions()
		{
		}

		private bool IsConfiguredRoadEnemy(string id)
		{
			return false;
		}

		private void AppendConfiguredRoadEnemies(List<HexMap.SpawnObject> enemies)
		{
		}

		private void InitializeStageLayout(CMaster_MapStageData stage)
		{
		}

		private void SelectStageLayoutPattern(UtpnRandom random)
		{
		}

		private bool PlaceConfiguredArea(MapArea area, int index, CMaster_MapStageData stage, UtpnRandom rnd)
		{
			return false;
		}

		private bool TryPreferredArea(MapArea area, int index, AreaRect previous, List<AreaRect> horizontal, List<AreaRect> vertical, UtpnRandom rnd, out bool useDefault)
		{
			useDefault = default;
			return false;
		}

		private bool HasConfiguredEndpoint(bool start)
		{
			return false;
		}

		private bool TryGetConfiguredEndpoint(MapArea area, bool start, out Vector2Int endpoint)
		{
			endpoint = default;
			return false;
		}

		private int LayoutVerticalShift(int defaultShift)
		{
			return 0;
		}

		private bool ExcludesEnemyGroup(string id)
		{
			return false;
		}

		private void CenterConfiguredLand(Texture2D maskTexture, int ofsX, int ofsY, int centerOffsetY)
		{
		}

		public AutoGenerateMap()
		{
		}

		public AutoGenerateMap(AutoGenerateMapDataSource data)
		{
		}

		public static (int, int) UpperLeft(int x, int y)
		{
			return default;
		}

		public static (int, int) UpperRight(int x, int y)
		{
			return default;
		}

		public static (int, int) Right(int x, int y)
		{
			return default;
		}

		public static (int, int) LowerRight(int x, int y)
		{
			return default;
		}

		public static (int, int) LowerLeft(int x, int y)
		{
			return default;
		}

		public static (int, int) Left(int x, int y)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGenerateMap_003Ed__59))]
		public UniTask<HexMap> GenerateMap(string stage, Dictionary<string, Texture2D> hexMapMask, int? randomseed = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGenerateRoad_003Ed__60))]
		private UniTask<bool> GenerateRoad(UtpnRandom rnd)
		{
			return default;
		}

		private void ConnectAllSlab(List<RoadSlab> allSlabList, int area)
		{
		}

		[AsyncStateMachine(typeof(_003CGenerateAreaMap_003Ed__62))]
		private UniTask<bool> GenerateAreaMap(CMaster_MapStageData stageData, Dictionary<string, Texture2D> hexMapMask, UtpnRandom rnd)
		{
			return default;
		}

		private List<HexMap.SpawnObject> InitialEnemyPosition(string stageId)
		{
			return null;
		}

		public List<HexMap.SpawnObject> InitialEventPosition(string stageId)
		{
			return null;
		}

		public List<Vector2Int> SearchMovableRange()
		{
			return null;
		}

		private bool CheckRoadConnectToArea(HexObject hexObject, string areaId, bool isStep)
		{
			return false;
		}

		private float TownDir(RoadDir roadDir)
		{
			return 0f;
		}

		private bool CheckLadder(int x, int y, int level, RoadDir roadDir)
		{
			return false;
		}

		private bool CheckAdjacent(int x, int y, MapArea mapArea)
		{
			return false;
		}

		private bool CheckCoastline(int x, int y, MapArea mapArea)
		{
			return false;
		}

		private void HeightAdjust(MapArea mapArea, float scale, float min, float max, Vector2Int startPos, Vector2Int endPos)
		{
		}

		private void DSquareWrite(List<MapArea> mapAreaList, Dictionary<string, Texture2D> hexMapMask)
		{
		}

		private int ClosestArea(Dictionary<int, float> dict)
		{
			return 0;
		}

		private int GetAreaNum(int x, int y, List<MapArea> mapAreaList, MapArea mapArea)
		{
			return 0;
		}

		private float GetWeight(int x, int y, List<MapArea> mapAreaList, MapArea mapArea)
		{
			return 0f;
		}

		private void DSquare(int x, int y, int size, ref (int area, float weight)[,] areaHeightMap)
		{
		}

		private void SquareStep(int cx, int cy, int radius, ref (int area, float weight)[,] heightMap)
		{
		}

		private void DiamondStep(int cx, int cy, int radius, ref (int area, float weight)[,] heightMap)
		{
		}

		private float CheckEllipse(Vector2 center, Vector2 radius, Vector2 point)
		{
			return 0f;
		}

		private Vector2 EllipseRadius(float width, float height)
		{
			return default;
		}

		public void SetWallToBendRoad(HexMap hexMap, int x, int y, int dx, int dy, int countMax)
		{
		}

		public void SetObstacles(HexMap hexMap, MapArea mapArea)
		{
		}

		public AreaRect GenerateAreaRect(int x1, int y1, int x2, int y2, MapArea prevMapArea, MapArea mapArea, List<MapArea> mapAreaList, int clip)
		{
			return null;
		}

		public bool GenerateLandMap()
		{
			return false;
		}

		public bool updateMapArea(ref MapArea mapArea)
		{
			return false;
		}

		public float[,] GeneratePerlinMap(float orgX, float orgY, float scale, int width, int height, int octave)
		{
			return null;
		}
	}
}
