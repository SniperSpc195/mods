using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CDevilsVoiceWeird : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Wait = 2,
		Close = 3,
		Weird_Wait = 4
	}

	private const int WEIRD_TIME = 30;

	private const int UI_TIME = 7;

	[SerializeField]
	private CUIGenericOpenClose mOpenClose;

	[SerializeField]
	private TextMeshProUGUI mText;

	[SerializeField]
	private TextMeshProUGUI mTimer_Num;

	[SerializeField]
	private Image mTimer_Progress;

	[SerializeField]
	private bool mEnableTimer;

	[SerializeField]
	private int mRemainingSec;

	private int mNowRemainingSec;

	private long mTimer;

	private int mElapsedTime;

	private int mOldElapsedTime;

	private CFieldPlayer mPlayer;

	private string mSetEffect;

	private static string[] VCEffectName;

	private static string[] VCEffectText;

	private MODE mMode;

	public void Initialize(bool isOnline)
	{
	}

	private void Active(bool a)
	{
	}

	public void Open(CFieldPlayer player)
	{
	}

	private void Reset_Time()
	{
	}

	private void Open_Start()
	{
	}

	public bool IsExec()
	{
		return false;
	}

	private void Update()
	{
	}

	private bool UpdateTimer(GamePad pad, TextMeshProUGUI textNum, Image progress)
	{
		return false;
	}
}
