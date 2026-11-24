using System.Collections.Generic;
using UnityEngine;

public class SignalSE : MonoBehaviour
{
	[HideInInspector]
	public enum InputType
	{
		Number = 0,
		Name = 1
	}

	[HideInInspector]
	public InputType m_SeType;

	[HideInInspector]
	public int m_SENo;

	[HideInInspector]
	public string m_SEName;

	[HideInInspector]
	public Transform m_Speaker;

	[HideInInspector]
	public string m_InspectorComment;

	private List<long> m_Handles;

	private void OnDestroy()
	{
	}

	public void PlaySE()
	{
	}

	public void SetSE(string i_SE)
	{
	}
}
