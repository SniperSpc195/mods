using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CUIButtonLayout : MonoBehaviour
{
	private const float DEF_PADDINGLEFT = 15f;

	[SerializeField]
	private bool mPaddingUse;

	[SerializeField]
	private float mPaddingLeft;

	[SerializeField]
	private Image mButton;

	[SerializeField]
	private TextMeshProUGUI mTextMeshPro;

	[SerializeField]
	private string mSetTextLang;

	private void Awake()
	{
	}

	public void UpdatePosition()
	{
	}
}
