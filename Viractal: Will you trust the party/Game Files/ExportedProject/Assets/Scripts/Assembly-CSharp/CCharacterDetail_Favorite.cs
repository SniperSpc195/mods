using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CCharacterDetail_Favorite : MonoBehaviour
{
	[SerializeField]
	private CCharacterDetail m_CharacterDetail;

	[SerializeField]
	private Image m_Cursor;

	[SerializeField]
	private Image[] m_FavIcons;

	[SerializeField]
	private Sprite m_FavSettingSprite;

	[SerializeField]
	private Sprite m_FavEmptySprite;

	[SerializeField]
	private Sprite m_FavOtherSprite;

	[SerializeField]
	private TextMeshProUGUI m_Title;

	private const int RowMax = 2;

	private const int ColumnMax = 4;

	private int? m_CursorPosition;

	private string m_ID;

	private string[] m_TmpShelfFavorite;

	public bool m_IsSavedSystemData { get; private set; }

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(string i_ID, bool i_ShowCursor)
	{
	}

	public void Input(bool i_IsMouseMoving)
	{
	}

	public void InputMouse(GamePad i_GamePad)
	{
	}

	private void SetShowCursor(bool i_IsMouseMoving, int i_Index)
	{
	}

	private int GetMouseoverIndex()
	{
		return 0;
	}

	private void ApplyFlag(int i_Index, string i_ID)
	{
	}

	public bool IsDifference()
	{
		return false;
	}

	public void Cache(bool i_SavedSystemData)
	{
	}

	public void ShowCursor()
	{
	}

	public void HideCursor()
	{
	}
}
