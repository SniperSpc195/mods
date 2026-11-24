using UnityEngine;

public class CMissionNotification_UI : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Wait = 2,
		Close = 3,
		End = 4
	}

	private CUIGenericOpenClose mOpenClose;

	private Vector2[] mPositionStartEnd;

	private MODE mMode;

	private double mTime;

	private const double WAIT_TIME = 3.0;

	public void Initialize(CParamMission pMiss, float y)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	private void Update()
	{
	}

	public void UpdateY(float y)
	{
	}
}
