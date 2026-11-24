using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Camera))]
public class SpeechBubbleRenderer : MonoBehaviour
{
	private Camera m_Camera;

	[SerializeField]
	private int m_RenderSize;

	[SerializeField]
	private float m_WorldSize;

	[SerializeField]
	private GameObject m_Prefab;

	private RenderTexture m_RenderTexture;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public CSpeechBubble InstantiateSpeechBubble(Transform i_Parent, Vector3? i_Offset = null, string i_LayerName = "Default")
	{
		return null;
	}

	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
	{
	}
}
