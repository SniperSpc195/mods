using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using Fork.GameRoom;
using TMPro;
using UnityEngine;

public class CCharacterSaveDetail : MonoBehaviour
{
	public enum ButtonGuide_CharacterDetail
	{
		Lower_Clipboard = 0,
		Lower_Ability = 1,
		Lower_ChangeCharacter = 2,
		Lower_Back = 3,
		Lower_Max = 4,
		Upper_Max = Lower_Clipboard
	}

	public enum ButtonGuide_AbilityMode
	{
		Lower_Clipboard = 0,
		Lower_Back = 1,
		Lower_Max = 2,
		Upper_Max = Lower_Clipboard
	}

	public enum ButtonGuide_CardList
	{
		Lower_Clipboard = 0,
		Lower_ChangeCharacter = 1,
		Lower_Back = 2,
		Lower_Max = 3,
		Upper_Max = Lower_Clipboard
	}

	public enum ButtonGuide_CardDetail
	{
		Lower_Clipboard = 0,
		Lower_Back = 1,
		Lower_Max = 2,
		Upper_Max = Lower_Clipboard
	}

	public enum ButtonGuide_ItemMenu
	{
		Lower_Clipboard = 0,
		Lower_Back = 1,
		Lower_Max = 2,
		Upper_Max = Lower_Clipboard
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CHideAnime_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CCharacterSaveDetail _003C_003E4__this;

		private float _003CalphaName_003E5__2;

		private float _003Ct_003E5__3;

		private UniTask.Awaiter _003C_003Eu__1;

		private float _003Ct_003E5__4;

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
	private CCardView m_CardView;

	[SerializeField]
	private CCharacterSaveDetail_Header m_Header;

	[SerializeField]
	private CCharacterSaveDetail_Status m_CharacterWindow;

	[SerializeField]
	private CGameRoom_ItemMenu m_ItemMenu;

	[SerializeField]
	private TextMeshProUGUI m_JobName;

	[SerializeField]
	private TextMeshProUGUI m_JobLevel;

	[SerializeField]
	private List<TextMeshProUGUI> m_RightUpperText;

	[SerializeField]
	private List<TextMeshProUGUI> m_RightLowerText;

	[SerializeField]
	private CanvasGroup m_ItemMenuCanvasGroup;

	[SerializeField]
	private CanvasGroup m_CardViewCanvasGroup;

	[SerializeField]
	private CanvasGroup m_NameCanvasGroup;

	private JsonNode m_ParamJson;

	public CCardView CardView => null;

	public CCharacterSaveDetail_Header Header => null;

	public CCharacterSaveDetail_Status CharacterWindow => null;

	public CGameRoom_ItemMenu ItemMenu => null;

	public CMouseCtrl MouseCtrl => null;

	private void Update()
	{
	}

	public void CopyToClipBoard()
	{
	}

	public void Open(JsonNode i_JsonNode)
	{
	}

	public void Close()
	{
	}

	public bool IsShow()
	{
		return false;
	}

	public void SetupButtonGuide(int i_UpperMax, int i_LowerMax)
	{
	}

	public void HideGuide()
	{
	}

	public void ChangeButtonGuide<T>()
	{
	}

	public void SetButtonGuideUpper(int i_Index, Utf16ValueStringBuilder i_Text)
	{
	}

	public void SetButtonGuideLower(int i_Index, Utf16ValueStringBuilder i_Text)
	{
	}

	private void SetButtonGuideLower(ButtonGuide_CharacterDetail type)
	{
	}

	public void SetButtonGuideLower(ButtonGuide_AbilityMode type)
	{
	}

	public void SetButtonGuideLower(ButtonGuide_CardList type)
	{
	}

	public void SetButtonGuideLower(ButtonGuide_CardDetail type)
	{
	}

	public void SetButtonGuideLower(ButtonGuide_ItemMenu type)
	{
	}

	public void ClearButtonGuideUpper()
	{
	}

	public void HideMenu()
	{
	}

	[AsyncStateMachine(typeof(_003CHideAnime_003Ed__44))]
	private UniTask HideAnime()
	{
		return default;
	}
}
