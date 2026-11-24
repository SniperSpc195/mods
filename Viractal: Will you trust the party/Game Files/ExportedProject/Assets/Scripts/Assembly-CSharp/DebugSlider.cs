using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugSlider : MonoBehaviour
{
	[SerializeField]
	private TMP_Text m_TitleText;

	[SerializeField]
	private Slider m_Slider;

	[SerializeField]
	private TMP_Text m_LeftText;

	[SerializeField]
	private TMP_Text m_RightText;

	[SerializeField]
	private TMP_Text m_ValueText;

	private Action<float> OnValueChanged;

	private int m_Min;

	private int m_Max;

	private int m_Step;

	private int m_Current;

	private GamePad m_Pad;

	private void Awake()
	{
	}

	private void OnSliderValueChanged(float value)
	{
	}

	public void Open(GamePad pad, Action<float> _onValueChanged, string i_TitleText, int i_Min, int i_Max, int i_Step, int i_Current)
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	private void Update()
	{
	}
}
