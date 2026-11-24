using System.Collections.Generic;
using Cysharp.Text;
using Fork.Game;
using Fork.GameRoom;
using TMPro;
using UnityEngine;

public class CCharacterDetail : MonoBehaviour
{
	public enum ButtonGuide_CharacterDetail
	{
		Lower_Rotation = 0,
		Lower_Ability = 1,
		Lower_Back = 2,
		Lower_Max = 3,
		Upper_Max = Lower_Rotation
	}

	public enum ButtonGuide_CardList
	{
		Lower_Rotation = 0,
		Lower_Appear = 1,
		Lower_Upgrade = 2,
		Lower_Back = 3,
		Lower_Max = 4,
		Upper_Max = Lower_Rotation
	}

	public enum ButtonGuide_ObjectDetail
	{
		Lower_Rotation = 0,
		Lower_Back = 1,
		Lower_Max = 2,
		Upper_Max = Lower_Rotation
	}

	public enum Kind
	{
		Shelf = 0,
		Other = 1
	}

	[SerializeField]
	private CCardView m_CardView;

	[SerializeField]
	private CCharacterDetail_Header m_Header;

	[SerializeField]
	private CCharacterDetail_Status m_CharacterWindow;

	[SerializeField]
	private CCharacterDetail_Object m_ObjectWindow;

	[SerializeField]
	private List<TextMeshProUGUI> m_RightUpperText;

	[SerializeField]
	private List<TextMeshProUGUI> m_RightLowerText;

	[SerializeField]
	[Header("棚UIから呼ばれるときのみ設定する")]
	private CGameRoom_Shelf m_Shelf;

	private Kind m_Kind;

	public CCardView CardView => null;

	public CCharacterDetail_Header Header => null;

	public CCharacterDetail_Status CharacterWindow => null;

	public CCharacterDetail_Object ObjectWindow => null;

	public CMouseCtrl MouseCtrl => null;

	private void Update()
	{
	}

	public void Open(CMaster_CharJobData i_Job, Kind i_Kind)
	{
	}

	public void Open(CMaster_EventObjectData i_Object, CMaster_ShelfData i_Shelf)
	{
	}

	public void Open(CMaster_MapStageData i_Stage, CMaster_ShelfData i_Shelf)
	{
	}

	public void CloseHeader()
	{
	}

	public bool IsBack()
	{
		return false;
	}

	public bool IsShowCharacterWindow()
	{
		return false;
	}

	public bool IsShowObjectWindow()
	{
		return false;
	}

	public void SetupButtonGuide(int i_UpperMax, int i_LowerMax)
	{
	}

	public void HideGuide()
	{
	}

	public void ChangeButtonGuide<T>()
	{
	}

	public void SetButtonGuideUpper(int i_Index, Utf16ValueStringBuilder i_Text)
	{
	}

	public void SetButtonGuideLower(int i_Index, Utf16ValueStringBuilder i_Text)
	{
	}

	private void SetButtonGuideLower(ButtonGuide_CharacterDetail type)
	{
	}

	public void SetButtonGuideLower(ButtonGuide_CardList type)
	{
	}

	private void SetButtonGuideLower(ButtonGuide_ObjectDetail type)
	{
	}

	public void ClearButtonGuideUpper()
	{
	}
}
