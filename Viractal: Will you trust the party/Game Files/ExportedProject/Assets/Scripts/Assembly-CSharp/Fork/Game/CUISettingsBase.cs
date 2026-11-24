using System;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUISettingsBase : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text m_TitleText;

		[SerializeField]
		private GameObject m_Active;

		[SerializeField]
		private GameObject m_Normal;

		private CUIGenericFocus m_Focus;

		protected Action m_OnDecision;

		protected Action m_OnUpdate;

		public CUISettingsMenu.ConfigItem m_ConfigItem { get; private set; }

		public string m_DescriptionID { get; protected set; }

		protected virtual void Awake()
		{
		}

		public virtual void SetBehaviour(CUISettingsMenu i_Menu, CUISettingsMenu.ConfigItem i_Item)
		{
		}

		public virtual void SetValue(int i_Value)
		{
		}

		public void SetTitleText(string i_ConstWordID)
		{
		}

		public void SetSelect(bool i_Switch)
		{
		}

		public virtual void Decision()
		{
		}

		public virtual bool MoveCursor(GameController.PADNUM i_PadNum, GamePad i_Pad)
		{
			return false;
		}

		protected void InvokeSetOption()
		{
		}

		protected bool IsSelected()
		{
			return false;
		}
	}
}
