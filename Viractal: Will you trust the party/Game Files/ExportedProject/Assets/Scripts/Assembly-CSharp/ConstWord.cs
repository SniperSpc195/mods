using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConstWord : MonoBehaviour
{
	[SerializeField]
	private bool mAwake;

	[SerializeField]
	private List<SerializableKeyPair<TextMeshProUGUI, string>> mTMPList;

	private void Awake()
	{
	}

	public void SetupText()
	{
	}
}
