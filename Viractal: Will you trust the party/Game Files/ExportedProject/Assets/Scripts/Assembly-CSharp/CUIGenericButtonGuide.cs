using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CUIGenericButtonGuide : CInOutBehaviour
{
	[SerializeField]
	private GameObject m_ButtonPrefab;

	[SerializeField]
	private Image m_Background;

	private int m_ButtonCount;

	public void Clear()
	{
	}

	public void AddButton(string i_Button, string i_Text, GameController.PADNUM i_Pad = GameController.PADNUM.None)
	{
	}

	[Conditional("UNITY_DEBUG")]
	public void AddDebugButton(string i_Button, string i_Text, GameController.PADNUM i_Pad = GameController.PADNUM.None)
	{
	}

	private void Update()
	{
	}
}
