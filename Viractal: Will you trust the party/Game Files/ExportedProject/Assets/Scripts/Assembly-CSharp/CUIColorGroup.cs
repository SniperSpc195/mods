using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CUIColorGroup : MonoBehaviour
{
	private class SaveImage
	{
		public Image mTarget;

		public Color mOrgColor;

		public SaveImage(Image org)
		{
		}

		public void UpdateColor(Color c)
		{
		}
	}

	private class SaveTextMeshProUGUI
	{
		public TextMeshProUGUI mTarget;

		public Color mOrgColor;

		public SaveTextMeshProUGUI(TextMeshProUGUI org)
		{
		}

		public void UpdateColor(Color c)
		{
		}
	}

	[SerializeField]
	[ReadOnly]
	private bool mVisible;

	[SerializeField]
	private Color mColorHide;

	private List<SaveImage> mSaveImage;

	private List<SaveTextMeshProUGUI> mSaveTmp;

	private void Awake()
	{
	}

	private void GetList()
	{
	}

	public void Select(bool a)
	{
	}

	public void Visible()
	{
	}

	public void Hide()
	{
	}

	private void SetColor(Color c)
	{
	}
}
