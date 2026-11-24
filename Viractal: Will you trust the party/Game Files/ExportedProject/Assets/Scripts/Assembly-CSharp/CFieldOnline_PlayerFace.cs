using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CFieldOnline_PlayerFace : MonoBehaviour
{
	private const long DISABLE_TIME = 6000L;

	private const int BUFFER_FULL = 10;

	private const float MAX_SPEED = 15f;

	private float mAddSpeed;

	[SerializeField]
	[ReadOnly]
	private bool mOnline;

	[SerializeField]
	[ReadOnly]
	private bool mExistGuest;

	[SerializeField]
	private Image mIcon;

	[SerializeField]
	private TextMeshProUGUI mName;

	[SerializeField]
	[ReadOnly]
	private Vector2 mUIPosition;

	private CFieldMain mField;

	private CFieldPlayer mPlayer;

	private string mCmdName;

	private long mTime;

	public long mMoveTime;

	private List<Vector2> mMousPosition;

	public void Initialize(CFieldMain field, CFieldPlayer player, Sprite sprite)
	{
	}

	private void Update()
	{
	}

	private void MoveUI(Vector2 normalPos)
	{
	}

	private void MouseNotMoved()
	{
	}

	private void Send()
	{
	}

	private void DispOff()
	{
	}

	private void SetPosition(Vector2 pos)
	{
	}

	private void Enable(bool e)
	{
	}

	private void Timeup(bool ownAction = false)
	{
	}

	public static void Sort(CFieldOnline_PlayerFace[] face)
	{
	}
}
