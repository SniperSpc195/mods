using System.Collections.Generic;
using UnityEngine;

public class CFieldEnemy : CCharDef
{
	public struct UniqueParam
	{
		public int hp;

		public bool hasItem;

		public bool hasGold;

		public bool escape;

		public List<CMaster_SkillAbilityData> abilities;
	}

	public bool mBoss;

	private string[] mGroup;

	private UniqueParam[][] mUniqueParam;

	private Transform mEnemyModel;

	private Quaternion mEnemyModelBaseRotation;

	private float mAppliedPieceAngle;

	private bool mPieceAngleApplied;

	public string mRushId { get; private set; }

	public bool IsMimic()
	{
		return false;
	}

	public string GetEnemyGroupID(int i_RushIndex = 0)
	{
		return null;
	}

	public CMaster_EnemyGroupData GetEnemyGroupData(int i_RushIndex = 0)
	{
		return null;
	}

	public UniqueParam? GetUniqueParam(int i_RushIndex, int i_Index)
	{
		return null;
	}

	public void SetUniqueParam(int i_RushIndex, int i_Index, bool i_HasItem, bool i_HasGold, int i_Hp, bool i_Escape)
	{
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void InitializeMapModel(Transform prefab)
	{
	}

	private void AlignMapModelToFloor(Transform prefab)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public void Load(JsonNode save, params CMaster_EnemyGroupData[] group)
	{
	}

	public static bool CheckSaveData(string savefile, JsonNode json)
	{
		return false;
	}

	private new void LateUpdate()
	{
	}

	public void SetGroupID(string i_ID)
	{
	}

	private void SetupUniqueParam()
	{
	}

	private List<CMaster_SkillAbilityData> GetAbility(int i_RushIndex, int i_EnemyIndex)
	{
		return null;
	}
}
