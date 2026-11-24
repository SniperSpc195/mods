using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;

namespace Fork.Game
{
	public class CUISettingsMenu : SingletonMonoBehaviour<CUISettingsMenu>
	{
		public enum ConfigItem
		{
			MasterVolume = 0,
			BGMVolume = 1,
			SEVolume = 2,
			SoundXR = 3,
			ButtonAssign = 4,
			GraphicsQuality = 5,
			FullscreenSwitch = 6,
			WindowsizeRestore = 7,
			RenderScale = 8,
			Blur = 9,
			SortHandCards = 10,
			GMMessageCut = 11,
			ItemInitial = 12,
			DefaultSettings = 13,
			License = 14
		}

		private enum State
		{
			None = 0,
			Open = 1,
			Select = 2,
			Close = 3,
			CloseWait = 4,
			DefaultSettings = 5,
			License = 6,
			Save = 7,
			SaveWait = 8
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSave_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUISettingsMenu _003C_003E4__this;

			private double _003Ctime_003E5__2;

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

		[SerializeField]
		private TMP_Text m_HeaderText;

		[SerializeField]
		private TMP_Text m_DescriptionText;

		[SerializeField]
		private CUIGenericMenu m_Menu;

		[SerializeField]
		private GameObject[] m_RemoveItemsOnSwitchPlatform;

		[SerializeField]
		private RectTransform m_ItemParent;

		[SerializeField]
		private CUIGenericOpenClose m_OpenClose;

		[SerializeField]
		private CUIGenericButtonGuide m_ButtonGuide;

		[SerializeField]
		private CUILicenseView m_LicenseView;

		private CUISettingsBase[] m_Buttons;

		private State m_State;

		private CConfigData m_ConfigBackup;

		private bool m_IsEnableDeactivate;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnButtonAssignChanged(CConfigData.ButtonAssign i_Value)
		{
		}

		private void OnFullScreenModeChanged()
		{
		}

		private void Start()
		{
		}

		private void CreateButtonContent()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public void Active(bool i_Switch)
		{
		}

		private void Update()
		{
		}

		private void UpdateSelect()
		{
		}

		private void UpdateSave()
		{
		}

		private void UpdateDefaultSettings()
		{
		}

		private void UpdateButtons()
		{
		}

		public void OnDefautSettings()
		{
		}

		public void OnViewLicense()
		{
		}

		[AsyncStateMachine(typeof(_003CSave_003Ed__30))]
		private UniTask Save()
		{
			return default;
		}

		public static CUILicenseView GetLicenseView()
		{
			return null;
		}
	}
}
