using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CGameResultReport : MonoBehaviour
	{
		public enum Category
		{
			DefeatCount = 0,
			DagameTaken = 1,
			DamateDealt = 2,
			DownCount = 3,
			Block = 4,
			BadCondition = 5,
			MoveCount = 6,
			Dice6 = 7,
			EnemyHex = 8,
			GoddesHex = 9,
			MystertyCircleHex = 10,
			TreatureBoxHex = 11,
			Gold = 12,
			DevilsWhispers = 13,
			_MAX = 14
		}

		public enum WinnerStatus
		{
			Platinum = 0,
			Gold = 1,
			Silver = 2,
			Bronze = 3,
			None = 4,
			Max = None
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetupWinnerMedalTask_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CGameResultReport _003C_003E4__this;

			public WinnerStatus i_WinnerStatus;

			public SpriteRenderer i_Sprite;

			private double _003Cstarttime_003E5__2;

			private float _003Cinitial_003E5__3;

			private UniTask.Awaiter _003C_003Eu__1;

			private YieldAwaitable.Awaiter _003C_003Eu__2;

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
		private CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		private Transform m_Root;

		[SerializeField]
		private CUIGenericMenu m_Menu;

		private static readonly string[] m_LabelIDTable;

		private const bool HIGH = true;

		private const bool LOW = false;

		private static readonly bool[] m_CategoryPredicatinConditions;

		public static readonly int[] m_OrderScore;

		private int m_HighlightIndex;

		private SpriteRenderer m_MedalSpriteRenderer;

		private bool m_IsMedalTask;

		private static readonly string[] orderSprites;

		public static bool PlatinumCondition(int i_TopCount)
		{
			return false;
		}

		public void SetReport(CFieldPlayer i_Player, int i_PlayerIndex, Vector3Int[] i_Orders, WinnerStatus i_WinnerStatus, Sprite i_Medal, Material i_MedalMaterial)
		{
		}

		public void Close()
		{
		}

		private static void SetValue(Transform i_Root, Category i_Category, CFieldPlayer i_Player, int i_Order)
		{
		}

		public static int GetValue(Category i_Category, CFieldPlayer i_Player)
		{
			return 0;
		}

		public static int GetMinValue(Category i_Category)
		{
			return 0;
		}

		public static int Predicate(Category i_Category, int i_Left, int i_Right)
		{
			return 0;
		}

		public void UpdateControll(bool isControl, bool isOnline, GameController.PADNUM padNum, GamePad pad)
		{
		}

		public void ClonePosition(CGameResultReport i_Other)
		{
		}

		private void HighlightCurrent()
		{
		}

		private void Highlight(bool i_IsActive, int i_Index)
		{
		}

		private void SetupWinnerMedal(CUICharacterStatus i_Status, Sprite i_Medal, Material i_MedalMaterial, WinnerStatus i_WinnerStatus)
		{
		}

		[AsyncStateMachine(typeof(_003CSetupWinnerMedalTask_003Ed__26))]
		private UniTask SetupWinnerMedalTask(SpriteRenderer i_Sprite, WinnerStatus i_WinnerStatus)
		{
			return default;
		}

		public bool IsMedalFinish()
		{
			return false;
		}
	}
}
