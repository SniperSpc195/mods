using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CCardReinforcement : MonoBehaviour
	{
		private enum State
		{
			Select_In = 0,
			Select = 1,
			Select_Out = 2,
			Inquiry = 3,
			Excecute_In = 4,
			Excecute = 5,
			Execute_Out = 6,
			Roulette = 7,
			None = 8
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003C_Roulette_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CCardReinforcement _003C_003E4__this;

			private int _003CdelayUnit_003E5__2;

			private int _003Ci_003E5__3;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private CCardView m_CardMenu;

		[SerializeField]
		private CCardReinforcementView m_ReinforceView;

		private CFieldPlayer m_Player;

		private int m_CardIndex;

		private int? m_CardResultIndex;

		private State m_State;

		private bool[] m_Judge;

		private bool? m_MessageIsUpgradable;

		private static readonly string m_OnlineUniqueName;

		private List<int> m_RouletteIndices;

		private const int StepUnit = 166;

		public void Open(CFieldPlayer i_Player)
		{
		}

		public void Open(CFieldPlayer i_Player, int i_CardIndex)
		{
		}

		private int CalcRouletteDelay(int i_Time)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003C_Roulette_003Ed__15))]
		private UniTask _Roulette()
		{
			return default;
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

		private void UpdateCardColors()
		{
		}

		private void SetAllCardDark()
		{
		}

		private bool IsActiveCardUpgradable()
		{
			return false;
		}

		private void UpdateMessage()
		{
		}
	}
}
