using UnityEngine;

public class CGameRoom_JobBase : MonoBehaviour
{
	private static string[] BaseModelFilenames;

	private MaterialPropertyBlock[] mMaterialPropertyBlock;

	private bool mBaseChangeColor;

	private int mIndex;

	public static int GetBaseLevel(int playerLv)
	{
		return 0;
	}

	public static int GetMaxBaseLevel()
	{
		return 0;
	}

	public static string GetBaseModelName(int lv)
	{
		return null;
	}

	public static string GetPlayerBaseModelPath(int lv)
	{
		return null;
	}

	public void ChangeBaseModel(GameObject orgBase, bool dup)
	{
	}

	public static void ChangeBaseModel(Transform parent, GameObject orgBase, bool dup)
	{
	}

	public void SetColor(int index)
	{
	}

	private void LateUpdate()
	{
	}

	public static Vector3 GetBaseModelY(Transform parent)
	{
		return default;
	}

	public static void ChangeBaseColor(Transform parent, MaterialPropertyBlock prop, int index)
	{
	}

	public static void ChangeBaseColor_Player(Transform parent, MaterialPropertyBlock[] prop, int index)
	{
	}

	public static void AnimeIdle(CAnimePlayer aPlayer, int lv)
	{
	}
}
