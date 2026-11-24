using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CSoundCrossFadeTest : MonoBehaviour
{
	[SerializeField]
	private Button m_PlayCh0Button;

	[SerializeField]
	private Button m_PlayCh1Button;

	[SerializeField]
	private Button m_StopCh0Button;

	[SerializeField]
	private Button m_StopCh1Button;

	[SerializeField]
	private Button m_BackButton;

	[SerializeField]
	private TextMeshProUGUI m_Ch0Log;

	[SerializeField]
	private TextMeshProUGUI m_Ch1Log;

	private SoundStatus m_Ch0Status;

	private SoundStatus m_Ch1Status;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
