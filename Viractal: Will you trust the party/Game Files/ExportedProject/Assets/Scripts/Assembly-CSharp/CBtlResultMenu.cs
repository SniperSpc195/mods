using System;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CBtlResultMenu : SingletonMonoBehaviour<CBtlResultMenu>
{
	[Serializable]
	public struct Button
	{
		public Image m_ButtonIcon;

		public TextMeshProUGUI m_Text;

		public TextMeshProUGUI m_Cost;
	}

	private enum ButtonType
	{
		Skip = 0,
		Lottery = 1
	}

	private enum InputSelectMenu
	{
		IsPressL = 0,
		IsPressR = 1
	}

	private enum InputDialog
	{
		IsOk = 0,
		IsCancel1 = 1,
		IsCancel2 = 2
	}

	private enum Seq
	{
		None = 0,
		SelectMenu = 1,
		ProcessSkip = 2,
		ProcessLottery = 3,
		ConfirmSkip = 4,
		ConfirmLottery = 5,
		LackMessage = 6,
		WaitToSelectMenu = 7
	}

	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private Button[] m_Button;

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private CCardSelector m_CardSelector;

	private CInOutPattern m_InOut;

	private UnityAction m_OnStartShow;

	private bool[] m_InputButton;

	private Seq m_Seq;

	private const int WaitFrameToSelectMenu = 2;

	private int m_WaitCounterToSelectMenu;

	public CBattlePlayer m_BattlePlayer { get; private set; }

	public void Setup(CBattlePlayer player)
	{
	}

	public void Show()
	{
	}

	public static void Hide()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool IsSequenceSkip()
	{
		return false;
	}

	public bool IsSequenceLottery()
	{
		return false;
	}

	public bool IsProcessLottery()
	{
		return false;
	}

	public void ApplyButtonColor()
	{
	}

	private int GetLotteryCost()
	{
		return 0;
	}

	private int GetSkipCost()
	{
		return 0;
	}

	public void SetupButtonUI()
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}
}
