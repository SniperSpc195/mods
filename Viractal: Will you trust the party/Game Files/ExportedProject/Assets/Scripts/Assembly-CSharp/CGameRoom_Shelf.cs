using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CGameRoom_Shelf : MonoBehaviour
{
	private enum Seq
	{
		None = 0,
		List = 1,
		CharacterDetail = 2,
		ObjectDetail = 3,
		Back = 4,
		StartSave = 5,
		Saving = 6,
		Close = 7
	}

	public enum ButtonGuide_List
	{
		Lower_Detail = 0,
		Lower_Rotation = 1,
		Lower_Zoom = 2,
		Lower_Back = 3,
		Lower_Max = 4,
		Upper_Favorite = Lower_Detail,
		Upper_Exchange = Lower_Rotation,
		Upper_Max = Lower_Zoom
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CResumeCamera_DetailFromList_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Shelf _003C_003E4__this;

		public CancellationToken i_Cancel;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Shelf _003C_003E4__this;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_SetCameraZoomIn_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Shelf _003C_003E4__this;

		public CancellationToken i_Cancel;

		public bool i_DetailMode;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_SetCameraZoomOut_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Shelf _003C_003E4__this;

		public CancellationToken i_Cancel;

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
	private CGameRoom m_GameRoom;

	[SerializeField]
	private CUIGenericMenu m_MenuYesNo;

	[SerializeField]
	private CMouseCtrl m_MouseCtrl;

	[SerializeField]
	private CCharacterDetail m_CharacterDetail;

	[SerializeField]
	private Image m_ShelfCursor;

	[SerializeField]
	private CDebugMenu m_DebugMenu;

	private CShelfPosition m_ShelfPosition;

	private bool m_IsZoom;

	private CancellationTokenSource m_ZoomCancelTokenSource;

	private static readonly Vector3[] CursorPosition;

	private Seq m_Seq;

	private Seq m_NextSeq;

	private CinemachineBrain m_CinemachineBrain;

	private float m_SaveBlendTime;

	private float m_LenShiftRate;

	private bool m_TmpIsFavoriteMode;

	public CGameRoom GameRoom => null;

	public CMouseCtrl MouseCtrl => null;

	public CCharacterDetail CharacterDetail => null;

	public CShelfPosition ShelfPosition => null;

	public int m_CursorIndex { get; private set; }

	public bool m_IsMouseMoving { get; private set; }

	[AsyncStateMachine(typeof(_003CStart_003Ed__33))]
	private UniTask Start()
	{
		return default;
	}

	private void Update()
	{
	}

	private bool TryMoveCursorLeft(int i_Column, int i_Row, out int o_Index)
	{
		o_Index = default;
		return false;
	}

	private bool TryMoveCursorRight(int i_Column, int i_Row, out int o_Index)
	{
		o_Index = default;
		return false;
	}

	private bool TryMoveCursorUp(int i_Column, int i_Row, out int o_Index)
	{
		o_Index = default;
		return false;
	}

	private bool TryMoveCursorDown(int i_Column, int i_Row, out int o_Index)
	{
		o_Index = default;
		return false;
	}

	private bool TryMoveCursorNearHorizontal(int i_Column, int i_Row, out int o_Index)
	{
		o_Index = default;
		return false;
	}

	private bool TryMoveCursorNearVertical(int i_Column, int i_Row, out int o_Index)
	{
		o_Index = default;
		return false;
	}

	public bool Select(int i_Index, bool i_Force = false)
	{
		return false;
	}

	public void Deselect()
	{
	}

	public void SelectNearestMousePointer()
	{
	}

	public void SelectNearest(int i_Column, int i_Row)
	{
	}

	private void SetCursorPosition(int i_Index)
	{
	}

	private void SetCameraZoomIn(bool i_DetailMode)
	{
	}

	[AsyncStateMachine(typeof(_003C_SetCameraZoomIn_003Ed__47))]
	private UniTask _SetCameraZoomIn(bool i_DetailMode, CancellationToken i_Cancel)
	{
		return default;
	}

	private void SetCameraZoomOut()
	{
	}

	[AsyncStateMachine(typeof(_003C_SetCameraZoomOut_003Ed__49))]
	private UniTask _SetCameraZoomOut(CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CResumeCamera_DetailFromList_003Ed__50))]
	private UniTask ResumeCamera_DetailFromList(CancellationToken i_Cancel)
	{
		return default;
	}

	private void SetButtonGuideLower(ButtonGuide_List type)
	{
	}

	public void SetButtonGuideUpper(ButtonGuide_List type)
	{
	}

	public void Open()
	{
	}

	private void _Back()
	{
	}

	public void Hide()
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public void ShowGuide()
	{
	}

	private void ShowShelfCursor()
	{
	}

	private void HideShelfCursor()
	{
	}
}
