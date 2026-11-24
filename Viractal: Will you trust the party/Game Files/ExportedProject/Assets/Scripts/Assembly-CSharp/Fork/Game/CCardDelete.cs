using UnityEngine;

namespace Fork.Game
{
	public class CCardDelete : MonoBehaviour
	{
		private enum State
		{
			Select_In = 0,
			Select = 1,
			Select_Out = 2,
			InquiryWait = 3,
			Inquiry = 4,
			Delete = 5,
			None = 6
		}

		private const string CardDeleteSE = "SE_0341";

		[SerializeField]
		private CCardView m_CardMenu;

		private CFieldPlayer m_Player;

		private int m_CardIndex;

		private int? m_CardResultIndex;

		private double m_DeleteStartTime;

		private State m_State;

		private bool[] m_Judge;

		private bool? m_MessageIsDeletable;

		private static readonly string m_OnlineUniqueName;

		private const int StepUnit = 166;

		public void Open(CFieldPlayer i_Player)
		{
		}

		private void Close()
		{
		}

		private void Deactivate()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public int GetResult()
		{
			return 0;
		}

		private void Update()
		{
		}

		private void UpdateSelect()
		{
		}

		private void UpdateInquiry()
		{
		}

		private void SetAllCardDark()
		{
		}

		private void SetAllCardLight()
		{
		}

		private bool IsActiveCardDeletable()
		{
			return false;
		}

		private void UpdateMessage()
		{
		}
	}
}
