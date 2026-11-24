using UnityEngine;

public class LwSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	protected static T instance;

	public static T Instance => null;

	protected void Awake(T inheritedClass)
	{
	}

	protected void OnDestroy()
	{
	}
}
