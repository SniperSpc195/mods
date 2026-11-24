using Fork.Game;
using TMPro;
using UnityEngine;

public class CDeleteCondition : MonoBehaviour
{
	private enum InputButton
	{
		Ok = 0,
		Cancel = 1,
		_Max = 2
	}

	private enum Seq
	{
		None = 0,
		Main = 1,
		DeleteDialog = 2
	}

	[SerializeField]
	private TextMeshProUGUI m_Title;

	[SerializeField]
	private CScrollMenu m_Menu;

	[SerializeField]
	private CUITooltip m_Tooltip;

	private CCharDef m_Character;

	private CParamDef m_Param;

	private bool[] m_InputButton;

	private Seq m_Seq;

	private CUIGenericDialog m_Dialog;
}
