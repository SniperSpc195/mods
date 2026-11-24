using TMPro;
using UnityEngine;

public class CUIGenericInputText : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField mInputField;

	[SerializeField]
	private TextMeshProUGUI mTextAreaText;

	private string mInputCompText;

	private string[] mInputString;

	private double mTime;

	public TMP_InputField InputField => null;

	public int GetCharacterLimit()
	{
		return 0;
	}

	public bool IsFocused()
	{
		return false;
	}

	private void Awake()
	{
	}

	public void StartInput(string a, bool enableInputField = true)
	{
	}

	public void Enable(bool a, string text = null)
	{
	}

	public void EndInput()
	{
	}

	public string IsCompleted(GamePad pad = null)
	{
		return null;
	}

	public void ClearCompText()
	{
	}

	public bool IsCancel(GamePad pad)
	{
		return false;
	}

	private void OnInputComplete(string text)
	{
	}

	private void OnInputTextChanged(string text)
	{
	}
}
