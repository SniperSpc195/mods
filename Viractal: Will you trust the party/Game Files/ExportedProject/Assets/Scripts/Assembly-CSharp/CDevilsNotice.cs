using TMPro;
using UnityEngine;

public class CDevilsNotice : SingletonMonoBehaviour<CDevilsNotice>
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Wait = 2,
		Close = 3
	}

	[SerializeField]
	private TextMeshProUGUI mText;

	private long mTimer;

	private MODE mMode;

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	public void Go()
	{
	}

	public void Stop()
	{
	}

	private void Update()
	{
	}
}
