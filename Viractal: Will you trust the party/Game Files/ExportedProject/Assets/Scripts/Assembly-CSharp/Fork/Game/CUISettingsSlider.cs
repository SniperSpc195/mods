using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUISettingsSlider : CUISettingsBase
	{
		private static readonly string SeTest;

		[SerializeField]
		private TMP_Text[] m_ValueTexts;

		[SerializeField]
		private Image[] m_VolumeImages;

		[SerializeField]
		private CUISliderMouseOp m_SliderFocus;

		public int m_Value { get; set; }

		public int m_Min { get; private set; }

		public int m_Max { get; private set; }

		public void InitSettings(string i_TitleID, int i_Value, int i_Min, int i_Max)
		{
		}

		public override void SetValue(int i_Value)
		{
		}

		public override bool MoveCursor(GameController.PADNUM i_PadNum, GamePad i_Pad)
		{
			return false;
		}

		private void OnSliderChanged(Vector2 i_NornalizedValue)
		{
		}

		public override void SetBehaviour(CUISettingsMenu i_Menu, CUISettingsMenu.ConfigItem i_Item)
		{
		}

		public override void Decision()
		{
		}
	}
}
