using System.Collections.Generic;

public class CFieldMove
{
	public enum STATE
	{
		None = 0,
		Wait = 1,
		JumpUp = 2,
		JumpDown = 3,
		JumpEnd = 4,
		TurnInFront_Start = 5,
		TurnInFront = 6,
		TurnInFront_End = 7,
		End = 8
	}

	private List<CHexRoute.CHECK> mRouteCheck;

	private List<CHexPosition> mRoute;

	private int mIndex;

	private int mMoveNum;

	private int mDiceNum;

	private CPlayerDiceNum mPlayerDiceNum;

	private bool mSkillHide;

	private float mStep;

	private float mHeight;

	private float mWait;

	private STATE mState;

	private bool mGetOutTown;

	private bool mEnteringTown;

	public bool IsGetOutTown => false;

	public bool IsEnteringTown => false;

	public STATE GetState()
	{
		return STATE.None;
	}

	public float GetStep()
	{
		return 0f;
	}

	public int GetMoveNum()
	{
		return 0;
	}

	public void SetRoute(CFramingCamera fCamera, List<CHexRoute.CHECK> route, int diceNum, CPlayerDiceNum playerDiceNum, bool skillHide)
	{
	}

	public bool IsLast()
	{
		return false;
	}

	private void SetHeight()
	{
	}

	public void CameraTracking(CFramingCamera fCamera, bool checkCrossFade = true)
	{
	}

	public STATE Move(CCharDef cchar, float addStep = 0.05f)
	{
		return STATE.None;
	}
}
