using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CTransmutationCard : MonoBehaviour
{
	public enum Kind
	{
		Job = 0,
		EventObject = 1,
		Card = 2,
		Item = 3,
		Stage = 4
	}

	public enum Condition
	{
		Lock = 0,
		Unlock = 1,
		Get = 2
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_SetCardIllust_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CTransmutationCard _003C_003E4__this;

		public string i_CardID;

		public bool i_SetRandomParam;

		private RawImage _003C_003E7__wrap1;

		private UniTask<Texture>.Awaiter _003C_003Eu__1;

		private UniTask<Material>.Awaiter _003C_003Eu__2;

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
	private CInOutBehaviour m_InOut;

	[SerializeField]
	private RawImage m_CardImage;

	[SerializeField]
	private Image m_IconImage;

	[SerializeField]
	private TextMeshProUGUI m_ConditionText;

	[SerializeField]
	private CToggle m_Toggle;

	public string ID { get; private set; }

	public CMaster_UnlockData m_UnlockData { get; private set; }

	public bool m_UpgradeMode { get; private set; }

	public Kind m_Kind { get; private set; }

	public Condition m_Condition { get; private set; }

	public void Active(bool i_Switch, bool i_Immediate = false)
	{
	}

	public void SetCardIllust(CMaster_UnlockData i_UnlockData, string i_CardID)
	{
	}

	[AsyncStateMachine(typeof(_003C_SetCardIllust_003Ed__29))]
	public UniTask _SetCardIllust(string i_CardID, bool i_SetRandomParam = true)
	{
		return default;
	}

	public void ToggleCardUpgrade()
	{
	}

	public void SetObjectIllust(CMaster_UnlockData i_UnlockData, string i_ObjectID)
	{
	}

	public void SetStageIllust(CMaster_UnlockData i_UnlockData, string i_StageID)
	{
	}

	public void SetItemIllust(CMaster_UnlockData i_UnlockData, string i_ItemID)
	{
	}

	public void SetJobIllust(CMaster_UnlockData i_UnlockData, string i_JobID)
	{
	}

	public void SetLockIllust(CMaster_UnlockData i_UnlockData)
	{
	}

	public void SetCondition(Condition condition, int price)
	{
	}

	public void SetupAppearCard()
	{
	}

	public bool IsUsableToggleButton()
	{
		return false;
	}

	public Texture GetCardTexture()
	{
		return null;
	}

	public Sprite GetIconSprite()
	{
		return null;
	}
}
