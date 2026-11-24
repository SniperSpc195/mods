using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CFieldNewDice : MonoBehaviour
{
	private enum OPENCLOSE
	{
		Open = 0,
		Right = 1,
		Right_Close = 2,
		Max = 3
	}

	private enum MODE
	{
		None = 0,
		Open = 1,
		BtnWait = 2,
		Throw = 3,
		Throw_Wait = 4,
		Dice_Stop = 5,
		Dice_Slide = 6,
		Num_Move = 7,
		Decision = 8,
		Close_Cancel = 9,
		Cancel = 10,
		Debug_Result = 11
	}

	[SerializeField]
	private CNewDice mDefaultDices;

	[SerializeField]
	private CNewDice[] mMoveDices;

	[SerializeField]
	private Vector3[] mMultiPosition_1;

	[SerializeField]
	private Vector3[] mMultiPosition_2;

	[SerializeField]
	private Vector3[] mMultiPosition_3;

	private List<CNewDice> mRollDices;

	[SerializeField]
	[ReadOnly]
	private int mRollNumDices;

	[SerializeField]
	[ReadOnly]
	private bool mStopDice;

	[SerializeField]
	private Camera mCamera;

	[SerializeField]
	private Vector3 mCamAngle;

	[SerializeField]
	private float mCamDistance;

	[SerializeField]
	private Canvas mCanvas;

	[SerializeField]
	private RawImage mRawImage;

	[SerializeField]
	[ReadOnly]
	private int mRawWidth;

	[SerializeField]
	[ReadOnly]
	private int mRawHeight;

	[SerializeField]
	[ReadOnly]
	private float mCanvasScale;

	private CUIGenericOpenClose[] mImageSlide;

	private CUIGenericOpenClose mOpenClose;

	private Vector2[][] mPosition_OpenClose;

	private RenderTexture mRenderTexture;

	private CFieldPlayer mPlayer;

	private CFramingCamera mFramingCamera;

	private CFramingCamera.Backup mBackupCamera;

	[SerializeField]
	private Vector3 mZoomCamera;

	[SerializeField]
	private Vector3 mOffsetCameraTarget;

	[SerializeField]
	private Vector3 mCenterCameraTarget;

	[SerializeField]
	private Vector2[] mUIDicePosition;

	[SerializeField]
	[ReadOnly]
	private bool mCancelOk;

	private bool mAutoThrow;

	private double mTime;

	private int[] mAddDiceNum;

	private Transform mSplineTarget;

	private Vector3 mSplineOffset;

	private MODE mMode;

	[SerializeField]
	[ReadOnly]
	private MODE mResult;

	private bool[] judg;

	public CNewDice UseDice => null;

	public bool IsStopDice()
	{
		return false;
	}

	public CPlayerDiceNum GetPlayerDiceNum(int index = -1)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void UpdateRawImage()
	{
	}

	private void Active(bool a)
	{
	}

	public void Show_ExecPlayerDiceNum(List<CFieldPlayer> players, int execIndex)
	{
	}

	public void ShowDiceNum(int index = -1)
	{
	}

	public void HideDiceNum(int index = -1, bool countdown = false)
	{
	}

	public void Go_AllMoveDice(CFramingCamera camera, List<CFieldPlayer> players)
	{
	}

	public void Go_SingleMoveDice(CFramingCamera camera, CFieldPlayer player)
	{
	}

	private void CheckAdd(CFieldPlayer player)
	{
	}

	public void Set_MoveDice(int num, CFieldPlayer player)
	{
	}

	public void Go_Dice(CFramingCamera camera, CFieldPlayer player, bool cancel = false)
	{
	}

	private void StartDice(CFramingCamera camera, CFieldPlayer player, bool autoThrow)
	{
	}

	public int GetRestDiceNum(CFieldPlayer player)
	{
		return 0;
	}

	public int GetPureDiceNum(CFieldPlayer player)
	{
		return 0;
	}

	public void SetSplineTarget(Transform target, Vector3 offset)
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

	public bool IsDecision()
	{
		return false;
	}

	public bool IsEndSpline()
	{
		return false;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}
}
