using UnityEngine;

[DisallowMultipleComponent]
public class CBtlGmMessage : MonoBehaviour
{
	private enum Seq
	{
		None = 0,
		Init = 1,
		Input = 2
	}

	private enum InputButton
	{
		Ok = 0
	}

	private Seq m_Seq;

	private GameController.PADNUM m_PadNum;

	private bool m_IsInputMe;

	private bool[] m_InputButton;

	public string m_PrevText { get; private set; }

	public string m_CurrentText { get; private set; }

	public void Setup(GameController.PADNUM i_PadNum, bool i_Me)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SaveText(string i_Text)
	{
	}
}
