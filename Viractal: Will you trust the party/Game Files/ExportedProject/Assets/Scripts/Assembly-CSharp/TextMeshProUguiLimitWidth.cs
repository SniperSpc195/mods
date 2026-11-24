using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TMP_Text))]
[RequireComponent(typeof(LayoutElement))]
public class TextMeshProUguiLimitWidth : MonoBehaviour
{
	private TMP_Text _Text;

	private LayoutElement _LayoutElement;

	[SerializeField]
	private float m_MaxWidth;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTextChanged(Object obj)
	{
	}
}
