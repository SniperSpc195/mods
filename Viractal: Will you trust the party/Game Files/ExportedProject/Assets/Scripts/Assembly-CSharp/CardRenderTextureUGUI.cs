using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class CardRenderTextureUGUI : SingletonMonoBehaviour<CardRenderTextureUGUI>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSetUI_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMaster_SkillCardData i_CardData;

		public CancellationToken i_Cancel;

		public CardRenderTextureUGUI _003C_003E4__this;

		private AsyncOperationHandle<Texture2D> _003CloadTex_003E5__2;

		private UniTask<Texture2D>.Awaiter _003C_003Eu__1;

		private CMaster_ModelData _003Cmodel_003E5__3;

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

	[SerializeField]
	private TextMeshProUGUI m_TextTitle;

	[SerializeField]
	private TextMeshProUGUI m_TextDetails;

	[SerializeField]
	private CanvasGroup m_ImgAtkFrame;

	[SerializeField]
	private TextMeshProUGUI m_TextAtk;

	[SerializeField]
	private CanvasGroup m_ImgDefFrame;

	[SerializeField]
	private TextMeshProUGUI m_TextDef;

	[SerializeField]
	private Image m_ImgBg;

	[SerializeField]
	private Image m_ImgJob;

	[SerializeField]
	private Image m_ImgRarity;

	[SerializeField]
	private RawImage m_ImgIllust;

	[SerializeField]
	private Image[] m_ImgCost;

	[SerializeField]
	private Image[] m_ImgCharge;

	[SerializeField]
	private Sprite[] m_BgSprite;

	[SerializeField]
	private Sprite[] m_ManaCostSprite;

	[SerializeField]
	private Sprite[] m_ManaChargeSprite;

	[SerializeField]
	private Sprite[] m_RaritySprite;

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CSetUI_003Ed__17))]
	public UniTask SetUI(CMaster_SkillCardData i_CardData, CancellationToken i_Cancel)
	{
		return default;
	}
}
