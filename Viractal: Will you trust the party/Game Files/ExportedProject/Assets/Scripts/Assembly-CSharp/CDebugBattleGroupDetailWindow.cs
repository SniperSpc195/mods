using TMPro;
using UnityEngine;

public sealed class CDebugBattleGroupDetailWindow : MonoBehaviour
{
	private const float WindowWidth = 680f;

	private const float WindowSpacing = 16f;

	private const float TextMargin = 20f;

	private RectTransform mWindow;

	private TextMeshProUGUI mText;

	public void Show(CScrollMenu groupMenu, TextMeshProUGUI textTemplate, string groupID)
	{
	}

	public void Hide()
	{
	}

	private void OnDisable()
	{
	}

	private void CreateWindow(CScrollMenu groupMenu, TextMeshProUGUI textTemplate)
	{
	}

	private void UpdatePosition(RectTransform groupRect)
	{
	}

	private static string BuildDetailText(string groupID)
	{
		return null;
	}
}
