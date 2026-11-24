using UnityEngine;

public class CEventKusudamaClose : MonoBehaviour
{
	private enum MODE
	{
		RibbonScaling = 0,
		Move = 1,
		End = 2
	}

	private Vector3 mStart;

	private Vector3 mTarget;

	private float mTime;

	private Transform mRibbon;

	private float mRibbonScale;

	private MODE mMode;

	private void Awake()
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
