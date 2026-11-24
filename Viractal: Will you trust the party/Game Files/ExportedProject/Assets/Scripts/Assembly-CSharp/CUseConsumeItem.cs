using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using UnityEngine;

public class CUseConsumeItem
{
	private enum Mode
	{
		Field = 0,
		Battle = 1
	}

	private enum InputSelectTarget
	{
		IsCancel = 0
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public JsonNode json;

		internal bool _003CProcessTargetSelector_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public CItemWindow itemwindow;

		public Func<bool> _003C_003E9__0;

		public Func<bool> _003C_003E9__2;

		public Func<bool> _003C_003E9__1;

		internal bool _003COpenAbilityWindow_003Eb__0()
		{
			return false;
		}

		internal bool _003COpenAbilityWindow_003Eb__2()
		{
			return false;
		}

		internal bool _003COpenAbilityWindow_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_1
	{
		public CMaster_SkillAbilityData ability;

		internal bool _003COpenAbilityWindow_003Eb__3(CSkillAbilityData x)
		{
			return false;
		}

		internal bool _003COpenAbilityWindow_003Eb__5(CSkillAbilityData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_2
	{
		public CEventMessage msg;

		internal bool _003COpenAbilityWindow_003Eb__7()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CApplyUIRank_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private IEnumerator<CSkillEffect.TargetContext> _003C_003E7__wrap1;

		private CUICharacterStatus _003Cui_003E5__3;

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
	private struct _003CAutoMessage_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_Message;

		public CancellationToken i_Cancel;

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
	private struct _003CContinueAutoMessage_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_Message;

		public CancellationToken i_Cancel;

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
	private struct _003CDisposeCard_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CFieldPlayer i_Target;

		public CancellationToken i_Cancel;

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
	private struct _003CDuplicateCard_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CFieldPlayer i_Target;

		public CancellationToken i_Cancel;

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
	private struct _003CDuplicateRandomCard_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CFieldPlayer i_Target;

		public CancellationToken i_Cancel;

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
	private struct _003COpenAbilityWindow_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CSkill i_Skill;

		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass25_1 _003C_003E8__2;

		private _003C_003Ec__DisplayClass25_2 _003C_003E8__3;

		private CItem _003Citem_003E5__2;

		private IEnumerator<CSkillEffect.TargetContext> _003C_003E7__wrap2;

		private CFieldPlayer _003Cfp_003E5__4;

		private List<CMaster_SkillAbilityData>.Enumerator _003C_003E7__wrap4;

		private CMaster_SkillAbilityData _003Cability_003E5__6;

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
	private struct _003CProcessTargetSelector_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CFieldPlayer player;

		public int index;

		public CancellationToken cancel;

		private _003C_003Ec__DisplayClass15_1 _003C_003E8__1;

		private CMaster_ItemData _003Citem_003E5__2;

		private CFramingCamera.Backup _003CbkCamera_003E5__3;

		private GameController.PADNUM _003CpadNum_003E5__4;

		private CItem _003CuseItem_003E5__5;

		private CBattlePlayer _003Cbp_003E5__6;

		private bool _003CisOnline_003E5__7;

		private bool _003CisControl_003E5__8;

		private UniTask.Awaiter _003C_003Eu__1;

		private CFieldPlayer _003Cfp_003E5__9;

		private List<CSkillEffect.TargetContext> _003Cplayers_003E5__10;

		private CFramingCamera _003CfCamera_003E5__11;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

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
	private struct _003CShowPopup_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public Transform i_Parent;

		public float i_Scale;

		public CMaster_ItemData i_Item;

		public CancellationToken i_Cancel;

		private CItemPopup _003Cpopup_003E5__2;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
	private struct _003CUpgradeCard_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CFieldPlayer i_Target;

		public CancellationToken i_Cancel;

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
	private struct _003CUpgradeRandomCard_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CFieldPlayer i_Target;

		public CancellationToken i_Cancel;

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
	private struct _003C_Execute_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CFieldPlayer player;

		public int index;

		public CancellationToken cancel;

		private CBattlePlayer _003Cbp_003E5__2;

		private Mode _003Cmode_003E5__3;

		private CMaster_ItemData _003Citem_003E5__4;

		private UniTask.Awaiter _003C_003Eu__1;

		private UniTask<CCardSelector>.Awaiter _003C_003Eu__2;

		private UniTask<bool>.Awaiter _003C_003Eu__3;

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

	private static UniTask m_Execute;

	private static bool[] m_InputButton;

	private static bool m_Consume;

	private static UniTask m_TaskAutoMessage;

	private static CancellationTokenSource m_CancelAutoMessage;

	private static bool m_RetoreMessage;

	public static CItem m_UsingItem { get; private set; }

	public static bool IsExecute()
	{
		return false;
	}

	public static bool IsComplete()
	{
		return false;
	}

	public static bool IsConsume()
	{
		return false;
	}

	[Obsolete]
	public static void Execute(CFieldPlayer player, CMaster_ItemData item, CancellationToken token)
	{
	}

	public static void Execute(CFieldPlayer player, int index, CancellationToken cancel)
	{
	}

	[AsyncStateMachine(typeof(_003C_Execute_003Ed__14))]
	private static UniTask _Execute(CFieldPlayer player, int index, CancellationToken cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CProcessTargetSelector_003Ed__15))]
	private static UniTask<bool> ProcessTargetSelector(CFieldPlayer player, int index, CancellationToken cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CShowPopup_003Ed__16))]
	private static UniTask ShowPopup(CMaster_ItemData i_Item, Transform i_Parent, float i_Scale, CancellationToken i_Cancel)
	{
		return default;
	}

	public static bool IsUsable(string id, bool battle, bool full)
	{
		return false;
	}

	public static bool IsUsable(CMaster_ItemData item, bool battle, bool full)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CDisposeCard_003Ed__19))]
	private static UniTask<bool> DisposeCard(CFieldPlayer i_Target, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CUpgradeCard_003Ed__20))]
	private static UniTask<bool> UpgradeCard(CFieldPlayer i_Target, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CUpgradeRandomCard_003Ed__21))]
	private static UniTask<bool> UpgradeRandomCard(CFieldPlayer i_Target, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CDuplicateCard_003Ed__22))]
	private static UniTask<bool> DuplicateCard(CFieldPlayer i_Target, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CDuplicateRandomCard_003Ed__23))]
	private static UniTask<bool> DuplicateRandomCard(CFieldPlayer i_Target, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CApplyUIRank_003Ed__24))]
	public static UniTask ApplyUIRank(CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003COpenAbilityWindow_003Ed__25))]
	private static UniTask OpenAbilityWindow(CSkill i_Skill, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAutoMessage_003Ed__29))]
	private static UniTask AutoMessage(string i_Message, CancellationToken i_Cancel)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CContinueAutoMessage_003Ed__30))]
	private static UniTask ContinueAutoMessage(string i_Message, CancellationToken i_Cancel)
	{
		return default;
	}

	public static bool IsNoEffect(CMaster_ItemData i_Item, CParamDef i_TargetParam, CParamDef i_UserParam = null)
	{
		return false;
	}
}
