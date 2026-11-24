using UnityEngine;

public class CardDiffParts : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer m_SpriteRenderer;

	[SerializeField]
	private SerializableKeyPair<CardRenderTextureSpriteRenderer.Rarity, CardDiffPartDescriptor[]>[] m_NojobSprite;

	[SerializeField]
	private SerializableKeyPair<CardRenderTextureSpriteRenderer.Rarity, CardDiffPartDescriptor[]>[] m_JobSprite;

	public void SetSprite(CardRenderTextureSpriteRenderer.ManaKind mana, CardRenderTextureSpriteRenderer.Rarity rarity, bool job)
	{
	}

	private void SetRarityEffect(Material i_Material)
	{
	}

	private void OnDestroy()
	{
	}
}
