using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CUISettingsSelector : CUISettingsBase
	{
		[SerializeField]
		private TMP_Text[] m_ValueTexts;

		private string[] m_ColumnIDTable;

		[SerializeField]
		private CUISettingsArrow[] m_LeftArrows;

		[SerializeField]
		private CUISettingsArrow[] m_RightArrows;

		[SerializeField]
		private Button m_LeftArrowButton;

		[SerializeField]
		private Button m_RightArrowButton;

		private int m_ButtonArrowTrigger;

		public int m_Value { get; set; }

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public void InitSettings(string i_TitleID, string[] i_ColumnIDTable, int i_Value)
		{
		}

		public override void SetValue(int i_Value)
		{
		}

		public override void SetBehaviour(CUISettingsMenu i_Menu, CUISettingsMenu.ConfigItem i_Item)
		{
		}

		private void UpdateArrow()
		{
		}

		private void HighlightArrow(bool i_Right)
		{
		}

		private void OnArrowButton(int i_Button)
		{
		}

		public override bool MoveCursor(GameController.PADNUM i_PadNum, GamePad i_Pad)
		{
			return false;
		}
	}
}
