using System.Collections.Generic;
using UnityEngine;

public class ActionWork
{
	public enum AttachDst
	{
		NodePosYZero = 0,
		NodePedestal = 1,
		NodeHit = 2,
		Center = 3,
		AmicalGroup = 4,
		HostileGroup = 5,
		NodeEffect1 = 6
	}

	public enum MapNode
	{
		Center = 0,
		AmicalGroup = 1,
		HostileGroup = 2,
		MainTarget = 3
	}

	public enum AttachType
	{
		None = 0,
		Current = 1,
		Continue = 2
	}

	public enum AnimationCurve
	{
		Liner = 0,
		EaseIn = 1,
		EaseOut = 2
	}

	public enum UnitType
	{
		Actor = 0,
		Self = 1
	}

	public enum MainScene
	{
		Field = 0,
		Battle = 1
	}

	public enum LotteryResult
	{
		None = 0,
		Failed = 1,
		Success = 2
	}

	public enum LotteryUpDown
	{
		Down = 0,
		Up = 1
	}

	public enum UnitGroup
	{
		None = 0,
		Friendly = 1,
		Hostile = 2
	}

	public struct Effect
	{
		public CEffectHandle hndEffect;

		public Vector3 position;
	}

	public struct Se
	{
		public CEffectHandle hndEffect;

		public Transform attach;

		public Vector3 position;

		public long handle;

		public float pitch;

		public string name;

		public float delay;

		public bool played;
	}

	public const float BattleEnemyAngle = 220f;

	public const string LabelRewardGold = "__RewardGold__";

	public const string LabelStealNothing = "__StealNothing__";

	public const string LabelStealCarryLimit = "__StealCarryLimit__";

	private static List<Effect> m_Effects;

	private static List<Se> m_Se;

	private static Vector3[] m_CacheFieldCameraPosition;

	private static Vector3[] m_CacheFieldCameraZoom;

	public static List<CHexCloud> m_ClearingHexCloud;

	public static void CacheEffect(CEffectHandle handle, Transform parent, bool attachPosition, bool attachScale, bool attachRotation)
	{
	}

	public static void CacheEffect(CEffectHandle handle)
	{
	}

	public static Effect? GetEffect(long handle)
	{
		return null;
	}

	public static void RegisterEffectSe(long i_Handle, string i_Se, float i_Pitch, int i_Delay)
	{
	}

	public static void RegisterSeAttached(Transform i_Attach, string i_Se, float i_Pitch, int i_Delay)
	{
	}

	public static void ApplyEffectPosition(long handle)
	{
	}

	public static void UpdateActionSE()
	{
	}

	public static void StopActionSE()
	{
	}

	private static void Remove()
	{
	}

	public static void ClearEffectCache()
	{
	}

	private static void Attach(CEffectHandle handle, Transform parent, bool attachPosition, bool attachScale, bool attachRotation)
	{
	}

	public static Vector3 GetMapNodePosition(MapNode node, bool player)
	{
		return default;
	}

	public static Vector3 GetMapNodePosition(MapNode node, CSkill skill)
	{
		return default;
	}

	public static UnityEngine.AnimationCurve CreateCurve(AnimationCurve type)
	{
		return null;
	}

	public static UnityEngine.AnimationCurve CreateCurve(AnimationCurve type, float start, float end)
	{
		return null;
	}

	public static void CacheFieldCameraPosition(Vector3 i_Position)
	{
	}

	public static Vector3 GetFieldCameraPositionCache(int i_Index)
	{
		return default;
	}

	public static void CacheFieldCameraZoom(Vector3 i_Zoom)
	{
	}

	public static Vector3 GetFieldCameraZoomCache(int i_Index)
	{
		return default;
	}
}
