using System.Collections.Generic;
using UnityEngine;

public class CGameRoom_SelectName : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Start_Contract = 2,
		Select_Contract = 3,
		Start_SelectName = 4,
		SelectName = 5,
		Delete_SelectName = 6,
		End_SelectName = 7,
		InputName = 8,
		Close = 9
	}

	private class Contract
	{
		private enum MODE
		{
			None = 0,
			Center = 1,
			OrgPosition = 2,
			FadeOut = 3,
			FadeIn = 4
		}

		public RectTransform mRectTransform;

		public CanvasGroup mCanvasGroup;

		public Vector2 mOrgPosition;

		public Vector2 mTargetScale;

		public float mLerp;

		private const float BASE_WIDTH = 694f;

		private const float SPEED = 0.15f;

		private MODE mMode;

		public Contract(RectTransform menu, RectTransform t)
		{
		}

		public void SetSiblingIndex(int i)
		{
		}

		public bool IsEnd()
		{
			return false;
		}

		public void MoveCenter()
		{
		}

		public void MoveOrgPosition()
		{
		}

		public void FadeOut()
		{
		}

		public void FadeIn()
		{
		}

		public void Update()
		{
		}
	}

	[SerializeField]
	private CUIButtonExplanation mButtonExplanation;

	[SerializeField]
	private CEventMessage mGMMessage;

	[SerializeField]
	private CMenu_Save mMenuSave;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private CUIGenericMenu[] mParentInputName;

	[SerializeField]
	private CUIGenericMenu mNameList;

	private List<string> mNames;

	private CUIGenericMenu mSelectMenu;

	private CGameRoom_InputName[] mInputNames;

	private CGameRoom_Table.PLAYER_SETTING[] mSetting;

	[SerializeField]
	[ReadOnly]
	private int mNumPlayer;

	[SerializeField]
	[ReadOnly]
	private int mNumPiece;

	[SerializeField]
	[ReadOnly]
	private int mCursor;

	private Contract[][] mContract;

	private Contract[] mDisplayContract;

	private static CUIButtonExplanation.DATA[] mKEYASSIGN_Contract;

	private static CUIButtonExplanation.DATA[] mKEYASSIGN_SelectName;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	[SerializeField]
	[ReadOnly]
	private bool mCancel;

	private void Awake()
	{
	}

	public void GoMenu(int numPlayer, int numPiece, CGameRoom_Table.PLAYER_SETTING[] setting, bool initCursor = true)
	{
	}

	public bool IsExec()
	{
		return false;
	}

	public bool IsCancel()
	{
		return false;
	}

	private void Update()
	{
	}

	private int Init_NameList(bool resetCursor = true)
	{
		return 0;
	}

	private void CbCancel_Contract()
	{
	}

	private void CbDecision_Contract(int n)
	{
	}

	private void End_SelectName()
	{
	}

	private void CbCancel_SelectName()
	{
	}

	private void CbDecision_SelectName(int n)
	{
	}
}
