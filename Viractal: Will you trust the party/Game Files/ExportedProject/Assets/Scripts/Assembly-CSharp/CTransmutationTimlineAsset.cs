using UnityEngine;

public class CTransmutationTimlineAsset : MonoBehaviour
{
	[SerializeField]
	private CTransmutationCard3D m_FastCard;

	[SerializeField]
	private CTransmutationCard3D m_FinishCard;

	[SerializeField]
	private CTransmutationCard3D m_FinishItem;

	[SerializeField]
	private Camera m_Camera;

	public CTransmutationCard3D FastCard => null;

	public CTransmutationCard3D FinishCard => null;

	public CTransmutationCard3D FinishItem => null;

	public Camera Camera => null;
}
