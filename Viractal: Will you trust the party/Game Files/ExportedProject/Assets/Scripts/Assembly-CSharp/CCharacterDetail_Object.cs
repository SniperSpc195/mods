using Fork.Game;
using TMPro;
using UnityEngine;

public class CCharacterDetail_Object : MonoBehaviour
{
	private enum Seq
	{
		None = 0,
		Default = 1,
		Back = 2,
		StartSave = 3,
		Saving = 4
	}

	[SerializeField]
	private CCharacterDetail m_CharacterDetail;

	[SerializeField]
	private TextMeshProUGUI m_WindowLabel;

	[SerializeField]
	private TextMeshProUGUI m_ObjectName;

	[SerializeField]
	private TextMeshProUGUI m_ObjectNameLabel;

	[SerializeField]
	private TextMeshProUGUI m_Detail;

	[SerializeField]
	private Animator m_Animator;

	private CInOutPattern _InOut;

	[SerializeField]
	private CCharacterDetail_Favorite m_Favorite;

	private CMaster_EventObjectData m_EventObject;

	private CMaster_MapStageData m_Stage;

	private bool m_IsShow;

	private Seq m_Seq;

	private Seq m_NextSeq;

	private CInOutPattern InOut => null;

	public bool m_IsMouseMoving { get; private set; }

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Setup(CMaster_EventObjectData i_Data, CMaster_ShelfData i_Shelf)
	{
	}

	public void Setup(CMaster_MapStageData i_Data, CMaster_ShelfData i_Shelf)
	{
	}

	public void Show(bool i_Immediate)
	{
	}

	public void Hide(bool i_Immediate)
	{
	}

	public bool IsShow()
	{
		return false;
	}

	public void Back()
	{
	}

	private void _Back()
	{
	}
}
