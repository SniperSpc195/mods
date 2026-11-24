using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CDebugInputFieldDialog : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField m_SearchInputField;

	[SerializeField]
	private TextMeshProUGUI m_InputFieldText;

	[SerializeField]
	private Button m_DecisionButton;

	[SerializeField]
	private TextMeshProUGUI m_DecisionName;

	[SerializeField]
	private Button m_CancelButton;

	[SerializeField]
	private TextMeshProUGUI m_CancelName;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Setup(UnityAction onDecision, UnityAction onCancel)
	{
	}

	public string GetInputText()
	{
		return null;
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public bool IsShow()
	{
		return false;
	}
}
