using Cysharp.Threading.Tasks;

namespace Fork.Game.AutoGenerateMap
{
	public class AutoGenerateMapDataSource
	{
		public virtual CMaster_MapAreaData[] Areas => null;

		public virtual CMaster_MapAreaTableData[] AreaTables => null;

		public virtual CMaster_MapAreaShapeData[] Shapes => null;

		public virtual CMaster_MapAreaShapeTableData[] ShapeTables => null;

		public virtual UtpnRandom Random => null;

		public virtual bool GeneratePlacements => false;

		public virtual CMaster_EnemyGroupData[] EnemyGroups => null;

		public virtual CMaster_EventObjectData[] EventObjects => null;

		public virtual CMaster_MapStageData Stage(string id)
		{
			return null;
		}

		public virtual StageLayoutDefinition StageLayout(string id)
		{
			return null;
		}

		public virtual CMaster_MapAreaData Area(string id)
		{
			return null;
		}

		public virtual CMaster_MapTownData Town(string id)
		{
			return null;
		}

		public virtual CMaster_HexDetailData Ground(string type, int index)
		{
			return null;
		}

		public virtual bool IsBlockingObstacle(string id)
		{
			return false;
		}

		public virtual int Constant(string id)
		{
			return 0;
		}

		public virtual bool IsEventAvailable(string id)
		{
			return false;
		}

		public virtual void ReportSeed(int seed)
		{
		}

		public virtual UniTask BeginAttempt(int attempt)
		{
			return default;
		}
	}
}
