using System;
using UnityEngine;

namespace Fork.GameRoom
{
	public class CCharacterDetail_Header : MonoBehaviour
	{
		public enum Tab
		{
			Character = 0,
			Card = 1,
			Deck = 2,
			_Max = 3
		}

		public enum Seq
		{
			None = 0,
			Proc = 1,
			StartSave = 2,
			Saving = 3
		}

		[SerializeField]
		private GameObject[] m_ButtonHilight;

		[SerializeField]
		private CCharacterDetail m_CharacterDetail;

		[SerializeField]
		private CUIGenericFocus m_FocusStatus;

		[SerializeField]
		private CUIGenericFocus m_FocusCard;

		[SerializeField]
		private CUIGenericFocus m_FocusDeck;

		[SerializeField]
		private GameObject[] m_ButtonIcon;

		private Seq m_Seq;

		public CDefine.GameFlag mPreUsableTransmutation;

		private Action m_OnSaveEnd;

		public Tab m_Selected { get; private set; }

		private void Update()
		{
		}

		public void Setup(Tab i_Select)
		{
		}

		private void Back()
		{
		}

		public void SetSeqNone()
		{
		}

		private void ButtonHilight()
		{
		}

		private void Active()
		{
		}

		private bool IsMouseLeftTabPressed()
		{
			return false;
		}

		private bool IsMouseRightTabPressed()
		{
			return false;
		}

		public void SaveDifference(Action onSaveEnd)
		{
		}

		public bool IsSaving()
		{
			return false;
		}

		public void CacheTransmutation()
		{
		}
	}
}
