using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CDebugEffectTest : MonoBehaviour
{
	[SerializeField]
	private CScrollMenu mTopMenu;

	[SerializeField]
	private RectTransform mInfo;

	[SerializeField]
	private TextMeshProUGUI mTextScale;

	private static int[] mSaveCursor;

	private static float mScale;

	private List<string> mEffectList;

	private Transform mEffectParent;

	private Vector3 mPosition;

	[SerializeField]
	[ReadOnly]
	private List<CEffectHandle> mHandle;

	public void SetEffectParent(Transform t)
	{
	}

	public void SetEffectPosition(Vector3 p)
	{
	}

	public static string GetEffectListPath_Editor()
	{
		return null;
	}

	public static string GetEffectListPath_DebugBinary()
	{
		return null;
	}

	private void SetTextScale()
	{
	}

	private void StopAll()
	{
	}
}
