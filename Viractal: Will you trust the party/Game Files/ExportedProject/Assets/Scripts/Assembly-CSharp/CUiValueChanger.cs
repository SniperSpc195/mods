using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CUiValueChanger : MonoBehaviour
{
	public struct SetupParam
	{
		public UnityAction<CUiValueChanger> onClickL2;

		public UnityAction<CUiValueChanger> onClickR2;

		public object value;
	}

	[SerializeField]
	private TextMeshProUGUI m_Value;

	[SerializeField]
	private Image m_IconL2;

	[SerializeField]
	private Image m_IconR2;

	public UnityAction<CUiValueChanger> m_OnClickL2;

	public UnityAction<CUiValueChanger> m_OnClickR2;

	private void Start()
	{
	}

	public void Setup(SetupParam param)
	{
	}

	public void SetText(float value)
	{
	}

	public void SetText(int value)
	{
	}

	public void SetText(string text)
	{
	}

	private void Update()
	{
	}
}
