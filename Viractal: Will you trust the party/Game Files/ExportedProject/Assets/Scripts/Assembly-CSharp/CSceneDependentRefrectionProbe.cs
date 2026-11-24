using UnityEngine;

[RequireComponent(typeof(ReflectionProbe))]
public class CSceneDependentRefrectionProbe : MonoBehaviour
{
	[SerializeField]
	private string m_DependentSceneName;
}
