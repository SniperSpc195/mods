using TMPro;
using UnityEngine;

public class CUIGenericExplain : MonoBehaviour
{
	[SerializeField]
	protected Vector2 mOffset;

	[SerializeField]
	protected TextMeshProUGUI[] mText;

	[SerializeField]
	[ReadOnly]
	protected bool mDispOn;

	public void Active(bool a)
	{
	}

	public void SetDisp(bool a, bool activeUpdate = false)
	{
	}

	public bool GetDisp()
	{
		return false;
	}

	public void WriteText(int n, string a)
	{
	}

	public void UpdateDrawPosition(Vector2 pos)
	{
	}
}
