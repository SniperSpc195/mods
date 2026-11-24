using System.Collections.Generic;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class CItemWindow : MonoBehaviour
{
	private enum MODE
	{
		None = 0,
		Open = 1,
		Wait = 2,
		Close = 3
	}

	public static int m_SoulPointTotal;

	public static int m_SoulPointBonus;

	[SerializeField]
	private Image m_TitleFrameGold;

	[SerializeField]
	private Image m_TitleFrameItem;

	[SerializeField]
	private Image m_TitleFrameAbility;

	[SerializeField]
	private Image m_TitleFrameAbilityLost;

	[SerializeField]
	private Image m_TitleFrameSoulPoint;

	[SerializeField]
	private TextMeshProUGUI m_TitleText;

	[SerializeField]
	private TextMeshProUGUI m_ItemName;

	[SerializeField]
	private TextMeshProUGUI m_ItemMessage;

	[SerializeField]
	private CItemIcon m_ItemIcon;

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private HorizontalLayoutGroup m_GoldDetailHorizontalLayoutGroup;

	[SerializeField]
	private CGoldObtainer[] m_GoldObtainer;

	private CFieldPlayer m_Player;

	private CInOutPattern _InOut;

	private bool m_IsShow;

	private bool m_EnableCloseButton;

	private bool m_IsGameRoom;

	private const string m_JudgName = "CItemWindow_Update";

	[SerializeField]
	[ReadOnly]
	private MODE m_Mode;

	private CMaster_ItemData m_ItemData;

	private CMaster_SkillAbilityData m_AbilityData;

	private bool m_Lost;

	private CInOutPattern InOut => null;

	public void SetGameRoom(bool a)
	{
	}

	public bool IsShowWindow()
	{
		return false;
	}

	public bool IsWaitButton()
	{
		return false;
	}

	private void Update()
	{
	}

	public void Setup(CMaster_ItemData i_Item, CItemIcon.Mode i_Mode, CFieldPlayer i_Player, bool i_EnableClose = true, string i_OverwriteTitle = "")
	{
	}

	public void Setup(CMaster_SkillAbilityData i_Ability, CItemIcon.Mode i_Mode, CFieldPlayer i_Player, bool i_EnableClose = true, string i_OverwriteTitle = "")
	{
	}

	public void SetupAbilityLost(CMaster_SkillAbilityData i_Ability, CItemIcon.Mode i_Mode, CFieldPlayer i_Player, bool i_EnableClose = true, string i_OverwriteTitle = "")
	{
	}

	public void SetupGold(List<CGoldObtainer.Obtain> i_List, CItemIcon.Mode i_Mode, CFieldPlayer i_Player, bool i_EnableClose = true, string i_OverwriteTitle = "")
	{
	}

	public void SetupGold(int i_Gold, CItemIcon.Mode i_Mode, CFieldPlayer i_Player, bool i_EnableClose = true, string i_OverwriteTitle = "")
	{
	}

	public void SetupSoulPoint(int i_GetPoint, CItemIcon.Mode i_Mode, CFieldPlayer i_Player, bool i_EnableClose = true, string i_OverwriteTitle = "")
	{
	}

	public void SetupSoulPoint()
	{
	}

	public void SetupBonusSoulPoint()
	{
	}

	private void SetupSoulPoint(int i_Point)
	{
	}

	public void ObtainGoldDetail(List<CGoldObtainer.Obtain> i_List)
	{
	}

	public void Show(bool i_Immediate)
	{
	}

	public void Hide(bool i_Immediate)
	{
	}

	public void ForceUpdateAnimetor()
	{
	}

	public bool IsShow()
	{
		return false;
	}
}
