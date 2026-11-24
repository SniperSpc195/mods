using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CShelfPosition : MonoBehaviour
{
	private struct Piece
	{
		public GameObject root;

		public CCharDef character;

		public AsyncOperationHandle<GameObject> handle;

		public CBlurEnabler blurEnabler;

		public CMaster_ShelfData shelf;

		public Animator anmCharacter;

		public Animator anmBase;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public List<Piece> prevList;

		public List<Piece> nextList;

		internal bool _003C_LoadPage_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public List<Piece> prevList;

		public List<Piece> nextList;

		internal bool _003C_LoadFavoritePage_003Eb__0()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public CShelfPosition _003C_003E4__this;

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
	private struct _003C_LoadFavoritePage_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken i_Cancel;

		public CShelfPosition _003C_003E4__this;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		public bool i_ChangeEffect;

		public UnityAction i_OnEnd;

		private PooledObject<List<Piece>> _003C_003E7__wrap1;

		private PooledObject<List<Piece>> _003C_003E7__wrap2;

		private int _003Ccount_003E5__4;

		private string[] _003C_003E7__wrap4;

		private int _003C_003E7__wrap5;

		private CMaster_ShelfData _003Cdata_003E5__7;

		private int _003Cindex_003E5__8;

		private GameObject _003Cparent_003E5__9;

		private AsyncOperationHandle<GameObject> _003C_handle_003E5__10;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003C_LoadPage_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken i_Cancel;

		public CShelfPosition _003C_003E4__this;

		public int i_Page;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		public bool i_ChangeEffect;

		public UnityAction i_OnEnd;

		private PooledObject<List<Piece>> _003C_003E7__wrap1;

		private PooledObject<List<Piece>> _003C_003E7__wrap2;

		private int _003Ccount_003E5__4;

		private CMaster_ShelfData[] _003C_003E7__wrap4;

		private int _003C_003E7__wrap5;

		private CMaster_ShelfData _003Cdata_003E5__7;

		private int _003Cindex_003E5__8;

		private GameObject _003Cparent_003E5__9;

		private AsyncOperationHandle<GameObject> _003C_handle_003E5__10;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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

	[CompilerGenerated]
	private sealed class _003C_MoveCameraLenShift_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float i_Speed;

		public CShelfPosition _003C_003E4__this;

		public int i_Index;

		public Vector2 i_Position;

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
		public _003C_MoveCameraLenShift_003Ed__51(int _003C_003E1__state)
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

	public const int ShelfWidth = 4;

	public const int ShelfHeight = 2;

	[SerializeField]
	private GameObject m_PieceRoot;

	[SerializeField]
	private Light m_DirectionaLight;

	[SerializeField]
	private Transform[] m_PieceNodes;

	[SerializeField]
	private Transform m_TmpPieceParent;

	[SerializeField]
	private CinemachineVirtualCamera[] m_VirtualCamera;

	private Light[] m_UnitSpotLights;

	private CMaster_ShelfData[] m_Sort;

	private List<Piece> m_Piece;

	private int m_PageCurrent;

	private int m_PageMax;

	private bool m_InitPage;

	private UniTask m_LoadPage;

	private CancellationTokenSource m_LoadPageCancel;

	private CGameRoom_Shelf _GameRoomShelf;

	public Transform[] PieceNodes => null;

	public Transform TmpPieceParent => null;

	public Light DirectionaLight => null;

	public Coroutine m_MoveLenShift { get; private set; }

	private CGameRoom_Shelf GameRoomShelf => null;

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__30))]
	private UniTaskVoid Start()
	{
		return default;
	}

	public void SetupPieceList()
	{
	}

	public void RefreshPage()
	{
	}

	private void InitPage()
	{
	}

	public void LoadPage(int i_Page, bool i_ChangeEffect, UnityAction i_OnEnd = null)
	{
	}

	[AsyncStateMachine(typeof(_003C_LoadPage_003Ed__35))]
	private UniTask _LoadPage(CancellationToken i_Cancel, int i_Page, bool i_ChangeEffect, UnityAction i_OnEnd = null)
	{
		return default;
	}

	public void LoadFavoritePage(bool i_ChangeEffect, UnityAction i_OnEnd = null)
	{
	}

	[AsyncStateMachine(typeof(_003C_LoadFavoritePage_003Ed__37))]
	private UniTask _LoadFavoritePage(CancellationToken i_Cancel, bool i_ChangeEffect, UnityAction i_OnEnd = null)
	{
		return default;
	}

	public void CancelLoadPage()
	{
	}

	public int GetPageCurrent()
	{
		return 0;
	}

	public int GetPageMax()
	{
		return 0;
	}

	public int MaxPiece()
	{
		return 0;
	}

	public int CountPiece()
	{
		return 0;
	}

	public void AddPieceAngle(int i_Index, Vector3 i_Add)
	{
	}

	public void ShowPiece()
	{
	}

	public void HidePiece()
	{
	}

	public CMaster_ShelfData GetShelfData(int i_Index)
	{
		return null;
	}

	public void EnableZoomCamera(int i_Index)
	{
	}

	public void DisableZoomCamera()
	{
	}

	public void SetUnitLight(int i_Index, bool i_Switch)
	{
	}

	public void MoveCameraLenShift(int i_Index, Vector2 i_Position, float i_Speed)
	{
	}

	[IteratorStateMachine(typeof(_003C_MoveCameraLenShift_003Ed__51))]
	private IEnumerator _MoveCameraLenShift(int i_Index, Vector2 i_Position, float i_Speed)
	{
		return null;
	}

	private void StopLenShiftCoroutine()
	{
	}

	private void AddComponentCharDef(List<Piece> i_Pieces)
	{
	}

	public void AddComponentCharDef()
	{
	}

	private void Update()
	{
	}
}
