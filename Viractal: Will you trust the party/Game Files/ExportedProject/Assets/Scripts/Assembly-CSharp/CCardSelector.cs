using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cinemachine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CCardSelector : LwSingleton<CCardSelector>
{
	private enum Mode
	{
		None = 0,
		Levelup = 1,
		Obtain = 2,
		Show = 3,
		Selectable = 4
	}

	private enum Rarity
	{
		Common = 0,
		UnCommon = 1,
		Rare = 2,
		Max = 3
	}

	private struct Card
	{
		public CSkillCardData card;

		public MeshRenderer meshRenderer;

		public bool modeUpgrade;
	}

	private enum InputButton
	{
		InputDebug = 0,
		Ok = 1,
		Cancel = 2,
		Upgrade = 3,
		_Max = 4
	}

	private enum Seq
	{
		None = 0,
		Init = 1,
		Select = 2,
		Decision = 3,
		PreEnd = 4,
		End = 5,
		DebugMenu = 6
	}

	private enum ButtonGuide_Levelup
	{
		Upgrade = 0,
		Detail = 1
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public float time;

		public Card i_Card;

		public Vector3 srcScale;

		public AnimationCurve curve;

		public CCardSelector _003C_003E4__this;

		internal bool _003C_InDeckDirection_003Eb__0()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAddSceneLevelup_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CCardSelector> _003C_003Et__builder;

		public CFieldPlayer player;

		public int level;

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
	private struct _003CAddSceneObtain_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CCardSelector> _003C_003Et__builder;

		public CancellationToken cancel;

		public CFieldPlayer player;

		public string i_CardID1;

		public int i_Count;

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
	private struct _003CAddSceneObtain_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CCardSelector> _003C_003Et__builder;

		public CancellationToken cancel;

		public ReadOnlyCollection<CFieldPlayer> player;

		public string i_CardID1;

		public int i_Count;

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
	private struct _003CAddSceneSelectable_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CCardSelector> _003C_003Et__builder;

		public CancellationToken cancel;

		public CFieldPlayer player;

		public string i_CardID1;

		public string i_CardID2;

		private UniTask<CCardSelector>.Awaiter _003C_003Eu__1;

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
	private struct _003CAddSceneSelectable_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CCardSelector> _003C_003Et__builder;

		public CancellationToken cancel;

		public CFieldPlayer player;

		public string i_CardID1;

		public string i_CardID2;

		public string i_CardID3;

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
	private struct _003CAddSceneShow_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CCardSelector> _003C_003Et__builder;

		public CancellationToken cancel;

		public CFieldPlayer player;

		public string i_CardID1;

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
	private struct _003CEnd_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCardSelector _003C_003E4__this;

		public CancellationToken cancel;

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
	private struct _003CInCard_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCardSelector _003C_003E4__this;

		public CancellationToken cancel;

		private float _003Ctime_003E5__2;

		private AnimationCurve _003Ccurve_003E5__3;

		private UniTask.Awaiter _003C_003Eu__1;

		private int _003Ci_003E5__4;

		private float _003CtimeScaleup_003E5__5;

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
	private struct _003CInitialize_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCardSelector _003C_003E4__this;

		public CancellationToken cancel;

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
	private struct _003CLoadPrefab_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<CCardSelector> _003C_003Et__builder;

		public Scene scene;

		public Transform parent;

		public CFieldPlayer player;

		public int levelPrev;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
	private struct _003COutCard_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCardSelector _003C_003E4__this;

		public CancellationToken cancel;

		private float _003Ctime_003E5__2;

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
	private struct _003CReload_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCardSelector _003C_003E4__this;

		public CancellationToken cancel;

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
	private struct _003CResumeCardScale_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCardSelector _003C_003E4__this;

		public int i_Index;

		public CancellationToken i_Cancel;

		private AnimationCurve _003Ccurve_003E5__2;

		private float _003CtimeScaler_003E5__3;

		private float _003CcurrentScale_003E5__4;

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
	private struct _003CStart_003Ed__68 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCardSelector _003C_003E4__this;

		private UniTask _003Czoomin_003E5__2;

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

	[CompilerGenerated]
	private sealed class _003CZoomInCharacter_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CFieldPlayer i_Player;

		public CCardSelector _003C_003E4__this;

		private CinemachineFramingTransposer _003Ctransposer_003E5__2;

		private float _003CscreenX_003E5__3;

		private float _003CscreenY_003E5__4;

		private float _003Cdistance_003E5__5;

		private float _003Ctime_003E5__6;

		private AnimationCurve _003Ccurve_003E5__7;

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
		public _003CZoomInCharacter_003Ed__105(int _003C_003E1__state)
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
	private sealed class _003C_DecisionCard_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CCardSelector _003C_003E4__this;

		public int i_Index;

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
		public _003C_DecisionCard_003Ed__89(int _003C_003E1__state)
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
	private sealed class _003C_InDeckDirection_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Card i_Card;

		public CCardSelector _003C_003E4__this;

		private _003C_003Ec__DisplayClass91_0 _003C_003E8__1;

		private List<CEffectHandle> _003CeffLines_003E5__2;

		private List<Vector3> _003Cpoints_003E5__3;

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
		public _003C_InDeckDirection_003Ed__91(int _003C_003E1__state)
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

	public static readonly int TokenKey;

	[SerializeField]
	private Transform m_CardsRoot;

	[SerializeField]
	private Transform m_3DRoot;

	[SerializeField]
	private Canvas m_Canvas;

	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private Camera m_Camera;

	[SerializeField]
	private Light m_Light;

	[SerializeField]
	private MeshRenderer m_CardMeshRendererSrc;

	[SerializeField]
	[HideInInspector]
	private int m_LevelPrev;

	[SerializeField]
	[HideInInspector]
	private int m_LevelCurrent;

	[SerializeField]
	private TextMeshProUGUI m_SelectMessage;

	[SerializeField]
	private CDebugMenu m_DebugMenu;

	[SerializeField]
	private CBtlCardDetail m_BtlCardDetail;

	[SerializeField]
	private CBtlResultMenu m_DPMenu;

	[SerializeField]
	private List<TextMeshProUGUI> m_RightLowerText;

	private static readonly float SelectedScale;

	private static readonly float DefaultScale;

	private static readonly float BtlCollisionScale;

	private Mode m_Mode;

	private bool m_AutoOk;

	private bool m_Battle;

	private const int SelectionMax = 3;

	private List<CMaster_DeckCardData>[] m_CandidateCard;

	private List<Card> m_SelectionCard;

	private int m_CursorPosition;

	private bool m_ConditionDetailMode;

	private List<CFieldPlayer> m_Players;

	private CFieldPlayer m_ExternalMenuSelectedPlayer;

	private int m_Count;

	private float m_BackupCameraScreenX;

	private float m_BackupCameraScreenY;

	private float m_BackupCameraDistance;

	private float m_BackupCameraSoftWidth;

	private float m_BackupCameraSoftHeight;

	private Quaternion m_BackupCameraRotation;

	private Transform m_BackupFollow;

	private Transform m_BackupLookAt;

	private bool m_OtherSelecting;

	private bool[] m_InputButton;

	private Seq m_Seq;

	private Seq m_TmpSeq;

	[SerializeField]
	private Animator m_SelectFrontEffect;

	[SerializeField]
	private Animator m_SelectBackEffect;

	private CSelectableInOutPattern m_InOutFront;

	private CInOutPattern m_InOutBack;

	private List<MaterialPropertyBlock> m_CardMaterialPropertyBlock;

	private Camera m_ActiveCamera;

	private CinemachineVirtualCamera m_ActiveVCamera;

	private bool m_IsMouseMoving;

	private float m_GameSpeed;

	private float m_OperateTime;

	public int GetCardRenderersCount()
	{
		return 0;
	}

	public static bool IsEnd()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CLoadPrefab_003Ed__58))]
	public static UniTask<CCardSelector> LoadPrefab(Scene scene, Transform parent, CFieldPlayer player, int levelPrev)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAddSceneObtain_003Ed__59))]
	public static UniTask<CCardSelector> AddSceneObtain(CancellationToken cancel, CFieldPlayer player, string i_CardID1, int i_Count = 1)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAddSceneObtain_003Ed__60))]
	public static UniTask<CCardSelector> AddSceneObtain(CancellationToken cancel, ReadOnlyCollection<CFieldPlayer> player, string i_CardID1, int i_Count = 1)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAddSceneShow_003Ed__61))]
	public static UniTask<CCardSelector> AddSceneShow(CancellationToken cancel, CFieldPlayer player, string i_CardID1)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAddSceneSelectable_003Ed__62))]
	public static UniTask<CCardSelector> AddSceneSelectable(CancellationToken cancel, CFieldPlayer player, string i_CardID1, string i_CardID2)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAddSceneSelectable_003Ed__63))]
	public static UniTask<CCardSelector> AddSceneSelectable(CancellationToken cancel, CFieldPlayer player, string i_CardID1, string i_CardID2, string i_CardID3)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAddSceneLevelup_003Ed__64))]
	public static UniTask<CCardSelector> AddSceneLevelup(CancellationToken cancel, CFieldPlayer player, int level)
	{
		return default;
	}

	public static bool IsSelectable()
	{
		return false;
	}

	private new void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__68))]
	private UniTask Start()
	{
		return default;
	}

	private void Update()
	{
	}

	private void OpenDebugMenu(bool i_Control)
	{
	}

	private void UpdateShowMode()
	{
	}

	public void Setup(CFieldPlayer player, int levelPrev)
	{
	}

	public void SetupObtain(CFieldPlayer player, string i_CardID, int i_Count)
	{
	}

	public void SetupObtain(ReadOnlyCollection<CFieldPlayer> player, string i_CardID, int i_Count)
	{
	}

	public void SetupShow(CFieldPlayer i_Player, string i_CardID)
	{
	}

	public void SetupSelectable(CFieldPlayer player, string i_CardID1, string i_CardID2)
	{
	}

	public void SetupSelectable(CFieldPlayer player, string i_CardID1, string i_CardID2, string i_CardID3)
	{
	}

	[AsyncStateMachine(typeof(_003CReload_003Ed__78))]
	public UniTask Reload(CancellationToken cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__79))]
	private UniTask Initialize(CancellationToken cancel)
	{
		return default;
	}

	private void SetCardIllust(string i_CardId, MeshRenderer i_MeshRenderer)
	{
	}

	[AsyncStateMachine(typeof(_003CInCard_003Ed__81))]
	private UniTask InCard(CancellationToken cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CResumeCardScale_003Ed__82))]
	private UniTask ResumeCardScale(int i_Index, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003COutCard_003Ed__83))]
	private UniTask OutCard(CancellationToken cancel)
	{
		return default;
	}

	private void InOutCard(float i_Time, ActionWork.AnimationCurve i_CurveType)
	{
	}

	private void SetCursor()
	{
	}

	private void NonCursor()
	{
	}

	private void ShowConditionDetail(bool i_PlaySE, GameController.PADNUM i_PadNum)
	{
	}

	private void DecisionCard(int i_Index)
	{
	}

	[IteratorStateMachine(typeof(_003C_DecisionCard_003Ed__89))]
	private IEnumerator _DecisionCard(int i_Index)
	{
		return null;
	}

	public void NextCardSelection()
	{
	}

	[IteratorStateMachine(typeof(_003C_InDeckDirection_003Ed__91))]
	private IEnumerator _InDeckDirection(Card i_Card)
	{
		return null;
	}

	private void SetEnd()
	{
	}

	[AsyncStateMachine(typeof(_003CEnd_003Ed__93))]
	private UniTask End(CancellationToken cancel)
	{
		return default;
	}

	private void ShowCardEffect(int i_Index)
	{
	}

	private void HideCardEffect()
	{
	}

	public void ResumeCamera()
	{
	}

	private List<Dictionary<string, object>> CreateSendCard()
	{
		return null;
	}

	private void SendCursorPosition()
	{
	}

	private Dictionary<string, object> CreateSendInput()
	{
		return null;
	}

	public void SetModeShow2Obtain(CFieldPlayer player, int i_Count = 1)
	{
	}

	public void SetExternalMenuSelectedPlayer(CFieldPlayer i_SelectedPlayer)
	{
	}

	public bool _IsSelectable()
	{
		return false;
	}

	public bool IsInitializing()
	{
		return false;
	}

	private int LotteryLevelupCard(int i_Level, List<CMaster_DeckCardData> i_Candidate)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CZoomInCharacter_003Ed__105))]
	private IEnumerator ZoomInCharacter(CFieldPlayer i_Player)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void ShowSelectMessage()
	{
	}

	public void HideSelectMessage()
	{
	}

	public bool IsOpenDebugMenu()
	{
		return false;
	}

	private bool TryToggleUpgrade()
	{
		return false;
	}

	private void SetButtonGuideLower(ButtonGuide_Levelup type)
	{
	}

	[Conditional("UNITY_DEBUG")]
	public void OutputTimeLog()
	{
	}
}
