using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class CItemIcon : MonoBehaviour
{
	public enum Mode
	{
		Result = 0,
		Shop = 1,
		GameRoom = 2
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadAbilityIcon_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_ID;

		public CItemIcon _003C_003E4__this;

		public CancellationToken i_Cancel;

		private RawImage _003C_003E7__wrap1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadIconAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_ID;

		public Scene i_Scene;

		public CItemIcon _003C_003E4__this;

		private CMaster_ItemData _003Citem_003E5__2;

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

	private static Color m_ColorDark;

	[SerializeField]
	private RawImage m_AbilityIcon;

	[SerializeField]
	private Image m_ItemIcon;

	[SerializeField]
	private Image m_Frame;

	[SerializeField]
	private Image m_ShopNewIcon;

	[SerializeField]
	private Image m_ResultNewIcon;

	[SerializeField]
	private Image m_ActiveFrame;

	[SerializeField]
	private Image m_ActiveBlink;

	private Mode m_Mode;

	private static float m_PingPongPeriod;

	private static float m_PingPongResult;

	private static Color[] m_PingPongColor;

	private static Color m_BlinkColor;

	private void Awake()
	{
	}

	public void Setup(Mode i_Mode)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadIconAsync_003Ed__12))]
	public UniTask LoadIconAsync(Scene i_Scene, string i_ID, CancellationToken cancel)
	{
		return default;
	}

	public void LoadItemIcon(Scene i_Scene, string i_ID)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadAbilityIcon_003Ed__14))]
	public UniTask LoadAbilityIcon(Scene i_Scene, string i_ID, CancellationToken i_Cancel)
	{
		return default;
	}

	public void SetIcon(Sprite icon)
	{
	}

	public void Dark(bool i_Active)
	{
	}

	public void Selected(bool i_Active, bool i_Blink = false)
	{
	}

	public void ShowNewIcon()
	{
	}

	public void HideNewIcon()
	{
	}

	public static void ProgressPingPong()
	{
	}

	public static Color GetBlinkColor()
	{
		return default;
	}

	private void LateUpdate()
	{
	}
}
