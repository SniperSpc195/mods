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

public class CUIAchievement : MonoBehaviour
{
	private enum TOOLTIP_TYPE
	{
		Left = 0,
		Right = 1
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadIcon_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CUIAchievement _003C_003E4__this;

		public CancellationToken token;

		private CSteamAchievements.ID _003Cid_003E5__2;

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
	private RectTransform mItemParent;

	[SerializeField]
	private CCursorAchievement mCursor;

	[SerializeField]
	private CUITooltip[] mTooltips;

	[SerializeField]
	private TextMeshProUGUI[] mTextTooltips;

	[SerializeField]
	private Vector2[] mOffsetTooltips;

	[SerializeField]
	private Color mSoulColor;

	[SerializeField]
	[ReadOnly]
	private string mStringSoulColor;

	[SerializeField]
	[ReadOnly]
	private CUITooltip mPopup;

	[SerializeField]
	[ReadOnly]
	private bool mEnableTooltis;

	[SerializeField]
	[ReadOnly]
	private TOOLTIP_TYPE mTooltipType;

	[SerializeField]
	[ReadOnly]
	protected int mMaxItems;

	[SerializeField]
	protected Vector2 mItemSize;

	[SerializeField]
	protected Vector2 mItemZeroPosition;

	[SerializeField]
	protected Vector2 mItemNextPosition;

	private List<CUIPhysicsShapeFocus> mFocusItemList;

	[SerializeField]
	[ReadOnly]
	private CUIPhysicsShapeFocus mEnterFocus;

	private List<CUIPhysicsShapeFocus.AchievementData> mAchievementData;

	public CCursorAchievement Cursor => null;

	public RectTransform CursorRectTransform => null;

	public CUIPhysicsShapeFocus EnterFocus => null;

	private void Awake()
	{
	}

	public bool IsGetSoul()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CLoadIcon_003Ed__26))]
	public UniTask LoadIcon(CancellationToken token)
	{
		return default;
	}

	public void Active(bool a)
	{
	}

	public int GetItemCount()
	{
		return 0;
	}

	public void ChangePopup()
	{
	}

	public void Initialize(bool active = true)
	{
	}

	public void Select()
	{
	}

	public void UpdateTooltip()
	{
	}
}
