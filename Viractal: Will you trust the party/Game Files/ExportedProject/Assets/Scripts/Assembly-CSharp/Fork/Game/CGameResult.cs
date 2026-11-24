using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CGameResult : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_Result_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CGameResult _003C_003E4__this;

			public Camera i_MainCamera;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_Result_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_ResultCommand_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CGameResult _003C_003E4__this;

			private bool[] _003CmJudg_003E5__2;

			private CFieldMain _003CfMain_003E5__3;

			private COnline _003C_online_003E5__4;

			private CSound _003C_sound_003E5__5;

			private GameController.PADNUM _003CpadNum_003E5__6;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_ResultCommand_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_ResultGameOver_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CGameResult _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_ResultGameOver_003Ed__16(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private GameObject m_PrepareVirtualCamera;

		[SerializeField]
		private GameObject m_ResultVirtualCamera;

		[SerializeField]
		private RectTransform m_ReportRoot;

		[SerializeField]
		private Sprite[] m_MedalSprites;

		[SerializeField]
		private Material m_MedalNormalMaterial;

		[SerializeField]
		private Material m_MedalShinyMaterial;

		private bool m_Execute;

		private bool m_ModeGameOver;

		private Vector3Int[] m_Orders;

		public Sprite GetMedal(CGameResultReport.WinnerStatus i_WinnerStatus)
		{
			return null;
		}

		public void ActiveCameraOnly()
		{
		}

		public void Active()
		{
		}

		public void ActiveGameOver()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		private static void HideGameField()
		{
		}

		[IteratorStateMachine(typeof(_003C_Result_003Ed__15))]
		private IEnumerator _Result(Camera i_MainCamera)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_ResultGameOver_003Ed__16))]
		private IEnumerator _ResultGameOver()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_ResultCommand_003Ed__17))]
		private IEnumerator _ResultCommand()
		{
			return null;
		}

		private void CreateOrders()
		{
		}

		private Vector3Int ScoreToOrder(CGameResultReport.Category i_Categoey, Vector3Int i_Score)
		{
			return default;
		}

		private CGameResultReport.WinnerStatus GetWinnerStatus(int i)
		{
			return CGameResultReport.WinnerStatus.Platinum;
		}

		private void SetupReports()
		{
		}

		private void CloseReport()
		{
		}
	}
}
