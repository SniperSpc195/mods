using UnityEngine;

public class CHexObjectScale : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Visible = 1,
		Hidden = 2
	}

	private const float SPEED = 0.1f;

	[SerializeField]
	[ReadOnly]
	private bool mOperable;

	[SerializeField]
	[ReadOnly]
	private float mEasing;

	[SerializeField]
	[ReadOnly]
	private Vector3 mScale;

	private Vector3Int mHexPosition;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private CHexCloud.ScaleUp mScaleUp;

	public void Initialize(CHexPosition hex)
	{
	}

	public void ReturnClouds()
	{
	}

	public void ScaleDown(bool imm = false, bool force = false)
	{
	}

	public void ScaleUp(bool imm = false, bool force = false)
	{
	}

	private void Update()
	{
	}
}
