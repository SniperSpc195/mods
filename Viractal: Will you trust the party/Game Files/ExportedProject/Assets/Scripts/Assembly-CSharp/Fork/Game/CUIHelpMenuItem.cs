using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUIHelpMenuItem : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text m_HeadlineText;

		[SerializeField]
		private TMP_Text m_ContentNameText;

		[SerializeField]
		private Material m_NormalMaterial;

		[SerializeField]
		private Material m_HighlightedMaterial;

		[SerializeField]
		private CUIGenericFocus m_Focus;

		private string m_Text;

		public bool IsHeadline { get; private set; }

		private void Awake()
		{
		}

		public void SetData(object i_Data)
		{
		}

		private void SetData(string i_HeadlineText)
		{
		}

		private void SetData(CHelp i_Help)
		{
		}

		public void SetSelect(bool i_Switch)
		{
		}
	}
}
