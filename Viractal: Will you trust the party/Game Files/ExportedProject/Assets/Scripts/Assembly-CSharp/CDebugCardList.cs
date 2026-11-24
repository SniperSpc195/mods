using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CDebugCardList : LwSingleton<CDebugCardList>
{
	[Serializable]
	private struct ScrollContent
	{
		public RectTransform m_ScrollContent;

		public GridLayoutGroup m_GridLayoutGroup;

		public ContentSizeFitter m_ContentSizeFiltter;

		public CanvasGroup canvasGroup;
	}

	public enum Mode
	{
		All = 0,
		OnlyRenderTexture = 1
	}

	private enum Seq
	{
		None = 0,
		Select = 1
	}

	private enum Tab
	{
		ID0000 = 0,
		ID1000 = 1,
		ID2000 = 2,
		ID3000 = 3,
		ID4000 = 4,
		ID5000 = 5,
		ID6000 = 6,
		ID7000 = 7,
		ID8000 = 8,
		ID9000 = 9,
		Fav = 10,
		_Max = 11
	}

	private enum InputSelect
	{
		IsCancel = 0,
		IsPress_R1 = 1,
		IsPress_L1 = 2,
		IsLeft = 3,
		IsRight = 4,
		IsUp = 5,
		IsDown = 6,
		IsRepUp = 7,
		IsRepDown = 8,
		IsStart = 9
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CApplyConditionTip_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CDebugCardList _003C_003E4__this;

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
	private struct _003CCreateList_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CDebugCardList _003C_003E4__this;

		public int i_Tab;

		public CancellationToken i_Cancel;

		private int _003Ccount_003E5__2;

		private CMaster_SkillCardData[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

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
	private struct _003CCreateListAll_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CDebugCardList _003C_003E4__this;

		private int _003Ctab_003E5__2;

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
	private struct _003CSetCardImage_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMaster_SkillCardData i_CardData;

		public RawImage i_Image;

		public CancellationToken i_Cancel;

		public CDebugCardList _003C_003E4__this;

		private RawImage _003C_003E7__wrap1;

		private UniTask<Texture>.Awaiter _003C_003Eu__1;

		private UniTask<Material>.Awaiter _003C_003Eu__2;

		private GameObject _003Cgo_003E5__3;

		private CancellationToken _003Ccancel_003E5__4;

		private UniTask<GameObject>.Awaiter _003C_003Eu__3;

		private UniTask.Awaiter _003C_003Eu__4;

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
	private struct _003CStart_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CDebugCardList _003C_003E4__this;

		private CUIGenericDialog _003Cdialog_003E5__2;

		private bool _003Ccancel_003E5__3;

		private UniTask _003Crendertask_003E5__4;

		private UniTask.Awaiter _003C_003Eu__1;

		private JsonNode _003Creceive_003E5__5;

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
	private sealed class _003C_SwList_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CDebugCardList _003C_003E4__this;

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
		public _003C_SwList_003Ed__48(int _003C_003E1__state)
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

	public static string m_SelectedCardID;

	[SerializeField]
	private Canvas m_Canvas;

	[SerializeField]
	private CanvasGroup m_ScrollCanvasGroup;

	[SerializeField]
	private ScrollRect m_ScrollRect;

	[SerializeField]
	private ScrollContent[] m_ScrollContent;

	[SerializeField]
	private RectTransform m_RawImageRoot;

	[SerializeField]
	private RawImage m_RawImageSrc;

	[SerializeField]
	private Button[] m_Tab;

	[SerializeField]
	private RectTransform m_Cursor;

	[SerializeField]
	private CBtlCardDetail m_TooltipRight;

	[SerializeField]
	private CBtlCardDetail m_TooltipLeft;

	[SerializeField]
	private TextMeshProUGUI m_Giude;

	private bool m_Started;

	private static Mode m_Mode;

	private static bool m_CursorMode;

	private static int[] m_CursorPosition;

	private static bool m_RenderAll;

	private Dictionary<string, RawImage> m_CardDict;

	private Dictionary<string, RawImage> m_FavDict;

	private List<GameObject> m_ShowList;

	private List<string> m_ShowCardID;

	public bool m_ShowConditionTip;

	private Seq m_Seq;

	private Coroutine m_CoroutineSwList;

	private static Tab m_SelectedTab;

	private bool[] m_CreatedTab;

	private bool[] m_InputButton;

	private Vector2 m_ScrollPosition;

	private bool m_ResetTooltipPosition;

	private Vector3[] viewportCorners;

	public bool m_Decide { get; private set; }

	public static void LoadScene(bool i_CursorMode, bool i_RenderAll, Mode i_Mode)
	{
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__40))]
	private Task Start()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCreateListAll_003Ed__41))]
	private UniTask CreateListAll()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCreateList_003Ed__42))]
	private UniTask CreateList(int i_Tab, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CSetCardImage_003Ed__43))]
	private UniTask SetCardImage(RawImage i_Image, CMaster_SkillCardData i_CardData, CancellationToken i_Cancel)
	{
		return default;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void SwList()
	{
	}

	[IteratorStateMachine(typeof(_003C_SwList_003Ed__48))]
	private IEnumerator _SwList()
	{
		return null;
	}

	public void EnableCursor(bool i_AutoScroll = true)
	{
	}

	public void DisableCursor()
	{
	}

	public void HideCursor()
	{
	}

	private void SelectCard(string i_SelectedCardID, bool i_Control)
	{
	}

	public void Cancel()
	{
	}

	public static void Close()
	{
	}

	[AsyncStateMachine(typeof(_003CApplyConditionTip_003Ed__55))]
	private UniTask ApplyConditionTip()
	{
		return default;
	}

	private GamePad GetPad()
	{
		return null;
	}

	private CFieldPlayer GetFieldPlayer()
	{
		return null;
	}

	private void SetGuideText()
	{
	}
}
