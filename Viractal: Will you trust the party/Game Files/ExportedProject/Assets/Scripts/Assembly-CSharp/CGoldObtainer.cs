using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CGoldObtainer : MonoBehaviour
{
	public struct Obtain
	{
		public int baseValue;

		public int bonusValue;

		public string chrId;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetupIcon_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken i_Cancel;

		public CGoldObtainer _003C_003E4__this;

		public Obtain i_Obtain;

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
	private RawImage m_Icon;

	[SerializeField]
	private TextMeshProUGUI m_BaseValue;

	[SerializeField]
	private TextMeshProUGUI m_BonusValue;

	[SerializeField]
	private TextMeshProUGUI m_BonusLabel;

	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	private void Start()
	{
	}

	[AsyncStateMachine(typeof(_003CSetupIcon_003Ed__7))]
	public UniTask SetupIcon(Obtain i_Obtain, CancellationToken i_Cancel)
	{
		return default;
	}
}
