using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class CCharacterDetail_Status : MonoBehaviour
{
	private enum Seq
	{
		None = 0,
		Status = 1,
		Ability = 2,
		StartSave = 3,
		Saving = 4,
		Back = 5
	}

	public enum Mode
	{
		Character = 0,
		Card = 1,
		Deck = 2,
		Back = 3
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadAbilityEmptyIcon_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCharacterDetail_Status _003C_003E4__this;

		public CancellationToken i_CancelToken;

		public RawImage i_Icon;

		private UniTask<Texture2D>.Awaiter _003C_003Eu__1;

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
	private struct _003CLoadAbilityIcon_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_AbilityID;

		public CancellationToken i_CancelToken;

		public RawImage i_Icon;

		private UniTask<RenderTexture>.Awaiter _003C_003Eu__1;

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
	private CCharacterDetail m_CharacterDetail;

	[SerializeField]
	private TextMeshProUGUI m_WindowLabel;

	[SerializeField]
	private TextMeshProUGUI m_CharacterName;

	[SerializeField]
	private TextMeshProUGUI m_CharacterNameLabel;

	[SerializeField]
	private TextMeshProUGUI m_Detail;

	[SerializeField]
	private TextMeshProUGUI m_DetailLabel;

	[SerializeField]
	private TextMeshProUGUI m_Hp;

	[SerializeField]
	private TextMeshProUGUI m_HpLabel;

	[SerializeField]
	private TextMeshProUGUI m_AbilityLabel;

	[SerializeField]
	private TextMeshProUGUI m_DropRankLabel;

	[SerializeField]
	private TextMeshProUGUI m_DeckLabel;

	[SerializeField]
	private TextMeshProUGUI m_DropRankAbility;

	[SerializeField]
	private TextMeshProUGUI m_DropRankItem;

	[SerializeField]
	private TextMeshProUGUI m_DropRankCard;

	[SerializeField]
	private TextMeshProUGUI m_DropRankGold;

	[SerializeField]
	private Image m_AbilityCursor;

	[SerializeField]
	private RawImage[] m_AbilityIcons;

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private AssetReferenceTexture2D m_EmptyIcon;

	[SerializeField]
	private CCharacterDetail_Favorite m_Favorite;

	private CInOutPattern _InOut;

	private CMaster_CharJobData m_Job;

	private AsyncOperationHandle<Texture2D> m_EmptyIconHandle;

	private Seq m_Seq;

	private Seq m_NextSeq;

	private Mode m_Mode;

	private bool m_IsShow;

	private List<CMaster_SkillAbilityData> m_Abilities;

	private int m_AbilityCursorIndex;

	private Vector2Int AbilityGroupSize;

	public CCharacterDetail_Favorite Favorite => null;

	private CInOutPattern InOut => null;

	public bool m_IsMouseMoving { get; private set; }

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateCharacterMode()
	{
	}

	public void Setup(CMaster_CharJobData i_Data)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadAbilityIcon_003Ed__45))]
	private UniTask LoadAbilityIcon(string i_AbilityID, RawImage i_Icon, CancellationToken i_CancelToken)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadAbilityEmptyIcon_003Ed__46))]
	private UniTask LoadAbilityEmptyIcon(RawImage i_Icon, CancellationToken i_CancelToken)
	{
		return default;
	}

	public void Show(bool i_Immediate)
	{
	}

	public void ShowCurrentMode()
	{
	}

	public void Hide(bool i_Immediate)
	{
	}

	public bool IsShow()
	{
		return false;
	}

	public void Back()
	{
	}

	private void _Back()
	{
	}

	public bool IsBack()
	{
		return false;
	}

	private void ShowAbilityTooltip(int i_Index, bool i_MoveMouse)
	{
	}

	private void HideAbilityTooltip()
	{
	}

	public void ChangeMode(Mode i_Mode)
	{
	}

	private int GetMouseoverAbilityIndex()
	{
		return 0;
	}
}
