using System;
using Cysharp.Text;
using UnityEngine;

public class DebugFont : SingletonMonoBehaviour<DebugFont>
{
	public static readonly int mDrawSizeW;

	public static readonly int mDrawSizeH;

	private static int mCodeWidth;

	private static int mCutSizeW;

	private static int mCutSizeH;

	private float mTextureWidthInv;

	private float mTextureHeightInv;

	private Vector2 mCANVAS;

	private Vector2Int mScreenSize;

	private static Vector2 mDefScreenPer;

	private const int FONTMAX = 1024;

	private const float DEF_SCALE = 1f;

	[SerializeField]
	private Material mMaterial;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static Vector2 GetFontSize()
	{
		return default;
	}

	public static Vector2 Add(Vector2 p, ReadOnlySpan<char> t, bool bgDark = true, float scale = 1f)
	{
		return default;
	}

	public static Vector2 Add(RectTransform rt, ReadOnlySpan<char> t, bool bgDark = true, float scale = 1f)
	{
		return default;
	}

	public static Vector2 Add(Vector2 p, Utf16ValueStringBuilder t, bool bgDark = true, float scale = 1f)
	{
		return default;
	}

	public static Vector2 Add(RectTransform rt, Utf16ValueStringBuilder t, bool bgDark = true, float scale = 1f)
	{
		return default;
	}

	public static Vector2 Add(Vector2 pos, ReadOnlySpan<char> t, Color color, bool bgDark = true, float scale = 1f)
	{
		return default;
	}

	public static Vector2 Add(RectTransform rt, string t, Color color, bool bgDark = true)
	{
		return default;
	}

	public static void Add(Rect rect, Color color, bool bgDark = false)
	{
	}
}
