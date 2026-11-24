using System.Collections.Generic;
using UnityEngine;

public class CFieldMenuOption_Controller : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		SelectPlayer = 1,
		Change = 2,
		Close = 3,
		End = 4
	}

	private class PLAYER_PAD
	{
		private static GameController.PADNUM[] mListPadNum;

		public bool mIsControl;

		public bool mIsOnline;

		public Transform mParent;

		public CFieldPlayer mPlayer;

		public int mIndex;

		public bool mConnect;

		public bool mChange;

		private int GetControllerIndex()
		{
			return 0;
		}

		public PLAYER_PAD(bool isControl, bool isOnline, Transform parent, CFieldPlayer player)
		{
		}

		public void InitInner()
		{
		}

		public void EnableArrow(bool a)
		{
		}

		public void WriteController(GameController.PADNUM padNum)
		{
		}

		public void Update()
		{
		}

		public bool SelectController()
		{
			return false;
		}
	}

	[SerializeField]
	private Vector2 mFrameSize;

	[SerializeField]
	private RectTransform mParent;

	[SerializeField]
	private CUIGenericMenu mMenu;

	[SerializeField]
	private RectTransform mInstruction;

	[SerializeField]
	private Vector2 mInstPosition;

	private int mCursorIndex;

	private List<CFieldPlayer> mPlayers;

	private CFieldPlayer mControlPlayer;

	private PLAYER_PAD[] mPlayerPad;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private bool[] mJudg;

	public void Go(List<CFieldPlayer> players, int index)
	{
	}

	private void EnableInstruction(bool a)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}
}
