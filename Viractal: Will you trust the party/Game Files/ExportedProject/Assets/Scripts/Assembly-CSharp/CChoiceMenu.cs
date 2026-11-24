using UnityEngine;
using UnityEngine.UI;

public class CChoiceMenu : MonoBehaviour
{
	[SerializeField]
	private CUIGenericMenu m_Menu;

	[SerializeField]
	private Image m_Frame;

	[SerializeField]
	private CUIGenericOpenClose m_OpenClose;

	[SerializeField]
	private Color[] m_TextColor;

	[SerializeField]
	private Vector2[] m_TextSize;

	public CUIGenericMenu GenericMenu => null;

	public CUIGenericOpenClose GenericOpenClose => null;

	public Color ColorUnselected => default;

	public void Active(bool i_Active)
	{
	}

	public void Initialize(string i_Choices)
	{
	}

	public void Initialize(string[] i_Choices)
	{
	}

	public void AddSubText(string[] i_Text, Color i_Color)
	{
	}

	public void AddSubText(int i_Index, string i_Text)
	{
	}

	public void SetSubTextColor(int i_Index, Color i_Color)
	{
	}

	public void SetCursorPosition(int i_Num)
	{
	}

	public bool MoveCursor(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
	{
		return false;
	}

	private void UpdateMoveCursor()
	{
	}

	public void AllNormal()
	{
	}

	public int GetCursorPosition()
	{
		return 0;
	}

	public void UpdateFrame()
	{
	}
}
