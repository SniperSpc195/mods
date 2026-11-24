using System.Collections.Generic;
using UnityEngine;

public class IconRenderTexture : SingletonMonoBehaviour<IconRenderTexture>
{
	[SerializeField]
	private Camera mCamera;

	[SerializeField]
	private Transform mParent;

	private Dictionary<string, Dictionary<string, Color>> mColorPool;

	private void Awake()
	{
	}

	private void Off()
	{
	}

	private void On()
	{
	}

	public Transform GetUI(string name)
	{
		return null;
	}

	public void Render(Transform ui, RenderTexture tex)
	{
	}

	public void Render(string name, RenderTexture tex)
	{
	}

	public RenderTexture MakeItemShop(RenderTexture rt, bool soldout, bool enough, int price, Sprite sprite)
	{
		return null;
	}
}
