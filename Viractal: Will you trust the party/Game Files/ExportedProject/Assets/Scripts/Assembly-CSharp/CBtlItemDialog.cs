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
using UnityEngine.UI;

public class CBtlItemDialog : MonoBehaviour
{
	private enum ActiveScene
	{
		Field = 0,
		Battle = 1
	}

	public enum GoldDistribute
	{
		None = 0,
		Sharing = 1,
		TaleAll = 2
	}

	private struct PlayerContext
	{
		public CMaster_CharJobData job;

		public CParamPlayer player;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitializeItem_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CBtlItemDialog _003C_003E4__this;

		public int dropNo;

		public string item;

		public CancellationToken cancel;

		private RawImage _003C_003E7__wrap1;

		private UniTask<Texture>.Awaiter _003C_003Eu__1;

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
	private RectTransform m_RectTransform;

	[SerializeField]
	private GameObject m_ButtonObj;

	[SerializeField]
	private GameObject m_ButtonsRoot;

	[SerializeField]
	private RawImage m_SkillIcon;

	[SerializeField]
	private Image m_ItemIcon;

	[SerializeField]
	private TextMeshProUGUI m_ItemName;

	[SerializeField]
	private TextMeshProUGUI m_ItemExplain;

	[SerializeField]
	private TextMeshProUGUI m_ObtainedMessage;

	[SerializeField]
	private Animator m_Animator;

	private ActiveScene m_ActiveScene;

	private List<PlayerContext> m_Players;

	private string m_ItemID;

	private int m_Gold;

	private int m_DropNo;

	private CFieldPlayer m_GivePlayer;

	public GoldDistribute m_GoldDistribute { get; private set; }

	public CInOutPattern m_InOut { get; private set; }

	public bool m_Started { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[AsyncStateMachine(typeof(_003CInitializeItem_003Ed__32))]
	public UniTask InitializeItem(int dropNo, string item, CancellationToken cancel)
	{
		return default;
	}

	public void InitializeGold(int dropNo, string id, int gold)
	{
	}

	public void Show(bool enable)
	{
	}

	public void Hide(bool enable)
	{
	}

	public void ShowObtainedItemMessage(CFieldPlayer player)
	{
	}

	public void ShowObtainedGoldMessage(params (CFieldPlayer player, int gold)[] pair)
	{
	}
}
