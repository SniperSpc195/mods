using UnityEngine;

public class CSpeechBubble : MonoBehaviour
{
	public Renderer m_IconRenderer;

	public Renderer m_BaseRenderer;

	private Texture2D m_Icon;

	private MaterialPropertyBlock m_Props;

	private float m_BaseIconScale;

	private void Awake()
	{
	}

	public void SetBase(RenderTexture i_Base)
	{
	}

	public void SetIcon(Texture2D i_Icon)
	{
	}

	public void SetIcon(Sprite i_Icon)
	{
	}

	public void SetLayer(string i_LayerName)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
