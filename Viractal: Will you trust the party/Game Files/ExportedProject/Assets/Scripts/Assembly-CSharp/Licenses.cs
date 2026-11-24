using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Licenses", fileName = "Licenses")]
public class Licenses : ScriptableObject
{
	[SerializeField]
	public License[] m_Licenses;
}
