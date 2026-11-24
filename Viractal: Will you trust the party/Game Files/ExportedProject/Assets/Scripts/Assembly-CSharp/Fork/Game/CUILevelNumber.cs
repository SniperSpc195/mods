using Fork.ModelButtons;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/LevelNumber")]
	public class CUILevelNumber : MonoBehaviour
	{
		private const int MaxLevelCheck = 2147483647;

		private TMP_Text m_Number;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIModelButton m_Button;

		private ColoredUnit m_Color;

		private MaterialPropertyBlock m_Property;

		private int m_RemainExp;

		private int m_NextExp;

		private int m_Lv;

		private int m_MaxLv;

		private CUICharacterStatus m_Parent;

		private void Start()
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void SetParent(CUICharacterStatus i_Parent)
		{
		}

		public void SetupResource(ColoredUnit i_Color, ColoredUnitResource i_Resource)
		{
		}

		public void SetValue(int i_Level, int i_Experience)
		{
		}
	}
}
