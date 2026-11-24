using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using Fork.ModelButtons;
using TMPro;
using UnityEngine;

public class CFieldMenu_ChangeAbility : MonoBehaviour
{
	private enum State
	{
		Pending = 0,
		OpenSelect = 1,
		Select = 2,
		Close = 3,
		Commit = 4,
		Inquiry = 5,
		Change = 6,
		ChangeWait = 7
	}

	private enum Control
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3,
		Decide = 4,
		Cancel = 5,
		Count = 6
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CMoveIcon_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CFieldMenu_ChangeAbility _003C_003E4__this;

		public int i_Index;

		private CUiCharacterStatusAbility _003Cicon_003E5__2;

		private float _003Cduration_003E5__3;

		private double _003CstartTime_003E5__4;

		private float _003Cip_003E5__5;

		private YieldAwaitable.Awaiter _003C_003Eu__1;

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
	private struct _003CRemoveOldMain_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CFieldMenu_ChangeAbility _003C_003E4__this;

		public int i_Index;

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
	private struct _003C_ChangeAbility_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CFieldMenu_ChangeAbility _003C_003E4__this;

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

	private static CFieldMenu_ChangeAbility Instance;

	private static readonly string m_ChangeAbilitySelectName;

	private static readonly string m_ChangeAbilityDecideName;

	private static readonly string m_SERemoveAbility;

	private static readonly string m_SEAppendAbility;

	[SerializeField]
	private Vector3 m_AbilityPosition;

	[SerializeField]
	private Vector3 m_AbilityRotation;

	[SerializeField]
	private Vector3 m_AbilityScale;

	[SerializeField]
	private CUICharacterStatusAbilityHolder m_TemporaryAbilityHolder;

	[SerializeField]
	private CChoiceMenu m_ChoiceMenu;

	[SerializeField]
	private TMP_Text m_TextInfo;

	[SerializeField]
	private GameObject m_TextArea;

	private CFieldPlayer m_FieldPlayer;

	private CBattlePlayer m_BattlePlayer;

	private CUICharacterStatusGroup m_StatusGroup;

	private CUICharacterStatus m_UI;

	private CUIModelButtonGroup m_AbilityUI;

	private CUIModelButtonGroup m_TemporaryAbilityUI;

	private CUICharacterStatusAbilityHolder m_AbilityHolder;

	private CUIGenericButtonGuide m_ButtonGuide;

	private List<CSkillAbilityData> m_Abilities;

	private State m_State;

	private MaterialPropertyBlock m_Property;

	private bool m_PrepareUI;

	private bool m_ChangeEnd;

	private bool[] m_JudgeArray;

	private int m_Result;

	private bool m_ResultIsMainAbility;

	private string[] m_InquirySelection;

	private bool m_FirstSelect;

	public GameController.PADNUM m_PadNum => GameController.PADNUM.PAD0;

	public CParamPlayer m_Parameter => null;

	public CCharDef m_Character => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static void Open(CFieldPlayer i_Player, List<string> i_SkillAbilityIDList)
	{
	}

	[Obsolete]
	public static void Open(CBattlePlayer i_Player, List<string> i_SkillAbilityIDList)
	{
	}

	public static bool IsEnd()
	{
		return false;
	}

	private void Start()
	{
	}

	private void _Open(CFieldPlayer i_Player, List<string> i_SkillAbilityIDList)
	{
	}

	[Obsolete]
	private void _Open(CBattlePlayer i_Player, List<string> i_SkillAbilityIDList)
	{
	}

	private void _Open(List<string> i_SkillAbilityIDList)
	{
	}

	private bool _IsEnd()
	{
		return false;
	}

	private void Close()
	{
	}

	private void Update()
	{
	}

	private void SelectionFillControll(GamePad i_Pad)
	{
	}

	private void UpdateSelect()
	{
	}

	private void InquilyFillEmpty()
	{
	}

	private void UpdateInquiry()
	{
	}

	private void _PrepareUI()
	{
	}

	private void SetStringForSelect()
	{
	}

	private void SetStringBySelectionState()
	{
	}

	private void PrepareInquily()
	{
	}

	[AsyncStateMachine(typeof(_003C_ChangeAbility_003Ed__58))]
	private UniTask _ChangeAbility()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CRemoveOldMain_003Ed__59))]
	private UniTask RemoveOldMain(int i_Index)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CMoveIcon_003Ed__60))]
	private UniTask MoveIcon(int i_Index)
	{
		return default;
	}
}
