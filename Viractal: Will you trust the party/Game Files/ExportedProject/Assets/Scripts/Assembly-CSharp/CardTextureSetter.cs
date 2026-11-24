using UnityEngine;

[AddComponentMenu("Debug/CardTextureSetter")]
public class CardTextureSetter : MonoBehaviour
{
	public enum Source
	{
		Temp = 0,
		PersistentDataPath = 1
	}

	[SerializeField]
	private MeshRenderer m_Renderer;

	[SerializeField]
	private Source m_Source;

	[SerializeField]
	[HideInInspector]
	public string m_CardID;

	private Texture2D _texture;

	private MaterialPropertyBlock _props;

	private string _cardID;

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	public void LoadAndSetTexture()
	{
	}
}
