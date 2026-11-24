using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CBtlItemButton : MonoBehaviour
{
	[SerializeField]
	private Image m_CharacterIcon;

	[SerializeField]
	private TextMeshProUGUI m_ButtonName;

	[SerializeField]
	private Button m_Button;

	public CParamPlayer m_ParamPlayer;

	public Button Button => null;

	public void SetCharacterIcon(Sprite icon)
	{
	}

	public void SetButtonName(string name)
	{
	}

	public void OnDecisionAdd(UnityAction<CBtlItemButton> onClick, CBtlItemButton self)
	{
	}

	public void OnDecisionClear()
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public void SetColor(Color color)
	{
	}
}
