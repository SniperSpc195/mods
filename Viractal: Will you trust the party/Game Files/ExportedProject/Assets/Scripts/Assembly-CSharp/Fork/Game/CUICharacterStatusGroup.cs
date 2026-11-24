using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.ModelButtons;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Animations;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/CharacterStatusGroup")]
	public class CUICharacterStatusGroup : MonoBehaviour
	{
		[Flags]
		public enum UpdateIgnoreMask
		{
			None = 0,
			Rank = 1
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public CUICharacterStatusGroup instance;

			public CMain.SCENE_HANDLE handle;

			internal void _003CAddScene_003Eb__0(Scene scene)
			{
			}

			internal bool _003CAddScene_003Eb__1()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddScene_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CUICharacterStatusGroup> _003C_003Et__builder;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

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
		private struct _003CDrawCards_003Ed__85 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

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
		private struct _003CPreloadConditionIcons_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatusGroup _003C_003E4__this;

			private Stopwatch _003Csw_003E5__2;

			private CMaster_SkillConditionData[] _003Cconditions_003E5__3;

			private IList<IResourceLocation> _003Clocations_003E5__4;

			private UniTask<IList<IResourceLocation>>.Awaiter _003C_003Eu__1;

			private UniTask<IList<GameObject>>.Awaiter _003C_003Eu__2;

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
		private struct _003CPreloadStampTextures_003Ed__72 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUICharacterStatusGroup _003C_003E4__this;

			private int _003Ci_003E5__2;

			private UniTask<Texture2D>.Awaiter _003C_003Eu__1;

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
		private sealed class _003CTooltipHideLater_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float i_DelaySeconds;

			public CUICharacterStatusGroup _003C_003E4__this;

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
			public _003CTooltipHideLater_003Ed__69(int _003C_003E1__state)
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
		private sealed class _003C_Zoom_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CUICharacterStatusGroup _003C_003E4__this;

			public int count;

			public float time;

			public float start;

			public float end;

			public Action onEnd;

			private double _003CstartTime_003E5__2;

			private float _003Cip_003E5__3;

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
			public _003C_Zoom_003Ed__109(int _003C_003E1__state)
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

		private static int? _LayerIndex;

		[SerializeField]
		public CUICharacterStatus[] m_PlayerStatusList;

		[SerializeField]
		private CInOutBehaviour m_InOut;

		[SerializeField]
		private LookAtConstraint m_ForcusLightGroup;

		[SerializeField]
		private ColoredUnitResource[] m_ColoredUnitResources;

		[SerializeField]
		private CUIEnemyStatusGroup m_EnemyStatusGroup;

		[SerializeField]
		private CUITurn m_Turn;

		[SerializeField]
		public AssetReferenceGameObject m_DpLineEffect;

		[SerializeField]
		public AssetReferenceGameObject m_DpAppearEffect;

		[SerializeField]
		private CCharacterStatusListener m_CustomListener;

		[SerializeField]
		private CUIFingerCursor m_FingerCursor;

		[SerializeField]
		private CUIAbilityView m_AbilityView;

		[SerializeField]
		private Transform[] m_ResultParentConstraints;

		[SerializeField]
		private CBtlWillTokenGroup m_WillTokenGroup;

		[SerializeField]
		private GameObject m_StampPrefab;

		[SerializeField]
		private RectTransform m_StampRoot;

		[SerializeField]
		private AssetReferenceTexture2D[] m_StampTextures;

		private AsyncOperationHandle<Texture2D>[] m_StampTextureHandles;

		private int m_CurrentTargetIndex;

		private RaycastHit[] m_RaycastResult;

		private Collider m_ActiveModelButton;

		private Coroutine m_TooltipHider;

		private int m_CurrentHandleIndex;

		private CCharDef m_CurrentHandledPlayer;

		private PreUIFadeController m_PreUIFadeController;

		private Dictionary<string, GameObject> m_ConditionIconPrefab;

		private AsyncOperationHandle<IList<GameObject>> m_ConditionIconPrefabHandle;

		private Transform m_StatusViewPosition;

		private Vector3 m_StatusViewOriginalPosition;

		public Vector3 m_StatusViewBattleOffset;

		private Vector2[] m_RecordMousePosition;

		private int m_RecordMousePositionIndex;

		private Volume m_FieldVolume;

		private Dictionary<int, CUIIngameStamp> m_CurrentStamps;

		public static int LayerIndex => 0;

		public CBtlWillTokenGroup WillTokenGroup => null;

		public Camera m_CameraTransform { get; private set; }

		public List<CCharDef> m_Players { get; private set; }

		public bool m_SelectionHide { get; set; }

		public bool m_Prepared { get; private set; }

		public bool m_FingerCursorEnabled { get; set; }

		public bool m_ForceTooltipDisabled { get; set; }

		[AsyncStateMachine(typeof(_003CAddScene_003Ed__3))]
		public static UniTask<CUICharacterStatusGroup> AddScene()
		{
			return default;
		}

		public CInOutBehaviour GetInOutBehaviour()
		{
			return null;
		}

		public void DestroyScene()
		{
		}

		public CUITurn GetTurnUI()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void Awake()
		{
		}

		private bool CheckMousePosition()
		{
			return false;
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CTooltipHideLater_003Ed__69))]
		private IEnumerator TooltipHideLater(float i_DelaySeconds)
		{
			return null;
		}

		public void OnLoadScene()
		{
		}

		[AsyncStateMachine(typeof(_003CPreloadConditionIcons_003Ed__71))]
		private UniTask PreloadConditionIcons()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CPreloadStampTextures_003Ed__72))]
		private UniTask PreloadStampTextures()
		{
			return default;
		}

		public bool TryGetConditionPrefab(string i_ID, out GameObject o_Result)
		{
			o_Result = null;
			return false;
		}

		public void GetAnyConditionPrefab(out GameObject o_Result)
		{
			o_Result = null;
		}

		public void OnRemoveScene()
		{
		}

		public void OnValueChanged(float i_Time = 0f)
		{
		}

		private static CParamPlayer GetParameter(CCharDef i_Character)
		{
			return null;
		}

		public void OnValueChanged(CCharDef i_Character, float i_Time = 0f, UpdateIgnoreMask i_Mask = UpdateIgnoreMask.None)
		{
		}

		public void SetActivePlayer(CCharDef i_Character)
		{
		}

		public int SetActivePlayer(int i_Direction)
		{
			return 0;
		}

		public void HideAllHandCard()
		{
		}

		public CUICharacterStatus GetCharacterStatus(CParamPlayer i_Param)
		{
			return null;
		}

		public void SetPlayer(List<CFieldPlayer> i_Players)
		{
		}

		public void SetPlayer(List<CBattlePlayer> i_Players)
		{
		}

		[AsyncStateMachine(typeof(_003CDrawCards_003Ed__85))]
		public UniTask DrawCards()
		{
			return default;
		}

		public void SetCurrentHandledPlayer(CCharDef i_GamePadHolder)
		{
		}

		public void SetStatusViewMode(CCharDef i_Player, CCharDef i_HandlePlayer = null)
		{
		}

		public int ChangeStatusViewMode(int i_Direction, CCharDef i_HandlePlayer)
		{
			return 0;
		}

		public void ChangeStatusViewMode(CCharDef i_Player, CParamDef i_Param, CCharDef i_HandlePlayer)
		{
		}

		public int GetIndex()
		{
			return 0;
		}

		public ColoredUnitResource GetColoredResource(ColoredUnit i_Color)
		{
			return null;
		}

		public CUIEnemyStatusGroup GetEnemyStatusGroup()
		{
			return null;
		}

		public void PauseControll()
		{
		}

		public void ResumeControll()
		{
		}

		public bool IsViewMoving()
		{
			return false;
		}

		public Vector2 GetShopIconPoint(int i_Index, Canvas i_TargetCanvas = null)
		{
			return default;
		}

		public void SetMoneyFocus(int i_Index)
		{
		}

		public void ResetMoneyFocus()
		{
		}

		public void SEPlay(string i_SEName, Vector3 i_Position, float i_Volume = 1f, float i_Pitch = 0f, int i_priority = 1)
		{
		}

		private void ActivateFingerCursor(CUIModelButton i_Button)
		{
		}

		public void SetStatusViewBattlePosition(bool i_Switch)
		{
		}

		public void SetHandCardFocusOff()
		{
		}

		public void SetHandCardFocusOn(CParamDef i_Targer)
		{
		}

		public void ShowViewAbilities(bool i_Switch, CParamDef i_Param = null)
		{
		}

		public bool IsEnableViewAbilities()
		{
			return false;
		}

		public CUIModelButton GetCurrentActiveButton()
		{
			return null;
		}

		public Vector2 GetResultAnchorPoint(int i_Index)
		{
			return default;
		}

		public void BeginResultMode()
		{
		}

		[IteratorStateMachine(typeof(_003C_Zoom_003Ed__109))]
		private IEnumerator _Zoom(int count, float start, float end, float time, Action onEnd = null)
		{
			return null;
		}

		public void EndResultMode()
		{
		}

		public Vector3 CalcModelUISpaceUnitPosition(Camera i_BattleCamera, Vector3 i_UnitPosition, Plane? i_UISpaceIntersectPlane = null)
		{
			return default;
		}

		public void SetFieldBloomVolumeWeight(float i_Weight)
		{
		}

		public void InstantiateStamp(int i_Index, CUICharacterStatus i_From)
		{
		}
	}
}
